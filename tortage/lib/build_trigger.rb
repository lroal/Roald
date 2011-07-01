require 'open-uri'
class BuildTrigger
	def initialize(config, all_solutions, changes)
		@config = config
		@changes = changes
		@all_solutions = all_solutions
	end

	def trigger branchname
		
		names = get_list_to_trigger
		names.uniq.each do |name| 
			url = get_uri_for(name, branchname)
			puts "accessing #{url}"
			begin
				open("#{url}") 
			rescue 
				puts "unable to trigger build for #{name} in #{branchname} branch #{$!}"
			end
		end
	end


	def pretend_trigger branchname
		
		names = get_list_to_trigger
		names.uniq.each do |name| 
			puts "Would trigger #{get_uri_for(name, branchname)}"
		end
	end


	private
	def get_list_to_trigger
		source_changes_detector = SourceCodeChangesDetector.new(@config)
		changed_solution_paths = source_changes_detector.find_changed_solutions_using @changes

		binary_changes_detector = BinaryChangesDetector.new(@config, @all_solutions)
		changed_solution_paths += binary_changes_detector.find_changed_solutions_using @changes

		dependent_solution_paths_finder = \
		AffectedSolutionsDetector.new(@all_solutions)
		dependent_solution_paths = dependent_solution_paths_finder\
			.find_sln_paths_dependent_on changed_solution_paths


		names = [] + changed_solution_paths + dependent_solution_paths
		names.collect{|n| File.basename(n.gsub('.sln',''))}
	end

	def get_uri_for(name, branchname)
		"#{job_uri_prefix}#{name}/buildWithParameters?token=#{job_token}&cause=BuildTrigger&branchName=#{branchname}"
	end

	def job_uri_prefix
		@config.build_job_uri_prefix
	end

	def job_token
		@config.job_token
	end

end

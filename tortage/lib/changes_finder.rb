class ChangesFinder
	def changes_in branch_name
		puts "\n\n\n***** checking for changes in #{branch_name} *****"

		cmd = "git rev-parse origin/#{branch_name}"
		puts cmd
		remote_branch_tip = `#{cmd}`.strip

		cmd = "git checkout #{remote_branch_tip}"
		puts cmd
		`#{cmd}`

		cmd =  "git tag -afm\"update changelist in origin/#{branch_name}\" #{branch_name}_current"
		puts cmd 
		`#{cmd}`
		
		return [] if `git show-ref #{branch_name}_previous`.empty?
		
		cmd = "git diff #{branch_name}_current #{branch_name}_previous --name-only"
		puts cmd
		changes = `#{cmd}`	
		puts changes
		45.times{ print '-' }
		print "\n\n\n"
		changes.split("\n")
	end
end

class SourceCodeChangesDetector
  def initialize(config)
    @config = config
  end
  
  def find_changed_solutions_using log
    solution_paths = []
    log.each do|logline|
      match = logline.match(/^#{projects_dir}\/[^\/]+/)
      unless match.eql? nil 
        solution_paths.push(match.to_s.gsub(/^(#{projects_dir}\/)([^\/]+)/, '\1\2/\2.sln')) 
      end
    end
    solution_paths
  end
  
  private 
  def projects_dir
    @config.projects_dir
  end
end



class SolutionFile
	attr_accessor :path, 
    :assembly_names, 
    :referenced_assembly_filenames, 
    :dependent_solutions, 
    :dependency_solutions,
    :referenced_assembly_full_paths,
    :non_buildable_reference_paths
	
  def initialize
    @assembly_names = []
    @referenced_assembly_filenames = []
    @dependent_solutions = []   
    @dependency_solutions = []   
    @referenced_assembly_full_paths = []
	end
  
  def has_dependent_solutions?
    @dependent_solutions.length > 0
  end
  
  def load_from(path)
    @path = path
    load_projects
  end
  
  private
	def load_projects
		file = File.new(@path, 'r')
		
		while (line = file.gets)
			
      project_path = get_project_path_from(line)
			unless project_path.eql? nil
				project = CsProjectFile.new(project_path, self)
        publish_assembly_names_produced_by project
        publish_assembly_names_referenced_by project
			end
		end
	end
  
  def get_project_path_from(line)
    if line.include?('.csproj')
      project_path = line.split(/, /)[1]
      project_path.strip!
      project_path.gsub!(/"/,'')
      project_path.gsub!(/\\/, '/')
      project_path = File.join(File.dirname(@path).dup, project_path)
    end
    project_path
  end
  
  def publish_assembly_names_produced_by(project)
    @assembly_names.push(project.assembly_name)
  end
  
  def publish_assembly_names_referenced_by(project)
    @referenced_assembly_filenames += project.referenced_assembly_filenames
    @referenced_assembly_filenames.uniq!
    
    @referenced_assembly_full_paths += project.referenced_assembly_full_paths
    @referenced_assembly_full_paths.uniq!
  end
  
end

class RelationsInfoCollector
  attr_accessor :solutions
  def initialize (projects_dir)
    @solution_file_paths = Dir["#{projects_dir}/**/*.sln"]
    discover_relations
    find_nonbuildables
  end
  
  private 
  def discover_relations
    load_solutions
    assign_solution_path_to_assembly_names
    populate_relations_of_solutions
  end
  
  def load_solutions
    @solutions = SolutionsLoader.new.load_solutions(@solution_file_paths)
  end

  def find_nonbuildables
    @solutions.each do |solution|
     
      non_buildable_assembly_paths = []
      
      solution.referenced_assembly_full_paths.each do |reference_path|
        
        reference_filename = Pathname.new(reference_path).basename.to_s
        unless @assembly_name_to_solution_map.has_key? reference_filename 
          non_buildable_assembly_paths.push(reference_path)
        end
        
      end
      solution.non_buildable_reference_paths = non_buildable_assembly_paths.uniq
    end
  end
  
  def assign_solution_path_to_assembly_names
    @assembly_name_to_solution_map = {}
    @solutions.each do |solution|
      solution.assembly_names.each do |assembly_name|
        throw_if_already_in_map assembly_name
        @assembly_name_to_solution_map[assembly_name] = solution
      end
    end
    
  end
  
  def throw_if_already_in_map(assembly_name)
    if @assembly_name_to_solution_map.has_key?(assembly_name)
      throw("At least 2 assemblies produce assembly with the same name") 
    end
  end

  def populate_relations_of_solutions
    @solutions.each do |solution|
      populate_dependent_solutions_of solution
      populate_dependency_solutions_of solution
    end
  end
  
 
  def populate_dependent_solutions_of(solution)
    solution.assembly_names.each do |assembly_filename|
      @solutions.each do |sln|  
        if sln.referenced_assembly_filenames.include?(assembly_filename)
          next if solution.dependent_solutions.include?(sln)
          solution.dependent_solutions.push(sln)
          populate_dependent_solutions_of(solution.dependent_solutions.last)
        end

      end
    end
  end
  
  def populate_dependency_solutions_of(solution)
    solution.referenced_assembly_filenames.each do |assembly_filename|
      
      @solutions.each do |sln|  
        if sln.assembly_names.include?(assembly_filename)
          next if solution.dependency_solutions.include?(sln)
          solution.dependency_solutions.push(sln)
          populate_dependency_solutions_of(solution.dependency_solutions.last)
        end

      end
    end
  end
  
end



class Rebuilder
    
  def rebuild_dependency_providers_among solutions
    prepare_to_build_dependency_providers_among solutions
    rebuild_solutions
  end
  
  def rebuild_with_dependencies solutions
    prepare_to_build_with_dependencies solutions
    rebuild_solutions
  end

  def pretend_rebuild_with_dependencies solutions
    prepare_to_build_with_dependencies solutions
	print_solutions_to_rebuild
  end

 
  def rebuild_one_with_dependencies solution
	prepare_to_build_with_dependencies [solution]
	rebuild_one_with_deps
  end

  def pretend_rebuild_one_with_dependencies solution
	prepare_to_build_with_dependencies [solution]
	print_solutions_to_rebuild
  end

  def rebuild_one_as_dependency solution
	  prepare_to_build_with_dependencies [solution]
	  rebuild_ordered_slns_as_deps
  end

  def rebuild_one_for_deployment solution
	  prepare_to_build_with_dependencies [solution]
	  rebuild_solutions_for_deployment
  end

  def rebuild_with_dependents solutions
	prepare_to_build_with_dependents solutions
	Rebuilder.new.rebuild_with_dependencies @ordered_solutions
  end

  def pretend_rebuild_with_dependents solutions
	prepare_to_build_with_dependents 
    print_solutions_to_rebuild
  end
  
  
  private
  def prepare_to_build_dependency_providers_among solutions
    solutions_to_rebuild_are solutions
    get_build_list_with_dependencies
    filter_away_non_deps
  end

  def prepare_to_build_with_dependents solutions
    solutions_to_rebuild_are solutions
    get_build_list_with_dependents
  end

  def prepare_to_build_with_dependencies solutions
    solutions_to_rebuild_are solutions
    get_build_list_with_dependencies
  end

  def solutions_to_rebuild_are(solutions)
    @solutions_to_rebuild = solutions  
  end
  
  def get_build_list_with_dependencies
    build_list_creator = SolutionBuildListCreator.new(@solutions_to_rebuild)
    @ordered_solutions = build_list_creator.solution_and_dependencies
  end
  
  def get_build_list_with_dependents
    build_list_creator = SolutionBuildListCreator.new(@solutions_to_rebuild)
    @ordered_solutions = build_list_creator.solution_and_depependents
  end
  
  def filter_away_non_deps
    @ordered_solutions.select! { |i| i.has_dependent_solutions? }
  end
  
    
  def print_solutions_to_rebuild
    @ordered_solutions.each do |solution|
      puts "would build #{solution.path}"
    end
  end
 
  def rebuild_one_with_deps
	solution = @solutions_to_rebuild.first
	@ordered_solutions.each do |d|
		SingleSolutionRebuilder.new.rebuild_as_dependency d unless d.eql? solution
	end
	SingleSolutionRebuilder.new.rebuild_as_toplevel solution
  end

  def rebuild_ordered_slns_as_deps
	@ordered_solutions.each do |dep|
		SingleSolutionRebuilder.new.rebuild_as_dependency dep
	end
  end

  def rebuild_solutions
    @ordered_solutions.each do |solution|
	  rebuild solution
    end
  end
  
  def rebuild_solutions_for_deployment
	  @ordered_solutions.each do |solution|
		  SingleSolutionRebuilder.new.rebuild_as_dependency solution if solution.has_dependent_solutions?
		  SingleSolutionRebuilder.new.rebuild_as_toplevel solution
	  end
  end


  def rebuild(solution)
    SingleSolutionRebuilder.new.rebuild(solution)
  end
  
end


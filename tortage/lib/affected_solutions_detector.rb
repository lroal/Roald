class AffectedSolutionsDetector
  def initialize(all_solutions)
    @all_solutions = all_solutions
  end
  def find_sln_paths_dependent_on paths
    dependent_slns = []
    paths.each do |sln_path|
      dep_solution = @all_solutions.select {|p| p.path == sln_path}
      build_list_creator = SolutionBuildListCreator.new(dep_solution)
      dependent_slns += build_list_creator.solution_and_depependents.select {|s| s.path != sln_path }

    end
    dependent_paths = []
    dependent_slns.each {|sln| dependent_paths.push sln.path}
    dependent_paths
  end
end



class SolutionBuildListCreator
	def initialize(solutions)
    @solutions = solutions
    
	end
	
	def solution_and_dependencies
		return nil if @solutions.size == 0

    @ordered = []
    @solutions.each do |solution|
      @ordered.push(solution)
      collect_dependencies_of solution
    end  
    @ordered.reverse.uniq
	end
  
  def solution_and_depependents
    @ordered = []
    @solutions.each do |solution|
      @ordered.push(solution)
      collect_dependents_of solution
    end  
    @ordered.uniq
  end
  
  private
  def collect_dependencies_of(solution)
    solution.dependency_solutions.each do |dependency_solution|    
      @ordered.push(dependency_solution)      
      collect_dependencies_of dependency_solution    
    end    
  end
  
  def collect_dependents_of(solution)
    solution.dependent_solutions.each do |dependent_solution|    
      @ordered.push(dependent_solution)      
      collect_dependents_of dependent_solution    
    end    
  end
  
  
end

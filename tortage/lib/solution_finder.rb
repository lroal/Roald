class SolutionFinder
  def initialize(all_solutions)
    @all_solutions = all_solutions
  end
  
  def find(search_string)
    sln = search_string.downcase
    
	
    solution = @all_solutions.select {|s| s.path.downcase == sln}.first
    if solution.eql? nil
      solution = @all_solutions.select {|s| 
        Pathname.new(s.path).basename.to_s.downcase == sln
      }.first 
    end
    
    if solution.eql? nil
    solution = @all_solutions.select {|s| 
        Pathname.new(s.path).basename.to_s.gsub('.sln', '').downcase == sln
      }.first
    end
	
    solution
  end
  
end

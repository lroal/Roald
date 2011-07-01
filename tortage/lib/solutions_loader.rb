
class SolutionsLoader
	def load_solutions(paths)		
	    solutions = []
		paths.each do |solution_file_path|
			print "."
			solution = SolutionFile.new
      		solution.load_from solution_file_path
			solutions.push(solution)
		end
	    puts ""
		solutions
	end
end

class RelationsVisualiser
	def initialize(solutions)
		@solutions = solutions
	end
  
   	def visualize
		@solutions.each do |solution|
			puts "#{solution.path} (#{solution.dependent_solutions.length})"
			print_dep_dependents_of(solution, 0)
			60.times {print '-'}
			print "\n\n\n\n"
		end
	end
   
	def print_dep_dependents_of(solution, level)
   
		separation_line = ""
		indent = ""
		indent_element = "\t|"
		alternate_indent_element = "\t "
		indent_element_length = indent_element.length

		while separation_line.length <= level * indent_element_length
			separation_line += indent_element
		end
		
		while indent.length <= level * 2 - indent_element_length
			indent += indent_element
		end

		indent += alternate_indent_element

		solution.dependent_solutions.each do |dependent_sln|
  			puts separation_line
  			puts "#{indent}-- #{dependent_sln.path}"
  			print_dep_dependents_of(dependent_sln, level + 1)
		end
	end
  	
end


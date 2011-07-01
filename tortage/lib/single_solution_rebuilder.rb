require 'FileUtils'
class SingleSolutionRebuilder
  def rebuild(solution)
    rebuild_as_dependency solution if solution.has_dependent_solutions?
    rebuild_as_toplevel solution unless solution.has_dependent_solutions?
  end
 

  def rebuild_as_dependency solution
    dir = Pathname.new(solution.path).basename.to_s.gsub('.sln', '')
    if File.exist?("deps/#{dir}")
      command = "del /F /S /Q deps\\#{dir}\\*"
      puts command
      exit(1) unless system(command)
    end
    command = "msbuild /m /t:rebuild /p:OutputPath=..\\..\\..\\deps\\#{dir} #{solution.path}"
    exit(1) unless system(command)
  end
  
  def rebuild_as_toplevel solution 
    command = "msbuild /m /t:rebuild  #{solution.path}"
    exit(1) unless system(command)
  end
end

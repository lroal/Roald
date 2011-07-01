class BinaryChangesDetector
  def initialize(config,all_solutions)
    @config = config
    @all_solutions = all_solutions
  end
  
  def find_changed_solutions_using log
    @paths = []
    log.each do|logline|
      #match lib/xxxx or tools/xxxx
      tool_or_lib_match = logline.match(/^(#{tools_dir}|#{lib_dir})\/([^\/]+)/)
      find_affected_by tool_or_lib_match.to_s unless tool_or_lib_match.eql? nil 
        
      
    end
    @paths
  end
  
  private
  def find_affected_by tool_or_lib
    @all_solutions.each do |sln|
      sln.non_buildable_reference_paths.each do |dll_path|
        #match relative_path/lib/xxxx/ or relative_path/tools/xxxx/
        pattern = Regexp.escape(csproj_to_root_relpath + tool_or_lib + '/')
          
        unless dll_path.downcase.match(/^#{pattern}/).eql? nil
          @paths.push sln.path
        end
      end
    end
  end
  
  def tools_dir
    @config.tools_dir
  end
  
  def lib_dir
    @config.lib_dir
  end
  
  def csproj_to_root_relpath
    @config.csproj_to_root_relpath
  end
end


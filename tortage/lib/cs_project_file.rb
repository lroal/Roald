require 'nokogiri'

class CsProjectFile
	attr_accessor :solution, :referenced_assembly_filenames, :referenced_assembly_full_paths
	def initialize(path, solution)
		@solution = solution
		@path = path
		
		@doc = Nokogiri::XML(File.open(path)).root
    
		@output_type = @doc.at('PropertyGroup/OutputType').text
    @referenced_assembly_filenames = []
    @referenced_assembly_full_paths = []
		discover_references_with_hintpaths
	end
	
		
		
	def assembly_name
		@assembly_name = @doc.at("PropertyGroup/AssemblyName").text if @assembly_name.eql? nil
		@assembly_name += ".dll" if output_type_is_library?
		@assembly_name += ".exe" if output_type_is_exe?
    @assembly_name
	end
	
		
	def output_type_is_library?
		@output_type.downcase.eql? 'library'
	end
	
	def output_type_is_exe?
		@output_type.downcase.include? 'exe'
	end
	
	def discover_references_with_hintpaths
		@doc.search("ItemGroup/Reference").each do |reference_node|
	
      assembly_name = reference_node['Include']
			hintpath_node = reference_node.at('HintPath')

			assembly_hint_path = hintpath_node.text if not hintpath_node.eql? nil 
			next if assembly_hint_path == nil or assembly_hint_path.eql? ''
			binary_reference = BinaryReference.new(assembly_name, assembly_hint_path)
      @referenced_assembly_filenames.push(binary_reference.filename)
      assembly_hint_path.gsub!('\\',"/");
      @referenced_assembly_full_paths.push("#{assembly_hint_path}")
		end
	end
  
end
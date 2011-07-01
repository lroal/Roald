require 'pathname'

class BinaryReference
	attr_accessor  :fullname, :name, :version, :hint_path, :filename
	
	def initialize(fullname, hint_path)
		@fullname = fullname
		@hint_path = hint_path
		@filename = Pathname.new(hint_path).basename.to_s
		parse_assembly_attributes
	end
	
	def parse_assembly_attributes
		name_parts = fullname.split(/, /)
		@name = name_parts.shift
		assembly_attributes = {}
		name_parts.each do |name_part|
			name_and_value = name_part.split(/=/)
			assembly_attributes[name_and_value[0]] = name_and_value[1]
		end
		@version = assembly_attributes['Version']
	end
	
end
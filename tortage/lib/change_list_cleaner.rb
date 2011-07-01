class ChangeListCleaner
	def initialize(branches)
		@branches = branches
	end

	def clear_changelist 
		
		@branches.each do |branch_name|
			puts "=== clearing changelist in #{branch_name} ==="
			
			cmd = "git checkout #{branch_name}_current"
			puts cmd
			`#{cmd}`

			
			cmd = "git tag -afm\"clear_changelist\" #{branch_name}_previous"
			puts cmd
			`#{cmd}`
			49.times {print '-'}
			print "\n\n\n"
		end
	end

end

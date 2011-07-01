require 'pathname'


current_dir = Pathname.new(__FILE__).dirname
require "#{current_dir}/rebuilder.rb"
require "#{current_dir}/relations_info_collector.rb"
require "#{current_dir}/solution_finder.rb"
require "#{current_dir}/solution_file.rb"
require "#{current_dir}/cs_project_file.rb"
require "#{current_dir}/solutions_loader.rb"
require "#{current_dir}/binary_reference.rb"
require "#{current_dir}/solution_build_list_creator.rb"
require "#{current_dir}/single_solution_rebuilder.rb"
require "#{current_dir}/paths_config.rb"
require "#{current_dir}/source_code_changes_detector.rb"
require "#{current_dir}/binary_changes_detector.rb"
require "#{current_dir}/affected_solutions_detector.rb"
require "#{current_dir}/relations_visualiser.rb"
require "#{current_dir}/build_trigger.rb"
require "#{current_dir}/changes_finder.rb"
require "#{current_dir}/change_list_cleaner.rb"

require 'rubygems'
require 'find'
require 'set'
require 'Sprockets'
require 'jsmin'
require 'fileutils'



libFiles = Dir.glob('../../srcjs/lib/**/*min.js')
coreFiles = Dir.glob('../../srcjs/Core/**/*.js')
clientFiles = Dir.glob('../../srcjs/Client/**/*[^Specs]/*js')
allFiles = coreFiles + libFiles + clientFiles

htmlFiles = Dir.glob('../../srcjs/Client/Roald/*.html')
for file in htmlFiles
	FileUtils.copy(file,'../../srcjs/deploy/Roald')
end


for f in allFiles
	puts(f)
end

secretary = Sprockets::Secretary.new(
  :root => '.',
  :source_files => allFiles
)

concatenation = secretary.concatenation
gluedFile = concatenation.to_s
concatenation.save_to("../../srcjs/deploy/Roald/Client.js")

compressedFile = "../../srcjs/deploy/Roald/Client.min.js"
File.open(compressedFile, 'w') {|file| file.write(JSMin.minify(gluedFile))}



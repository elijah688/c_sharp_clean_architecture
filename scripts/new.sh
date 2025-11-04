curl -v -X POST http://localhost:5005/api/notes \
	-H "Content-Type: application/json" \
	-d '{"title":"My New Note","content":"This is the content of the note"}'

# this code is modify from:
    # https://stackoverflow.com/questions/1009860/how-can-i-read-and-process-parse-command-line-arguments

import sys
import json

# Retrieve the form data from C# as a JSON string
formInputKeyByValueList = json.loads(sys.argv[1])  # Get array of form inputs key by value
targetSearchText = sys.argv[2].lower() # Get the search text that user input to form

result = []

# Iterate through each dictionary in the list
for form in formInputKeyByValueList:
    if (form): # Skip if that element is null
        targetField = []
        for key, val in form.items():  # Ensure you're iterating over key-value pairs in the dictionary
            if targetSearchText in val.lower():
                targetField.append(key)
        result.append(targetField)

# Print the result, which will be captured by the C# program
print(json.dumps(result))
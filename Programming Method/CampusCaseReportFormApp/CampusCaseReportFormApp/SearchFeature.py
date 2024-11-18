# this code is modify from:
    # https://stackoverflow.com/questions/1009860/how-can-i-read-and-process-parse-command-line-arguments
    # https://chatgpt.com/

import sys
import json

# Retrieve the form data from C# as a JSON string
formInputKeyByValueList = json.loads(sys.argv[1])  # Get array of form inputs key by value
targetSearchText = sys.argv[2]

result = []

# Iterate through each dictionary in the list
for form in formInputKeyByValueList:
    if (form):
        targetField = []
        for key, val in form.items():  # Ensure you're iterating over key-value pairs in the dictionary
            if targetSearchText in val:
                targetField.append(key)
        result.append(targetField)

# Print the result, which will be captured by the C# program
print(json.dumps(result))
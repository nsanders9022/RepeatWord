# Word Counter

#### _Website for counting the number of times a word is included in a sentence_

#### By _**Nicole Sanders**_

## Description

This web application is for counting the number of times a word is included in user input. Only full words are considered.

## Setup/Installation Requirements

* Requires DNU, DNX, and Mono
* Clone to local machine
* Use command "dnu restore" in command prompt/shell
* Use command "dnx kestrel" to start server
* Navigate to http://localhost:5004 in web browser of choice

## Specifications

**The user inputs one letter and the same letter to search for, and the match for that letter is outputted.**
* Example Input: "a", "a"
* Example Output: 1
* One letter is the simplest input that a person could enter.

**The user inputs one word and the same word to search for, and the match for that word is outputted.**
* Example Input: "bananas", "bananas"
* Example Output: 1
* One word is the next simplest input from a user. This input value also contains the letter "a" which was used in the first test which guarantees that both tests will pass.

**The user inputs multiple words and a word to search for and the match for that word is outputted.**
* Example Input: "monkeys like to eat bananas", "bananas"
* Example Output: 1
* This input contains the word that was used in the previous test so all tests will continue to pass.

**The user inputs multiple words and a word to search for and the match for that word is outputted. The searched word is found more than once**
* Example Input: "monkeys like to eat bananas for breakfast and bananas for dinner", "bananas"
* Example Output: 2
* This input contains the word that was used in the previous test so all tests will continue to pass.

**The user inputs multiple words and a word to search for. If the word is not in the sentence an error message is displayed**
* Example Input: "monkeys like to eat bananas", "apple"
* Example Output: "The word apple could not be found in the sentence"
* This input looks for one word that was not in the sentence.

**The user inputs multiple words and a word to search for. If the EXACT word is not in the sentence an error message is displayed**
* Example Input: "monkeys like to eat bananas", "banana"
* Example Output: "The word banana could not be found in the sentence"
* The input for the searched word is very similar to the word in the sentence but it is not an exact match.

## Support and contact details

Please contact Nicole Sanders at nsanders9022@gmail.com with any questions, concerns, or suggestions.

## Known Bugs

_None. If you find any bugs please let us know._

## Technologies Used

This web application uses:
* Nancy
* Mono
* C#
* Razor

### License

*This project is licensed under the MIT license.*

Copyright (c) 2017 **_Nicole Sanders_**

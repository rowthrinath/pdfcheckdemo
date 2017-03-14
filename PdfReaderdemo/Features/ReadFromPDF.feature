Feature: Check PDF contents

Scenario Outline: Read from a pdf


Given I have the expected pdf file
Then I open and read text from PDF
And I validate text in pdf 
| Linetocheck |
| <Line1>     |

Examples: 
| Line1          |
| 2. Introduction |

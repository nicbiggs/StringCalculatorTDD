# StringCalculatorTDD
An example run-through for how to implement Test-Driven Development (TDD).

The original example (written in Java) can be found at: https://technologyconversations.com/2013/12/20/test-driven-development-tdd-example-walkthrough/

### The requirements to implement, one at a time, are:
1. Create a simple String calculator with a method int Add(string numbers)
2. The method can take 0, 1 or 2 numbers, and will return their sum (for an empty string it will return 0) for example “” or “1” or “1,2”
3. Allow the Add method to handle an unknown amount of numbers
4. Allow the Add method to handle new lines between numbers (instead of commas).
5. The following input is ok: “1\n2,3” (will equal 6)
6. Support different delimiters
7. To change a delimiter, the beginning of the string will contain a separate line that looks like this: “//[delimiter]\n[numbers…]” for example “//;\n1;2” should return three where the default delimiter is ‘;’ .
8. The first line is optional. All existing scenarios should still be supported
9. Calling Add with a negative number will throw an exception “negatives not allowed” – and the negative that was passed. If there are multiple negatives, show all of them in the exception message stop here if you are a beginner.
10. Numbers bigger than 1000 should be ignored, so adding 2 + 1001 = 2
11. Delimiters can be of any length with the following format: “//[delimiter]\n” for example: “//[—]\n1—2—3” should return 6
12. Allow multiple delimiters like this: “//[delim1][delim2]\n” for example “//[-][%]\n1-2%3” should return 6.
13. Make sure you can also handle multiple delimiters with length longer than one char
14. Add a method int Subtract(string numbers) to the String calculator
15. Allow Subtract method to handle all the same input as the Add method

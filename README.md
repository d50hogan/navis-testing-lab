# Testing Lab Files

This repository is the Java version of the lab files. Git tags are used 
to mark various points in the development history.

## Instructions

You are to test-drive the development of a console-based game of 2-player blackjack where the computer
plays the dealer. You may *not* run the game (or even write a `main()`) until it has a complete, runnable specification. 

You must write runnable tests for every algorithm you write (anything with logic). You do not have
to write tests for library classes/functions (e.g. System.in can be assumed to read from the process's 
standard input), but *you must test any code that uses them*.

### Part 1 -- Basics of specification testing and injection

Make a branch from 001-starting-to-implement-deck and:

- Generate enumerations for Rank and Suit.
- Generate a Card abstraction that holds rank/suit
    - Cards must have a functional equals(), hashCode(), and toString() (with spec)
- Generate a Deck abstraction
    - Methods: 
        - `dealCard()` removes the "top card" and returns it
        - Constructor generates a deck in rank/suit order
        - `shuffle()` mutates the deck in place to randomize the location of cards
            - The shuffle algorithm requires some advanced thinking: how do you easily 
              prove your logic is correct without basing the tests on what you are specifically doing?
    - Specifications must name and test all behaviors
  
### Part 2 -- I/O, injection, and integration/manual testing

Use your result from part 1 to continue:

- Create an I/O layer for asking questions and showing output: ConsoleIO
    - Must be injectable
    - Make manual integration tests (-Duser-intervention trick)

### Part 3 -- Round out algorithms

- Make a Hand abstraction (container of cards)
    - `String visibleHand(boolean hideBottom)` - Returns a string that represents current hand. The option indicates that the first card should be obscured.
    - `Set<Card> visibleCards(boolean hideBottom)` - Returns visible cards as a set
    - `int size()` - returns the number of cards in the hand
    - `static int score(Hand h)` - Returns the current "score" of the hand (accounting for Ace behavior)
- Make a Player interface or abstract class
    - `Action nextAction(Hand otherHand)` - Returns `Hit`, `Stay`, or `Busted` (based on known cards of the other player's hand)
    - `String getName()` - Returns the "name" of the player
- Implement and spec test a `HumanPlayer` that interacts with the console. `getName()` returns "You"
- Implement and spec test a `BotPlayer` that hits if he has not won or whose score is under 17 (or something similar). `getName()` returns "Dealer"

### Part 4 -- Dealing with more complex logic.

- Create a `BlackjackGame` class with:
    - `play()`: the main logic of game
        - Create deck 
        - Shuffle cards
        - Show visible dealer hand and player hand
        - Ask player for action until `Stay` or `Busted`
          - Hit: Add card and repeat (at show hands)
          - Stay: move on
          - Busted: show result and return
        - Do a similar dealer sequence
        - Determine winner, show result, return

Discuss with classmates the various ways you go about splitting this up 
and making it all testable. Algorithms that have multiple steps and decisions can
make for complicated test, which in turn indicate that you should redesign
your algorithm's structure. 

### Part 5 -- Implement main() AND TEST it before running it:

- Main logic is:
    - Create/inject a game
    - Play the game
    - Ask user "play again?"
    - Repeat if they answer yes.

Now run your fully functioning game for the first time!


 

 in the Pieces :
        the pawn is the one exception unit to my solution, 
        in the case of the pawn i'll just add an static check based on color and if the unit is 
        on passant, yes i'm aware this wastes 3 cycles of an for loop
        but its WAAAAAAy more readable this way, and i think the reduction in 
        the redundancy of the code in general is worth the exta 3 cycles per pawn
        if ur reaaly concerned about this it is possible to circunvent this by adding a check for white in the Map.cs


        this is the thing i disagree the most about the zen of python (and most "code this specific way)
        there isn't a "best way to do a method, because that's a way of thinking that completely ignores readability and expandability
        yes, there is always a fastest way to code a search algorithim, but it may not be the most readable for all, since readability is a higly subjective thing making something more readable doesnt automatically mean its better, or even faster
        and i think Tim Peters knew that to an extent, specially since he said that readability matters in the text, but the underlying idea that there is only one "right" way to solve a problem is just insane, 
        i wouldn't go as far as saying that coding is an art
        but being a good coder means that you need to write code in a way humans can understand, and use efficiently 
        which is in essence the art of knowing how to express yourself in a coherent way
        in short code is not art but coders are definitely artists 
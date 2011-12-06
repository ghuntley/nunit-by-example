One of the problems I've always had with unit testing is that the tests need to
live in a separate assembly, and so anything under test has to be publicly
visible outside the assembly. Not great.

Enter the [InternalsVisibleTo()] attribute. This little beauty will allow you
to separate your unit tests from your code, but make it possible to call
internals from another assembly. Cool!.

    using System; 
    using System.Runtime.CompilerServices;
    [assembly: InternalsVisibleTo ( "UnitTests" ) ] 
    
That's all there is to it (well, nearly). When you compile the main assembly,
we pickle (yes, that's the right word!) this attribute into it. Then, when you
try to compile your unit tests, the compiler is clever enough to look for this
attribute and emit the appropriate stuff so that you can then call you internal
classes/methods.  Obviously the above is a little lacking, in that I've only
specified "UnitTests" as the name of the assembly. Typically you would use not
only the name but also the public key token of that assembly. The text used by
the attribute is an assembly name, so you can add in culture etc to the string
too.

The [InternalsVisibleTo()] attribute also allows you to use it multiple times,
so you could have a list of assemblies that can call your internal methods.

Now, this isn't a suggestion that you mark all your public methods internal,
nor is it a suggestion that you should mark all privates as internals - use
this where it makes sense, but sparingly.

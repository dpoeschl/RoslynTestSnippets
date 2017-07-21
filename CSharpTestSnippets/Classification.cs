// This file illustrates the various classification types in VS

// "Comment"

using // "Keyword"
    System; // "Identifier"
using System.CodeDom; // Unused code fading (in Blue/Light/Dark themes)

namespace CSharpTestSnippets
{
    delegate int D(); // "User Types - Delegates"
    enum E { } // "User Types - Enums"
    interface I { } // "User Types - Interfaces"
    struct S { } // "User Types - Structures"
    class C1<TypeParameter> { } // "User Types - Type Parameters"

    class C2 // "User Types - Classes"
    {
        void M()
        {
            Console.WriteLine("Hello, world"); // "String"
            Console.WriteLine(@"Hello world"); // "String - Verbatim"

            var x1 = y; // Compiler error squiggle under "y"
            var x2 = 7; // Compiler warning squiggle under "x2"

            // Set "Tools | Options | Text Editor | C# | Code Style | General | 'var' preferences: | For built-in types" 
            // to "Prefer 'var'" with "Suggestion" severity
            int x3 = 7; // "Suggestion ellipses (...)" (under the "int")

            int x4 = 7 + 3; // "Operator" (the "+" sign)

#if FALSE
            int x4 = 7; // "Excluded Code"
#endif // "Preprocessor Keyword"

            Console.WriteLine("http://www.microsoft.com"); // "URL Hyperlink"
        }
    }

    // Right-click "Rename" on "ab" on the first line of "M" and change it to "abc"
    class InlineRenameSample
    {
        int abc = 7;

        void M()
        {
            int abc = 8; // "Inline Rename Field Text" + "Inline Rename Field Background and Border"
            this.abc = 8; // "Inline Rename Fixup"

            {
                int abc; // "Inline Rename Conflict
            }
        }
    }

    // Type a "1" at the end of "RenameTrackingSample" on the next line, you'll see a dotted border around it
    class RenameTrackingSample { } // "Rename Tracking"

    class DocCommentsSample
    {
        /// <summary> ("XML Doc Comments - Delimiter" for the "///", "XML Doc Comments - Name" for the "summary")
        /// Text ("XML Doc Comments - Text")
        /// <!--Comment--> ("XML Doc Comments - Comment")
        /// <![CDATA[ Content ]]> ("XML Doc Comments - CData Section")
        /// <tag Attribute = "Value"/>
        /// ("XML Doc Comments - Attribute Name" for "Attribute")
        /// ("XML Doc Comments - Attribute Quotes" for the quotation marks)
        /// ("XML Doc Comments - Attribute Value" for "Value")
        /// <tag><?test[=test]?></tag> ("XML Doc Comments - Processing Instruction")
        /// <tag>&lt;</tag> ("XML Doc Comments - Entity Reference" for "&lt;")
        /// </summary>
        void M() { }
    }
}

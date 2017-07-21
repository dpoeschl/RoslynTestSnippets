' See "CSharpTestSnippets\Classification.cs" for many of the shared classification types between C# and VB
' This file only illustrates the classification types unique to VB

Module M ' "User Types - Modules"
    Sub M()
        Dim x = 7
        Dim y =
            <Container>
                <Test1/> ' "VB XML Literals - Delimiter" for the angle brackets
                <Test2/> ' "VB XML Literals - Name" for the "Test2"
                <Test3 Attribute=""/> ' "VB XML Literals - Attribute Name" for "Attribute"
                <Test4 Attribute="AttributeValue"/> ' "VB XML Literals - Attribute Value" for the "AttributeValue"
                <Test5 Attribute=""/> ' "VB XML Literals - Attribute Quotes" for the quotation marks
                <Text6>Text</Text6> ' "VB XML Literals - Text"
                <Test7><%= x %></Test7> ' "VB XML Literals - Embedded Expression" for the %=
                <Test8>&lt;</Test8> ' "VB XML Literals - Entity Reference"
                <Test9><?piName [= piData]?></Test9> "VB XML Literals - Processing Instruction"
                <Test10><![CDATA[content]]></Test10> "VB XML Literals - CData Section"
                <!-- Comment --> ' "VB XML Literals - Comment"
            </Container>
    End Sub
End Module

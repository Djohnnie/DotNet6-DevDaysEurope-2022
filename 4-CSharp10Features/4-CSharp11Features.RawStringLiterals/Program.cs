

string message = """
    Never gonna give you up
    Never gonna let you down
    Never gonna run around and desert you
    Never gonna make you cry
    Never gonna say goodbye
    Never gonna tell a lie and hurt you
""";

Console.WriteLine(message);


var i = $"{{200}}";

(int x, int y) = (11, 22);

var otherMessage = $"""

    Your character is at position "{x},{y}"

    """;

Console.WriteLine(otherMessage);


var json = $$"""

{
    "rootObject": {
        "children": [
            {
                "id": "0001",
                "description": "First Item"
            },
            {
                "id": "0002",
                "description": "Second Item"
            },
            {
                "id": "0003",
                "description": "Third Item"
            }
        ]
    }
}

""";


Console.WriteLine(json);
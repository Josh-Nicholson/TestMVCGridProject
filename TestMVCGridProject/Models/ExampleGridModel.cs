using System.Collections.Generic;

namespace TestMVCGridProject.Models
{
    public class ExampleGridModel
    {
        public List<Example> Examples { get; set; }

        public ExampleGridModel()
        {
            Examples = new List<Example>
            {
                new Example()
                {
                    Id = 1,
                    ExampleName = "Example 1",
                    ExampleText = "Example Text"
                },
                new Example()
                {
                    Id = 2,
                    ExampleName = "Example 2",
                    ExampleText = "Example Text"
                },
                new Example()
                {
                    Id = 3,
                    ExampleName = "Example 3",
                    ExampleText = "Example Text"
                },
                new Example()
                {
                    Id = 4,
                    ExampleName = "Example 4",
                    ExampleText = "Example Text"
                },
                new Example()
                {
                    Id = 5,
                    ExampleName = "Example 5",
                    ExampleText = "Example Text"
                },
                new Example()
                {
                    Id = 6,
                    ExampleName = "Example 6",
                    ExampleText = "Example Text"
                },
                new Example()
                {
                    Id = 7,
                    ExampleName = "Example 7",
                    ExampleText = "Example Text"
                }
            };
        }
    }
}
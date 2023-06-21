using System;
using System.Collections.Generic;

class Branch
{
    public string Name { get; set; }
    public List<Branch> Children { get; set; }

    public Branch(string name)
    {
        Name = name;
        Children = new List<Branch>();
    }
}

class Program
{
    
    static int CalculateDepth(Branch branch)
    {
        if (branch.Children.Count == 0)
        {
            return 1; // Base case: depth is 1 for leaf nodes
        }

        int maxDepth = 0;
        foreach (Branch childBranch in branch.Children)
        {
            int childDepth = CalculateDepth(childBranch);
            maxDepth = Math.Max(maxDepth, childDepth);
        }

        return maxDepth + 1; // Increment depth by 1 for the current level
    }

    static void Main()
    {
        // Create the hierarchical structure
        Branch rootNode = new Branch("Main Node");
        Branch branchA = new Branch("A");
        Branch branchB = new Branch("B");
        Branch branchC = new Branch("C");
        Branch branchD = new Branch("D");
        Branch branchE = new Branch("E");
        Branch branchF = new Branch("F");
        Branch branchG = new Branch("G");
        Branch branchH = new Branch("H");
        Branch branchI = new Branch("I");
        Branch branchJ = new Branch("J");

        rootNode.Children.Add(branchA);
        rootNode.Children.Add(branchB);
        branchA.Children.Add(branchC);
        branchB.Children.Add(branchD);
        branchB.Children.Add(branchE);
        branchB.Children.Add(branchF);
        branchD.Children.Add(branchG);
        branchE.Children.Add(branchH);
        branchE.Children.Add(branchI);
        branchH.Children.Add(branchJ);

        
        

        // Calculate the depth of the structure
        int depth = CalculateDepth(rootNode);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"\nThe depth of the structure is: {depth}");
        Console.ResetColor();
    }
}

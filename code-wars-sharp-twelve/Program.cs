using System;

public enum Side { None, Left, Right }

public class ChainLink
{
    public ChainLink Left { get; private set; }
    public ChainLink Right { get; private set; }

    public void Append(ChainLink rightPart)
    {
        if (this.Right != null)
            throw new InvalidOperationException("Link is already connected.");

        this.Right = rightPart;
        rightPart.Left = this;
    }

    public Side LongerSide()
    {
        int lefCout = 0;
        ChainLink current = this.Left;
        while (current != null)
        {
            lefCout++;
            current = current.Left;
        }
        while (current != null)
        {
            lefCout--;
            current = current.Right;
        }
        if (lefCout > 0)
            return Side.Left;
        else if (lefCout < 0)
            return Side.Right;
        else
            return Side.None;
    }

    public static void Main(string[] args)
    {
        ChainLink left = new ChainLink();
        ChainLink middle = new ChainLink();
        ChainLink right = new ChainLink();
        left.Append(middle);
        middle.Append(right);
        Console.WriteLine(left.LongerSide());
    }
}

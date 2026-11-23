// ============================================================
//  Command  ·  Behavioral · 3 of 3
//
//  PROBLEM : Actions hard-wired to the UI
//  BENEFIT : Queue, log and undo actions
//
//    [ Button ] ──▶ [ Command ] ──▶ [ Receiver ]
//                     History: Bold, Paste, Copy   ← Undo pops last action
// ============================================================
namespace DesignPatterns.Behavioral;

public interface ICommand
{
    void Execute();
    void Undo();
}

// Receiver: does the real work
public class TextEditor
{
    public string Text { get; set; } = "";
}

public class AppendTextCommand(TextEditor editor, string value) : ICommand
{
    public void Execute() => editor.Text += value;
    public void Undo() => editor.Text = editor.Text[..^value.Length];
}

// Invoker: runs commands and keeps history for undo
public class CommandHistory
{
    private readonly Stack<ICommand> _history = new();

    public void Run(ICommand command)
    {
        command.Execute();
        _history.Push(command);
    }

    public void Undo()
    {
        if (_history.TryPop(out var command)) command.Undo();
    }
}

public static class CommandDemo
{
    public static void Run()
    {
        var editor = new TextEditor();
        var history = new CommandHistory();

        history.Run(new AppendTextCommand(editor, "Hello"));
        history.Run(new AppendTextCommand(editor, " World"));
        Console.WriteLine(editor.Text); // Hello World

        history.Undo();
        Console.WriteLine(editor.Text); // Hello
    }
}

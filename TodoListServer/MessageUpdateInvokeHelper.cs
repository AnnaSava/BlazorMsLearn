using Microsoft.JSInterop;

public class MessageUpdateInvokeHelper
{
    private Action action;

    public MessageUpdateInvokeHelper(Action action)
    {
        this.action = action;
    }

    [JSInvokable("TodoListServer")]
    public void UpdateMessageCaller()
    {
        action.Invoke();
    }
}
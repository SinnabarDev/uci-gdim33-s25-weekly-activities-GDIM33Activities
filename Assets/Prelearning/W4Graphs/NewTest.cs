using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewTest : MonoBehaviour
{
    public static string TestEvent = "Testing";
    // Start is called before the first frame update
    [UnitTitle("TestEvent")]
[UnitCategory("Events\\MyEvents")]
public class RelevantClassNameHere : EventUnit<DialogueNode>
{
// other stuff in here
public override EventHook GetHook(GraphReference reference)
{
return new EventHook(EventNames.YourEventNameHere);

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
public class TouchCreator:MonoBehaviour
{
    static BindingFlags flag = BindingFlags.Instance | BindingFlags.NonPublic;
    static Dictionary<string, FieldInfo> fields;

    object touch;

    public float deltaTime { get { return ((Touch)touch).deltaTime; } set { fields["m_TimeDelta"].SetValue(touch, value); } }
    public int tapCount { get { return ((Touch)touch).tapCount; } set { fields["m_TapCount"].SetValue(touch, value); } }
    public TouchPhase phase { get { return ((Touch)touch).phase; } set { fields["m_Phase"].SetValue(touch, value); } }
    public Vector2 deltaPosition { get { return ((Touch)touch).deltaPosition; } set { fields["m_PositionDelta"].SetValue(touch, value); } }
    public int fingerId { get { return ((Touch)touch).fingerId; } set { fields["m_FingerId"].SetValue(touch, value); } }
    public Vector2 position { get { return ((Touch)touch).position; } set { fields["m_Position"].SetValue(touch, value); } }
    public Vector2 rawPosition { get { return ((Touch)touch).rawPosition; } set { fields["m_RawPosition"].SetValue(touch, value); } }

    public Touch Create()
    {
        return (Touch)touch;
    }

    public TouchCreator()
    {
        touch = new Touch();
    }

    static TouchCreator()
    {
        fields = new Dictionary<string, FieldInfo>();
        foreach (var f in typeof(Touch).GetFields(BindingFlags.Instance | BindingFlags.NonPublic))
        {
            fields.Add(f.Name, f);
            Debug.Log("name: " + f.Name);
        }
    }
}
public class InputManager : MonoBehaviour
{
    private static TouchCreator lastFakeTouch;

    public static List<Touch> GetTouches()
    {
        List<Touch> touches = new List<Touch>();
        touches.AddRange(Input.touches);
#if UNITY_EDITOR
        if (lastFakeTouch == null) lastFakeTouch = new TouchCreator();
        if (Input.GetMouseButtonDown(0))
        {
            lastFakeTouch.phase = TouchPhase.Began;
            lastFakeTouch.deltaPosition = new Vector2(0, 0);
            lastFakeTouch.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            lastFakeTouch.fingerId = 0;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            lastFakeTouch.phase = TouchPhase.Ended;
            Vector2 newPosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            lastFakeTouch.deltaPosition = newPosition - lastFakeTouch.position;
            lastFakeTouch.position = newPosition;
            lastFakeTouch.fingerId = 0;
        }
        else if (Input.GetMouseButton(0))
        {
            lastFakeTouch.phase = TouchPhase.Moved;
            Vector2 newPosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            lastFakeTouch.deltaPosition = newPosition - lastFakeTouch.position;
            lastFakeTouch.position = newPosition;
            lastFakeTouch.fingerId = 0;
        }
        else
        {
            lastFakeTouch = null;
        }
        if (lastFakeTouch != null) touches.Add(lastFakeTouch.Create());
        return touches;
#endif
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            //Debug.Log(List<Touch>GetTouches());
            //if (Input.touchCount > 0)
            //{
            //    Debug.Log("test");
            //    Touch touch = Input.GetTouch(0); // get first touch since touch count is greater than zero

            //    if (touch.phase == TouchPhase.Stationary || touch.phase == TouchPhase.Moved)
            //    {
            //        // get the touch position from the screen touch to world point
            //        Vector3 touchedPos = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, 10));
            //        // lerp and set the position of the current object to that of the touch, but smoothly over time.
            //        transform.position = Vector3.Lerp(transform.position, touchedPos, Time.deltaTime);
            //    }
            //}
        }
    }
}

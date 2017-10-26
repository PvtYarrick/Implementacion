using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineDemo : MonoBehaviour 
{
	public LineFactory lineFactory;

	private Vector2 start;
	private Line drawnLine;

    public float offset1;
    public float offset2;

    public Transform target1;
    public Transform target2;
    public Camera lineCamera;
    public Camera scenarioCamera;

    void Update ()
	{
        /*if (Input.GetMouseButtonDown (0)) {
			var pos = Camera.main.ScreenToWorldPoint (Input.mousePosition); // Start line drawing
			drawnLine = lineFactory.GetLine (pos, pos, 0.02f, Color.green);
		} else if (Input.GetMouseButtonUp (0)) {
			drawnLine = null; // End line drawing
		}

		if (drawnLine != null) {
			drawnLine.end = Camera.main.ScreenToWorldPoint (Input.mousePosition); // Update line end
		}*/

        Vector3 viewPos1 = scenarioCamera.WorldToViewportPoint(target1.position);
        Vector3 viewPos2 = scenarioCamera.WorldToViewportPoint(target2.position);
         viewPos1 = lineCamera.ViewportToWorldPoint(viewPos1);
         viewPos2 = lineCamera.ViewportToWorldPoint(viewPos2);
        drawnLine = lineFactory.GetLine((viewPos1), (viewPos2), 0.02f, Color.green);
    }

	/// <summary>
	/// Get a list of active lines and deactivates them.
	/// </summary>
	public void Clear()
	{
		var activeLines = lineFactory.GetActive ();

		foreach (var line in activeLines) {
			line.gameObject.SetActive(false);
		}
	}
}

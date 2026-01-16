using UnityEngine;

namespace TimeControl
{
    internal static class ToolTips
    {
        internal static void ShowToolTip(Rect rect)
        {
            //if (HighLogic.CurrentGame.Parameters.CustomParams<MissionPlannerSettings>().showTooltips)
            {
                if (!string.IsNullOrEmpty(GUI.tooltip))
                {
                    Vector2 mouse = Event.current.mousePosition;
                    GUIStyle style = GUI.skin.box;
                    Vector2 size = style.CalcSize(new GUIContent(GUI.tooltip));
                    float maxx = rect.width - (size.x + 20);
                    float x = Mathf.Clamp(mouse.x + 16f, 0f, maxx);
                    float y = Mathf.Clamp(mouse.y + 16f + ((x == maxx) ? 8 : 0), 0f, rect.height);
                    // Small offset so it doesn’t overlap the cursor
                    Rect tipRect = new Rect(x, y, size.x + 8f, size.y + 4f);

                    GUI.Box(tipRect, GUI.tooltip);
                }
            }
        }
    }
}

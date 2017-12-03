using UnityEngine;

namespace Appname.Domain
{
    public static class Constants
    {
        #region RELASE CONSTS

        public const bool DEBUG_BUILD = true;

        #endregion


        // General
        public const int PUZZLE_COUNT_PER_RANKED_REGION = 5;
        public static readonly int[] DEFAULT_REGIONS = {1};
        public const float REGION_BASE_POINT_MODIFIER = 1.0f;
        public const string PLAYER_DATA_KEY = "PlayerData";
        public const string NAME_PUZZLE_VIEW_3D_ROOT = "3D";
        public const string NAME_PUZZLE_VIEW_SOLUTION_ROOT = "Solution";
        public const string LAYER_NAME_SOLUTION = "Solution";
        public const float SPHERECAST_RADIUS = 0.1f;
        public const long TIME_ELAPSED_INTERSTIAL = 300000; // 5 min

        // General UI / Presentation
        public const string SHADER_EMISSION_COLOR_PROPERTY = "_EmissionColor";
        public const string BLANK_TIME = "--:--:--.--";
        public const string ESCAPE_BUTTON = "escape";

        // Home
        public const float HOME_REGION_VIEW_SHOW_DELAY = 0.2f;
        public const float HOME_REGION_VIEW_SHOW_DURATION = 0.5f;
        public const float HOME_SCROLL_SNAP_DELAY = 0.6f;
        public const float HOME_SCROLL_SNAP_DURATION = 1.9f;
        public const string REGION_VIEW_REUSABLE_ID = "RegionView";
        public const string REGION_PUZZLE_VIEW_REUSABLE_ID = "RegionPuzzleView";
        public const float TRANSITION_IN_OUT_DURATION = 1f;
        public static readonly Vector3 PUZZLE_SELECT_PREVIEW_PUZZLE_VIEW_SCALE = new Vector3(0.45f, 0.45f, 0.45f);

        // Puzzle
        public const int PUZZLE_VALIDATION_FRAME_COUNT = 1;
        public const float PUZZLE_BLOCK_TRAIL_CLEANUP_DURATION = 0.4f;
        public const float PUZZLE_CENTER_DURATION = 0.15f;
        public const float PUZZLE_ROTATE_SNAP_THRESHOLD = 22.5f;
        public const float PUZZLE_BLOCK_GIZMO_COLOR_DURATION = 0.6f;
        public const float PUZZLE_INVALID_TOUCH_RESET_DURATION = 0.5f;
        public const float MAX_DELTA_ROT_PER_FRAME = 45f;

        // Ads
        #if UNITY_IOS
        public const string UNITY_ADS_GAME_ID = "1188692";
        public const string UNITY_ADS_REWARDED_VIDEO_PLACEMENT_ID = "rewardedVideo";

        public const string ADMOB_PUZZLE_COMPLETION_ID = "ca-app-pub-5106713995555466/9267823434";
        #else
        public const string UNITY_ADS_GAME_ID = "1188693";
        public const string UNITY_ADS_REWARDED_VIDEO_PLACEMENT_ID = "rewardedVideo";

        public const string ADMOB_PUZZLE_COMPLETION_ID = "ca-app-pub-5106713995555466/1744556634";
        #endif

    }

    // Analytics
    public static class AnalyticParam
    {
        public const string PLAYER_NAME = "playerName";
        public const string PLAYER_POINTS = "playerPoints";
        public const string PLAYER_MEDAL_COUNT = "playerMedalCount";
        public const string REGION_PUZZLE_ID = "regionPuzzleId";
        public const string TIME = "time";
    }
}

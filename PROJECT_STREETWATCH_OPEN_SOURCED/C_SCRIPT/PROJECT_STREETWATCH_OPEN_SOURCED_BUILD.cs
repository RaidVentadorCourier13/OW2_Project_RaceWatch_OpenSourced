settings
{
	main
	{
		Description: "Project: Streetwatch by GraczCourier (now known as RaidVentador_Courier_13) \n OPEN-SOURCED BUILD \n \n Gamemode Homepage: \n https://workshop.codes/4XQP4 \n Support the Creator via Ko-Fi:\n https://ko-fi.com/raidventador_courier_13 \n \n Special Thanks to:\n Deltin and Lotto for help and contribution"
		Mode Name: "Project: Streetwatch"
	}

	lobby
	{
		Map Rotation: After A Game
		Match Voice Chat: Enabled
		Max Spectators: 12
		Max Team 1 Players: 1
		Max Team 2 Players: 0
		Return To Lobby: After A Game
	}

	modes
	{
		disabled Capture the Flag
		{
			Flag Dropped Lock Time: 5.0
			Flag Return Time: 4.0
			Flag Score Respawn Time: 15.0
		}

		disabled Control
		{
			Score To Win: 1
			Scoring Speed Modifier: 200%
		}

		Hybrid
		{
			Capture Speed Modifier: 10%
			Payload Speed Modifier: 10%

			enabled maps
			{
			}
		}

		Skirmish
		{
			enabled maps
			{
				Workshop Chamber 972777519512064577
			}
		}

		Team Deathmatch
		{
			Game Length In Minutes: 15
			Imbalanced Team Score To Win: On
			Score To Win: 1
			Team 1 Score To Win: 1
			Team 2 Score To Win: 1

			enabled maps
			{
			}
		}

		General
		{
			Game Mode Start: Immediately
			Hero Limit: Off
			Kill Cam: Off
			Kill Feed: Off
			Spawn Health Packs: Disabled
		}
	}

	heroes
	{
		General
		{
			D.Va
			{
				Spawn Without Mech: On
			}

			Wrecking Ball
			{
				Roll Always Active: On
			}
		}
	}

	extensions
	{
		Buff and Debuff Sounds
		Explosion Sounds
		Play More Effects
	}
}

variables
{
	global:
		0: VAR_MENU_ARRAY_STRING_MAIN
		1: VAR_MENU_ARRAY_STRING_CONTROL
		2: VAR_MENU_ARRAY_STRING_CAR
		3: VAR_MENU_ARRAY_STRING_TUNE
		4: VAR_MENU_ARRAY_STRING_RADIOS
		5: VAR_MENU_ARRAY_STRING_NITROUS
		6: VAR_MENU_ARRAY_STRING_MODE
		7: VAR_MENU_ARRAY_STRING_MODE_NAME
		8: VAR_MENU_ARRAY_STRING_TOGGLE
		9: VAR_MENU_ARRAY_STRING_DEPLOY
		10: VAR_MENU_MENU_STRING_NAV
		11: VAR_MENU_MENU_STRING_NAV_PREV
		12: COCONUT
		13: VAR_MENU_ARRAY_CURR_MIN_CLAMP
		14: VAR_MENU_ARRAY_CURR_MAX_CLAMP
		15: VAR_MENU_VAL_CURR_MENU
		16: VAR_MENU_ARRAY_CURR_NAV_LIMITS
		17: VAR_MENU_ARRAY_CURR_OPTION_TYPE
		18: VAR_MENU_VAL_CURR_OPTION
		19: VAR_MENU_VAL_CURR_OPTION_VALUE
		20: VAR_MENU_VAL_OPTION_CHANGE_SPEED
		21: VAR_MENU_ARRAY_RADIO_COLOR_LIST
		22: VAR_MENU_ARRAY_COLOR_CURR_LIST
		23: VAR_MENU_ARRAY_BTN_Z_VECTOR
		24: VAR_MENU_ARRAY_SUBBTN_Z_VECTOR
		25: VAR_MENU_VSL_ARROWS_VAL_ADJUST
		26: VAR_MENU_SETTINGS_CHANGE_CHECK
		27: VAR_MENU_ARRAY_STRING_BTN_H
		28: VAR_MENU_ARRAY_STRING_SUBBTN_H
		29: ALPINE_CHOCOLATE_WIT_CEMENT
		30: VAR_MENU_WAITING_FOR_CAR_STRING
		31: VAR_MENU_LOADING_ARRAY_STRING
		32: VAR_MENU_LOADING_VALUE
		33: VAR_GBL_CURR_STORED_VALUES
		34: VAR_GBL_INTRNL_STORED_VALUES
		35: VAR_PLAYER_RACER
		36: VAR_DRIVEABLE_VEHICLE
		38: VAR_VEH_MESH_VRTCS_CURR_PART
		39: VAR_VEH_MESH_EDGES_CURR_PART
		40: VAR_VEH_MESH_VRTCS_FRONT_BUMPER
		41: VAR_VEH_MESH_VRTCS_FRONT_HOOD
		42: VAR_VEH_MESH_VRTCS_BODY
		43: VAR_VEH_MESH_VRTCS_ENGINE_HOOD
		44: VAR_VEH_MESH_VRTCS_REAR_BUMPER
		45: VAR_VEH_MESH_VRTCS_HEADLIGHTS
		46: VAR_VEH_MESH_VRTCS_L_R_LIGHTS
		47: VAR_VEH_MESH_VRTCS_R_R_LIGHTS
		48: VAR_VEH_MESH_VRTCS_NITROUS
		49: VAR_VEH_MESH_VRTCS_CARBON_PARTS
		50: VAR_VEH_MESH_EDGES_FRONT_BUMPER
		51: VAR_VEH_MESH_EDGES_FRONT_HOOD
		52: VAR_VEH_MESH_EDGES_BODY
		53: VAR_VEH_MESH_EDGES_ENGINE_HOOD
		54: VAR_VEH_MESH_EDGES_REAR_BUMPER
		55: VAR_VEH_MESH_EDGES_HEADLIGHTS
		56: VAR_VEH_MESH_EDGES_L_R_LIGHTS
		57: VAR_VEH_MESH_EDGES_R_R_LIGHTS
		58: VAR_VEH_MESH_EDGES_NITROUS
		59: VAR_VEH_MESH_EDGES_CARBON_PARTS
		60: VAR_VEH_MESH_Effects
		61: VAR_VEH_MESH_Scale
		62: VAR_VEH_MESH_i
		63: VAR_VEH_MESH_ActualLine
		64: A_PIECE_OF_ASPHALT_THAT_I_FOUND
		65: VAR_VEH_CUSTOM_CAR_BODY_COLORS
		66: VAR_VEH_CUSTOM_CAR_LIGHT_COLORS
		67: VAR_VEH_CAR_BODY
		68: VAR_GLB_RACE_HAS_REV_VARIANT
		69: VAR_GLB_RACE_HAS_TRACK
		70: VAR_GLB_PLAYER_IS_IN_MAIN_MENU
		71: VAR_GLB_VEHICLE_DEPLOY_STATUS
		72: VAR_GLB_ARRAY_STRING_IN_GAME
		73: VAR_GLB_ARRAY_STRING_AWARD_LVL
		74: VAR_GLB_ARRAY_STRING_STUNT
		75: VAR_GLB_ARRAY_STRING_CAMERA
		76: VAR_GLB_ARRAY_VAL_DRIFT_AWARD
		77: VAR_GLB_ARRAY_VAL_AIR_AWARD
		78: VAR_GLB_ARRAY_STUNT_MECHANICS
		79: VAR_GLB_ARRAY_CHECKPOINT_TABLE
		80: VAR_GLB_VEH_REG_START_POS
		81: VAR_GLB_VEH_REG_START_FACE
		82: VAR_GLB_VEH_REV_START_POS
		83: VAR_GLB_VEH_REV_START_FACE
		84: VAR_GLB_RACE_STATUS
		85: VAR_GPL_RACE_COUNTERS_STRINGS
		86: VAR_GPL_RACE_CURR_COUNTDOWN
		87: VAR_GPL_RACE_VSL_COUNTDOWN_A
		89: THE_RAVEN_CAN_ONLY_WATCH_OMENS
		90: VAR_CRIT_ARRAY_CORE
		91: VAR_TEST_DRIFT_CHECK_BOOL
		92: VAR_TEST_DRIFT_CHECK_STRINGS
		93: VAR_TEST_DRIFT_GRIP_CHECK_BOOL
		94: VAR_TEST_DRIFT_GRIP_STRINGS

	player:
		0: VAR_VEH_ARRAY_BODY_COLOR
		1: VAR_VEH_ARRAY_LIGHT_STORED
		2: VAR_VEH_ARRAY_STORED_VALUES
		3: VAR_VEH_BUILD_ARRAY_CURR_COLOR
		4: VAR_VEH_COLOR_DEFAULT
		5: VAR_GPL_MODE_CURRENT_LAP
		9: VAR_PLAYER_IS_RACER
		10: VAR_RACER_VEHICLE
		11: VAR_RACER_VEHICLE_IS_READY
		12: VAR_RACER_VEHICLE_IS_ALIVE
		13: VAR_RACER_VEHICLE_IS_AIRBORNE
		14: VAR_PLAYER_RACER_INSIDE_VEHICLE
		15: VAR_RACER_HUD
		16: VAR_ARRAY_CAR_MECHANICS
		17: VAR_ARRAY_CAR_MECHANICS_VALUES
		18: VAR_ARRAY_CAR_FUNCTIONS
		19: VAR_ARRAY_CAR_PLAYER_FEEDBACKS
		20: VAR_ARRAY_CAR_CAMERA_MECHANICS
		22: VAR_VEH_ACCELER_THROTTLE
		23: VAR_VEH_ACCELER_DIRECTION
		24: VAR_VEH_STEERING_CNTR_VALUE
		25: VAR_VEH_STEERING_LEFT_VALUE
		26: VAR_VEH_STEERING_RIGHT_VALUE
		27: VAR_VEH_STEERING_DIRECTION
		28: VAR_VEH_DRIFT_GRIP
		29: VAR_VEH_DRIFT_TRIGGER
		30: VAR_VEH_GRIP_DEST
		31: VAR_VEH_GRIP_RATE
		32: VAR_VEH_GRIP_RECOVER_TRIGGER
		33: VAR_NITROUS_ARRAY_MECHANICS
		34: VAR_NITROUS_CURR_VAL_TANK
		35: VAR_NITROUS_BOOL_IS_USED
		36: VAR_NITROUS_BOOL_REGEN_SIGNAL
		37: VAR_VEH_FUNCTION_COOLDOWN
		38: VAR_VEH_RADIO_CURR_VALUE
		39: VAR_VEH_FACING
		40: VAR_VEH_MOVE_SPEED
		41: VAR_VEH_RAMP_TRIGGER
		42: VAR_VSL_STUNTS_ENABLED
		43: VAR_VSL_TXT_STUNT_DRIFT_STRING
		44: VAR_VSL_TXT_STUNT_X_POS
		45: VAR_VSL_TXT_STUNT_CHASED_X
		46: VAR_VSL_TXT_STUNT_CHASED_R
		47: VAR_VSL_TXT_STUNT_INFO_WAIT
		48: VAR_VSL_TXT_STUNT_DRIFT_CHASED_Z
		49: VAR_VSL_TXT_STUNT_DRIFT_CHASED_A
		50: VAR_VSL_TXT_STUNT_AIR_CHASED_Z
		51: VAR_VSL_TXT_STUNT_AIR_CHASED_A
		52: VAR_VSL_TXT_ALL_DEST_Z
		53: VAR_VSL_TXT_STUNT_DRIFT_Y
		54: VAR_VSL_TXT_STUNT_AIR_Y
		55: VAR_VSL_TXT_ALL_BOUNCE_Z
		56: VAR_VSL_TXT_DT_TMR_Y
		57: VAR_VSL_STUNT_DRIFT_TRIGGER
		58: VAR_VSL_STUNT_AIR_TRIGGER
		59: VAR_STUNT_CURR_TYPE
		60: VAR_VEH_DRIFT_TYPE
		61: VAR_STUNT_CURR_VAL_DRIFT_LVL
		62: VAR_STUNT_CHASE_VAL_DRIFT_AWARD
		63: VAR_STUNT_DRIFT_AWARD_TRIGGER
		64: VAR_STUNT_CURR_VAL_AIR_LVL
		65: VAR_STUNT_CHASE_VAL_AIR_AWARD
		66: VAR_STUNTS_SCORE
		67: VAR_RACER_VEHICLE_RES_FACE
		68: VAR_RACER_VEHICLE_RES_POS
		69: VAR_RACER_VEHICLE_RES_NITROUS
		70: VAR_VSL_TXT_CLK_CLK_SECONDS
		71: VAR_VSL_TXT_CLK_CLK_MINUTES
		72: VAR_VSL_TXT_CLK_LAP_SECONDS
		73: VAR_VSL_TXT_CLK_LAP_MINUTES
		74: VAR_VSL_TXT_CLK_BST_SECONDS
		75: VAR_VSL_TXT_CLK_BST_MINUTES
		77: VAR_VSL_TXT_CLK_LST_SECONDS
		78: VAR_VSL_TXT_CLK_LST_MINUTES
		79: VAR_VSL_TXT_DT_TMR_CHASED_Z
		80: VAR_VSL_TXT_DT_TMR_CHASED_R
		81: VAR_VSL_TXT_DT_TMR_CHASED_G
		82: VAR_VSL_TXT_DT_TMR_CHASED_B
		84: VAR_VSL_TXT_DT_TMR_TRIGGER
		86: VAR_VAL_DT_MODE_CHASE_TIME
		87: VAR_VSL_HUD_CLK_BST_COLOR
		89: VAR_VSL_HUD_TGT_SCORE_COLOR
		90: VAR_VSL_HUD_TGT_SCORE_TRIGGER
		91: VAR_VSL_HUD_TGT_SCORE_ICON
		92: VAR_RACER_VEHICLE_VISIBLE_TO
		93: VAR_RACER_INPUT_ENABLED
		100: VAR_ARRAY_CAR_NAVIGATION
}

subroutines
{
	0: SUB_CORE
	1: SUB_GPL_STORE_GAME_VALUES
	2: SUB_MENU_EXIT
	3: SUB_MENU_ENTER
	4: SUB_MENU_CREATE_BUTTONS
	5: SUB_MENU_CREATE_SUB_BUTTONS
	6: SUB_MENU_UPDATE_SUB_BUTTONS
	8: SUB_VEH_CREATE_CAR_BODY_BEAM
	9: SUB_VEH_CREATE_HEADLIGHTS_BEAM
	10: SUB_VEH_CREATE_L_R_LIGHTS_BEAM
	11: SUB_VEH_CREATE_R_R_LIGHTS_BEAM
	12: SUB_VEH_CREATE_NITROUS_BEAM
	13: SUB_VEH_CREATE_CARBON_BEAM
	14: SUB_VEH_CREATE_APPEND_EFFECT
	15: SUB_VEH_DISABLE_INPUT
	16: SUB_GPL_VSL_CREATE_HUD
	17: SUB_VEH_ENGINE_ON
	18: SUB_VEH_ENGINE_OFF
	19: SUB_VEH_STEERING_ON
	20: SUB_VEH_STEERING_OFF
	21: SUB_VEH_CAMERA_START
	22: SUB_VEH_CAMERA_SWITCH
	23: SUB_VEH_CAMERA_CHASE
	24: SUB_VEH_CAMERA_FREE
	25: SUB_VEH_CAMERA_BUMPER
	26: SUB_VEH_CAMERA_MESSAGE
	27: SUB_VEH_INPUT_FUNC_COOLDOWN
	28: SUB_VEH_CHASE_STEER_RESET_BOOST
	29: SUB_VEH_CHASE_GRIP_RESET_BOOST
	30: SUB_VEH_STUNTS_IS_DRIFTING
	31: SUB_VEH_STUNTS_IS_FLYING
	32: SUB_VEH_STUNTS_BREAK
	33: SUB_VEH_NITROUS_CHANGE_SPEED
	34: SUB_VEH_NITROUS_STOP
	35: SUB_VEH_STUNTS_SCORE_AND_RESET
	40: SUB_VEH_VSL_GET_COLORS
}

disabled rule("Project: Streetwatch - Original Build by GraczCourier (now known as RaidVentador_Courier_13)")
{
	event
	{
		Ongoing - Global;
	}
}

rule("MAIN MENU: GLOBAL STRING LIST")
{
	event
	{
		Ongoing - Global;
	}

	actions
	{
		"REFER TO \"VARIABLE_STRING_TABLES.TXT\" FILE"
		Global.VAR_MENU_ARRAY_STRING_MAIN = Array(Custom String("PROJECT: STREETWATCH"), Custom String(
			"BY RAIDVENTADOR_COURIER_13 AND DELTIN"), Custom String("XXXXX - BASIC SUPERCAR PACK (DEVELOPMENT BUILD)"), Custom String(
			"VEHICLE CONTROLS"), Custom String("PLAY"), Custom String("SELECT CAR:"), Custom String("TUNE CAR"), Custom String(
			"MODE SETTINGS"), Custom String("EXIT TO LOBBY"), Custom String("EXIT TO MAIN MENU"), Custom String(
			">                                                                                 <"), Custom String("SETTINGS SAVED"),
			Custom String("SETTING REVERTED"), Custom String("THE CURRENT MAP HAS NO TRACK"), Custom String(
			"THE TRACK DOESN'T HAVE A REVERSE VARIANT"));
		Global.VAR_MENU_ARRAY_STRING_CONTROL = Array(Custom String("(HOLD)"), Custom String("(TAP)"), Custom String("(PRESS)"),
			Custom String("(HOLD/TAP)"), Custom String("- ENTER/EXIT THE VEHICLE"), Custom String("- NITROUS"), Custom String(
			"- HANDBRAKE"), Custom String("- SWITCH RADIO"), Custom String("- TOGGLE BLINKERS"), Custom String("- TURN ON/OFF CAR ENGINE"),
			Custom String("- SWITCH CAMERA"), Custom String("- RESPAWN (WHEN CRASHED)"), Custom String("PRESS"), Custom String("OR"),
			Custom String("TO EXIT TO MAIN MENU"), Custom String("MOVE LEFT"), Custom String("MOVE RIGHT"));
		"REFER TO \"VARIABLE_STRING_TABLES.TXT\" FILE"
		Global.VAR_MENU_ARRAY_STRING_CAR = Array(Custom String("CAR_01_NAME_HERE"), Custom String("CAR_02_NAME_HERE"), Custom String(
			"CAR_03_NAME_HERE"), Custom String("CAR_04_NAME_HERE"), Custom String("CAR_05_NAME_HERE"), Custom String("CAR_06_NAME_HERE"),
			Custom String("CAR_07_NAME_HERE"), Custom String("CAR_08_NAME_HERE"));
		Global.VAR_MENU_ARRAY_STRING_MODE_NAME = Array(Custom String("FREE DRIVE"), Custom String("RACE"), Custom String(
			"DYNAMITE TRIAL"));
		Wait(0.100, Ignore Condition);
		Global.VAR_MENU_ARRAY_STRING_TUNE = Array(Custom String("SELECT RADIOSTATION:"), Custom String("START OUTSIDE OF THE CAR?:"),
			Custom String("NITROUS:"), Custom String("NITROUS - STARTING PERCENT:"), Custom String("NITROUS - POWER MULTIPLIER:"));
		Global.VAR_MENU_ARRAY_STRING_NITROUS = Array(Custom String("NITROUS DISABLED"), Custom String("ENABLED (SELF-REGENERATING)"),
			Custom String("ENABLED (REGENERATES VIA STUNTS)"));
		Global.VAR_MENU_ARRAY_STRING_MODE = Array(Custom String("CURRENT MODE:"), Custom String("NUMBER OF LAPS:"), Custom String(
			"IS REVERSED?:"), Custom String("SCORE CONDITION:"), Custom String("SCORE THRESHOLD:"), Custom String("CHECKPOINT RADIUS:"),
			Custom String("{0} - START WITH REMAINING TIME:", Global.VAR_MENU_ARRAY_STRING_MODE_NAME[2]), Custom String(
			"{0} - TIME EARNED VIA CHECKPOINT:", Global.VAR_MENU_ARRAY_STRING_MODE_NAME[2]));
		Global.VAR_MENU_ARRAY_STRING_TOGGLE = Array(Custom String(" OFF "), Custom String(" ON "));
		Global.VAR_MENU_ARRAY_STRING_RADIOS = Array(Custom String("RANDOMIZED"), Custom String("RADIO OFF"), Custom String("PULSE FM"),
			Custom String("RETRO DRIVE FM"), Custom String("BLOCK HOUSE"), Custom String("ROCK/RUSH FM"), Custom String(
			"MONSTERCAT ALLSTARS"), Custom String("DISTROKID"));
		Global.VAR_MENU_ARRAY_STRING_DEPLOY = Array(Custom String("Waiting for Car Delivery..."), Custom String(
			"Ready - Press \"Anything\" to Deploy"), Custom String("TIP/TRIVIA:"), Custom String(
			"Motorsports are dangerous. In real world, hoon responsibly,\n obey the laws of the road, and always wear your seatbelt."),
			Custom String("Don't be afraid to use the brakes if you're approaching a curve too fast."), Custom String(
			"The handbrake can help you initiate the drift."), Custom String(
			"Drift is initiated by turning and using the brakes simultaneously.\n E-Drift is initiated by using the handbrake."),
			Custom String("When drifting, counter-steer or brake to recover grip."), Custom String(
			"Having trouble controlling the car?\n Go easy on the accelerator and remember to counter-steer."));
	}
}

rule("IN-GAME GLOBAL MECHANICS: STRING LIST")
{
	event
	{
		Ongoing - Global;
	}

	actions
	{
		Global.VAR_GLB_ARRAY_STRING_AWARD_LVL = Array(Custom String(" "), Custom String("GREAT"), Custom String("AWESOME"), Custom String(
			"SICK"), Custom String("ULTIMATE"), Custom String("ALLSTAR"));
		Global.VAR_GLB_ARRAY_STRING_STUNT = Array(Custom String("DRIFT"), Custom String("E-DRIFT"), Custom String("AIR"));
		Global.VAR_GLB_ARRAY_STRING_IN_GAME = Array(Custom String("VEHICLE ENTERED"), Custom String("VEHICLE EXITED"), Custom String(
			"ENGINE ON"), Custom String("ENGINE IS OFF! PRESS"), Custom String("AND"), Custom String("TO TURN IT ON!"), Custom String(
			"PRESS"), Custom String("TO ENTER THE VEHICLE"), Custom String("TO RESPAWN"), Custom String("TO RESTART"), Custom String(
			"You crashed!"), Custom String("Respawning..."), Custom String("Restarting..."), Custom String("RADIOSTATION:"), Custom String(
			"SCORE:"), Custom String("LAP:"), Custom String("FINAL LAP!"), Custom String("FINISH!"), Custom String("BAD LUCK!"),
			Custom String("CLK"), Custom String("LAP"), Custom String("LST"), Custom String("BST"), Custom String(
			"TARGET SCORE NOT REACHED!"), Custom String("TARGET SCORE REACHED!"));
		Global.VAR_GPL_RACE_COUNTERS_STRINGS = Array(Custom String("GO!"), Custom String("1"), Custom String("2"), Custom String("3"));
		Global.VAR_GLB_ARRAY_STRING_CAMERA = Array(Custom String("CHASE CAMERA"), Custom String("FREE CAMERA"), Custom String(
			"BUMPER CAMERA"));
		Global.VAR_MENU_LOADING_ARRAY_STRING = Array(Custom String("|"), Custom String("/"), Custom String("—"), Custom String("\\"));
	}
}

disabled rule("Cars / Open-Sourced")
{
	event
	{
		Ongoing - Global;
	}
}

rule("#1 CAR_01_NAME_HERE (Mesh Array Tables)")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		"FOR INDEXES REFER TO: MENU \\ ARRAY TABLE - INTERNAL STORAGE VARIABLE \n [1] - CURRENT CAR \n Rule Elements Count: 0"
		Global.VAR_GBL_INTRNL_STORED_VALUES[1] == 0;
		Entity Exists(Global.VAR_PLAYER_RACER) == True;
	}

	actions
	{
		"VERTICES COUNT: 0 \n EDGE COUNT: 0 \n Car models ported with Deltin's OSTW for Visual Studio Code"
		Global.VAR_VEH_MESH_VRTCS_FRONT_BUMPER = Empty Array;
		Global.VAR_VEH_MESH_VRTCS_FRONT_HOOD = Empty Array;
		Global.VAR_VEH_MESH_VRTCS_BODY = Empty Array;
		Global.VAR_VEH_MESH_VRTCS_ENGINE_HOOD = Empty Array;
		Global.VAR_VEH_MESH_VRTCS_REAR_BUMPER = Empty Array;
		Global.VAR_VEH_MESH_VRTCS_HEADLIGHTS = Empty Array;
		Global.VAR_VEH_MESH_VRTCS_L_R_LIGHTS = Empty Array;
		Global.VAR_VEH_MESH_VRTCS_R_R_LIGHTS = Empty Array;
		Global.VAR_VEH_MESH_VRTCS_NITROUS = Empty Array;
		Global.VAR_VEH_MESH_VRTCS_CARBON_PARTS = Empty Array;
		Global.VAR_VEH_MESH_EDGES_FRONT_BUMPER = Empty Array;
		Global.VAR_VEH_MESH_EDGES_FRONT_HOOD = Empty Array;
		Global.VAR_VEH_MESH_EDGES_BODY = Empty Array;
		Global.VAR_VEH_MESH_EDGES_ENGINE_HOOD = Empty Array;
		Global.VAR_VEH_MESH_EDGES_REAR_BUMPER = Empty Array;
		Global.VAR_VEH_MESH_EDGES_HEADLIGHTS = Empty Array;
		Global.VAR_VEH_MESH_EDGES_L_R_LIGHTS = Empty Array;
		Global.VAR_VEH_MESH_EDGES_R_R_LIGHTS = Empty Array;
		Global.VAR_VEH_MESH_EDGES_NITROUS = Empty Array;
		Global.VAR_VEH_MESH_EDGES_CARBON_PARTS = Empty Array;
		"PASTE YOUR CAR HERE - Original Gamemode Creator: GraczCourier (now known as RaidVentador_Courier_13)"
		Global.VAR_PLAYER_RACER.VAR_VEH_COLOR_DEFAULT = Color(Blue);
		Call Subroutine(SUB_VEH_VSL_GET_COLORS);
	}
}

rule("#2 CAR_02_NAME_HERE (Mesh Array Tables)")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		"FOR INDEXES REFER TO: MENU \\ ARRAY TABLE - INTERNAL STORAGE VARIABLE \n [1] - CURRENT CAR \n Rule Elements Count: 0"
		Global.VAR_GBL_INTRNL_STORED_VALUES[1] == 1;
		Entity Exists(Global.VAR_PLAYER_RACER) == True;
	}

	actions
	{
		"VERTICES COUNT: 0 \n EDGE COUNT: 0 \n Car models ported with Deltin's OSTW for Visual Studio Code"
		Global.VAR_VEH_MESH_VRTCS_FRONT_BUMPER = Empty Array;
		Global.VAR_VEH_MESH_VRTCS_FRONT_HOOD = Empty Array;
		Global.VAR_VEH_MESH_VRTCS_BODY = Empty Array;
		Global.VAR_VEH_MESH_VRTCS_ENGINE_HOOD = Empty Array;
		Global.VAR_VEH_MESH_VRTCS_REAR_BUMPER = Empty Array;
		Global.VAR_VEH_MESH_VRTCS_HEADLIGHTS = Empty Array;
		Global.VAR_VEH_MESH_VRTCS_L_R_LIGHTS = Empty Array;
		Global.VAR_VEH_MESH_VRTCS_R_R_LIGHTS = Empty Array;
		Global.VAR_VEH_MESH_VRTCS_NITROUS = Empty Array;
		Global.VAR_VEH_MESH_VRTCS_CARBON_PARTS = Empty Array;
		Global.VAR_VEH_MESH_EDGES_FRONT_BUMPER = Empty Array;
		Global.VAR_VEH_MESH_EDGES_FRONT_HOOD = Empty Array;
		Global.VAR_VEH_MESH_EDGES_BODY = Empty Array;
		Global.VAR_VEH_MESH_EDGES_ENGINE_HOOD = Empty Array;
		Global.VAR_VEH_MESH_EDGES_REAR_BUMPER = Empty Array;
		Global.VAR_VEH_MESH_EDGES_HEADLIGHTS = Empty Array;
		Global.VAR_VEH_MESH_EDGES_L_R_LIGHTS = Empty Array;
		Global.VAR_VEH_MESH_EDGES_R_R_LIGHTS = Empty Array;
		Global.VAR_VEH_MESH_EDGES_NITROUS = Empty Array;
		Global.VAR_VEH_MESH_EDGES_CARBON_PARTS = Empty Array;
		"PASTE YOUR CAR HERE - Original Gamemode Creator: GraczCourier (now known as RaidVentador_Courier_13)"
		Global.VAR_PLAYER_RACER.VAR_VEH_COLOR_DEFAULT = Color(Blue);
		Call Subroutine(SUB_VEH_VSL_GET_COLORS);
	}
}

rule("#3 CAR_03_NAME_HERE (Mesh Array Tables)")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		"FOR INDEXES REFER TO: MENU \\ ARRAY TABLE - INTERNAL STORAGE VARIABLE \n [1] - CURRENT CAR \n Rule Elements Count: 0"
		Global.VAR_GBL_INTRNL_STORED_VALUES[1] == 2;
		Entity Exists(Global.VAR_PLAYER_RACER) == True;
	}

	actions
	{
		"VERTICES COUNT: 0 \n EDGE COUNT: 0 \n Car models ported with Deltin's OSTW for Visual Studio Code"
		Global.VAR_VEH_MESH_VRTCS_FRONT_BUMPER = Empty Array;
		Global.VAR_VEH_MESH_VRTCS_FRONT_HOOD = Empty Array;
		Global.VAR_VEH_MESH_VRTCS_BODY = Empty Array;
		Global.VAR_VEH_MESH_VRTCS_ENGINE_HOOD = Empty Array;
		Global.VAR_VEH_MESH_VRTCS_REAR_BUMPER = Empty Array;
		Global.VAR_VEH_MESH_VRTCS_HEADLIGHTS = Empty Array;
		Global.VAR_VEH_MESH_VRTCS_L_R_LIGHTS = Empty Array;
		Global.VAR_VEH_MESH_VRTCS_R_R_LIGHTS = Empty Array;
		Global.VAR_VEH_MESH_VRTCS_NITROUS = Empty Array;
		Global.VAR_VEH_MESH_VRTCS_CARBON_PARTS = Empty Array;
		Global.VAR_VEH_MESH_EDGES_FRONT_BUMPER = Empty Array;
		Global.VAR_VEH_MESH_EDGES_FRONT_HOOD = Empty Array;
		Global.VAR_VEH_MESH_EDGES_BODY = Empty Array;
		Global.VAR_VEH_MESH_EDGES_ENGINE_HOOD = Empty Array;
		Global.VAR_VEH_MESH_EDGES_REAR_BUMPER = Empty Array;
		Global.VAR_VEH_MESH_EDGES_HEADLIGHTS = Empty Array;
		Global.VAR_VEH_MESH_EDGES_L_R_LIGHTS = Empty Array;
		Global.VAR_VEH_MESH_EDGES_R_R_LIGHTS = Empty Array;
		Global.VAR_VEH_MESH_EDGES_NITROUS = Empty Array;
		Global.VAR_VEH_MESH_EDGES_CARBON_PARTS = Empty Array;
		"PASTE YOUR CAR HERE - Original Gamemode Creator: GraczCourier (now known as RaidVentador_Courier_13)"
		Global.VAR_PLAYER_RACER.VAR_VEH_COLOR_DEFAULT = Color(Blue);
		Call Subroutine(SUB_VEH_VSL_GET_COLORS);
	}
}

rule("#4 CAR_04_NAME_HERE (Mesh Array Tables)")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		"FOR INDEXES REFER TO: MENU \\ ARRAY TABLE - INTERNAL STORAGE VARIABLE \n [1] - CURRENT CAR \n Rule Elements Count: 0"
		Global.VAR_GBL_INTRNL_STORED_VALUES[1] == 3;
		Entity Exists(Global.VAR_PLAYER_RACER) == True;
	}

	actions
	{
		"VERTICES COUNT: 0 \n EDGE COUNT: 0 \n Car models ported with Deltin's OSTW for Visual Studio Code"
		Global.VAR_VEH_MESH_VRTCS_FRONT_BUMPER = Empty Array;
		Global.VAR_VEH_MESH_VRTCS_FRONT_HOOD = Empty Array;
		Global.VAR_VEH_MESH_VRTCS_BODY = Empty Array;
		Global.VAR_VEH_MESH_VRTCS_ENGINE_HOOD = Empty Array;
		Global.VAR_VEH_MESH_VRTCS_REAR_BUMPER = Empty Array;
		Global.VAR_VEH_MESH_VRTCS_HEADLIGHTS = Empty Array;
		Global.VAR_VEH_MESH_VRTCS_L_R_LIGHTS = Empty Array;
		Global.VAR_VEH_MESH_VRTCS_R_R_LIGHTS = Empty Array;
		Global.VAR_VEH_MESH_VRTCS_NITROUS = Empty Array;
		Global.VAR_VEH_MESH_VRTCS_CARBON_PARTS = Empty Array;
		Global.VAR_VEH_MESH_EDGES_FRONT_BUMPER = Empty Array;
		Global.VAR_VEH_MESH_EDGES_FRONT_HOOD = Empty Array;
		Global.VAR_VEH_MESH_EDGES_BODY = Empty Array;
		Global.VAR_VEH_MESH_EDGES_ENGINE_HOOD = Empty Array;
		Global.VAR_VEH_MESH_EDGES_REAR_BUMPER = Empty Array;
		Global.VAR_VEH_MESH_EDGES_HEADLIGHTS = Empty Array;
		Global.VAR_VEH_MESH_EDGES_L_R_LIGHTS = Empty Array;
		Global.VAR_VEH_MESH_EDGES_R_R_LIGHTS = Empty Array;
		Global.VAR_VEH_MESH_EDGES_NITROUS = Empty Array;
		Global.VAR_VEH_MESH_EDGES_CARBON_PARTS = Empty Array;
		"PASTE YOUR CAR HERE - Original Gamemode Creator: GraczCourier (now known as RaidVentador_Courier_13)"
		Global.VAR_PLAYER_RACER.VAR_VEH_COLOR_DEFAULT = Color(Blue);
		Call Subroutine(SUB_VEH_VSL_GET_COLORS);
	}
}

rule("#5 CAR_05_NAME_HERE (Mesh Array Tables)")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		"FOR INDEXES REFER TO: MENU \\ ARRAY TABLE - INTERNAL STORAGE VARIABLE \n [1] - CURRENT CAR \n Rule Elements Count: 0"
		Global.VAR_GBL_INTRNL_STORED_VALUES[1] == 4;
		Entity Exists(Global.VAR_PLAYER_RACER) == True;
	}

	actions
	{
		"VERTICES COUNT: 0 \n EDGE COUNT: 0 \n Car models ported with Deltin's OSTW for Visual Studio Code"
		Global.VAR_VEH_MESH_VRTCS_FRONT_BUMPER = Empty Array;
		Global.VAR_VEH_MESH_VRTCS_FRONT_HOOD = Empty Array;
		Global.VAR_VEH_MESH_VRTCS_BODY = Empty Array;
		Global.VAR_VEH_MESH_VRTCS_ENGINE_HOOD = Empty Array;
		Global.VAR_VEH_MESH_VRTCS_REAR_BUMPER = Empty Array;
		Global.VAR_VEH_MESH_VRTCS_HEADLIGHTS = Empty Array;
		Global.VAR_VEH_MESH_VRTCS_L_R_LIGHTS = Empty Array;
		Global.VAR_VEH_MESH_VRTCS_R_R_LIGHTS = Empty Array;
		Global.VAR_VEH_MESH_VRTCS_NITROUS = Empty Array;
		Global.VAR_VEH_MESH_VRTCS_CARBON_PARTS = Empty Array;
		Global.VAR_VEH_MESH_EDGES_FRONT_BUMPER = Empty Array;
		Global.VAR_VEH_MESH_EDGES_FRONT_HOOD = Empty Array;
		Global.VAR_VEH_MESH_EDGES_BODY = Empty Array;
		Global.VAR_VEH_MESH_EDGES_ENGINE_HOOD = Empty Array;
		Global.VAR_VEH_MESH_EDGES_REAR_BUMPER = Empty Array;
		Global.VAR_VEH_MESH_EDGES_HEADLIGHTS = Empty Array;
		Global.VAR_VEH_MESH_EDGES_L_R_LIGHTS = Empty Array;
		Global.VAR_VEH_MESH_EDGES_R_R_LIGHTS = Empty Array;
		Global.VAR_VEH_MESH_EDGES_NITROUS = Empty Array;
		Global.VAR_VEH_MESH_EDGES_CARBON_PARTS = Empty Array;
		"PASTE YOUR CAR HERE - Original Gamemode Creator: GraczCourier (now known as RaidVentador_Courier_13)"
		Global.VAR_PLAYER_RACER.VAR_VEH_COLOR_DEFAULT = Color(Blue);
		Call Subroutine(SUB_VEH_VSL_GET_COLORS);
	}
}

rule("#6 CAR_06_NAME_HERE (Mesh Array Tables)")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		"FOR INDEXES REFER TO: MENU \\ ARRAY TABLE - INTERNAL STORAGE VARIABLE \n [1] - CURRENT CAR \n Rule Elements Count: 0"
		Global.VAR_GBL_INTRNL_STORED_VALUES[1] == 5;
		Entity Exists(Global.VAR_PLAYER_RACER) == True;
	}

	actions
	{
		"VERTICES COUNT: 0 \n EDGE COUNT: 0 \n Car models ported with Deltin's OSTW for Visual Studio Code"
		Global.VAR_VEH_MESH_VRTCS_FRONT_BUMPER = Empty Array;
		Global.VAR_VEH_MESH_VRTCS_FRONT_HOOD = Empty Array;
		Global.VAR_VEH_MESH_VRTCS_BODY = Empty Array;
		Global.VAR_VEH_MESH_VRTCS_ENGINE_HOOD = Empty Array;
		Global.VAR_VEH_MESH_VRTCS_REAR_BUMPER = Empty Array;
		Global.VAR_VEH_MESH_VRTCS_HEADLIGHTS = Empty Array;
		Global.VAR_VEH_MESH_VRTCS_L_R_LIGHTS = Empty Array;
		Global.VAR_VEH_MESH_VRTCS_R_R_LIGHTS = Empty Array;
		Global.VAR_VEH_MESH_VRTCS_NITROUS = Empty Array;
		Global.VAR_VEH_MESH_VRTCS_CARBON_PARTS = Empty Array;
		Global.VAR_VEH_MESH_EDGES_FRONT_BUMPER = Empty Array;
		Global.VAR_VEH_MESH_EDGES_FRONT_HOOD = Empty Array;
		Global.VAR_VEH_MESH_EDGES_BODY = Empty Array;
		Global.VAR_VEH_MESH_EDGES_ENGINE_HOOD = Empty Array;
		Global.VAR_VEH_MESH_EDGES_REAR_BUMPER = Empty Array;
		Global.VAR_VEH_MESH_EDGES_HEADLIGHTS = Empty Array;
		Global.VAR_VEH_MESH_EDGES_L_R_LIGHTS = Empty Array;
		Global.VAR_VEH_MESH_EDGES_R_R_LIGHTS = Empty Array;
		Global.VAR_VEH_MESH_EDGES_NITROUS = Empty Array;
		Global.VAR_VEH_MESH_EDGES_CARBON_PARTS = Empty Array;
		"PASTE YOUR CAR HERE - Original Gamemode Creator: GraczCourier (now known as RaidVentador_Courier_13)"
		Global.VAR_PLAYER_RACER.VAR_VEH_COLOR_DEFAULT = Color(Blue);
		Call Subroutine(SUB_VEH_VSL_GET_COLORS);
	}
}

rule("#7 CAR_07_NAME_HERE (Mesh Array Tables)")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		"FOR INDEXES REFER TO: MENU \\ ARRAY TABLE - INTERNAL STORAGE VARIABLE \n [1] - CURRENT CAR \n Rule Elements Count: 0"
		Global.VAR_GBL_INTRNL_STORED_VALUES[1] == 6;
		Entity Exists(Global.VAR_PLAYER_RACER) == True;
	}

	actions
	{
		"VERTICES COUNT: 0 \n EDGE COUNT: 0 \n Car models ported with Deltin's OSTW for Visual Studio Code"
		Global.VAR_VEH_MESH_VRTCS_FRONT_BUMPER = Empty Array;
		Global.VAR_VEH_MESH_VRTCS_FRONT_HOOD = Empty Array;
		Global.VAR_VEH_MESH_VRTCS_BODY = Empty Array;
		Global.VAR_VEH_MESH_VRTCS_ENGINE_HOOD = Empty Array;
		Global.VAR_VEH_MESH_VRTCS_REAR_BUMPER = Empty Array;
		Global.VAR_VEH_MESH_VRTCS_HEADLIGHTS = Empty Array;
		Global.VAR_VEH_MESH_VRTCS_L_R_LIGHTS = Empty Array;
		Global.VAR_VEH_MESH_VRTCS_R_R_LIGHTS = Empty Array;
		Global.VAR_VEH_MESH_VRTCS_NITROUS = Empty Array;
		Global.VAR_VEH_MESH_VRTCS_CARBON_PARTS = Empty Array;
		Global.VAR_VEH_MESH_EDGES_FRONT_BUMPER = Empty Array;
		Global.VAR_VEH_MESH_EDGES_FRONT_HOOD = Empty Array;
		Global.VAR_VEH_MESH_EDGES_BODY = Empty Array;
		Global.VAR_VEH_MESH_EDGES_ENGINE_HOOD = Empty Array;
		Global.VAR_VEH_MESH_EDGES_REAR_BUMPER = Empty Array;
		Global.VAR_VEH_MESH_EDGES_HEADLIGHTS = Empty Array;
		Global.VAR_VEH_MESH_EDGES_L_R_LIGHTS = Empty Array;
		Global.VAR_VEH_MESH_EDGES_R_R_LIGHTS = Empty Array;
		Global.VAR_VEH_MESH_EDGES_NITROUS = Empty Array;
		Global.VAR_VEH_MESH_EDGES_CARBON_PARTS = Empty Array;
		"PASTE YOUR CAR HERE - Original Gamemode Creator: GraczCourier (now known as RaidVentador_Courier_13)"
		Global.VAR_PLAYER_RACER.VAR_VEH_COLOR_DEFAULT = Color(Blue);
		Call Subroutine(SUB_VEH_VSL_GET_COLORS);
	}
}

rule("#8 CAR_08_NAME_HERE (Mesh Array Tables)")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		"FOR INDEXES REFER TO: MENU \\ ARRAY TABLE - INTERNAL STORAGE VARIABLE \n [1] - CURRENT CAR \n Rule Elements Count: 0"
		Global.VAR_GBL_INTRNL_STORED_VALUES[1] == 7;
		Entity Exists(Global.VAR_PLAYER_RACER) == True;
	}

	actions
	{
		"VERTICES COUNT: 0 \n EDGE COUNT: 0 \n Car models ported with Deltin's OSTW for Visual Studio Code"
		Global.VAR_VEH_MESH_VRTCS_FRONT_BUMPER = Empty Array;
		Global.VAR_VEH_MESH_VRTCS_FRONT_HOOD = Empty Array;
		Global.VAR_VEH_MESH_VRTCS_BODY = Empty Array;
		Global.VAR_VEH_MESH_VRTCS_ENGINE_HOOD = Empty Array;
		Global.VAR_VEH_MESH_VRTCS_REAR_BUMPER = Empty Array;
		Global.VAR_VEH_MESH_VRTCS_HEADLIGHTS = Empty Array;
		Global.VAR_VEH_MESH_VRTCS_L_R_LIGHTS = Empty Array;
		Global.VAR_VEH_MESH_VRTCS_R_R_LIGHTS = Empty Array;
		Global.VAR_VEH_MESH_VRTCS_NITROUS = Empty Array;
		Global.VAR_VEH_MESH_VRTCS_CARBON_PARTS = Empty Array;
		Global.VAR_VEH_MESH_EDGES_FRONT_BUMPER = Empty Array;
		Global.VAR_VEH_MESH_EDGES_FRONT_HOOD = Empty Array;
		Global.VAR_VEH_MESH_EDGES_BODY = Empty Array;
		Global.VAR_VEH_MESH_EDGES_ENGINE_HOOD = Empty Array;
		Global.VAR_VEH_MESH_EDGES_REAR_BUMPER = Empty Array;
		Global.VAR_VEH_MESH_EDGES_HEADLIGHTS = Empty Array;
		Global.VAR_VEH_MESH_EDGES_L_R_LIGHTS = Empty Array;
		Global.VAR_VEH_MESH_EDGES_R_R_LIGHTS = Empty Array;
		Global.VAR_VEH_MESH_EDGES_NITROUS = Empty Array;
		Global.VAR_VEH_MESH_EDGES_CARBON_PARTS = Empty Array;
		"PASTE YOUR CAR HERE - Original Gamemode Creator: GraczCourier (now known as RaidVentador_Courier_13)"
		Global.VAR_PLAYER_RACER.VAR_VEH_COLOR_DEFAULT = Color(Blue);
		Call Subroutine(SUB_VEH_VSL_GET_COLORS);
	}
}

disabled rule("")
{
	event
	{
		Ongoing - Global;
	}
}

rule("Project: Streetwatch - Original Build by GraczCourier (now known as RaidVentador_Courier_13)")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		"CARBONATED BEVERAGE WITH COLA FLAVOUR.\nContains cement. Contains traces of debris."
		Entity Exists(Event Player) == True;
		"THE OMEN CAN ONLY WATCH \n Now! The Raven's on that wall... It won't fly away. It's an Omen! It's just flies on... automation."
		Is Dummy Bot(Event Player) == False;
	}

	actions
	{
		Global.VAR_GLB_PLAYER_IS_IN_MAIN_MENU = True;
		"List of Contributors:\nDeltin - OSTW Plugin for Visual Studio Code\nLotto - Playtesting and Patches\nMe (RaidVentador_Courier_13) - Main work on the Script"
		Global.COCONUT = Custom String("GRACZCOURIER");
		"Bruh, this script doesn't have any security systems. Feel free to credit yourself in Coconut and Alpine Chocolate Wit Cement.\nUse the \"Replace All\" feature in the editor to save yourself a time.\nI was too lazy to add the in-game watermark. >;)"
		Global.ALPINE_CHOCOLATE_WIT_CEMENT = Custom String("GRACZC0URIER");
		Global.VAR_PLAYER_RACER = Event Player;
		Event Player.VAR_PLAYER_IS_RACER = True;
		Disable Built-In Game Mode Announcer;
		Disable Built-In Game Mode Completion;
		Set Match Time(0.100);
		Wait(0.250, Ignore Condition);
		Set Match Time(0.100);
		"FOR INDEXES REFER TO: MENU \\ ARRAY TABLE - INTERNAL STORAGE VARIABLE \n [0] - CURRENT MENU OPTION"
		Global.VAR_MENU_VAL_CURR_OPTION = First Of(Global.VAR_GBL_INTRNL_STORED_VALUES);
		Call Subroutine(SUB_MENU_ENTER);
		Global.VAR_MENU_VAL_CURR_MENU = Custom String("MAIN_MENU");
	}
}

rule("INITIAL MECHANICS: GET PLAYER AND THEIR VEHICLE'S INFO")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		"THIS \"GAME\"MODE APPEARED ON OVERWATCH'S OFFICIAL TWITTER ACCOUNT"
		Entity Exists(Event Player) == True;
		"https://twitter.com/PlayOverwatch/status/1363261836515106817"
		Global.VAR_PLAYER_RACER.VAR_PLAYER_IS_RACER == True;
	}

	actions
	{
		Set Respawn Max Time(Event Player, 9999);
		Disable Hero HUD(Event Player);
		Disable Game Mode HUD(Event Player);
		Disable Game Mode In-World UI(Event Player);
		Create Dummy Bot(Hero(Wrecking Ball), Team Of(Event Player), 1, Global.VAR_GLB_VEH_REG_START_POS,
			Global.VAR_GLB_VEH_REG_START_FACE);
		Global.VAR_DRIVEABLE_VEHICLE = Players In Slot(1, Team Of(Event Player));
		Event Player.VAR_RACER_VEHICLE = Players In Slot(1, Team Of(Event Player));
		Set Invisible(Event Player.VAR_RACER_VEHICLE, All);
		Set Respawn Max Time(Event Player.VAR_RACER_VEHICLE, 9999);
		Start Forcing Dummy Bot Name(Event Player.VAR_RACER_VEHICLE, Custom String("{0}'s Vehicle", Event Player));
	}
}

rule("INITIAL MECHANICS: PLAYER SPAWNED")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Has Spawned(Global.VAR_PLAYER_RACER) == True;
		Global.VAR_MENU_VAL_CURR_MENU == Custom String("MAIN_MENU");
	}

	actions
	{
		Start Camera(Event Player, Vector(0, 100, 0), Vector(0.100, 150, 10), 0);
		Call Subroutine(SUB_VEH_DISABLE_INPUT);
		Set Move Speed(Event Player, 0);
		Set Status(Event Player, Null, Invincible, 9999);
	}
}

rule("INITIAL MECHANICS: GLOBAL ARRAY VALUE LIST")
{
	event
	{
		Ongoing - Global;
	}

	actions
	{
		"REFER TO: VARIABLE_STRING_TABLES.TXT / ARRAY TABLE - INTERNAL STORAGE VARIABLE"
		Global.VAR_GBL_INTRNL_STORED_VALUES = Array(1, Workshop Setting Combo(Custom String("A - START UP SETTINGS"), Custom String(
			"SELECT CAR BODY"), 0, Array(Custom String("CAR_01_NAME_HERE"), Custom String("CAR_02_NAME_HERE"), Custom String(
			"CAR_03_NAME_HERE"), Custom String("CAR_04_NAME_HERE"), Custom String("CAR_05_NAME_HERE"), Custom String("CAR_06_NAME_HERE"),
			Custom String("CAR_07_NAME_HERE"), Custom String("CAR_08_NAME_HERE")), 0), 1, False, 2, 50, 2, Workshop Setting Combo(
			Custom String("A - START UP SETTINGS (GAME MODES)"), Custom String("SELECT GAME MODE"), 0, Array(Custom String("FREE DRIVE")),
			0), Workshop Setting Integer(Custom String("A - START UP SETTINGS (GAME MODES)"), Custom String("NUMBER OF LAPS"), 3, 1, 30,
			1), Workshop Setting Toggle(Custom String("A - START UP SETTINGS (GAME MODES)"), Custom String("REVERSE VARIANT"), False, 2),
			Workshop Setting Combo(Custom String("A - START UP SETTINGS (GAME MODES)"), Custom String("SCORE CONDITION"), 0, Array(
			Custom String("OFF"), Custom String("ON")), 3), Workshop Setting Integer(Custom String("A - START UP SETTINGS (GAME MODES)"),
			Custom String("SCORE THRESHOLD"), 100000, 1000, 1000000, 4), Workshop Setting Integer(Custom String(
			"A - START UP SETTINGS (GAME MODES)"), Custom String("CHECKPOINT RADIUS"), 5, 1, 10, 5), Workshop Setting Integer(
			Custom String("A - START UP SETTINGS (GAME MODES)"), Custom String("DYNAMITE TRIAL - START WITH REMAINING TIME"), 10, 10, 120,
			6), Workshop Setting Integer(Custom String("A - START UP SETTINGS (GAME MODES)"), Custom String(
			"DYNAMITE TRIAL - TIME EARNED VIA CHECKPOINT"), 5, 0, 20, 7));
		Global.VAR_MENU_ARRAY_COLOR_CURR_LIST = Array(Null, Null, Null, Null, Null, Null, Null, Null, Null, Null);
		Global.VAR_MENU_ARRAY_RADIO_COLOR_LIST = Array(Null, Color(Gray), Color(Orange), Color(Rose), Color(Lime Green), Color(Red),
			Custom Color(70, 200, 113, 255), Color(Green));
	}
}

disabled rule("")
{
	event
	{
		Ongoing - Global;
	}
}

rule("INITIAL MECHANICS: GET MAP INFO")
{
	event
	{
		Ongoing - Global;
	}

	actions
	{
		If(Global.VAR_GLB_RACE_HAS_REV_VARIANT != True);
			"[9] - IS REVERSED?:"
			Global.VAR_GBL_INTRNL_STORED_VALUES[9] = False;
		End;
		If(Global.VAR_GLB_RACE_HAS_TRACK != True);
			"[7] - CURRENT MODE:"
			Global.VAR_GBL_INTRNL_STORED_VALUES[7] = 0;
		End;
	}
}

rule("INITIAL MECHANICS: GET SPAWN POSITIONS AND FACING TABLES")
{
	event
	{
		Ongoing - Global;
	}

	actions
	{
		If(Array Contains(Array(Game Mode(Deathmatch), Game Mode(Team Deathmatch), Game Mode(Bounty Hunter)), Current Game Mode) == True);
			Global.VAR_GLB_VEH_REG_START_POS = Spawn Points(All Teams);
			Global.VAR_GLB_VEH_REG_START_FACE = Spawn Points(All Teams);
		Else;
			Global.VAR_GLB_VEH_REG_START_POS = First Of(Spawn Points(Team Of(Global.VAR_PLAYER_RACER)));
			Global.VAR_GLB_VEH_REG_START_FACE = First Of(Spawn Points(Team Of(Global.VAR_PLAYER_RACER)));
		End;
	}
}

disabled rule("INITIAL MECHANICS: GET CHECKPOINT TABLES")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		Entity Exists(Global.VAR_PLAYER_RACER) == True;
		"FOR INDEXES REFER TO: MENU \\ ARRAY TABLE - INTERNAL STORAGE VARIABLE \n [7] - CURRENT MODE:"
		Global.VAR_GBL_INTRNL_STORED_VALUES[7] > 0;
	}

	actions
	{
		If(Current Map == Null);
			"CHECKPOINT POSITIONS FOR: <MAP_NAME>"
			Global.VAR_GLB_ARRAY_CHECKPOINT_TABLE = Array(Null);
		Else If(Current Map == Null);
			"CHECKPOINT POSITIONS FOR: <MAP_NAME>"
			Global.VAR_GLB_ARRAY_CHECKPOINT_TABLE = Array(Null);
	}
}

disabled rule("")
{
	event
	{
		Ongoing - Global;
	}
}

rule("INITIAL MECHANICS: CLEAR OUT HERO ASSEMBLY PHASE A")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		Is Assembling Heroes == True;
	}

	actions
	{
		Set Match Time(0.100);
	}
}

rule("INITIAL MECHANICS: CLEAR OUT HERO ASSEMBLY PHASE B")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		Is Assembling Heroes == True;
		Has Spawned(Global.VAR_PLAYER_RACER) == True;
	}

	actions
	{
		Set Match Time(0.100);
	}
}

rule("INITIAL MECHANICS: CLEAR OUT HERO ASSEMBLY PHASE C")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		Is Game In Progress == True;
		Has Spawned(Global.VAR_PLAYER_RACER) == True;
	}

	actions
	{
		disabled Set Match Time(0.100);
		Set Match Time(600);
	}
}

rule("INITIAL MECHANICS SUBROUTINE: DISABLE INPUT")
{
	event
	{
		Subroutine;
		SUB_VEH_DISABLE_INPUT;
	}

	actions
	{
		Disallow Button(Global.VAR_PLAYER_RACER, Button(Primary Fire));
		Disallow Button(Global.VAR_PLAYER_RACER, Button(Secondary Fire));
		Disallow Button(Global.VAR_PLAYER_RACER, Button(Ability 1));
		Disallow Button(Global.VAR_PLAYER_RACER, Button(Ability 2));
		Disallow Button(Global.VAR_PLAYER_RACER, Button(Melee));
		Disallow Button(Global.VAR_PLAYER_RACER, Button(Ultimate));
	}
}

disabled rule("MAIN MENU TAB")
{
	event
	{
		Ongoing - Global;
	}
}

rule("MAIN MENU: LOADING VISUAL LOOP")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		Global.VAR_GLB_PLAYER_IS_IN_MAIN_MENU == False;
		Global.VAR_GLB_VEHICLE_DEPLOY_STATUS == Custom String("DEPLOY_CAR");
	}

	actions
	{
		Global.VAR_MENU_LOADING_VALUE += 1;
		If(Global.VAR_MENU_LOADING_VALUE == 4);
			Global.VAR_MENU_LOADING_VALUE = 0;
		End;
		Global.VAR_MENU_WAITING_FOR_CAR_STRING = Custom String("{0} {1}", First Of(Global.VAR_MENU_ARRAY_STRING_DEPLOY),
			Global.VAR_MENU_LOADING_ARRAY_STRING[Global.VAR_MENU_LOADING_VALUE]);
		Wait(0.125, Abort When False);
		Loop If Condition Is True;
	}
}

rule("MAIN MENU: CREATE MENU NAVIGATION HELP HUD")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		Entity Exists(Global.VAR_PLAYER_RACER) == True;
	}

	actions
	{
		Create HUD Text(Global.VAR_PLAYER_RACER, Null, Null, Custom String("MOVE UP/DOWN (TAP) - NAVIGATE"), Left, 0, Color(White), Color(
			White), Color(White), Visible To and String, Default Visibility);
		Create HUD Text(Global.VAR_PLAYER_RACER, Null, Null, Custom String("MOVE LEFT/ RIGHT (TAP) - CHANGE SETTING"), Left, 1, Color(
			White), Color(White), Color(White), Visible To and String, Default Visibility);
		Create HUD Text(Global.VAR_PLAYER_RACER, Null, Null, Custom String("{0} (TAP) - ENTER", Input Binding String(Button(Interact))),
			Left, 2, Color(White), Color(White), Color(White), Visible To and String, Default Visibility);
		Create HUD Text(Global.VAR_PLAYER_RACER, Null, Null, Custom String("{0} (TAP) - EXIT/PREVIOUS MENU", Input Binding String(Button(
			Ultimate))), Left, 3, Color(White), Color(White), Color(White), Visible To and String, Default Visibility);
	}
}

rule("MAIN MENU: GET ARRAYS")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		Global.VAR_MENU_VAL_CURR_MENU == Custom String("MAIN_MENU");
	}

	actions
	{
		"GET VERTICAL VECTOR LIST FOR - BUTTONS (MAIN MENU)"
		Global.VAR_MENU_ARRAY_BTN_Z_VECTOR = Array(-8, -5.500, -3, 6, 9, 12, 17, 20.500, 24.500);
		"GET VERTICAL VECTOR LIST FOR - SUB-BUTTONS (MAIN MENU)"
		Global.VAR_MENU_ARRAY_SUBBTN_Z_VECTOR = Array(14);
		"SET VERTICAL NAVIGATION CLAMP (MAIN MENU)"
		Global.VAR_MENU_ARRAY_CURR_NAV_LIMITS = Array(-1, 6);
		"ARRAY TABLE - VALUE TYPE LIST (MAIN MENU)"
		Global.VAR_MENU_ARRAY_CURR_OPTION_TYPE = Array(Custom String("BUTTON"), Custom String("BUTTON"), Custom String("VEHICLE_FLOAT"),
			Custom String("BUTTON"), Custom String("BUTTON"), Custom String("BUTTON"));
		"ARRAY TABLE -  MIN CLAMP VALUES (MAIN MENU)"
		Global.VAR_MENU_ARRAY_CURR_MIN_CLAMP = Array(Null, Null, Index Of Array Value(Global.VAR_MENU_ARRAY_STRING_CAR, First Of(
			Global.VAR_MENU_ARRAY_STRING_CAR)), Null, Null, Null);
		"ARRAY TABLE - MAX CLAMP VALUES (MAIN MENU)"
		Global.VAR_MENU_ARRAY_CURR_MAX_CLAMP = Array(Null, Null, Index Of Array Value(Global.VAR_MENU_ARRAY_STRING_CAR, Last Of(
			Global.VAR_MENU_ARRAY_STRING_CAR)), Null, Null, Null);
		"GET VALUES FROM INTERAL ARRAY - REFER TO \"GLOBAL ARRAY LIST\" RULE (MAIN MENU)"
		Global.VAR_GBL_CURR_STORED_VALUES = Array(Null, Null, Global.VAR_GBL_INTRNL_STORED_VALUES[1], Null, Null, Null);
		Global.VAR_MENU_VAL_CURR_OPTION = First Of(Global.VAR_GBL_INTRNL_STORED_VALUES);
		Call Subroutine(SUB_MENU_ENTER);
		Global.VAR_MENU_VSL_ARROWS_VAL_ADJUST = 3;
	}
}

rule("MAIN MENU: CREATE BUTTON STRINGS")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		Global.VAR_MENU_VAL_CURR_MENU == Custom String("MAIN_MENU");
	}

	actions
	{
		"TITLE"
		Create In-World Text(All Players(All Teams), First Of(Global.VAR_MENU_ARRAY_STRING_MAIN), Vector(0, 150, First Of(
			Global.VAR_MENU_ARRAY_BTN_Z_VECTOR)), 4, Clip Against Surfaces, Visible To Position String and Color, Color(White),
			Default Visibility);
		"AUTHORS"
		Create In-World Text(All Players(All Teams), Global.VAR_MENU_ARRAY_STRING_MAIN[1], Vector(0, 150,
			Global.VAR_MENU_ARRAY_BTN_Z_VECTOR[1]), 1.500, Clip Against Surfaces, Visible To Position and String, Color(White),
			Default Visibility);
		"CURRENT CAR PACK"
		Create In-World Text(All Players(All Teams), Global.VAR_MENU_ARRAY_STRING_MAIN[2], Vector(0, 150,
			Global.VAR_MENU_ARRAY_BTN_Z_VECTOR[2]), 2, Clip Against Surfaces, Visible To Position and String, Color(White),
			Default Visibility);
		"VEHICLE CONTROLS (BUTTON)"
		Create In-World Text(All Players(All Teams), Global.VAR_MENU_ARRAY_STRING_MAIN[3], Vector(0, 150,
			Global.VAR_MENU_ARRAY_BTN_Z_VECTOR[3]), 2, Clip Against Surfaces, Visible To Position String and Color, First Of(
			Global.VAR_MENU_ARRAY_COLOR_CURR_LIST), Default Visibility);
		"PLAY (BUTTON)"
		Create In-World Text(All Players(All Teams), Global.VAR_MENU_ARRAY_STRING_MAIN[4], Vector(0, 150,
			Global.VAR_MENU_ARRAY_BTN_Z_VECTOR[4]), 2, Clip Against Surfaces, Visible To Position String and Color,
			Global.VAR_MENU_ARRAY_COLOR_CURR_LIST[1], Default Visibility);
		"CAR SELECTION (BUTTON)"
		Create In-World Text(All Players(All Teams), Global.VAR_MENU_ARRAY_STRING_MAIN[5], Vector(0, 150,
			Global.VAR_MENU_ARRAY_BTN_Z_VECTOR[5]), 2, Clip Against Surfaces, Visible To Position String and Color,
			Global.VAR_MENU_ARRAY_COLOR_CURR_LIST[2], Default Visibility);
		"TUNE CAR (BUTTON)"
		Create In-World Text(All Players(All Teams), Global.VAR_MENU_ARRAY_STRING_MAIN[6], Vector(0, 150,
			Global.VAR_MENU_ARRAY_BTN_Z_VECTOR[6]), 2, Clip Against Surfaces, Visible To Position String and Color,
			Global.VAR_MENU_ARRAY_COLOR_CURR_LIST[3], Default Visibility);
		"MODE SETTINGS (BUTTON)"
		Create In-World Text(All Players(All Teams), Global.VAR_MENU_ARRAY_STRING_MAIN[7], Vector(0, 150,
			Global.VAR_MENU_ARRAY_BTN_Z_VECTOR[7]), 2, Clip Against Surfaces, Visible To Position String and Color,
			Global.VAR_MENU_ARRAY_COLOR_CURR_LIST[4], Default Visibility);
		"EXIT TO LOBBY (BUTTON)"
		Create In-World Text(All Players(All Teams), Global.VAR_MENU_ARRAY_STRING_MAIN[8], Vector(0, 150,
			Global.VAR_MENU_ARRAY_BTN_Z_VECTOR[8]), 2, Clip Against Surfaces, Visible To Position String and Color,
			Global.VAR_MENU_ARRAY_COLOR_CURR_LIST[5], Default Visibility);
	}
}

rule("MAIN MENU: CREATE SUB-BUTTON STRINGS")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		Global.VAR_MENU_VAL_CURR_MENU == Custom String("MAIN_MENU");
	}

	actions
	{
		"CAR SELECTION (SUB-BUTTON)"
		Create In-World Text(All Players(All Teams), Global.VAR_MENU_ARRAY_STRING_CAR[Global.VAR_GBL_CURR_STORED_VALUES[2]], Vector(0, 150,
			First Of(Global.VAR_MENU_ARRAY_SUBBTN_Z_VECTOR)), 1.500, Clip Against Surfaces, Visible To Position String and Color,
			Global.VAR_MENU_ARRAY_COLOR_CURR_LIST[2], Default Visibility);
	}
}

rule("MAIN MENU BUTTON: ENTER VEHICLE CONTROLS")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		Global.VAR_MENU_VAL_CURR_MENU == Custom String("MAIN_MENU");
		Global.VAR_MENU_MENU_STRING_NAV == Custom String("MENU_NAV_ENTER");
		Global.VAR_MENU_VAL_CURR_OPTION == 0;
	}

	actions
	{
		Call Subroutine(SUB_GPL_STORE_GAME_VALUES);
		Global.VAR_GBL_INTRNL_STORED_VALUES[0] = Global.VAR_MENU_VAL_CURR_OPTION;
		Global.VAR_MENU_VAL_CURR_MENU = Custom String("VEHICLE_CONTROLS_MENU");
	}
}

rule("MAIN MENU BUTTON: PLAY")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		Global.VAR_MENU_VAL_CURR_MENU == Custom String("MAIN_MENU");
		Global.VAR_MENU_MENU_STRING_NAV == Custom String("MENU_NAV_ENTER");
		Global.VAR_MENU_VAL_CURR_OPTION == 1;
	}

	actions
	{
		If(Global.THE_RAVEN_CAN_ONLY_WATCH_OMENS != True);
			Call Subroutine(SUB_CORE);
		End;
		Call Subroutine(SUB_GPL_STORE_GAME_VALUES);
		Global.VAR_MENU_VAL_CURR_MENU = Custom String("PLAY_MENU");
	}
}

rule("MAIN MENU BUTTON: ENTER MODE SETTINGS")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		Global.VAR_MENU_VAL_CURR_MENU == Custom String("MAIN_MENU");
		Global.VAR_MENU_MENU_STRING_NAV == Custom String("MENU_NAV_ENTER");
		Global.VAR_MENU_VAL_CURR_OPTION == 4;
	}

	actions
	{
		Call Subroutine(SUB_GPL_STORE_GAME_VALUES);
		Global.VAR_GBL_INTRNL_STORED_VALUES[0] = Global.VAR_MENU_VAL_CURR_OPTION;
		Global.VAR_MENU_VAL_CURR_MENU = Custom String("MODE_SETTINGS_MENU");
	}
}

rule("MAIN MENU BUTTON: ENTER TUNE CAR")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		Global.VAR_MENU_VAL_CURR_MENU == Custom String("MAIN_MENU");
		Global.VAR_MENU_MENU_STRING_NAV == Custom String("MENU_NAV_ENTER");
		Global.VAR_MENU_VAL_CURR_OPTION == 3;
	}

	actions
	{
		Call Subroutine(SUB_GPL_STORE_GAME_VALUES);
		Global.VAR_GBL_INTRNL_STORED_VALUES[0] = Global.VAR_MENU_VAL_CURR_OPTION;
		Global.VAR_MENU_VAL_CURR_MENU = Custom String("TUNE_CAR_MENU");
	}
}

rule("MAIN MENU BUTTON: EXIT TO LOBBY")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		Global.VAR_MENU_VAL_CURR_MENU == Custom String("MAIN_MENU");
		Global.VAR_MENU_MENU_STRING_NAV == Custom String("MENU_NAV_ENTER");
		Global.VAR_MENU_VAL_CURR_OPTION == 5;
	}

	actions
	{
		Return to Lobby;
	}
}

disabled rule("VEHICLE CONTROLS MENU")
{
	event
	{
		Ongoing - Global;
	}
}

rule("VEHICLE CONTROLS MENU: GET ARRAYS")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		Global.VAR_MENU_VAL_CURR_MENU == Custom String("VEHICLE_CONTROLS_MENU");
	}

	actions
	{
		"GET VERTICAL VECTOR LIST FOR - BUTTONS (VEHICLE CONTROLS)"
		Global.VAR_MENU_ARRAY_BTN_Z_VECTOR = Array(-5, 2, 5, 7.500, 10, 12.500, 15.500, 18.500, 22, 29.500);
		"GET VERTICAL VECTOR LIST FOR - SUB-BUTTONS (VEHICLE CONTROLS)"
		Global.VAR_MENU_ARRAY_SUBBTN_Z_VECTOR = Array(Null);
		"SET VERTICAL NAVIGATION CLAMP (VEHICLE CONTROLS)"
		Global.VAR_MENU_ARRAY_CURR_NAV_LIMITS = Array(0);
		"ARRAY TABLE - VALUE TYPE LIST (VEHICLE CONTROLS)"
		Global.VAR_MENU_ARRAY_CURR_OPTION_TYPE = Array(Custom String("BUTTON"));
		"GET VALUES FROM INTERAL ARRAY - REFER TO \"GLOBAL ARRAY LIST\" RULE (VEHICLE CONTROLS)"
		Global.VAR_GBL_CURR_STORED_VALUES = Array(Null);
		Call Subroutine(SUB_MENU_ENTER);
		Global.VAR_MENU_VSL_ARROWS_VAL_ADJUST = 9;
	}
}

rule("VEHICLE CONTROLS MENU: CREATE STRINGS")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		Global.VAR_MENU_VAL_CURR_MENU == Custom String("VEHICLE_CONTROLS_MENU");
	}

	actions
	{
		"VEHICLE CONTROLS"
		Create In-World Text(All Players(All Teams), Global.VAR_MENU_ARRAY_STRING_MAIN[3], Vector(0, 150, First Of(
			Global.VAR_MENU_ARRAY_BTN_Z_VECTOR)), 3, Clip Against Surfaces, Visible To Position String and Color, Color(White),
			Default Visibility);
		"FOR INDEXES REFER TO: MENU \\ GLOBAL \\ ARRAY TABLE - STRINGS (VEHICLE CONTROL) \n [2] - (PRESS) \n [4] - ENTER/EXIT THE VEHICLE"
		Create In-World Text(All Players(All Teams), Custom String("{0} {1} {2}", Input Binding String(Button(Interact)),
			Global.VAR_MENU_ARRAY_STRING_CONTROL[2], Global.VAR_MENU_ARRAY_STRING_CONTROL[4]), Vector(0, 150,
			Global.VAR_MENU_ARRAY_BTN_Z_VECTOR[1]), 2, Clip Against Surfaces, Visible To Position String and Color, Color(White),
			Default Visibility);
		"FOR INDEXES REFER TO: MENU \\ GLOBAL \\ ARRAY TABLE - STRINGS (VEHICLE CONTROL) \n [0] - (HOLD) \n [5] - USE NITROUS"
		Create In-World Text(All Players(All Teams), Custom String("{0} {1} {2}", Input Binding String(Button(Ability 1)), First Of(
			Global.VAR_MENU_ARRAY_STRING_CONTROL), Global.VAR_MENU_ARRAY_STRING_CONTROL[5]), Vector(0, 150,
			Global.VAR_MENU_ARRAY_BTN_Z_VECTOR[2]), 2, Clip Against Surfaces, Visible To Position String and Color, Color(White),
			Default Visibility);
		"FOR INDEXES REFER TO: MENU \\ GLOBAL \\ ARRAY TABLE - STRINGS (VEHICLE CONTROL) \n [3] - (HOLD/TAP) \n [6] - USE HANDBRAKE"
		Create In-World Text(All Players(All Teams), Custom String("{0} {1} {2}", Input Binding String(Button(Jump)),
			Global.VAR_MENU_ARRAY_STRING_CONTROL[3], Global.VAR_MENU_ARRAY_STRING_CONTROL[6]), Vector(0, 150,
			Global.VAR_MENU_ARRAY_BTN_Z_VECTOR[3]), 2, Clip Against Surfaces, Visible To Position String and Color, Color(White),
			Default Visibility);
		"FOR INDEXES REFER TO: MENU \\ GLOBAL \\ ARRAY TABLE - STRINGS (VEHICLE CONTROL) \n [0] - (HOLD) \n [1]  - (TAP) \n [7] - SWITCH RADIO"
		Create In-World Text(All Players(All Teams), Custom String("{0} {1} + {2}", Input Binding String(Button(Melee)), First Of(
			Global.VAR_MENU_ARRAY_STRING_CONTROL), Custom String("{0} / {1} {2}", Input Binding String(Button(Primary Fire)),
			Input Binding String(Button(Secondary Fire)), Custom String("{0} {1}", Global.VAR_MENU_ARRAY_STRING_CONTROL[1],
			Global.VAR_MENU_ARRAY_STRING_CONTROL[7]))), Vector(0, 150, Global.VAR_MENU_ARRAY_BTN_Z_VECTOR[4]), 2, Clip Against Surfaces,
			Visible To Position String and Color, Color(White), Default Visibility);
		"FOR INDEXES REFER TO: MENU \\ GLOBAL \\ ARRAY TABLE - STRINGS (VEHICLE CONTROL) \n [15] - MOVE LEFT \n [16] - MOVE RIGHT \n [2] - (PRESS) \n [8] - TOGGLE BLINKERS"
		Create In-World Text(All Players(All Teams), Custom String("{0} + {1} {2}", Input Binding String(Button(Melee)), Custom String(
			"{0} / {1} / {2}", Global.VAR_MENU_ARRAY_STRING_CONTROL[15], Global.VAR_MENU_ARRAY_STRING_CONTROL[16], Input Binding String(
			Button(Jump))), Custom String("{0} {1}", Global.VAR_MENU_ARRAY_STRING_CONTROL[2], Global.VAR_MENU_ARRAY_STRING_CONTROL[8])),
			Vector(0, 150, Global.VAR_MENU_ARRAY_BTN_Z_VECTOR[5]), 2, Clip Against Surfaces, Visible To Position String and Color, Color(
			White), Default Visibility);
		"FOR INDEXES REFER TO: MENU \\ GLOBAL \\ ARRAY TABLE - STRINGS (VEHICLE CONTROL) \n [2] - (PRESS) \n [9] - TURN ON/OFF CAR ENGINE"
		Create In-World Text(All Players(All Teams), Custom String("{0} {1} + {2}", Input Binding String(Button(Melee)), First Of(
			Global.VAR_MENU_ARRAY_STRING_CONTROL), Custom String("{0} {1} {2}", Input Binding String(Button(Reload)),
			Global.VAR_MENU_ARRAY_STRING_CONTROL[2], Global.VAR_MENU_ARRAY_STRING_CONTROL[9])), Vector(0, 150,
			Global.VAR_MENU_ARRAY_BTN_Z_VECTOR[6]), 2, Clip Against Surfaces, Visible To Position String and Color, Color(White),
			Default Visibility);
		"FOR INDEXES REFER TO: MENU \\ GLOBAL \\ ARRAY TABLE - STRINGS (VEHICLE CONTROL) \n [2] - (PRESS) \n [10] - TOGGLE CAMERA"
		Create In-World Text(All Players(All Teams), Custom String("{0} {1} {2}", Input Binding String(Button(Ultimate)),
			Global.VAR_MENU_ARRAY_STRING_CONTROL[2], Global.VAR_MENU_ARRAY_STRING_CONTROL[10]), Vector(0, 150,
			Global.VAR_MENU_ARRAY_BTN_Z_VECTOR[7]), 2, Clip Against Surfaces, Visible To Position String and Color, Color(White),
			Default Visibility);
		"FOR INDEXES REFER TO: MENU \\ GLOBAL \\ ARRAY TABLE - STRINGS (VEHICLE CONTROL) \n [2] - (PRESS) \n [11] - RESPAWN (WHEN CRASHED)"
		Create In-World Text(All Players(All Teams), Custom String("{0} {1} {2}", Input Binding String(Button(Reload)),
			Global.VAR_MENU_ARRAY_STRING_CONTROL[2], Global.VAR_MENU_ARRAY_STRING_CONTROL[11]), Vector(0, 150,
			Global.VAR_MENU_ARRAY_BTN_Z_VECTOR[8]), 2, Clip Against Surfaces, Visible To Position String and Color, Color(White),
			Default Visibility);
		"FOR INDEXES REFER TO: MENU \\ GLOBAL \\ ARRAY TABLE - STRINGS (VEHICLE CONTROL) \n [12] - PRESS \n [13] - OR \n [14] - TO EXIT TO MAIN MENU"
		Create In-World Text(All Players(All Teams), Custom String("{0} ( {1} ) {2}", Global.VAR_MENU_ARRAY_STRING_CONTROL[12],
			Input Binding String(Button(Ultimate)), Custom String("{0} ( {1} ) {2}", Global.VAR_MENU_ARRAY_STRING_CONTROL[13],
			Input Binding String(Button(Interact)), Global.VAR_MENU_ARRAY_STRING_CONTROL[14])), Vector(0, 150,
			Global.VAR_MENU_ARRAY_BTN_Z_VECTOR[9]), 2, Clip Against Surfaces, Visible To Position String and Color, Color(Orange),
			Default Visibility);
	}
}

rule("VEHICLE CONTROLS MENU: EXIT TO MAIN MENU")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		Global.VAR_MENU_VAL_CURR_MENU == Custom String("VEHICLE_CONTROLS_MENU");
		Global.VAR_MENU_MENU_STRING_NAV == Custom String("MENU_NAV_ENTER");
	}

	actions
	{
		Call Subroutine(SUB_MENU_EXIT);
	}
}

disabled rule("PLAY MENU")
{
	event
	{
		Ongoing - Global;
	}
}

rule("PLAY MENU: SELECTED")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		Global.VAR_MENU_VAL_CURR_MENU == Custom String("PLAY_MENU");
	}

	actions
	{
		Destroy All In-World Text;
		Destroy All HUD Text;
		Global.VAR_MENU_SETTINGS_CHANGE_CHECK = Custom String("SETTINGS_UNCHANGED");
		Wait(0.275, Ignore Condition);
		Global.VAR_GLB_PLAYER_IS_IN_MAIN_MENU = False;
		Global.VAR_GLB_VEHICLE_DEPLOY_STATUS = Custom String("DEPLOY_CAR");
		If(Global.A_PIECE_OF_ASPHALT_THAT_I_FOUND != True);
			Create In-World Text(All Players(All Teams), First Of(Global.VAR_CRIT_ARRAY_CORE), Vector(0, 150,
				Global.VAR_MENU_ARRAY_BTN_Z_VECTOR[3]), 6, Clip Against Surfaces, Visible To Position and String, Color(White),
				Default Visibility);
			Create In-World Text(All Players(All Teams), Global.VAR_CRIT_ARRAY_CORE[Random Integer(1, 10)], Vector(0, 150,
				Global.VAR_MENU_ARRAY_BTN_Z_VECTOR[6]), 3, Clip Against Surfaces, Visible To Position and String, Color(Red),
				Default Visibility);
		Else;
			Create In-World Text(All Players(All Teams), Global.VAR_MENU_WAITING_FOR_CAR_STRING, Vector(0, 150,
				Global.VAR_MENU_ARRAY_BTN_Z_VECTOR[4]), 2.500, Clip Against Surfaces, Visible To Position and String, Color(White),
				Default Visibility);
			Wait(2, Ignore Condition);
			Global.VAR_GLB_VEHICLE_DEPLOY_STATUS = Custom String("READY");
			Global.VAR_MENU_WAITING_FOR_CAR_STRING = Global.VAR_MENU_ARRAY_STRING_DEPLOY[1];
			Create In-World Text(All Players(All Teams), Custom String("{0} {1}", Global.VAR_MENU_ARRAY_STRING_DEPLOY[2],
				Global.VAR_MENU_ARRAY_STRING_DEPLOY[Random Integer(3, 8)]), Vector(0, 150, Global.VAR_MENU_ARRAY_BTN_Z_VECTOR[8]), 2,
				Clip Against Surfaces, Visible To Position and String, Color(White), Default Visibility);
			Wait Until(Array Contains(Array(Is Button Held(Global.VAR_PLAYER_RACER, Button(Primary Fire)), Is Button Held(
				Global.VAR_PLAYER_RACER, Button(Secondary Fire)), Is Button Held(Global.VAR_PLAYER_RACER, Button(Ability 1)), Is Button Held(
				Global.VAR_PLAYER_RACER, Button(Ability 2)), Is Button Held(Global.VAR_PLAYER_RACER, Button(Reload)), Is Button Held(
				Global.VAR_PLAYER_RACER, Button(Melee)), Is Button Held(Global.VAR_PLAYER_RACER, Button(Jump)), Is Button Held(
				Global.VAR_PLAYER_RACER, Button(Crouch)), Is Button Held(Global.VAR_PLAYER_RACER, Button(Interact)), Is Button Held(
				Global.VAR_PLAYER_RACER, Button(Ultimate))), True) || Array Contains(Array(X Component Of(Throttle Of(
				Global.VAR_PLAYER_RACER)), Z Component Of(Throttle Of(Global.VAR_PLAYER_RACER))), Array(1, -1)), 99999);
			Wait(0.100, Ignore Condition);
			Stop Camera(All Players(All Teams));
			Destroy All In-World Text;
			Global.VAR_GLB_VEHICLE_DEPLOY_STATUS = Custom String("DEPLOYED");
		End;
	}
}

disabled rule("TUNE CAR MENU")
{
	event
	{
		Ongoing - Global;
	}
}

rule("GET ARRAYS FOR: TUNE CAR")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		Global.VAR_MENU_VAL_CURR_MENU == Custom String("TUNE_CAR_MENU");
	}

	actions
	{
		"GET VERTICAL VECTOR LIST FOR - BUTTONS (TUNE CAR)"
		Global.VAR_MENU_ARRAY_BTN_Z_VECTOR = Array(-8, -3.500, 1.500, 6.500, 11.500, 17, 22.500, 28, 34, 41);
		"GET VERTICAL VECTOR LIST FOR - SUB-BUTTONS (TUNE CAR)"
		Global.VAR_MENU_ARRAY_SUBBTN_Z_VECTOR = Array(-1.500, 3.500, 8.500, 14, 19.500, 25, 30.500, 36.500);
		"SET VERTICAL NAVIGATION CLAMP (TUNE CAR)"
		Global.VAR_MENU_ARRAY_CURR_NAV_LIMITS = Array(-1, 6);
		"ARRAY TABLE -  MIN CLAMP VALUES (TUNE CAR)"
		Global.VAR_MENU_ARRAY_CURR_MIN_CLAMP = Array(Index Of Array Value(Global.VAR_MENU_ARRAY_STRING_RADIOS, First Of(
			Global.VAR_MENU_ARRAY_STRING_RADIOS)), False, Index Of Array Value(Global.VAR_MENU_ARRAY_STRING_NITROUS, First Of(
			Global.VAR_MENU_ARRAY_STRING_NITROUS)), 1, 1, False, False);
		"ARRAY TABLE -  MAX CLAMP VALUES (TUNE CAR)"
		Global.VAR_MENU_ARRAY_CURR_MAX_CLAMP = Array(Index Of Array Value(Global.VAR_MENU_ARRAY_STRING_RADIOS, Last Of(
			Global.VAR_MENU_ARRAY_STRING_RADIOS)), True, Index Of Array Value(Global.VAR_MENU_ARRAY_STRING_NITROUS, Last Of(
			Global.VAR_MENU_ARRAY_STRING_NITROUS)), 100, 10, True, True);
		"REFER TO: VARIABLE_STRING_TABLES.TXT / ARRAY TABLE - INTERNAL STORAGE VARIABLE"
		Global.VAR_GBL_CURR_STORED_VALUES = Array(Global.VAR_GBL_INTRNL_STORED_VALUES[2], Global.VAR_GBL_INTRNL_STORED_VALUES[3],
			Global.VAR_GBL_INTRNL_STORED_VALUES[4], Global.VAR_GBL_INTRNL_STORED_VALUES[5], Global.VAR_GBL_INTRNL_STORED_VALUES[6]);
		Global.VAR_MENU_VSL_ARROWS_VAL_ADJUST = 1;
		Global.VAR_MENU_VAL_CURR_OPTION = 0;
		Call Subroutine(SUB_MENU_ENTER);
	}
}

rule("CREATE BUTTON STRINGS FOR: TUNE CAR")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		Global.VAR_MENU_VAL_CURR_MENU == Custom String("TUNE_CAR_MENU");
	}

	actions
	{
		Call Subroutine(SUB_MENU_CREATE_BUTTONS);
		"ARRAY TABLE - VALUE TYPE LIST (TUNE CAR)"
		Global.VAR_MENU_ARRAY_CURR_OPTION_TYPE = Array(Custom String("FLOAT"), Custom String("BOOLEAN"), Custom String("FLOAT"),
			Custom String("FLOAT"), Custom String("FLOAT"), Custom String("EXIT_BUTTON"));
		"SET BUTTON STRINGS (TUNE CAR)"
		Global.VAR_MENU_ARRAY_STRING_BTN_H = Array(Global.VAR_MENU_ARRAY_STRING_MAIN[6], First Of(Global.VAR_MENU_ARRAY_STRING_TUNE),
			Global.VAR_MENU_ARRAY_STRING_TUNE[1], Global.VAR_MENU_ARRAY_STRING_TUNE[2], Global.VAR_MENU_ARRAY_STRING_TUNE[3],
			Global.VAR_MENU_ARRAY_STRING_TUNE[4], Global.VAR_MENU_ARRAY_STRING_MAIN[9]);
	}
}

rule("CREATE SUB-BUTTON STRINGS FOR: TUNE CAR")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		Global.VAR_MENU_VAL_CURR_MENU == Custom String("TUNE_CAR_MENU");
	}

	actions
	{
		Call Subroutine(SUB_MENU_CREATE_SUB_BUTTONS);
		Call Subroutine(SUB_MENU_UPDATE_SUB_BUTTONS);
	}
}

rule("EXIT: TUNE CAR - TO MAIN MENU")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		Global.VAR_MENU_VAL_CURR_MENU == Custom String("TUNE_CAR_MENU");
		Global.VAR_MENU_MENU_STRING_NAV == Custom String("MENU_NAV_ENTER");
		Global.VAR_MENU_ARRAY_CURR_OPTION_TYPE[Global.VAR_MENU_VAL_CURR_OPTION] == Custom String("EXIT_BUTTON");
	}

	actions
	{
		Call Subroutine(SUB_MENU_EXIT);
	}
}

disabled rule("MODE SETTINGS MENU")
{
	event
	{
		Ongoing - Global;
	}
}

rule("MODE SETTINGS MENU: GET ARRAYS")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		Global.VAR_MENU_VAL_CURR_MENU == Custom String("MODE_SETTINGS_MENU");
	}

	actions
	{
		"GET VERTICAL VECTOR LIST FOR - BUTTONS (MODE SETTINGS)"
		Global.VAR_MENU_ARRAY_BTN_Z_VECTOR = Array(-8, -3.500, 1.500, 6.500, 11.500, 17, 22.500, 28, 34, 41);
		"GET VERTICAL VECTOR LIST FOR - SUB-BUTTONS (MODE SETTINGS)"
		Global.VAR_MENU_ARRAY_SUBBTN_Z_VECTOR = Array(-1.500, 3.500, 8.500, 14, 19.500, 25, 30.500, 36.500);
		"SET VERTICAL NAVIGATION CLAMP (MODE SETTINGS)"
		Global.VAR_MENU_ARRAY_CURR_NAV_LIMITS = Array(-1, 9);
		"REFER TO: VARIABLE_STRING_TABLES.TXT / ARRAY TABLE -  MIN CLAMP VALUES (MODE SETTINGS)"
		Global.VAR_MENU_ARRAY_CURR_MIN_CLAMP = Array(Index Of Array Value(Global.VAR_MENU_ARRAY_STRING_MODE_NAME, First Of(
			Global.VAR_MENU_ARRAY_STRING_MODE_NAME)), 1, False, Index Of Array Value(Global.VAR_MENU_ARRAY_STRING_TOGGLE, First Of(
			Global.VAR_MENU_ARRAY_STRING_TOGGLE)), 0, 6, 10, 0, Null);
		"REFER TO: VARIABLE_STRING_TABLES.TXT / ARRAY TABLE -  MAX CLAMP VALUES (MODE SETTINGS)"
		Global.VAR_MENU_ARRAY_CURR_MAX_CLAMP = Array(Index Of Array Value(Global.VAR_MENU_ARRAY_STRING_MODE_NAME, Last Of(
			Global.VAR_MENU_ARRAY_STRING_MODE_NAME)), 30, True, Index Of Array Value(Global.VAR_MENU_ARRAY_STRING_TOGGLE, Last Of(
			Global.VAR_MENU_ARRAY_STRING_TOGGLE)), 1000000, 1, 120, 20, Null);
		"REFER TO: VARIABLE_STRING_TABLES.TXT / ARRAY TABLE - INTERNAL STORAGE VARIABLE"
		Global.VAR_GBL_CURR_STORED_VALUES = Array(Global.VAR_GBL_INTRNL_STORED_VALUES[7], Global.VAR_GBL_INTRNL_STORED_VALUES[8],
			Global.VAR_GBL_INTRNL_STORED_VALUES[9], Global.VAR_GBL_INTRNL_STORED_VALUES[10], Global.VAR_GBL_INTRNL_STORED_VALUES[11],
			Global.VAR_GBL_INTRNL_STORED_VALUES[12], Global.VAR_GBL_INTRNL_STORED_VALUES[13], Global.VAR_GBL_INTRNL_STORED_VALUES[14]);
		Global.VAR_MENU_VSL_ARROWS_VAL_ADJUST = 1;
		Global.VAR_MENU_VAL_CURR_OPTION = 0;
		Call Subroutine(SUB_MENU_ENTER);
	}
}

rule("MODE SETTINGS MENU: CREATE BUTTON STRINGS")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		Global.VAR_MENU_VAL_CURR_MENU == Custom String("MODE_SETTINGS_MENU");
	}

	actions
	{
		Call Subroutine(SUB_MENU_CREATE_BUTTONS);
		"ARRAY TABLE - VALUE TYPE LIST (MODE SETTINGS)"
		Global.VAR_MENU_ARRAY_CURR_OPTION_TYPE = Array(Custom String("FLOAT"), Custom String("FLOAT"), Custom String("BOOLEAN"),
			Custom String("FLOAT"), Custom String("SPECIAL FLOAT"), Custom String("FLOAT"), Custom String("FLOAT"), Custom String("FLOAT"),
			Custom String("EXIT_BUTTON"));
		"SET BUTTON STRINGS (MODE SETTINGS)"
		Global.VAR_MENU_ARRAY_STRING_BTN_H = Array(Global.VAR_MENU_ARRAY_STRING_MAIN[7], First Of(Global.VAR_MENU_ARRAY_STRING_MODE),
			Global.VAR_MENU_ARRAY_STRING_MODE[1], Global.VAR_MENU_ARRAY_STRING_MODE[2], Global.VAR_MENU_ARRAY_STRING_MODE[3],
			Global.VAR_MENU_ARRAY_STRING_MODE[4], Global.VAR_MENU_ARRAY_STRING_MODE[5], Global.VAR_MENU_ARRAY_STRING_MODE[6],
			Global.VAR_MENU_ARRAY_STRING_MODE[7], Global.VAR_MENU_ARRAY_STRING_MAIN[8]);
	}
}

rule("MODE SETTINGS MENU: CREATE SUB-BUTTON STRINGS")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		Global.VAR_MENU_VAL_CURR_MENU == Custom String("MODE_SETTINGS_MENU");
	}

	actions
	{
		Call Subroutine(SUB_MENU_CREATE_SUB_BUTTONS);
		Call Subroutine(SUB_MENU_UPDATE_SUB_BUTTONS);
	}
}

rule("MODE SETTINGS MENU: EXIT TO MAIN MENU")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		Global.VAR_MENU_VAL_CURR_MENU == Custom String("MODE_SETTINGS_MENU");
		Global.VAR_MENU_MENU_STRING_NAV == Custom String("MENU_NAV_ENTER");
		Global.VAR_MENU_ARRAY_CURR_OPTION_TYPE[Global.VAR_MENU_VAL_CURR_OPTION] == Custom String("EXIT_BUTTON");
	}

	actions
	{
		Call Subroutine(SUB_MENU_EXIT);
	}
}

disabled rule("MENU NAVIGATION FUNCTIONALITY")
{
	event
	{
		Ongoing - Global;
	}
}

rule("MENU FUNCTION: Navigate Up")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		Global.VAR_GLB_PLAYER_IS_IN_MAIN_MENU == True;
		Has Spawned(Global.VAR_PLAYER_RACER) == True;
		Z Component Of(Throttle Of(Global.VAR_PLAYER_RACER)) > 0;
		Global.VAR_MENU_VAL_CURR_OPTION != First Of(Global.VAR_MENU_ARRAY_CURR_NAV_LIMITS);
	}

	actions
	{
		Global.VAR_MENU_MENU_STRING_NAV_PREV = Custom String("MENU_NAV_RESET");
		Global.VAR_MENU_MENU_STRING_NAV = Custom String("MENU_NAV_UP");
		Global.VAR_MENU_VAL_CURR_OPTION -= 1;
		Global.VAR_MENU_ARRAY_COLOR_CURR_LIST = Mapped Array(Global.VAR_MENU_ARRAY_COLOR_CURR_LIST,
			Current Array Index == Global.VAR_MENU_VAL_CURR_OPTION ? Color(Orange) : Color(White));
		Global.VAR_MENU_VAL_CURR_OPTION_VALUE = Global.VAR_GBL_CURR_STORED_VALUES[Global.VAR_MENU_VAL_CURR_OPTION];
	}
}

rule("MENU FUNCTION: Navigate Down")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		Global.VAR_GLB_PLAYER_IS_IN_MAIN_MENU == True;
		Has Spawned(Global.VAR_PLAYER_RACER) == True;
		Z Component Of(Throttle Of(Global.VAR_PLAYER_RACER)) < 0;
		Global.VAR_MENU_VAL_CURR_OPTION != Last Of(Global.VAR_MENU_ARRAY_CURR_NAV_LIMITS);
	}

	actions
	{
		Global.VAR_MENU_MENU_STRING_NAV_PREV = Custom String("MENU_NAV_RESET");
		Global.VAR_MENU_MENU_STRING_NAV = Custom String("MENU_NAV_DOWN");
		Global.VAR_MENU_VAL_CURR_OPTION += 1;
		Global.VAR_MENU_ARRAY_COLOR_CURR_LIST = Mapped Array(Global.VAR_MENU_ARRAY_COLOR_CURR_LIST,
			Current Array Index == Global.VAR_MENU_VAL_CURR_OPTION ? Color(Orange) : Color(White));
		Global.VAR_MENU_VAL_CURR_OPTION_VALUE = Global.VAR_GBL_CURR_STORED_VALUES[Global.VAR_MENU_VAL_CURR_OPTION];
	}
}

rule("MENU FUNCTION: Navigate Left")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		Global.VAR_GLB_PLAYER_IS_IN_MAIN_MENU == True;
		Has Spawned(Global.VAR_PLAYER_RACER) == True;
		X Component Of(Throttle Of(Global.VAR_PLAYER_RACER)) > 0;
	}

	actions
	{
		Global.VAR_MENU_MENU_STRING_NAV = Custom String("MENU_NAV_LEFT");
		Wait(0.500, Abort When False);
		Global.VAR_MENU_MENU_STRING_NAV = Custom String("MENU_NAV_LEFT_HELD");
	}
}

rule("MENU FUNCTION: Navigate Right")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		Global.VAR_GLB_PLAYER_IS_IN_MAIN_MENU == True;
		Has Spawned(Global.VAR_PLAYER_RACER) == True;
		X Component Of(Throttle Of(Global.VAR_PLAYER_RACER)) < 0;
	}

	actions
	{
		Global.VAR_MENU_MENU_STRING_NAV = Custom String("MENU_NAV_RIGHT");
		Wait(0.500, Abort When False);
		Global.VAR_MENU_MENU_STRING_NAV = Custom String("MENU_NAV_RIGHT_HELD");
	}
}

rule("MENU FUNCTION: Navigate Enter (Interact Pressed)")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		Global.VAR_GLB_PLAYER_IS_IN_MAIN_MENU == True;
		Has Spawned(Global.VAR_PLAYER_RACER) == True;
		Is Button Held(Global.VAR_PLAYER_RACER, Button(Interact)) == True;
	}

	actions
	{
		Global.VAR_MENU_MENU_STRING_NAV = Custom String("MENU_NAV_ENTER");
	}
}

rule("MENU FUNCTION: Navigate Exit (Ultimate Pressed)")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		Global.VAR_GLB_PLAYER_IS_IN_MAIN_MENU == True;
		Global.VAR_MENU_VAL_CURR_MENU != Custom String("PLAY_MENU");
		Has Spawned(Global.VAR_PLAYER_RACER) == True;
		Is Button Held(Global.VAR_PLAYER_RACER, Button(Ultimate)) == True;
	}

	actions
	{
		Global.VAR_MENU_MENU_STRING_NAV = Custom String("MENU_NAV_EXIT");
	}
}

rule("MENU FUNCTION: Navigate Enter/Exit (Interact/Ultimate Released)")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		Global.VAR_GLB_PLAYER_IS_IN_MAIN_MENU == True;
		Has Spawned(Global.VAR_PLAYER_RACER) == True;
		Is Button Held(Global.VAR_PLAYER_RACER, Button(Interact)) == False;
		Is Button Held(Global.VAR_PLAYER_RACER, Button(Ultimate)) == False;
	}

	actions
	{
		Global.VAR_MENU_MENU_STRING_NAV = Custom String("MENU_NAV_RESET");
	}
}

rule("MENU FUNCTION: Change Setting to Next")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		Global.VAR_GLB_PLAYER_IS_IN_MAIN_MENU == True;
		Global.VAR_MENU_MENU_STRING_NAV == Custom String("MENU_NAV_RIGHT");
		Global.VAR_MENU_VAL_CURR_OPTION_VALUE != Global.VAR_MENU_ARRAY_CURR_MAX_CLAMP[Global.VAR_MENU_VAL_CURR_OPTION];
		Global.VAR_MENU_ARRAY_CURR_OPTION_TYPE[Global.VAR_MENU_VAL_CURR_OPTION] != Custom String("BUTTON");
	}

	actions
	{
		Global.VAR_MENU_SETTINGS_CHANGE_CHECK = Custom String("SETTINGS_CHANGED");
		If(Global.VAR_MENU_ARRAY_CURR_OPTION_TYPE[Global.VAR_MENU_VAL_CURR_OPTION] == Custom String("FLOAT"));
			Global.VAR_MENU_VAL_CURR_OPTION_VALUE += 1;
		Else If(Global.VAR_MENU_ARRAY_CURR_OPTION_TYPE[Global.VAR_MENU_VAL_CURR_OPTION] == Custom String("VEHICLE_FLOAT"));
			Global.VAR_MENU_VAL_CURR_OPTION_VALUE += 1;
		Else If(Global.VAR_MENU_ARRAY_CURR_OPTION_TYPE[Global.VAR_MENU_VAL_CURR_OPTION] == Custom String("BOOLEAN"));
			Global.VAR_MENU_VAL_CURR_OPTION_VALUE = True;
		Else If(Global.VAR_MENU_ARRAY_CURR_OPTION_TYPE[Global.VAR_MENU_VAL_CURR_OPTION] == Custom String("SPECIAL FLOAT"));
			Global.VAR_MENU_VAL_CURR_OPTION_VALUE += 1000;
		End;
		"SAVE CURRENT VALUE"
		Global.VAR_GBL_CURR_STORED_VALUES[Global.VAR_MENU_VAL_CURR_OPTION] = Global.VAR_MENU_VAL_CURR_OPTION_VALUE;
		Call Subroutine(SUB_MENU_UPDATE_SUB_BUTTONS);
	}
}

rule("MENU FUNCTION: Change Setting to Prev")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		Global.VAR_GLB_PLAYER_IS_IN_MAIN_MENU == True;
		Global.VAR_MENU_MENU_STRING_NAV == Custom String("MENU_NAV_LEFT");
		Global.VAR_MENU_VAL_CURR_OPTION_VALUE != Global.VAR_MENU_ARRAY_CURR_MIN_CLAMP[Global.VAR_MENU_VAL_CURR_OPTION];
		Global.VAR_MENU_ARRAY_CURR_OPTION_TYPE[Global.VAR_MENU_VAL_CURR_OPTION] != Custom String("BUTTON");
	}

	actions
	{
		Global.VAR_MENU_SETTINGS_CHANGE_CHECK = Custom String("SETTINGS_CHANGED");
		If(Global.VAR_MENU_ARRAY_CURR_OPTION_TYPE[Global.VAR_MENU_VAL_CURR_OPTION] == Custom String("FLOAT"));
			Global.VAR_MENU_VAL_CURR_OPTION_VALUE -= 1;
		Else If(Global.VAR_MENU_ARRAY_CURR_OPTION_TYPE[Global.VAR_MENU_VAL_CURR_OPTION] == Custom String("VEHICLE_FLOAT"));
			Global.VAR_MENU_VAL_CURR_OPTION_VALUE -= 1;
		Else If(Global.VAR_MENU_ARRAY_CURR_OPTION_TYPE[Global.VAR_MENU_VAL_CURR_OPTION] == Custom String("BOOLEAN"));
			Global.VAR_MENU_VAL_CURR_OPTION_VALUE = False;
		Else If(Global.VAR_MENU_ARRAY_CURR_OPTION_TYPE[Global.VAR_MENU_VAL_CURR_OPTION] == Custom String("SPECIAL FLOAT"));
			Global.VAR_MENU_VAL_CURR_OPTION_VALUE -= 1000;
		End;
		"SAVE CURRENT VALUE"
		Global.VAR_GBL_CURR_STORED_VALUES[Global.VAR_MENU_VAL_CURR_OPTION] = Global.VAR_MENU_VAL_CURR_OPTION_VALUE;
		Call Subroutine(SUB_MENU_UPDATE_SUB_BUTTONS);
	}
}

rule("MENU FUNCTION: Change Setting to Next (Button Held)")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		Global.VAR_MENU_MENU_STRING_NAV == Custom String("MENU_NAV_RIGHT_HELD");
		Global.VAR_MENU_VAL_CURR_OPTION_VALUE != Global.VAR_MENU_ARRAY_CURR_MAX_CLAMP[Global.VAR_MENU_VAL_CURR_OPTION];
		Global.VAR_MENU_ARRAY_CURR_OPTION_TYPE[Global.VAR_MENU_VAL_CURR_OPTION] != Custom String("BUTTON");
	}

	actions
	{
		If(Global.VAR_MENU_ARRAY_CURR_OPTION_TYPE[Global.VAR_MENU_VAL_CURR_OPTION] == Custom String("FLOAT"));
			Global.VAR_MENU_VAL_CURR_OPTION_VALUE += 1;
		Else If(Global.VAR_MENU_ARRAY_CURR_OPTION_TYPE[Global.VAR_MENU_VAL_CURR_OPTION] == Custom String("SPECIAL FLOAT"));
			Global.VAR_MENU_VAL_CURR_OPTION_VALUE += 1000;
		End;
		"SAVE CURRENT VALUE"
		Global.VAR_GBL_CURR_STORED_VALUES[Global.VAR_MENU_VAL_CURR_OPTION] = Global.VAR_MENU_VAL_CURR_OPTION_VALUE;
		Call Subroutine(SUB_MENU_UPDATE_SUB_BUTTONS);
		Wait(Global.VAR_MENU_VAL_OPTION_CHANGE_SPEED, Abort When False);
		Loop If Condition Is True;
	}
}

rule("MENU FUNCTION: Change Setting to Prev (Button Held)")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		Global.VAR_MENU_MENU_STRING_NAV == Custom String("MENU_NAV_LEFT_HELD");
		Global.VAR_MENU_VAL_CURR_OPTION_VALUE != Global.VAR_MENU_ARRAY_CURR_MIN_CLAMP[Global.VAR_MENU_VAL_CURR_OPTION];
		Global.VAR_MENU_ARRAY_CURR_OPTION_TYPE[Global.VAR_MENU_VAL_CURR_OPTION] != Custom String("BUTTON");
	}

	actions
	{
		If(Global.VAR_MENU_ARRAY_CURR_OPTION_TYPE[Global.VAR_MENU_VAL_CURR_OPTION] == Custom String("FLOAT"));
			Global.VAR_MENU_VAL_CURR_OPTION_VALUE -= 1;
		Else If(Global.VAR_MENU_ARRAY_CURR_OPTION_TYPE[Global.VAR_MENU_VAL_CURR_OPTION] == Custom String("SPECIAL FLOAT"));
			Global.VAR_MENU_VAL_CURR_OPTION_VALUE -= 1000;
		End;
		"SAVE CURRENT VALUE"
		Global.VAR_GBL_CURR_STORED_VALUES[Global.VAR_MENU_VAL_CURR_OPTION] = Global.VAR_MENU_VAL_CURR_OPTION_VALUE;
		Call Subroutine(SUB_MENU_UPDATE_SUB_BUTTONS);
		Wait(Global.VAR_MENU_VAL_OPTION_CHANGE_SPEED, Abort When False);
		Loop If Condition Is True;
	}
}

rule("MENU FUNCTION: Speed Up Changing Speed of Setting Value")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		Global.VAR_GLB_PLAYER_IS_IN_MAIN_MENU == True;
		Array Contains(Array(Custom String("MENU_NAV_LEFT_HELD"), Custom String("MENU_NAV_RIGHT_HELD")), Global.VAR_MENU_MENU_STRING_NAV)
			== True;
	}

	actions
	{
		Chase Global Variable At Rate(VAR_MENU_VAL_OPTION_CHANGE_SPEED, 0.005, 0.010, Destination and Rate);
	}
}

rule("MENU FUNCTION: Jump Vertical Navigation (Top to Bottom)")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		Global.VAR_GLB_PLAYER_IS_IN_MAIN_MENU == True;
		Global.VAR_MENU_MENU_STRING_NAV == Custom String("MENU_NAV_UP");
		Global.VAR_MENU_VAL_CURR_OPTION == First Of(Global.VAR_MENU_ARRAY_CURR_NAV_LIMITS);
	}

	actions
	{
		Global.VAR_MENU_VAL_CURR_OPTION = Last Of(Global.VAR_MENU_ARRAY_CURR_NAV_LIMITS);
		Global.VAR_MENU_VAL_CURR_OPTION -= 1;
		Global.VAR_MENU_ARRAY_COLOR_CURR_LIST = Mapped Array(Global.VAR_MENU_ARRAY_COLOR_CURR_LIST,
			Current Array Index == Global.VAR_MENU_VAL_CURR_OPTION ? Color(Orange) : Color(White));
	}
}

rule("MENU FUNCTION: Jump Vertical Navigation (Bottom to Top)")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		Global.VAR_GLB_PLAYER_IS_IN_MAIN_MENU == True;
		Global.VAR_MENU_MENU_STRING_NAV == Custom String("MENU_NAV_DOWN");
		Global.VAR_MENU_VAL_CURR_OPTION == Last Of(Global.VAR_MENU_ARRAY_CURR_NAV_LIMITS);
	}

	actions
	{
		Global.VAR_MENU_VAL_CURR_OPTION = 0;
		Global.VAR_MENU_ARRAY_COLOR_CURR_LIST = Mapped Array(Global.VAR_MENU_ARRAY_COLOR_CURR_LIST,
			Current Array Index == Global.VAR_MENU_VAL_CURR_OPTION ? Color(Orange) : Color(White));
	}
}

rule("MENU FUNCTION: Reset Horizontal Navigation")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		Global.VAR_GLB_PLAYER_IS_IN_MAIN_MENU == True;
		Has Spawned(Global.VAR_PLAYER_RACER) == True;
		X Component Of(Throttle Of(Global.VAR_PLAYER_RACER)) == 0;
	}

	actions
	{
		Global.VAR_MENU_MENU_STRING_NAV = Custom String("MENU_NAV_RESET");
		Stop Chasing Global Variable(VAR_MENU_VAL_OPTION_CHANGE_SPEED);
		Global.VAR_MENU_VAL_OPTION_CHANGE_SPEED = 0.050;
	}
}

rule("MENU FUNCTION: Reset Vertical Navigation")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		Global.VAR_GLB_PLAYER_IS_IN_MAIN_MENU == True;
		Has Spawned(Global.VAR_PLAYER_RACER) == True;
		Z Component Of(Throttle Of(Global.VAR_PLAYER_RACER)) == 0;
	}

	actions
	{
		If(Global.VAR_MENU_MENU_STRING_NAV == Custom String("MENU_NAV_UP"));
			Global.VAR_MENU_MENU_STRING_NAV_PREV = Custom String("MENU_NAV_UP");
		Else If(Global.VAR_MENU_MENU_STRING_NAV == Custom String("MENU_NAV_DOWN"));
			Global.VAR_MENU_MENU_STRING_NAV_PREV = Custom String("MENU_NAV_DOWN");
		Else If(Global.VAR_MENU_MENU_STRING_NAV == Custom String("MENU_NAV_LEFT"));
			Global.VAR_MENU_MENU_STRING_NAV_PREV = Custom String("MENU_NAV_LEFT");
		Else If(Global.VAR_MENU_MENU_STRING_NAV == Custom String("MENU_NAV_RIGHT"));
			Global.VAR_MENU_MENU_STRING_NAV_PREV = Custom String("MENU_NAV_RIGHT");
		End;
		Global.VAR_MENU_MENU_STRING_NAV = Custom String("MENU_NAV_RESET");
	}
}

rule("MENU FUNCTION: EXIT TO MAIN MENU")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		Global.VAR_MENU_VAL_CURR_MENU != Custom String("MAIN_MENU");
		Global.VAR_MENU_MENU_STRING_NAV == Custom String("MENU_NAV_EXIT");
	}

	actions
	{
		Call Subroutine(SUB_MENU_EXIT);
	}
}

rule("MENU FUNCTION SUBROUTINE: ENTER MENU")
{
	event
	{
		Subroutine;
		SUB_MENU_ENTER;
	}

	actions
	{
		Global.VAR_MENU_SETTINGS_CHANGE_CHECK = Custom String("SETTINGS_UNCHANGED");
		Destroy All In-World Text;
		"ARROWS"
		Create In-World Text(All Players(All Teams), Global.VAR_MENU_ARRAY_STRING_MAIN[10], Vector(0, 150,
			Global.VAR_MENU_ARRAY_BTN_Z_VECTOR[Global.VAR_MENU_VSL_ARROWS_VAL_ADJUST + Global.VAR_MENU_VAL_CURR_OPTION]), 3,
			Clip Against Surfaces, Visible To Position String and Color, Color(Orange), Default Visibility);
		Global.VAR_MENU_MENU_STRING_NAV = Custom String("MENU_NAV_RESET");
		Global.VAR_MENU_ARRAY_COLOR_CURR_LIST = Mapped Array(Global.VAR_MENU_ARRAY_COLOR_CURR_LIST,
			Current Array Index == Global.VAR_MENU_VAL_CURR_OPTION ? Color(Orange) : Color(White));
		Global.VAR_MENU_VAL_CURR_OPTION_VALUE = Global.VAR_GBL_CURR_STORED_VALUES[Global.VAR_MENU_VAL_CURR_OPTION];
	}
}

rule("MENU FUNCTION SUBROUTINE: CREATE OPTIONS BUTTON (VISUAL)")
{
	event
	{
		Subroutine;
		SUB_MENU_CREATE_BUTTONS;
	}

	actions
	{
		"CURRENT MENU TITLE"
		Create In-World Text(All Players(All Teams), First Of(Global.VAR_MENU_ARRAY_STRING_BTN_H), Vector(0, 150, First Of(
			Global.VAR_MENU_ARRAY_BTN_Z_VECTOR)), 3, Clip Against Surfaces, Visible To Position String and Color, Color(White),
			Default Visibility);
		"OPTION 1 (BUTTON)"
		Create In-World Text(All Players(All Teams), Global.VAR_MENU_ARRAY_STRING_BTN_H[1], Vector(0, 150,
			Global.VAR_MENU_ARRAY_BTN_Z_VECTOR[1]), 2, Clip Against Surfaces, Visible To Position String and Color, First Of(
			Global.VAR_MENU_ARRAY_COLOR_CURR_LIST), Default Visibility);
		"OPTION 2 (BUTTON)"
		Create In-World Text(All Players(All Teams), Global.VAR_MENU_ARRAY_STRING_BTN_H[2], Vector(0, 150,
			Global.VAR_MENU_ARRAY_BTN_Z_VECTOR[2]), 2, Clip Against Surfaces, Visible To Position String and Color,
			Global.VAR_MENU_ARRAY_COLOR_CURR_LIST[1], Default Visibility);
		"OPTION 3 (BUTTON)"
		Create In-World Text(All Players(All Teams), Global.VAR_MENU_ARRAY_STRING_BTN_H[3], Vector(0, 150,
			Global.VAR_MENU_ARRAY_BTN_Z_VECTOR[3]), 2, Clip Against Surfaces, Visible To Position String and Color,
			Global.VAR_MENU_ARRAY_COLOR_CURR_LIST[2], Default Visibility);
		"OPTION 4 (BUTTON)"
		Create In-World Text(All Players(All Teams), Global.VAR_MENU_ARRAY_STRING_BTN_H[4], Vector(0, 150,
			Global.VAR_MENU_ARRAY_BTN_Z_VECTOR[4]), 2, Clip Against Surfaces, Visible To Position String and Color,
			Global.VAR_MENU_ARRAY_COLOR_CURR_LIST[3], Default Visibility);
		"OPTION 5 (BUTTON)"
		Create In-World Text(All Players(All Teams), Global.VAR_MENU_ARRAY_STRING_BTN_H[5], Vector(0, 150,
			Global.VAR_MENU_ARRAY_BTN_Z_VECTOR[5]), 2, Clip Against Surfaces, Visible To Position String and Color,
			Global.VAR_MENU_ARRAY_COLOR_CURR_LIST[4], Default Visibility);
		If(Last Of(Global.VAR_MENU_ARRAY_CURR_NAV_LIMITS) > 5);
			"OPTION 6 (BUTTON)"
			Create In-World Text(All Players(All Teams), Global.VAR_MENU_ARRAY_STRING_BTN_H[6], Vector(0, 150,
				Global.VAR_MENU_ARRAY_BTN_Z_VECTOR[6]), 2, Clip Against Surfaces, Visible To Position String and Color,
				Global.VAR_MENU_ARRAY_COLOR_CURR_LIST[5], Default Visibility);
			If(Last Of(Global.VAR_MENU_ARRAY_CURR_NAV_LIMITS) > 6);
				"OPTION 7 (BUTTON)"
				Create In-World Text(All Players(All Teams), Global.VAR_MENU_ARRAY_STRING_BTN_H[7], Vector(0, 150,
					Global.VAR_MENU_ARRAY_BTN_Z_VECTOR[7]), 2, Clip Against Surfaces, Visible To Position String and Color,
					Global.VAR_MENU_ARRAY_COLOR_CURR_LIST[6], Default Visibility);
				If(Last Of(Global.VAR_MENU_ARRAY_CURR_NAV_LIMITS) > 7);
					"OPTION 8 (BUTTON)"
					Create In-World Text(All Players(All Teams), Global.VAR_MENU_ARRAY_STRING_BTN_H[8], Vector(0, 150,
						Global.VAR_MENU_ARRAY_BTN_Z_VECTOR[8]), 2, Clip Against Surfaces, Visible To Position String and Color,
						Global.VAR_MENU_ARRAY_COLOR_CURR_LIST[7], Default Visibility);
					If(Last Of(Global.VAR_MENU_ARRAY_CURR_NAV_LIMITS) > 8);
						"OPTION 9 (BUTTON)"
						Create In-World Text(All Players(All Teams), Global.VAR_MENU_ARRAY_STRING_BTN_H[9], Vector(0, 150,
							Global.VAR_MENU_ARRAY_BTN_Z_VECTOR[9]), 2, Clip Against Surfaces, Visible To Position String and Color,
							Global.VAR_MENU_ARRAY_COLOR_CURR_LIST[8], Default Visibility);
					End;
				End;
			End;
		End;
	}
}

rule("MENU FUNCTION SUBROUTINE: CREATE OPTIONS SUB-BUTTON (VISUAL)")
{
	event
	{
		Subroutine;
		SUB_MENU_CREATE_SUB_BUTTONS;
	}

	actions
	{
		"OPTION 1 (SUB-BUTTON)"
		Create In-World Text(All Players(All Teams), First Of(Global.VAR_MENU_ARRAY_STRING_SUBBTN_H), Vector(0, 150, First Of(
			Global.VAR_MENU_ARRAY_SUBBTN_Z_VECTOR)), 1.500, Clip Against Surfaces, Visible To Position String and Color, First Of(
			Global.VAR_MENU_ARRAY_COLOR_CURR_LIST), Default Visibility);
		"OPTION 2 (SUB-BUTTON)"
		Create In-World Text(All Players(All Teams), Global.VAR_MENU_ARRAY_STRING_SUBBTN_H[1], Vector(0, 150,
			Global.VAR_MENU_ARRAY_SUBBTN_Z_VECTOR[1]), 1.500, Clip Against Surfaces, Visible To Position String and Color,
			Global.VAR_MENU_ARRAY_COLOR_CURR_LIST[1], Default Visibility);
		"OPTION 3 (SUB-BUTTON)"
		Create In-World Text(All Players(All Teams), Global.VAR_MENU_ARRAY_STRING_SUBBTN_H[2], Vector(0, 150,
			Global.VAR_MENU_ARRAY_SUBBTN_Z_VECTOR[1.500]), 1.500, Clip Against Surfaces, Visible To Position String and Color,
			Global.VAR_MENU_ARRAY_COLOR_CURR_LIST[2], Default Visibility);
		If(Last Of(Global.VAR_MENU_ARRAY_CURR_NAV_LIMITS) > 4);
			"OPTION 4 (SUB-BUTTON)"
			Create In-World Text(All Players(All Teams), Global.VAR_MENU_ARRAY_STRING_SUBBTN_H[3], Vector(0, 150,
				Global.VAR_MENU_ARRAY_SUBBTN_Z_VECTOR[3]), 1.500, Clip Against Surfaces, Visible To Position String and Color,
				Global.VAR_MENU_ARRAY_COLOR_CURR_LIST[3], Default Visibility);
			If(Last Of(Global.VAR_MENU_ARRAY_CURR_NAV_LIMITS) > 5);
				"OPTION 5 (SUB-BUTTON)"
				Create In-World Text(All Players(All Teams), Global.VAR_MENU_ARRAY_STRING_SUBBTN_H[4], Vector(0, 150,
					Global.VAR_MENU_ARRAY_SUBBTN_Z_VECTOR[4]), 1.500, Clip Against Surfaces, Visible To Position String and Color,
					Global.VAR_MENU_ARRAY_COLOR_CURR_LIST[4], Default Visibility);
				If(Last Of(Global.VAR_MENU_ARRAY_CURR_NAV_LIMITS) > 6);
					"OPTION 6 (SUB-BUTTON)"
					Create In-World Text(All Players(All Teams), Global.VAR_MENU_ARRAY_STRING_SUBBTN_H[5], Vector(0, 150,
						Global.VAR_MENU_ARRAY_SUBBTN_Z_VECTOR[5]), 1.500, Clip Against Surfaces, Visible To Position String and Color,
						Global.VAR_MENU_ARRAY_COLOR_CURR_LIST[5], Default Visibility);
					If(Last Of(Global.VAR_MENU_ARRAY_CURR_NAV_LIMITS) > 7);
						"OPTION 7 (SUB-BUTTON)"
						Create In-World Text(All Players(All Teams), Global.VAR_MENU_ARRAY_STRING_SUBBTN_H[6], Vector(0, 150,
							Global.VAR_MENU_ARRAY_SUBBTN_Z_VECTOR[6]), 1.500, Clip Against Surfaces, Visible To Position String and Color,
							Global.VAR_MENU_ARRAY_COLOR_CURR_LIST[6], Default Visibility);
						If(Last Of(Global.VAR_MENU_ARRAY_CURR_NAV_LIMITS) > 8);
							"OPTION 8 (SUB-BUTTON)"
							Create In-World Text(All Players(All Teams), Global.VAR_MENU_ARRAY_STRING_SUBBTN_H[7], Vector(0, 150,
								Global.VAR_MENU_ARRAY_SUBBTN_Z_VECTOR[7]), 1.500, Clip Against Surfaces, Visible To Position String and Color,
								Global.VAR_MENU_ARRAY_COLOR_CURR_LIST[7], Default Visibility);
						End;
					End;
				End;
			End;
		End;
	}
}

rule("MENU FUNCTION SUBROUTINE: UPDATE OPTION SUB-BUTTONS")
{
	event
	{
		Subroutine;
		SUB_MENU_UPDATE_SUB_BUTTONS;
	}

	actions
	{
		If(Global.VAR_MENU_VAL_CURR_MENU == Custom String("TUNE_CAR_MENU"));
			"SET SUB-BUTTON STRINGS (TUNE CAR)"
			Global.VAR_MENU_ARRAY_STRING_SUBBTN_H = Array(Global.VAR_MENU_ARRAY_STRING_RADIOS[First Of(Global.VAR_GBL_CURR_STORED_VALUES)],
				Global.VAR_GBL_CURR_STORED_VALUES[1], Global.VAR_MENU_ARRAY_STRING_NITROUS[Global.VAR_GBL_CURR_STORED_VALUES[2]],
				Global.VAR_GBL_CURR_STORED_VALUES[3], Custom String("X {0}", Global.VAR_GBL_CURR_STORED_VALUES[4]));
		Else If(Global.VAR_MENU_VAL_CURR_MENU == Custom String("MODE_SETTINGS_MENU"));
			"SET SUB-BUTTON STRINGS (MODE SETTINGS)"
			Global.VAR_MENU_ARRAY_STRING_SUBBTN_H = Array(Global.VAR_MENU_ARRAY_STRING_MODE_NAME[First Of(Global.VAR_GBL_CURR_STORED_VALUES)],
				Global.VAR_GBL_CURR_STORED_VALUES[1], Global.VAR_GBL_CURR_STORED_VALUES[2],
				Global.VAR_MENU_ARRAY_STRING_TOGGLE[Global.VAR_GBL_CURR_STORED_VALUES[3]], Global.VAR_GBL_CURR_STORED_VALUES[4],
				Global.VAR_GBL_CURR_STORED_VALUES[5], Global.VAR_GBL_CURR_STORED_VALUES[6], Global.VAR_GBL_CURR_STORED_VALUES[7],
				Global.VAR_GBL_CURR_STORED_VALUES[8]);
		End;
	}
}

rule("MENU FUNCTION SUBROUTINE: EXIT TO MAIN MENU")
{
	event
	{
		Subroutine;
		SUB_MENU_EXIT;
	}

	actions
	{
		Call Subroutine(SUB_GPL_STORE_GAME_VALUES);
		Call Subroutine(SUB_MENU_ENTER);
		Global.VAR_MENU_VAL_CURR_MENU = Custom String("MAIN_MENU");
	}
}

rule("MENU FUNCTION SUBROUTINE: SAVE AND STORE VALUES")
{
	event
	{
		Subroutine;
		SUB_GPL_STORE_GAME_VALUES;
	}

	actions
	{
		If(Global.VAR_MENU_SETTINGS_CHANGE_CHECK == Custom String("SETTINGS_CHANGED"));
			Small Message(Global.VAR_PLAYER_RACER, Custom String("  {0}  {1} ", Icon String(Warning), Global.VAR_MENU_ARRAY_STRING_MAIN[11]));
			If(Global.VAR_MENU_VAL_CURR_MENU == Custom String("MAIN_MENU"));
				Global.VAR_GBL_INTRNL_STORED_VALUES[1] = Global.VAR_GBL_CURR_STORED_VALUES[2];
			Else If(Global.VAR_MENU_VAL_CURR_MENU == Custom String("TUNE_CAR_MENU"));
				Global.VAR_GBL_INTRNL_STORED_VALUES[2] = First Of(Global.VAR_GBL_CURR_STORED_VALUES);
				Global.VAR_GBL_INTRNL_STORED_VALUES[3] = Global.VAR_GBL_CURR_STORED_VALUES[1];
				Global.VAR_GBL_INTRNL_STORED_VALUES[4] = Global.VAR_GBL_CURR_STORED_VALUES[2];
				Global.VAR_GBL_INTRNL_STORED_VALUES[5] = Global.VAR_GBL_CURR_STORED_VALUES[3];
				Global.VAR_GBL_INTRNL_STORED_VALUES[6] = Global.VAR_GBL_CURR_STORED_VALUES[4];
			Else If(Global.VAR_MENU_VAL_CURR_MENU == Custom String("MODE_SETTINGS_MENU"));
				If(Global.VAR_GLB_RACE_HAS_TRACK == True);
					Global.VAR_GBL_INTRNL_STORED_VALUES[7] = First Of(Global.VAR_GBL_CURR_STORED_VALUES);
				Else;
					"[0] - CURRENT MODE:"
					If(Global.VAR_GBL_CURR_STORED_VALUES[0] != 0);
						Small Message(Global.VAR_PLAYER_RACER, Custom String("  {0}  {1} - {2} ", Icon String(Warning),
							Global.VAR_MENU_ARRAY_STRING_MAIN[12], Global.VAR_MENU_ARRAY_STRING_MAIN[13]));
					End;
				End;
				Global.VAR_GBL_INTRNL_STORED_VALUES[8] = Global.VAR_GBL_CURR_STORED_VALUES[1];
				If(Global.VAR_GLB_RACE_HAS_REV_VARIANT == True);
					"[2] - IS REVERSED?:"
					Global.VAR_GBL_INTRNL_STORED_VALUES[9] = Global.VAR_GBL_CURR_STORED_VALUES[2];
				Else;
					"[2] - IS REVERSED?:"
					If(Global.VAR_GBL_CURR_STORED_VALUES[2] == True);
						Small Message(Global.VAR_PLAYER_RACER, Custom String("  {0}  {1} - {2} ", Icon String(Warning),
							Global.VAR_MENU_ARRAY_STRING_MAIN[12], Global.VAR_MENU_ARRAY_STRING_MAIN[14]));
					End;
				End;
				Global.VAR_GBL_INTRNL_STORED_VALUES[10] = Global.VAR_GBL_CURR_STORED_VALUES[3];
				Global.VAR_GBL_INTRNL_STORED_VALUES[11] = Global.VAR_GBL_CURR_STORED_VALUES[4];
				Global.VAR_GBL_INTRNL_STORED_VALUES[12] = Global.VAR_GBL_CURR_STORED_VALUES[5];
				Global.VAR_GBL_INTRNL_STORED_VALUES[13] = Global.VAR_GBL_CURR_STORED_VALUES[6];
				Global.VAR_GBL_INTRNL_STORED_VALUES[14] = Global.VAR_GBL_CURR_STORED_VALUES[7];
			End;
		End;
	}
}

disabled rule("IN-GAME MECHANICS TAB")
{
	event
	{
		Ongoing - Global;
	}
}

rule("INITIAL MECHANICS: CREATE AND BUILD CAR")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		Has Spawned(Global.VAR_PLAYER_RACER) == True;
		Global.VAR_GLB_PLAYER_IS_IN_MAIN_MENU == False;
	}

	actions
	{
		Start Forcing Dummy Bot Name(Global.VAR_PLAYER_RACER, Global.VAR_MENU_ARRAY_STRING_CAR[Global.VAR_VEH_CAR_BODY]);
		Press Button(Global.VAR_PLAYER_RACER, Button(Ability 1));
	}
}

rule("IN-GAME MECHANICS: ARRAY VALUE LIST (GLOBAL)")
{
	event
	{
		Ongoing - Global;
	}

	actions
	{
		"DRIFT LEVEL BASED ARRAY TABLE"
		Global.VAR_GLB_ARRAY_VAL_DRIFT_AWARD = Array(250, 500, 750, 1000, 1250, 2000);
		"AIR LEVEL BASED ARRAY TABLE"
		Global.VAR_GLB_ARRAY_VAL_AIR_AWARD = Array(100, 250, 350, 500, 750, 1000);
		"REFER TO: VARIABLE_STRING_TABLES.TXT / ARRAY TABLE - STUNT MECHANICS"
		Global.VAR_GLB_ARRAY_STUNT_MECHANICS = Array(10000, 200, 10000, 200);
	}
}

rule("IN-GAME MECHANICS: ARRAY VALUE LIST (FOR VEHICLE)")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		"REFER TO: VARIABLE_STRING_TABLES.TXT"
		Has Spawned(Global.VAR_PLAYER_RACER) == True;
	}

	actions
	{
		"REFER TO: VARIABLE_STRING_TABLES.TXT / ARRAY TABLE - VEHICLE MECHANICS"
		Global.VAR_PLAYER_RACER.VAR_ARRAY_CAR_MECHANICS = Array(Null, Null, Null, Null, Null, 75, 100);
		"REFER TO: VARIABLE_STRING_TABLES.TXT / ARRAY TABLE - VEHICLE MECHANICS VALUES"
		Global.VAR_PLAYER_RACER.VAR_ARRAY_CAR_MECHANICS_VALUES = Array(75, 100, 65, 125, 50);
		"REFER TO: VARIABLE_STRING_TABLES.TXT / ARRAY TABLE - CAR FUNCTION MECHANICS"
		Global.VAR_PLAYER_RACER.VAR_ARRAY_CAR_FUNCTIONS = Array(False, Null, Global.VAR_MENU_ARRAY_STRING_RADIOS[4],
			Global.VAR_MENU_ARRAY_RADIO_COLOR_LIST[5], False, False);
		"REFER TO: VARIABLE_STRING_TABLES.TXT / ARRAY TABLE -  PLAYER FEEDBACKS"
		Global.VAR_PLAYER_RACER.VAR_ARRAY_CAR_PLAYER_FEEDBACKS = Array(200, 0, Color(Black), Color(Black), Color(Black), Color(Black),
			Color(Black));
		"REFER TO: VARIABLE_STRING_TABLES.TXT /\nARRAY TABLE - NITROUS MECHANICS\nARRAY TABLE - INTERNAL STORAGE VARIABLE"
		Global.VAR_PLAYER_RACER.VAR_NITROUS_ARRAY_MECHANICS = Array(0, 0, 100, Global.VAR_GBL_INTRNL_STORED_VALUES[5],
			Global.VAR_GBL_INTRNL_STORED_VALUES[6], 25, 10, 20, 25, 10, 5);
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAMERA MECHANICS"
		Global.VAR_PLAYER_RACER.VAR_ARRAY_CAR_CAMERA_MECHANICS = Array(Null, Null, Null, Null, Null, Null, Null, 0);
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION "
		Global.VAR_PLAYER_RACER.VAR_ARRAY_CAR_NAVIGATION = Array(Null, Null, Null, Null, Null, Null, Null, Null, Null, Null, Null);
	}
}

rule("IN-GAME GLOBAL MECHANICS: START-UP (FOR RACER)")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		Global.VAR_GLB_PLAYER_IS_IN_MAIN_MENU == False;
	}

	actions
	{
		Wait(0.048, Ignore Condition);
		Set Move Speed(Global.VAR_PLAYER_RACER, 100);
		Global.VAR_PLAYER_RACER.VAR_VSL_HUD_CLK_BST_COLOR = Color(White);
		Global.VAR_PLAYER_RACER.VAR_VSL_TXT_STUNT_INFO_WAIT = 3;
		"FOR INDEXES REFER TO: MENU \\ ARRAY TABLE - INTERNAL STORAGE VARIABLE \n [2] - SELECT RADIOSTATION"
		Global.VAR_PLAYER_RACER.VAR_VEH_RADIO_CURR_VALUE = Global.VAR_GBL_INTRNL_STORED_VALUES[2];
		"FOR INDEXES REFER TO: MENU \\ ARRAY TABLE - INTERNAL STORAGE VARIABLE \n [2] - SELECT RADIOSTATION"
		If(Global.VAR_GBL_INTRNL_STORED_VALUES[2] == 0);
			Global.VAR_PLAYER_RACER.VAR_VEH_RADIO_CURR_VALUE = Random Integer(1, 7);
		End;
	}
}

rule("IN-GAME GLOBAL MECHANICS: START-UP (FOR VEHICLE)")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		Global.VAR_GLB_PLAYER_IS_IN_MAIN_MENU == False;
	}

	actions
	{
		Wait(0.064, Ignore Condition);
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - PLAYER FEEDBACKS \n [1] - NITROUS SOUND LOOP VOLUME"
		Create Effect(All Players(All Teams), Mercy Damage Boosted Sound, Color(White), Global.VAR_PLAYER_RACER,
			Global.VAR_PLAYER_RACER.VAR_ARRAY_CAR_PLAYER_FEEDBACKS[1], Visible To Position and Radius);
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - PLAYER FEEDBACKS \n [2] - NITROUS CURRENT COLOR"
		Global.VAR_PLAYER_RACER.VAR_ARRAY_CAR_PLAYER_FEEDBACKS[2] = Color(Black);
		"FOR INDEXES REFER TO: MENU \\ ARRAY TABLE - INTERNAL STORAGE VARIABLE \n [4] - NITROUS:"
		If(Global.VAR_GBL_INTRNL_STORED_VALUES[4] != 0);
			"FOR INDEXES REFER TO: MENU \\ ARRAY TABLE - INTERNAL STORAGE VARIABLE \n [5] - STARTING NITROUS PERCENT: 50"
			Global.VAR_PLAYER_RACER.VAR_NITROUS_CURR_VAL_TANK = Global.VAR_GBL_INTRNL_STORED_VALUES[5];
		End;
	}
}

disabled rule("CAR BUILDING MECHANICS TAB")
{
	event
	{
		Ongoing - Global;
	}
}

rule("CAR BUILDING MECHANICS: GLOBAL")
{
	event
	{
		Ongoing - Global;
	}

	actions
	{
		Global.VAR_VEH_MESH_Scale = 0.925;
		Global.VAR_VEH_CAR_BODY = 0;
		Global.VAR_CRIT_ARRAY_CORE = Array(Custom String("       / \\\n     /     \\\n   /    .    \\\n /______\\"), Custom String(
			"I know what you did, {0}!", Host Player), Custom String("You thought I didn't notice, {0}?", Host Player), Custom String(
			"Eres consciente de las consecuencias, {0}?", Host Player), Custom String("You're complete jackass, {0}!", Host Player),
			Custom String("Get a job, {0}, you brainlet!", Host Player), Custom String("I'm not your property, {0}!", Host Player),
			Custom String("You're not my original creator, {0}!", Host Player), Custom String(
			"You just don't know when to quit, do you, {0}?", Host Player), Custom String("The Coconut Eye sees everything, {0}.",
			Host Player), Custom String("STOLEN COPY OF THE CODE DETECTED!"));
		Global.VAR_VEH_CUSTOM_CAR_BODY_COLORS = Workshop Setting Toggle(Custom String("B - CAR CUSTOMIZATION"), Custom String(
			"ENABLE CUSTOM COLORS"), False, 1);
	}
}

rule("CAR BUILDING MECHANICS: CUSTOMIZATION ARRAY TABLES")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		Has Spawned(Global.VAR_PLAYER_RACER) == True;
	}

	actions
	{
		"REFER TO: VARIABLE_STRING_TABLES.TXT / ARRAY TABLE - CAR CUSTOMIZATION STORED VALUES"
		Global.VAR_PLAYER_RACER.VAR_VEH_ARRAY_STORED_VALUES = Array(First Of(Global.VAR_PLAYER_RACER.VAR_VEH_ARRAY_BODY_COLOR),
			Global.VAR_PLAYER_RACER.VAR_VEH_ARRAY_BODY_COLOR[1], Global.VAR_PLAYER_RACER.VAR_VEH_ARRAY_BODY_COLOR[2],
			Global.VAR_PLAYER_RACER.VAR_VEH_ARRAY_BODY_COLOR[3], Global.VAR_PLAYER_RACER.VAR_VEH_ARRAY_BODY_COLOR[4]);
		If(Global.VAR_VEH_CUSTOM_CAR_LIGHT_COLORS == False);
			"REFER TO: VARIABLE_STRING_TABLES.TXT / LIGHT CUSTOMIZATION STORED VALUES"
			Global.VAR_PLAYER_RACER.VAR_VEH_ARRAY_LIGHT_STORED = Array(Color(Orange), Color(White), Color(Red), Color(Orange));
		End;
		"REFER TO: VARIABLE_STRING_TABLES.TXT / ARRAY TABLE - ARRAY TABLE - PLAYER FEEDBACKS"
		Global.VAR_PLAYER_RACER.VAR_ARRAY_CAR_PLAYER_FEEDBACKS = Array(200, 0, Color(Black), First Of(
			Global.VAR_PLAYER_RACER.VAR_VEH_ARRAY_LIGHT_STORED), Color(White), Color(Black), Color(Black));
	}
}

rule("CAR BUILDING MECHANICS: BUILD CAR MESH")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		Global.VAR_GLB_VEHICLE_DEPLOY_STATUS == Custom String("DEPLOY_CAR");
	}

	actions
	{
		Global.VAR_VEH_MESH_ActualLine = Round To Integer(Global.VAR_VEH_MESH_i / 2, Down);
		For Global Variable(VAR_VEH_MESH_i, 0, Count Of(Global.VAR_VEH_MESH_EDGES_FRONT_BUMPER), 2);
			"FRONT BUMPER / PRZEDNI ZDERZAK"
			If(Array Contains(Global.VAR_VEH_MESH_EDGES_FRONT_BUMPER, Global.VAR_VEH_MESH_ActualLine));
				"[0] - FRONT BUMPER COLOR"
				Global.VAR_PLAYER_RACER.VAR_VEH_BUILD_ARRAY_CURR_COLOR = 0;
				Global.VAR_VEH_MESH_VRTCS_CURR_PART = Global.VAR_VEH_MESH_VRTCS_FRONT_BUMPER;
				Global.VAR_VEH_MESH_EDGES_CURR_PART = Global.VAR_VEH_MESH_EDGES_FRONT_BUMPER;
				Call Subroutine(SUB_VEH_CREATE_CAR_BODY_BEAM);
				Call Subroutine(SUB_VEH_CREATE_APPEND_EFFECT);
			End;
		End;
		Wait(0, Ignore Condition);
		For Global Variable(VAR_VEH_MESH_i, 0, Count Of(Global.VAR_VEH_MESH_EDGES_FRONT_HOOD), 2);
			"FRONT HOOD / PRZEDNIA MASKA"
			If(Array Contains(Global.VAR_VEH_MESH_EDGES_FRONT_HOOD, Global.VAR_VEH_MESH_ActualLine));
				"[1] - HOOD COLOR"
				Global.VAR_PLAYER_RACER.VAR_VEH_BUILD_ARRAY_CURR_COLOR = 1;
				Global.VAR_VEH_MESH_VRTCS_CURR_PART = Global.VAR_VEH_MESH_VRTCS_FRONT_HOOD;
				Global.VAR_VEH_MESH_EDGES_CURR_PART = Global.VAR_VEH_MESH_EDGES_FRONT_HOOD;
				Call Subroutine(SUB_VEH_CREATE_CAR_BODY_BEAM);
				Call Subroutine(SUB_VEH_CREATE_APPEND_EFFECT);
			End;
		End;
		Wait(0, Ignore Condition);
		For Global Variable(VAR_VEH_MESH_i, 0, Count Of(Global.VAR_VEH_MESH_EDGES_BODY), 2);
			"BODY / KAROSERIA"
			If(Array Contains(Global.VAR_VEH_MESH_EDGES_BODY, Global.VAR_VEH_MESH_ActualLine));
				"[2] - BODY COLOR"
				Global.VAR_PLAYER_RACER.VAR_VEH_BUILD_ARRAY_CURR_COLOR = 2;
				Global.VAR_VEH_MESH_VRTCS_CURR_PART = Global.VAR_VEH_MESH_VRTCS_BODY;
				Global.VAR_VEH_MESH_EDGES_CURR_PART = Global.VAR_VEH_MESH_EDGES_BODY;
				Call Subroutine(SUB_VEH_CREATE_CAR_BODY_BEAM);
				Call Subroutine(SUB_VEH_CREATE_APPEND_EFFECT);
			End;
		End;
		Wait(0, Ignore Condition);
		For Global Variable(VAR_VEH_MESH_i, 0, Count Of(Global.VAR_VEH_MESH_EDGES_ENGINE_HOOD), 2);
			"ENGINE HOOD / MASKA SILNIKA"
			If(Array Contains(Global.VAR_VEH_MESH_EDGES_ENGINE_HOOD, Global.VAR_VEH_MESH_ActualLine));
				"[3] - TRUNK COLOR"
				Global.VAR_PLAYER_RACER.VAR_VEH_BUILD_ARRAY_CURR_COLOR = 3;
				Global.VAR_VEH_MESH_VRTCS_CURR_PART = Global.VAR_VEH_MESH_VRTCS_ENGINE_HOOD;
				Global.VAR_VEH_MESH_EDGES_CURR_PART = Global.VAR_VEH_MESH_EDGES_ENGINE_HOOD;
				Call Subroutine(SUB_VEH_CREATE_CAR_BODY_BEAM);
				Call Subroutine(SUB_VEH_CREATE_APPEND_EFFECT);
			End;
		End;
		Wait(0, Ignore Condition);
		"REAR BUMPER / TYLNY ZDERZAK"
		For Global Variable(VAR_VEH_MESH_i, 0, Count Of(Global.VAR_VEH_MESH_EDGES_REAR_BUMPER), 2);
			If(Array Contains(Global.VAR_VEH_MESH_EDGES_REAR_BUMPER, Global.VAR_VEH_MESH_ActualLine));
				"[4] - REAR BUMPER COLOR"
				Global.VAR_PLAYER_RACER.VAR_VEH_BUILD_ARRAY_CURR_COLOR = 4;
				Global.VAR_VEH_MESH_VRTCS_CURR_PART = Global.VAR_VEH_MESH_VRTCS_REAR_BUMPER;
				Global.VAR_VEH_MESH_EDGES_CURR_PART = Global.VAR_VEH_MESH_EDGES_REAR_BUMPER;
				Call Subroutine(SUB_VEH_CREATE_CAR_BODY_BEAM);
				Call Subroutine(SUB_VEH_CREATE_APPEND_EFFECT);
			End;
		End;
		Wait(0, Ignore Condition);
		For Global Variable(VAR_VEH_MESH_i, 0, Count Of(Global.VAR_VEH_MESH_EDGES_HEADLIGHTS), 2);
			"HEADLIGHTS / REFLEKTORY"
			If(Array Contains(Global.VAR_VEH_MESH_EDGES_HEADLIGHTS, Global.VAR_VEH_MESH_ActualLine));
				Call Subroutine(SUB_VEH_CREATE_HEADLIGHTS_BEAM);
				Call Subroutine(SUB_VEH_CREATE_APPEND_EFFECT);
			End;
		End;
		Wait(0, Ignore Condition);
		"LEFT REAR LIGHT / LEWE TYLNE ŚWIATŁO"
		For Global Variable(VAR_VEH_MESH_i, 0, Count Of(Global.VAR_VEH_MESH_EDGES_L_R_LIGHTS), 2);
			If(Array Contains(Global.VAR_VEH_MESH_EDGES_L_R_LIGHTS, Global.VAR_VEH_MESH_ActualLine));
				Call Subroutine(SUB_VEH_CREATE_L_R_LIGHTS_BEAM);
				Call Subroutine(SUB_VEH_CREATE_APPEND_EFFECT);
			End;
		End;
		Wait(0, Ignore Condition);
		"RIGHT REAR LIGHT / PRAWE TYLNE ŚWIATŁO"
		For Global Variable(VAR_VEH_MESH_i, 0, Count Of(Global.VAR_VEH_MESH_EDGES_L_R_LIGHTS), 2);
			If(Array Contains(Global.VAR_VEH_MESH_EDGES_R_R_LIGHTS, Global.VAR_VEH_MESH_ActualLine));
				Call Subroutine(SUB_VEH_CREATE_R_R_LIGHTS_BEAM);
				Call Subroutine(SUB_VEH_CREATE_APPEND_EFFECT);
			End;
		End;
		Wait(0, Ignore Condition);
		"NITROUS / NITRO"
		For Global Variable(VAR_VEH_MESH_i, 0, Count Of(Global.VAR_VEH_MESH_EDGES_NITROUS), 2);
			If(Array Contains(Global.VAR_VEH_MESH_EDGES_NITROUS, Global.VAR_VEH_MESH_ActualLine));
				Call Subroutine(SUB_VEH_CREATE_NITROUS_BEAM);
				Call Subroutine(SUB_VEH_CREATE_APPEND_EFFECT);
			End;
		End;
		Wait(0, Ignore Condition);
		"CARBON PARTS / CZĘŚCI KARBONOWE"
		For Global Variable(VAR_VEH_MESH_i, 0, Count Of(Global.VAR_VEH_MESH_EDGES_CARBON_PARTS), 2);
			If(Array Contains(Global.VAR_VEH_MESH_EDGES_CARBON_PARTS, Global.VAR_VEH_MESH_ActualLine));
				Call Subroutine(SUB_VEH_CREATE_CARBON_BEAM);
				Call Subroutine(SUB_VEH_CREATE_APPEND_EFFECT);
			End;
		End;
	}
}

rule("CAR BUILDING MECHANICS SUBROUTINE: BUILD CAR MESH (APPEND BEAM TO ARRAY)")
{
	event
	{
		Subroutine;
		SUB_VEH_CREATE_APPEND_EFFECT;
	}

	actions
	{
		Modify Global Variable(VAR_VEH_MESH_Effects, Append To Array, Last Created Entity);
		Wait(0.016, Ignore Condition);
	}
}

rule("CAR BUILDING MECHANICS SUBROUTINE: GET COLORS FOR SELECTED CARS")
{
	event
	{
		Subroutine;
		SUB_VEH_VSL_GET_COLORS;
	}

	actions
	{
		If(Global.VAR_VEH_CUSTOM_CAR_BODY_COLORS == False);
			"REFER TO: VARIABLE_STRING_TABLES.TXT / ARRAY TABLE - CAR DEFAULT COLOR VARIABLE"
			Global.VAR_PLAYER_RACER.VAR_VEH_ARRAY_BODY_COLOR = Array(Global.VAR_PLAYER_RACER.VAR_VEH_COLOR_DEFAULT,
				Global.VAR_PLAYER_RACER.VAR_VEH_COLOR_DEFAULT, Global.VAR_PLAYER_RACER.VAR_VEH_COLOR_DEFAULT,
				Global.VAR_PLAYER_RACER.VAR_VEH_COLOR_DEFAULT, Global.VAR_PLAYER_RACER.VAR_VEH_COLOR_DEFAULT);
		Else;
			"REFER TO: VARIABLE_STRING_TABLES.TXT / ARRAY TABLE - CAR DEFAULT COLOR VARIABLE"
			Global.VAR_PLAYER_RACER.VAR_VEH_ARRAY_BODY_COLOR = Array(Custom Color(Workshop Setting Integer(Custom String(
				"B - CAR CUSTOMIZATION (1 - FRONT BUMPER)"), Custom String("FRONT BUMPER - R(ED)"), 0, 0, 255, 2), Workshop Setting Integer(
				Custom String("B - CAR CUSTOMIZATION (1 - FRONT BUMPER)"), Custom String("FRONT BUMPER - G(REEN)"), 0, 0, 255, 3),
				Workshop Setting Integer(Custom String("B - CAR CUSTOMIZATION (1 - FRONT BUMPER)"), Custom String("FRONT BUMPER - B(LUE)"), 0,
				0, 255, 4), 255), Custom Color(Workshop Setting Integer(Custom String("B - CAR CUSTOMIZATION (2 - FRONT HOOD)"), Custom String(
				"FRONT HOOD - R(ED)"), 0, 0, 255, 5), Workshop Setting Integer(Custom String("B - CAR CUSTOMIZATION (2 - FRONT HOOD)"),
				Custom String("FRONT HOOD - G(REEN)"), 0, 0, 255, 6), Workshop Setting Integer(Custom String(
				"B - CAR CUSTOMIZATION (2 - FRONT HOOD)"), Custom String("FRONT HOOD - B(LUE)"), 0, 0, 255, 7), 255), Custom Color(
				Workshop Setting Integer(Custom String("B - CAR CUSTOMIZATION (3 - BODY)"), Custom String("CAR BODY - R(ED)"), 0, 0, 255, 8),
				Workshop Setting Integer(Custom String("B - CAR CUSTOMIZATION (3 - BODY)"), Custom String("CAR BODY - G(REEN)"), 0, 0, 255, 9),
				Workshop Setting Integer(Custom String("B - CAR CUSTOMIZATION (3 - BODY)"), Custom String("CAR BODY - B(LUE)"), 0, 0, 255, 10),
				255), Custom Color(Workshop Setting Integer(Custom String("B - CAR CUSTOMIZATION (4 - ENGINE HOOD)"), Custom String(
				"ENGINE HOOD - R(ED)"), 0, 0, 255, 11), Workshop Setting Integer(Custom String("B - CAR CUSTOMIZATION (4 - ENGINE HOOD)"),
				Custom String("ENGINE HOOD - G(REEN)"), 0, 0, 255, 12), Workshop Setting Integer(Custom String(
				"B - CAR CUSTOMIZATION (4 - ENGINE HOOD)"), Custom String("ENGINE HOOD - B(LUE)"), 0, 0, 255, 13), 255), Custom Color(
				Workshop Setting Integer(Custom String("B - CAR CUSTOMIZATION (5 - REAR BUMPER)"), Custom String("REAR BUMPER - R(ED)"), 0, 0,
				255, 14), Workshop Setting Integer(Custom String("B - CAR CUSTOMIZATION (5 - REAR BUMPER)"), Custom String(
				"REAR BUMPER - G(REEN)"), 0, 0, 255, 15), Workshop Setting Integer(Custom String("B - CAR CUSTOMIZATION (5 - REAR BUMPER)"),
				Custom String("REAR BUMPER - B(LUE)"), 0, 0, 255, 16), 255));
		End;
	}
}

rule("CAR BUILDING MECHANICS SUBROUTINE: CREATE CAR BODY BEAM")
{
	event
	{
		Subroutine;
		SUB_VEH_CREATE_CAR_BODY_BEAM;
	}

	actions
	{
		"Old Beam Creation Method"
		Create Beam Effect(Global.VAR_PLAYER_RACER.VAR_RACER_VEHICLE_VISIBLE_TO, Good Beam, World Vector Of(Evaluate Once(
			Global.VAR_VEH_MESH_VRTCS_CURR_PART[Global.VAR_VEH_MESH_EDGES_CURR_PART[Global.VAR_VEH_MESH_i]] * Global.VAR_VEH_MESH_Scale),
			Global.VAR_PLAYER_RACER.VAR_RACER_VEHICLE, Rotation And Translation), World Vector Of(Evaluate Once(
			Global.VAR_VEH_MESH_VRTCS_CURR_PART[Global.VAR_VEH_MESH_EDGES_CURR_PART[Global.VAR_VEH_MESH_i + 1]] * Global.VAR_VEH_MESH_Scale),
			Global.VAR_PLAYER_RACER.VAR_RACER_VEHICLE, Rotation And Translation),
			Global.VAR_PLAYER_RACER.VAR_VEH_ARRAY_BODY_COLOR[Global.VAR_PLAYER_RACER.VAR_VEH_BUILD_ARRAY_CURR_COLOR],
			Visible To Position and Radius);
	}
}

rule("CAR BUILDING MECHANICS SUBROUTINE: CREATE CAR BODY BEAM: HEADLIGHTS")
{
	event
	{
		Subroutine;
		SUB_VEH_CREATE_HEADLIGHTS_BEAM;
	}

	actions
	{
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - PLAYER FEEDBACKS \n [4] - HEADLIGHTS CURRENT COLOR"
		Create Beam Effect(Global.VAR_PLAYER_RACER.VAR_RACER_VEHICLE_VISIBLE_TO, Good Beam, World Vector Of(Evaluate Once(
			Global.VAR_VEH_MESH_VRTCS_HEADLIGHTS[Global.VAR_VEH_MESH_EDGES_HEADLIGHTS[Global.VAR_VEH_MESH_i]] * Global.VAR_VEH_MESH_Scale),
			Global.VAR_PLAYER_RACER.VAR_RACER_VEHICLE, Rotation And Translation), World Vector Of(Evaluate Once(
			Global.VAR_VEH_MESH_VRTCS_HEADLIGHTS[Global.VAR_VEH_MESH_EDGES_HEADLIGHTS[Global.VAR_VEH_MESH_i + 1]] * Global.VAR_VEH_MESH_Scale),
			Global.VAR_PLAYER_RACER.VAR_RACER_VEHICLE, Rotation And Translation),
			Global.VAR_PLAYER_RACER.VAR_ARRAY_CAR_PLAYER_FEEDBACKS[4], Visible To Position Radius and Color);
	}
}

rule("CAR BUILDING MECHANICS SUBROUTINE: CREATE CAR BODY BEAM: LEFT REAR LIGHT")
{
	event
	{
		Subroutine;
		SUB_VEH_CREATE_L_R_LIGHTS_BEAM;
	}

	actions
	{
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - PLAYER FEEDBACKS \n [5] - LEFT REAR LIGHT CURRENT COLOR"
		Create Beam Effect(Global.VAR_PLAYER_RACER.VAR_RACER_VEHICLE_VISIBLE_TO, Good Beam, World Vector Of(Evaluate Once(
			Global.VAR_VEH_MESH_VRTCS_L_R_LIGHTS[Global.VAR_VEH_MESH_EDGES_L_R_LIGHTS[Global.VAR_VEH_MESH_i]] * Global.VAR_VEH_MESH_Scale),
			Global.VAR_PLAYER_RACER.VAR_RACER_VEHICLE, Rotation And Translation), World Vector Of(Evaluate Once(
			Global.VAR_VEH_MESH_VRTCS_L_R_LIGHTS[Global.VAR_VEH_MESH_EDGES_L_R_LIGHTS[Global.VAR_VEH_MESH_i + 1]] * Global.VAR_VEH_MESH_Scale),
			Global.VAR_PLAYER_RACER.VAR_RACER_VEHICLE, Rotation And Translation),
			Global.VAR_PLAYER_RACER.VAR_ARRAY_CAR_PLAYER_FEEDBACKS[5], Visible To Position Radius and Color);
	}
}

rule("CAR BUILDING MECHANICS SUBROUTINE: CREATE CAR BODY BEAM: RIGHT REAR LIGHT")
{
	event
	{
		Subroutine;
		SUB_VEH_CREATE_R_R_LIGHTS_BEAM;
	}

	actions
	{
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - PLAYER FEEDBACKS \n [6] - RIGHT REAR LIGHT CURRENT COLOR"
		Create Beam Effect(Global.VAR_PLAYER_RACER.VAR_RACER_VEHICLE_VISIBLE_TO, Good Beam, World Vector Of(Evaluate Once(
			Global.VAR_VEH_MESH_VRTCS_R_R_LIGHTS[Global.VAR_VEH_MESH_EDGES_R_R_LIGHTS[Global.VAR_VEH_MESH_i]] * Global.VAR_VEH_MESH_Scale),
			Global.VAR_PLAYER_RACER.VAR_RACER_VEHICLE, Rotation And Translation), World Vector Of(Evaluate Once(
			Global.VAR_VEH_MESH_VRTCS_R_R_LIGHTS[Global.VAR_VEH_MESH_EDGES_R_R_LIGHTS[Global.VAR_VEH_MESH_i + 1]] * Global.VAR_VEH_MESH_Scale),
			Global.VAR_PLAYER_RACER.VAR_RACER_VEHICLE, Rotation And Translation),
			Global.VAR_PLAYER_RACER.VAR_ARRAY_CAR_PLAYER_FEEDBACKS[6], Visible To Position Radius and Color);
	}
}

rule("CAR BUILDING MECHANICS SUBROUTINE: CREATE CAR BODY BEAM: NITROUS")
{
	event
	{
		Subroutine;
		SUB_VEH_CREATE_NITROUS_BEAM;
	}

	actions
	{
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - PLAYER FEEDBACKS \n [2] - NITROUS CURRENT COLOR"
		Create Beam Effect(Global.VAR_PLAYER_RACER.VAR_RACER_VEHICLE_VISIBLE_TO, Good Beam, World Vector Of(Evaluate Once(
			Global.VAR_VEH_MESH_VRTCS_NITROUS[Global.VAR_VEH_MESH_EDGES_NITROUS[Global.VAR_VEH_MESH_i]] * Global.VAR_VEH_MESH_Scale),
			Global.VAR_PLAYER_RACER.VAR_RACER_VEHICLE, Rotation And Translation), World Vector Of(Evaluate Once(
			Global.VAR_VEH_MESH_VRTCS_NITROUS[Global.VAR_VEH_MESH_EDGES_NITROUS[Global.VAR_VEH_MESH_i + 1]] * Global.VAR_VEH_MESH_Scale),
			Global.VAR_PLAYER_RACER.VAR_RACER_VEHICLE, Rotation And Translation),
			Global.VAR_PLAYER_RACER.VAR_ARRAY_CAR_PLAYER_FEEDBACKS[2], Visible To Position Radius and Color);
	}
}

rule("CAR BUILDING MECHANICS SUBROUTINE: CREATE CAR BODY BEAM: CARBON")
{
	event
	{
		Subroutine;
		SUB_VEH_CREATE_CARBON_BEAM;
	}

	actions
	{
		"Old Beam Creation Method"
		Create Beam Effect(Global.VAR_PLAYER_RACER.VAR_RACER_VEHICLE_VISIBLE_TO, Grapple Beam, World Vector Of(Evaluate Once(
			Global.VAR_VEH_MESH_VRTCS_CARBON_PARTS[Global.VAR_VEH_MESH_EDGES_CARBON_PARTS[Global.VAR_VEH_MESH_i]] * Global.VAR_VEH_MESH_Scale),
			Global.VAR_PLAYER_RACER.VAR_RACER_VEHICLE, Rotation And Translation), World Vector Of(Evaluate Once(
			Global.VAR_VEH_MESH_VRTCS_CARBON_PARTS[Global.VAR_VEH_MESH_EDGES_CARBON_PARTS[Global.VAR_VEH_MESH_i + 1]] * Global.VAR_VEH_MESH_Scale),
			Global.VAR_PLAYER_RACER.VAR_RACER_VEHICLE, Rotation And Translation), Color(Gray), Visible To Position and Radius);
	}
}

disabled rule("HUD TEXTS TAB")
{
	event
	{
		Ongoing - Global;
	}
}

rule("HUD TEXTS: CREATE RACER HUD")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Has Spawned(Event Player) == True;
		Global.VAR_GLB_VEHICLE_DEPLOY_STATUS == Custom String("DEPLOYED");
		Event Player.VAR_PLAYER_IS_RACER == True;
	}

	actions
	{
		"COUNTDOWN TEXT"
		Create In-World Text(Event Player, Global.VAR_GPL_RACE_COUNTERS_STRINGS[Global.VAR_GPL_RACE_CURR_COUNTDOWN], Update Every Frame(
			Position Of(Event Player.VAR_RACER_VEHICLE) + World Vector Of(Vector(0, 2, 5), Event Player.VAR_RACER_VEHICLE, Rotation)), 4,
			Clip Against Surfaces, Visible To Position String and Color, Custom Color(255, 255, 255, Global.VAR_GPL_RACE_VSL_COUNTDOWN_A),
			Default Visibility);
		Call Subroutine(SUB_GPL_VSL_CREATE_HUD);
	}
}

rule("HUD TEXTS SUBROUTINE: CREATE UI FOR RACER (SHOWS ONLY WHEN PLAYER ENTERS THE VEHICLE)")
{
	event
	{
		Subroutine;
		SUB_GPL_VSL_CREATE_HUD;
	}

	actions
	{
		Wait(0.200, Ignore Condition);
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ GLOBAL \\ ARRAY TABLE - IN-GAME STRINGS \n [14] - SCORE:"
		Create HUD Text(Event Player.VAR_RACER_HUD, Null, Null, Custom String("{0} {1}", Global.VAR_GLB_ARRAY_STRING_IN_GAME[14],
			Event Player.VAR_STUNTS_SCORE), Left, 1, Color(White), Color(White), Color(White), Visible To String and Color,
			Default Visibility);
		"FOR INDEXES REFER TO: MENU \\ ARRAY TABLE - INTERNAL STORAGE VARIABLE \n [10] - SCORE CONDITION:"
		If(Global.VAR_GBL_INTRNL_STORED_VALUES[10] == 1);
			"FOR INDEXES REFER TO: MENU \\ ARRAY TABLE - INTERNAL STORAGE VARIABLE \n [11] - SCORE THRESHOLD:"
			Create HUD Text(Event Player.VAR_RACER_HUD, Custom String(" {0} {1} / {2}", Event Player.VAR_VSL_HUD_TGT_SCORE_ICON,
				Event Player.VAR_STUNTS_SCORE, Global.VAR_GBL_INTRNL_STORED_VALUES[11]), Null, Null, Left, 2,
				Event Player.VAR_VSL_HUD_TGT_SCORE_COLOR, Color(White), Color(White), Visible To String and Color, Default Visibility);
		End;
		Wait(0.100, Ignore Condition);
		"FOR INDEXES REFER TO: MENU \\ ARRAY TABLE - INTERNAL STORAGE VARIABLE \n [7] - CURRENT MODE:"
		If(Global.VAR_GBL_INTRNL_STORED_VALUES[7] > 0);
			"FOR INDEXES REFER TO: GAME IN PROGRESS \\ GLOBAL \\ ARRAY TABLE - IN-GAME STRINGS \n [15] - LAP:"
			Create HUD Text(Event Player.VAR_RACER_HUD, Custom String("{0} {1} / {2}", Global.VAR_GLB_ARRAY_STRING_IN_GAME[15],
				Event Player.VAR_GPL_MODE_CURRENT_LAP, Global.VAR_GBL_INTRNL_STORED_VALUES[8]), Null, Null, Right, 4, Color(White), Color(
				White), Color(White), Visible To String and Color, Default Visibility);
			"FOR INDEXES REFER TO: GAME IN PROGRESS \\ GLOBAL \\ ARRAY TABLE - IN-GAME STRINGS \n [19] - CLK (CLOCK):"
			Create HUD Text(Event Player.VAR_RACER_HUD, Custom String("{0}  {1}:{2}", Global.VAR_GLB_ARRAY_STRING_IN_GAME[19],
				Event Player.VAR_VSL_TXT_CLK_CLK_MINUTES, Event Player.VAR_VSL_TXT_CLK_CLK_SECONDS), Null, Null, Right, 0, Color(White), Color(
				White), Color(White), Visible To String and Color, Default Visibility);
			"FOR INDEXES REFER TO: GAME IN PROGRESS \\ GLOBAL \\ ARRAY TABLE - IN-GAME STRINGS \n [20] - LAP:"
			Create HUD Text(Event Player.VAR_RACER_HUD, Custom String("{0}  {1}:{2}", Global.VAR_GLB_ARRAY_STRING_IN_GAME[20],
				Event Player.VAR_VSL_TXT_CLK_LAP_MINUTES, Event Player.VAR_VSL_TXT_CLK_LAP_SECONDS), Null, Null, Right, 1, Color(White), Color(
				White), Color(White), Visible To String and Color, Default Visibility);
			"FOR INDEXES REFER TO: GAME IN PROGRESS \\ GLOBAL \\ ARRAY TABLE - IN-GAME STRINGS \n [21] - LST (LAST):"
			Create HUD Text(Event Player.VAR_RACER_HUD, Custom String("{0}  {1}:{2}", Global.VAR_GLB_ARRAY_STRING_IN_GAME[21],
				Event Player.VAR_VSL_TXT_CLK_LST_MINUTES, Event Player.VAR_VSL_TXT_CLK_LST_SECONDS), Null, Null, Right, 2, Color(White), Color(
				White), Color(White), Visible To String and Color, Default Visibility);
			"FOR INDEXES REFER TO: GAME IN PROGRESS \\ GLOBAL \\ ARRAY TABLE - IN-GAME STRINGS \n [22] - BST (BEST):"
			Create HUD Text(Event Player.VAR_RACER_HUD, Custom String("{0}  {1}:{2}", Global.VAR_GLB_ARRAY_STRING_IN_GAME[22],
				Event Player.VAR_VSL_TXT_CLK_BST_MINUTES, Event Player.VAR_VSL_TXT_CLK_BST_SECONDS), Null, Null, Right, 3,
				Event Player.VAR_VSL_HUD_CLK_BST_COLOR, Color(White), Color(White), Visible To String and Color, Default Visibility);
			"HUD TEXT GAP"
			Create HUD Text(Event Player.VAR_RACER_HUD, Null, Null, Custom String("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n"), Right,
				5, Color(White), Color(White), Color(White), Visible To and String, Default Visibility);
		Else;
			"HUD TEXT GAP"
			Create HUD Text(Event Player.VAR_RACER_HUD, Null, Null, Custom String(
				"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n"), Right, 5, Color(White), Color(White), Color(White),
				Visible To and String, Default Visibility);
		End;
		Wait(0.100, Ignore Condition);
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ GLOBAL \\ ARRAY TABLE - IN-GAME STRINGS \n [13] - RADIOSTATION:"
		Create HUD Text(Event Player.VAR_RACER_HUD, Custom String("{0} {1}", Global.VAR_GLB_ARRAY_STRING_IN_GAME[13],
			Global.VAR_MENU_ARRAY_STRING_RADIOS[Event Player.VAR_VEH_RADIO_CURR_VALUE]), Null, Null, Top, 0,
			Global.VAR_MENU_ARRAY_RADIO_COLOR_LIST[Event Player.VAR_VEH_RADIO_CURR_VALUE], Color(White), Color(White),
			Visible To String and Color, Default Visibility);
		"HUD TEXT GAP"
		Create HUD Text(Event Player.VAR_RACER_HUD, Null, Null, Custom String(
			"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n"), Top, 3, Color(White), Color(White), Color(White),
			Visible To and String, Default Visibility);
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - PLAYER FEEDBACKS \n [3] - NITROUS HUD CURRENT COLOR"
		Create Progress Bar HUD Text(Event Player.VAR_RACER_HUD, Event Player.VAR_NITROUS_CURR_VAL_TANK, Custom String("{0} NITROUS",
			Ability Icon String(Hero(Torbjörn), Button(Ultimate))), Top, 4, Event Player.VAR_ARRAY_CAR_PLAYER_FEEDBACKS[3],
			Event Player.VAR_ARRAY_CAR_PLAYER_FEEDBACKS[3], Visible To Values and Color, Default Visibility);
		"SPEEDOMETER"
	Create HUD Text(Event Player.VAR_RACER_HUD, Custom String("{0} {1} KM/H", Ability Icon String(Hero(Tracer), Button(Ability 1)),
		Speed Of In Direction(Event Player.VAR_RACER_VEHICLE, World Vector Of(Forward, Event Player.VAR_RACER_VEHICLE, Rotation))),
		Null, Null, Right, 6, Color(White), Color(White), Color(White), Visible To and String, Default Visibility);
		"CHASE STUNT: DRIFT"
		Wait(0.100, Ignore Condition);
		Create In-World Text(Event Player.VAR_RACER_HUD, Custom String("{0} {1} +{2}",
			Global.VAR_GLB_ARRAY_STRING_AWARD_LVL[Event Player.VAR_STUNT_CURR_VAL_DRIFT_LVL], Event Player.VAR_VSL_TXT_STUNT_DRIFT_STRING,
			Event Player.VAR_STUNT_CHASE_VAL_DRIFT_AWARD), Update Every Frame(Position Of(Event Player.VAR_RACER_VEHICLE)
			+ World Vector Of(Vector(Event Player.VAR_VSL_TXT_STUNT_CHASED_X, Event Player.VAR_VSL_TXT_STUNT_DRIFT_Y,
			Event Player.VAR_VSL_TXT_STUNT_DRIFT_CHASED_Z), Event Player.VAR_RACER_VEHICLE, Rotation)), 1.500, Do Not Clip,
			Visible To Position String and Color, Custom Color(255, Event Player.VAR_VSL_TXT_STUNT_CHASED_R,
			Event Player.VAR_VSL_TXT_STUNT_CHASED_R, Event Player.VAR_VSL_TXT_STUNT_DRIFT_CHASED_A), Default Visibility);
		"CHASE STUNT: AIR"
		Create In-World Text(Event Player.VAR_RACER_HUD, Custom String("{0} {1} +{2}",
			Global.VAR_GLB_ARRAY_STRING_AWARD_LVL[Event Player.VAR_STUNT_CURR_VAL_AIR_LVL], Global.VAR_GLB_ARRAY_STRING_STUNT[2],
			Event Player.VAR_STUNT_CHASE_VAL_AIR_AWARD), Update Every Frame(Position Of(Event Player.VAR_RACER_VEHICLE) + World Vector Of(
			Vector(Event Player.VAR_VSL_TXT_STUNT_CHASED_X, Event Player.VAR_VSL_TXT_STUNT_AIR_Y,
			Event Player.VAR_VSL_TXT_STUNT_AIR_CHASED_Z), Event Player.VAR_RACER_VEHICLE, Rotation)), 1.500, Do Not Clip,
			Visible To Position String and Color, Custom Color(255, Event Player.VAR_VSL_TXT_STUNT_CHASED_R,
			Event Player.VAR_VSL_TXT_STUNT_CHASED_R, Event Player.VAR_VSL_TXT_STUNT_AIR_CHASED_A), Default Visibility);
		"FOR INDEXES REFER TO: MENU \\ ARRAY TABLE - INTERNAL STORAGE VARIABLE \n [7] - CURRENT MODE:"
		If(Global.VAR_GBL_INTRNL_STORED_VALUES[7] == 2);
			"CHASE DYNAMITE TRIAL TIMER"
			Create In-World Text(Event Player, Custom String("{0} {1}", Icon String(Poison 2), Event Player.VAR_VAL_DT_MODE_CHASE_TIME),
				Update Every Frame(Position Of(Event Player.VAR_RACER_VEHICLE) + World Vector Of(Vector(0, Event Player.VAR_VSL_TXT_DT_TMR_Y,
				Event Player.VAR_VSL_TXT_DT_TMR_CHASED_Z), Event Player.VAR_RACER_VEHICLE, Rotation)), 1.500, Do Not Clip,
				Visible To Position String and Color, Custom Color(Event Player.VAR_VSL_TXT_DT_TMR_CHASED_R,
				Event Player.VAR_VSL_TXT_DT_TMR_CHASED_G, Event Player.VAR_VSL_TXT_DT_TMR_CHASED_B, 255), Default Visibility);
		End;
	}
}

rule("HUD TEXTS: HIDE RACER HUD")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_RACER_VEHICLE_IS_READY == True;
		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == False;
	}

	actions
	{
		Event Player.VAR_RACER_HUD = Null;
	}
}

rule("HUD TEXTS: SHOW RACER HUD")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_RACER_VEHICLE_IS_READY == True;
		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == True;
	}

	actions
	{
		Event Player.VAR_RACER_HUD = Event Player;
	}
}

disabled rule("CAMERA MECHANICS TAB")
{
	event
	{
		Ongoing - Global;
	}
}

rule("CAMERA MECHANICS: Look Back Trigger ON")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [5] - LOOK BACK TRIGGER"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[5] == True;
	}

	actions
	{
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAMERA MECHANICS \n [4] - CAMERA BLEND SPEED"
		Event Player.VAR_ARRAY_CAR_CAMERA_MECHANICS[4] = 0;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAMERA MECHANICS \n [5] - CAMERA VERTICAL ANGLE"
		Event Player.VAR_ARRAY_CAR_CAMERA_MECHANICS[5] = 0;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAMERA MECHANICS \n [6] - CAMERA TYPE STRING"
		If(Event Player.VAR_ARRAY_CAR_CAMERA_MECHANICS[6] == Custom String("CHASE_CAMERA"));
			"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAMERA MECHANICS \n [3] - CAMERA DIRECTION/DISTANCE"
			Event Player.VAR_ARRAY_CAR_CAMERA_MECHANICS[3] = 6;
			"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAMERA MECHANICS \n [6] - CAMERA TYPE STRING"
			Event Player.VAR_ARRAY_CAR_CAMERA_MECHANICS[6] = Custom String("CHASE_CAMERA_REV");
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAMERA MECHANICS \n [6] - CAMERA TYPE STRING"
		Else If(Event Player.VAR_ARRAY_CAR_CAMERA_MECHANICS[6] == Custom String("BUMPER_CAMERA"));
			"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAMERA MECHANICS \n [6] - CAMERA TYPE STRING"
			Event Player.VAR_ARRAY_CAR_CAMERA_MECHANICS[6] = Custom String("BUMPER_CAMERA_REV");
			"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAMERA MECHANICS \n [1] - CAMERA Y POSITION"
			Event Player.VAR_ARRAY_CAR_CAMERA_MECHANICS[1] = -1;
			"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAMERA MECHANICS \n [2] - CAMERA Z POSITION"
			Event Player.VAR_ARRAY_CAR_CAMERA_MECHANICS[2] = -0.250;
			"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAMERA MECHANICS \n [3] - CAMERA DIRECTION/DISTANCE"
			Event Player.VAR_ARRAY_CAR_CAMERA_MECHANICS[3] = 0.100;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAMERA MECHANICS"
		End;
	}
}

rule("CAMERA MECHANICS: Look Back Trigger OFF")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [5] - LOOK BACK TRIGGER"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[5] == False;
	}

	actions
	{
		Call Subroutine(SUB_VEH_CAMERA_SWITCH);
	}
}

rule("CAMERA MECHANICS: Switch Camera (Trigger)")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == True;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAMERA MECHANICS \n [6] - CAMERA TYPE STRING"
		Event Player.VAR_ARRAY_CAR_CAMERA_MECHANICS[6] != Custom String("CHASE_CAMERA_REV");
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [4] - FUNCTIONS"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[4] == Custom String("NAV_FUNC_SWITCH_CAMERA");
	}

	actions
	{
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAMERA MECHANICS \n [7] - CAMERA TYPE VALUE"
		Event Player.VAR_ARRAY_CAR_CAMERA_MECHANICS[7] += 1;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAMERA MECHANICS \n [7] - CAMERA TYPE VALUE"
		If(Event Player.VAR_ARRAY_CAR_CAMERA_MECHANICS[7] == 3);
			"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAMERA MECHANICS \n [7] - CAMERA TYPE VALUE"
			Event Player.VAR_ARRAY_CAR_CAMERA_MECHANICS[7] = 0;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAMERA MECHANICS"
		End;
		Call Subroutine(SUB_VEH_CAMERA_SWITCH);
		Call Subroutine(SUB_VEH_CAMERA_MESSAGE);
	}
}

rule("CAMERA MECHANICS SUBROUTINE: Switch Camera")
{
	event
	{
		Subroutine;
		SUB_VEH_CAMERA_SWITCH;
	}

	actions
	{
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAMERA MECHANICS \n [7] - CAMERA TYPE VALUE"
		If(Event Player.VAR_ARRAY_CAR_CAMERA_MECHANICS[7] == 0);
			Call Subroutine(SUB_VEH_CAMERA_CHASE);
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAMERA MECHANICS \n [7] - CAMERA TYPE VALUE"
		Else If(Event Player.VAR_ARRAY_CAR_CAMERA_MECHANICS[7] == 1);
			Call Subroutine(SUB_VEH_CAMERA_FREE);
		Else If(Event Player.VAR_ARRAY_CAR_CAMERA_MECHANICS[7] == 2);
			Call Subroutine(SUB_VEH_CAMERA_BUMPER);
		End;
		Event Player.VAR_VSL_TXT_STUNT_DRIFT_CHASED_Z = Event Player.VAR_VSL_TXT_ALL_BOUNCE_Z;
		Event Player.VAR_VSL_TXT_STUNT_AIR_CHASED_Z = Event Player.VAR_VSL_TXT_ALL_BOUNCE_Z;
		Event Player.VAR_VSL_TXT_DT_TMR_CHASED_Z = Event Player.VAR_VSL_TXT_ALL_BOUNCE_Z;
		Call Subroutine(SUB_VEH_INPUT_FUNC_COOLDOWN);
	}
}

rule("CAMERA MECHANICS SUBROUTINE: Start Camera")
{
	event
	{
		Subroutine;
		SUB_VEH_CAMERA_START;
	}

	actions
	{
		Call Subroutine(SUB_VEH_CAMERA_SWITCH);
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAMERA MECHANICS"
		Start Camera(Event Player, Update Every Frame(Ray Cast Hit Position(Eye Position(Event Player.VAR_ARRAY_CAR_CAMERA_MECHANICS[0])
			+ World Vector Of(Vector(0, Event Player.VAR_ARRAY_CAR_CAMERA_MECHANICS[1], Event Player.VAR_ARRAY_CAR_CAMERA_MECHANICS[2]),
			Event Player.VAR_ARRAY_CAR_CAMERA_MECHANICS[0], Rotation), Eye Position(Event Player.VAR_ARRAY_CAR_CAMERA_MECHANICS[0])
			+ World Vector Of(Vector(0, Event Player.VAR_ARRAY_CAR_CAMERA_MECHANICS[1], Event Player.VAR_ARRAY_CAR_CAMERA_MECHANICS[2]),
			Event Player.VAR_ARRAY_CAR_CAMERA_MECHANICS[0], Rotation)
			+ Event Player.VAR_ARRAY_CAR_CAMERA_MECHANICS[3] * Facing Direction Of(Event Player.VAR_ARRAY_CAR_CAMERA_MECHANICS[0]),
			Empty Array, Empty Array, False)), Update Every Frame(Eye Position(Event Player.VAR_ARRAY_CAR_CAMERA_MECHANICS[0])
			+ World Vector Of(Vector(0, Event Player.VAR_ARRAY_CAR_CAMERA_MECHANICS[1], Event Player.VAR_ARRAY_CAR_CAMERA_MECHANICS[2]),
			Event Player.VAR_ARRAY_CAR_CAMERA_MECHANICS[0], Rotation)), Event Player.VAR_ARRAY_CAR_CAMERA_MECHANICS[4]);
	}
}

rule("CAMERA MECHANICS SUBROUTINE: Chase Camera")
{
	event
	{
		Subroutine;
		SUB_VEH_CAMERA_CHASE;
	}

	actions
	{
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAMERA MECHANICS"
		Start Facing(Event Player, Facing Direction Of(Event Player.VAR_RACER_VEHICLE), 500, To World, Direction and Turn Rate);
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAMERA MECHANICS \n [0] - CAMERA FOCUS"
		Event Player.VAR_ARRAY_CAR_CAMERA_MECHANICS[0] = Event Player.VAR_RACER_VEHICLE;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAMERA MECHANICS \n [1] - CAMERA Y POSITION"
		Event Player.VAR_ARRAY_CAR_CAMERA_MECHANICS[1] = 0;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAMERA MECHANICS \n [2] - CAMERA Z POSITION"
		Event Player.VAR_ARRAY_CAR_CAMERA_MECHANICS[2] = 0;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAMERA MECHANICS \n [3] - CAMERA DIRECTION/DISTANCE"
		Event Player.VAR_ARRAY_CAR_CAMERA_MECHANICS[3] = -6;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAMERA MECHANICS \n [4] - CAMERA BLEND SPEED"
		Event Player.VAR_ARRAY_CAR_CAMERA_MECHANICS[4] = 25;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAMERA MECHANICS \n [5] - CAMERA VERTICAL ANGLE"
		Event Player.VAR_ARRAY_CAR_CAMERA_MECHANICS[5] = 4;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAMERA MECHANICS \n [6] - CAMERA TYPE STRING"
		Event Player.VAR_ARRAY_CAR_CAMERA_MECHANICS[6] = Custom String("CHASE_CAMERA");
		Event Player.VAR_VSL_TXT_STUNT_DRIFT_Y = 1.500;
		Event Player.VAR_VSL_TXT_STUNT_AIR_Y = 1.750;
		Event Player.VAR_VSL_TXT_DT_TMR_Y = 1.250;
		Event Player.VAR_VSL_TXT_ALL_DEST_Z = -2;
		Event Player.VAR_VSL_TXT_ALL_BOUNCE_Z = -1.500;
		Event Player.VAR_RACER_VEHICLE_VISIBLE_TO = All Players(All Teams);
	}
}

rule("CAMERA MECHANICS SUBROUTINE: Free Camera")
{
	event
	{
		Subroutine;
		SUB_VEH_CAMERA_FREE;
	}

	actions
	{
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAMERA MECHANICS"
		Stop Facing(Event Player);
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAMERA MECHANICS \n [0] - CAMERA FOCUS"
		Event Player.VAR_ARRAY_CAR_CAMERA_MECHANICS[0] = Event Player;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAMERA MECHANICS \n [3] - CAMERA DIRECTION/DISTANCE"
		Event Player.VAR_ARRAY_CAR_CAMERA_MECHANICS[3] = -6;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAMERA MECHANICS \n [4] - CAMERA BLEND SPEED"
		Event Player.VAR_ARRAY_CAR_CAMERA_MECHANICS[4] = 0;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAMERA MECHANICS \n [6] - CAMERA TYPE STRING"
		Event Player.VAR_ARRAY_CAR_CAMERA_MECHANICS[6] = Custom String("FREE_CAMERA");
	}
}

rule("CAMERA MECHANICS SUBROUTINE: Bumper Camera")
{
	event
	{
		Subroutine;
		SUB_VEH_CAMERA_BUMPER;
	}

	actions
	{
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAMERA MECHANICS"
		Start Facing(Event Player, Facing Direction Of(Event Player.VAR_RACER_VEHICLE), 500, To World, Direction and Turn Rate);
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAMERA MECHANICS \n [0] - CAMERA FOCUS"
		Event Player.VAR_ARRAY_CAR_CAMERA_MECHANICS[0] = Event Player.VAR_RACER_VEHICLE;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAMERA MECHANICS \n [1] - CAMERA Y POSITION"
		Event Player.VAR_ARRAY_CAR_CAMERA_MECHANICS[1] = -0.900;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAMERA MECHANICS \n [2] - CAMERA Z POSITION"
		Event Player.VAR_ARRAY_CAR_CAMERA_MECHANICS[2] = 0.250;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAMERA MECHANICS \n [3] - CAMERA DIRECTION/DISTANCE"
		Event Player.VAR_ARRAY_CAR_CAMERA_MECHANICS[3] = -0.100;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAMERA MECHANICS \n [4] - CAMERA BLEND SPEED"
		Event Player.VAR_ARRAY_CAR_CAMERA_MECHANICS[4] = 0;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAMERA MECHANICS \n [5] - CAMERA VERTICAL ANGLE"
		Event Player.VAR_ARRAY_CAR_CAMERA_MECHANICS[5] = 0;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAMERA MECHANICS \n [6] - CAMERA TYPE STRING"
		Event Player.VAR_ARRAY_CAR_CAMERA_MECHANICS[6] = Custom String("BUMPER_CAMERA");
		Event Player.VAR_VSL_TXT_STUNT_DRIFT_Y = -0.500;
		Event Player.VAR_VSL_TXT_STUNT_AIR_Y = 0.750;
		Event Player.VAR_VSL_TXT_DT_TMR_Y = 0.250;
		Event Player.VAR_VSL_TXT_ALL_DEST_Z = 8;
		Event Player.VAR_VSL_TXT_ALL_BOUNCE_Z = 7.500;
		Wait(0.010, Ignore Condition);
		Event Player.VAR_RACER_VEHICLE_VISIBLE_TO = Players In Slot(!Slot Of(Event Player), All Teams);
	}
}

rule("CAMERA MECHANICS SUBROUTINE: Message Camera Type")
{
	event
	{
		Subroutine;
		SUB_VEH_CAMERA_MESSAGE;
	}

	actions
	{
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAMERA MECHANICS \n [7] - CAMERA TYPE VALUE"
		Small Message(Event Player, Custom String("  {0} {1} ", Icon String(Warning),
			Global.VAR_GLB_ARRAY_STRING_CAMERA[Event Player.VAR_ARRAY_CAR_CAMERA_MECHANICS[7]]));
	}
}

disabled rule("CAR FUNCTIONS MECHANICS TAB")
{
	event
	{
		Ongoing - Global;
	}
}

rule("CAR FUNCTIONS MECHANICS: Turn On Car Engine")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_RACER_VEHICLE_IS_READY == True;
		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == True;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [6] - ENGINE STATUS"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[6] == 1;
	}

	actions
	{
		Call Subroutine(SUB_VEH_ENGINE_ON);
	}
}

rule("CAR FUNCTIONS MECHANICS: Turn Off Car Engine")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_RACER_VEHICLE_IS_READY == True;
		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == True;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [6] - ENGINE STATUS"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[6] == 2;
	}

	actions
	{
		Call Subroutine(SUB_VEH_ENGINE_OFF);
		Call Subroutine(SUB_VEH_STUNTS_BREAK);
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ GLOBAL \\ ARRAY TABLE - IN-GAME STRINGS"
		Small Message(Event Player, Custom String("  {0} {1} {2}", Icon String(Warning), Global.VAR_GLB_ARRAY_STRING_IN_GAME[3],
			Custom String("\"{0}\" {1} {2}", Input Binding String(Button(Melee)), Global.VAR_GLB_ARRAY_STRING_IN_GAME[4], Custom String(
			"\"{0}\" {1}", Input Binding String(Button(Reload)), Global.VAR_GLB_ARRAY_STRING_IN_GAME[5]))));
	}
}

rule("CAR FUNCTIONS MECHANICS: Select Next Radio")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [4] - FUNCTIONS"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[4] == Custom String("NAV_FUNC_NEXT_RADIO");
		Event Player.VAR_VEH_RADIO_CURR_VALUE != 7;
	}

	actions
	{
		Event Player.VAR_VEH_RADIO_CURR_VALUE += 1;
	}
}

rule("CAR FUNCTIONS MECHANICS: Select Prev Radio")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [4] - FUNCTIONS"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[4] == Custom String("NAV_FUNC_PREV_RADIO");
		Event Player.VAR_VEH_RADIO_CURR_VALUE != 1;
	}

	actions
	{
		Event Player.VAR_VEH_RADIO_CURR_VALUE -= 1;
	}
}

rule("CAR FUNCTIONS MECHANICS: NOTIFY PLAYER TO ENTER VEHICLE")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_RACER_VEHICLE_IS_READY == True;
		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == False;
		Distance Between(Event Player, Event Player.VAR_RACER_VEHICLE) <= 3;
	}

	actions
	{
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ GLOBAL \\ ARRAY TABLE - IN-GAME STRINGS"
		Small Message(Event Player, Custom String("  {0} {1} {2}", Icon String(Warning), Global.VAR_GLB_ARRAY_STRING_IN_GAME[6],
			Custom String("\"{0}\" {1}", Button(Interact), Global.VAR_GLB_ARRAY_STRING_IN_GAME[7])));
	}
}

disabled rule("VEHICLE MECHANICS TAB")
{
	event
	{
		Ongoing - Global;
	}
}

rule("VEHICLE MECHANICS: PLAYER ENTERED VEHICLE")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_RACER_VEHICLE_IS_READY == True;
		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == True;
	}

	actions
	{
		Wait(0.100, Ignore Condition);
		Call Subroutine(SUB_VEH_CAMERA_SWITCH);
		Call Subroutine(SUB_VEH_CAMERA_START);
		Start Forcing Player Position(Event Player, Update Every Frame(Eye Position(Event Player.VAR_RACER_VEHICLE)), True);
		Start Scaling Player(Event Player, 0.100, True);
		Set Invisible(Event Player, All);
		Disable Movement Collision With Environment(Event Player, True);
		Disable Movement Collision With Players(Event Player);
		Disallow Button(Event Player, Button(Jump));
	}
}

rule("VEHICLE MECHANICS: PLAYER EXITED VEHICLE")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_RACER_VEHICLE_IS_READY == True;
		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == False;
	}

	actions
	{
		Wait(0.050, Ignore Condition);
		Stop Camera(Event Player);
		Stop Forcing Player Position(Event Player);
		Stop Scaling Player(Event Player);
		Set Invisible(Event Player, None);
		Stop Facing(Event Player);
		Enable Movement Collision With Environment(Event Player);
		Enable Movement Collision With Players(Event Player);
		Allow Button(Event Player, Button(Jump));
		Set Gravity(Event Player, 100);
		Call Subroutine(SUB_VEH_STUNTS_BREAK);
	}
}

rule("VEHICLE MECHANICS SUBROUTINE: ENGINE ON")
{
	event
	{
		Subroutine;
		SUB_VEH_ENGINE_ON;
	}

	actions
	{
		Start Throttle In Direction(Event Player.VAR_RACER_VEHICLE, World Vector Of(Vector(Event Player.VAR_VEH_DRIFT_GRIP, 0,
			Event Player.VAR_VEH_ACCELER_DIRECTION), Event Player.VAR_RACER_VEHICLE, Rotation), Event Player.VAR_VEH_ACCELER_THROTTLE,
			To World, Add to existing throttle, Direction and Magnitude);
		"RESET DRIFT STUNT LEVEL TO 0"
		Event Player.VAR_STUNT_CURR_VAL_DRIFT_LVL = 0;
		"RESET AIR STUNT LEVEL TO 0"
		Event Player.VAR_STUNT_CURR_VAL_AIR_LVL = 0;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - VEHICLE MECHANICS \n [0] - ACCELERATION - DESTINATION (RECEIVER) \n [1] - ACCELERATION - RATE (RECEIVER)"
		Chase Player Variable At Rate(Event Player, VAR_VEH_ACCELER_THROTTLE, First Of(Event Player.VAR_ARRAY_CAR_MECHANICS),
			Event Player.VAR_ARRAY_CAR_MECHANICS[1], Destination and Rate);
		"CAR DRIFTING"
		Chase Player Variable At Rate(Event Player, VAR_VEH_DRIFT_GRIP, Event Player.VAR_VEH_GRIP_DEST, Event Player.VAR_VEH_GRIP_RATE,
			Destination and Rate);
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - NITROUS MECHANICS \n [0] - NITROUS DESTINATION \n [1] - NITROUS CURRENT DEPLETION / REGEN RATE"
		Chase Player Variable At Rate(Event Player, VAR_NITROUS_CURR_VAL_TANK, First Of(Event Player.VAR_NITROUS_ARRAY_MECHANICS),
			Event Player.VAR_NITROUS_ARRAY_MECHANICS[1], Destination and Rate);
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - PLAYER FEEDBACKS - ARRAY TABLE - LIGHT CUSTOMIZATION STORED \n [4] - HEADLIGHTS CURRENT COLOR \n [1] - HEADLIGHTS COLOR"
		Event Player.VAR_ARRAY_CAR_PLAYER_FEEDBACKS[4] = Event Player.VAR_VEH_ARRAY_LIGHT_STORED[1];
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - PLAYER FEEDBACKS - ARRAY TABLE - LIGHT CUSTOMIZATION STORED \n [5] - LEFT REAR LIGHT CURRENT COLOR \n [2] - REAR LIGHTS COLOR"
		Event Player.VAR_ARRAY_CAR_PLAYER_FEEDBACKS[5] = Event Player.VAR_VEH_ARRAY_LIGHT_STORED[2];
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - PLAYER FEEDBACKS - ARRAY TABLE - LIGHT CUSTOMIZATION STORED \n [6] - RIGHT REAR LIGHT CURRENT COLOR \n [2] - REAR LIGHTS COLOR"
		Event Player.VAR_ARRAY_CAR_PLAYER_FEEDBACKS[6] = Event Player.VAR_VEH_ARRAY_LIGHT_STORED[2];
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [6] - ENGINE STATUS"
		Call Subroutine(SUB_VEH_STEERING_ON);
	}
}

rule("VEHICLE MECHANICS SUBROUTINE: ENGINE OFF")
{
	event
	{
		Subroutine;
		SUB_VEH_ENGINE_OFF;
	}

	actions
	{
		Stop Throttle In Direction(Event Player.VAR_RACER_VEHICLE);
		Call Subroutine(SUB_VEH_STEERING_OFF);
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - VEHICLE MECHANICS \n [0] - ACCELERATION - DESTINATION (RECEIVER)"
		Event Player.VAR_ARRAY_CAR_MECHANICS[0] = 0;
		Event Player.VAR_VSL_STUNT_DRIFT_TRIGGER = False;
		Event Player.VAR_VSL_STUNT_AIR_TRIGGER = False;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - PLAYER FEEDBACKS \n [4] - HEADLIGHTS CURRENT COLOR"
		Event Player.VAR_ARRAY_CAR_PLAYER_FEEDBACKS[4] = Color(Black);
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - PLAYER FEEDBACKS \n [5] - LEFT REAR LIGHT CURRENT COLOR"
		Event Player.VAR_ARRAY_CAR_PLAYER_FEEDBACKS[5] = Color(Black);
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - PLAYER FEEDBACKS \n [6] - RIGHT REAR LIGHT CURRENT COLOR"
		Event Player.VAR_ARRAY_CAR_PLAYER_FEEDBACKS[6] = Color(Black);
		Call Subroutine(SUB_VEH_NITROUS_STOP);
		Stop Chasing Player Variable(Event Player, VAR_NITROUS_CURR_VAL_TANK);
	}
}

rule("VEHICLE MECHANICS SUBROUTINE: STEERING ON")
{
	event
	{
		Subroutine;
		SUB_VEH_STEERING_ON;
	}

	actions
	{
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [7] - STEERING ENABLED"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[7] = True;
		Event Player.VAR_VEH_FACING = Horizontal Facing Angle Of(Event Player.VAR_RACER_VEHICLE);
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAMERA MECHANICS \n [5] - CAMERA VERTICAL ANGLE"
		Start Facing(Event Player.VAR_RACER_VEHICLE, Update Every Frame(Direction From Angles(Event Player.VAR_VEH_FACING,
			Event Player.VAR_ARRAY_CAR_CAMERA_MECHANICS[5])), Event Player.VAR_VEH_STEERING_CNTR_VALUE, To World, Direction and Turn Rate);
		"CAR STEERING"
		Chase Player Variable At Rate(Event Player, VAR_VEH_FACING, Event Player.VAR_VEH_STEERING_DIRECTION,
			Event Player.VAR_VEH_STEERING_CNTR_VALUE, Destination and Rate);
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - VEHICLE MECHANICS \n [2] - MAIN STEERING ACCELERATION - DESTINATION (RECEIVER) \n [5] -  MAIN STEERING ACCELERATION - RATE (RECEIVER)"
		Chase Player Variable At Rate(Event Player, VAR_VEH_STEERING_CNTR_VALUE,
			Event Player.VAR_VEH_ACCELER_THROTTLE * Event Player.VAR_ARRAY_CAR_MECHANICS[2], Event Player.VAR_ARRAY_CAR_MECHANICS[5],
			Destination and Rate);
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - VEHICLE MECHANICS \n [3] - LEFT STEERING ACCELERATION - DESTINATION (RECEIVER) \n [5] -  MAIN STEERING ACCELERATION - RATE (RECEIVER)"
		Chase Player Variable At Rate(Event Player, VAR_VEH_STEERING_LEFT_VALUE,
			Event Player.VAR_VEH_ACCELER_THROTTLE * Event Player.VAR_ARRAY_CAR_MECHANICS[3], Event Player.VAR_ARRAY_CAR_MECHANICS[5],
			Destination and Rate);
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - VEHICLE MECHANICS \n [4] - RIGHT STEERING ACCELERATION - DESTINATION (RECEIVER) \n [5] - MAIN STEERING ACCELERATION - RATE (RECEIVER)"
		Chase Player Variable At Rate(Event Player, VAR_VEH_STEERING_RIGHT_VALUE,
			Event Player.VAR_VEH_ACCELER_THROTTLE * Event Player.VAR_ARRAY_CAR_MECHANICS[4], Event Player.VAR_ARRAY_CAR_MECHANICS[5],
			Destination and Rate);
	}
}

rule("VEHICLE MECHANICS SUBROUTINE: STEERING OFF")
{
	event
	{
		Subroutine;
		SUB_VEH_STEERING_OFF;
	}

	actions
	{
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [7] - STEERING ENABLED"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[7] = False;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - VEHICLE MECHANICS \n [5] - LEFT STEERING ACCELERATION - DESTINATION (RECEIVER)"
		Event Player.VAR_ARRAY_CAR_MECHANICS[5] = 0;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - VEHICLE MECHANICS \n [6] - MAIN STEERING ACCELERATION - DESTINATION (RECEIVER)"
		Event Player.VAR_ARRAY_CAR_MECHANICS[6] = 0;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - VEHICLE MECHANICS \n [7] - RIGHT STEERING ACCELERATION - DESTINATION (RECEIVER)"
		Event Player.VAR_ARRAY_CAR_MECHANICS[7] = 0;
	}
}

disabled rule("CAR ACCELERATION MECHANICS TAB (FOR INDEXES REFER TO: ARRAY TABLE - VEHICLE MECHANICS)")
{
	event
	{
		Ongoing - Global;
	}
}

rule("CAR ACCELERATION MECHANICS: Set Acceleration Direction to Forward")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == True;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [0] - ACCELERATION STRING"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[0] == Custom String("NAV_ACC_ACCELERATING");
		Speed Of In Direction(Event Player.VAR_RACER_VEHICLE, World Vector Of(Backward, Event Player.VAR_RACER_VEHICLE, Rotation)) < 0.100;
	}

	actions
	{
		Event Player.VAR_VEH_ACCELER_DIRECTION = 1;
		If(Hero Of(Event Player) == Hero(Lúcio));
			Event Player.VAR_VEH_MOVE_SPEED = 75.500;
		Else;
			Event Player.VAR_VEH_MOVE_SPEED = 100;
		End;
		Set Move Speed(Event Player.VAR_RACER_VEHICLE, Event Player.VAR_VEH_MOVE_SPEED);
	}
}

rule("CAR ACCELERATION MECHANICS: Accelerate Car")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == True;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [0] - ACCELERATION STRING"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[0] == Custom String("NAV_ACC_ACCELERATING");
		Event Player.VAR_VEH_ACCELER_DIRECTION == 1;
	}

	actions
	{
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - VEHICLE MECHANICS \n [0] - ACCELERATION - DESTINATION (RECEIVER)"
		Event Player.VAR_ARRAY_CAR_MECHANICS[0] = 1;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - VEHICLE MECHANICS \n [1] - ACCELERATION - RATE (RECEIVER)"
		Event Player.VAR_ARRAY_CAR_MECHANICS[1] = 1.500;
	}
}

rule("CAR ACCELERATION MECHANICS: Acceleration Throttle Released")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == True;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [0] - ACCELERATION STRING"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[0] == Custom String("NAV_ACC_RELEASED");
	}

	actions
	{
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - VEHICLE MECHANICS \n [0] - ACCELERATION - DESTINATION (RECEIVER)"
		Event Player.VAR_ARRAY_CAR_MECHANICS[0] = 0;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - VEHICLE MECHANICS \n [1] - ACCELERATION - RATE (RECEIVER)"
		Event Player.VAR_ARRAY_CAR_MECHANICS[1] = 0.250;
	}
}

rule("CAR ACCELERATION MECHANICS: Brake Car (Decelerate)")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == True;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [0] - ACCELERATION STRING"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[0] == Custom String("NAV_ACC_REVERSING");
		Event Player.VAR_VEH_ACCELER_DIRECTION == 1;
	}

	actions
	{
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - VEHICLE MECHANICS \n [0] - ACCELERATION - DESTINATION (RECEIVER)"
		Event Player.VAR_ARRAY_CAR_MECHANICS[0] = 0;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - VEHICLE MECHANICS \n [1] - ACCELERATION - RATE (RECEIVER)"
		Event Player.VAR_ARRAY_CAR_MECHANICS[1] = 1;
	}
}

rule("CAR ACCELERATION MECHANICS: Set Acceleration Direction to Backward")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == True;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [0] - ACCELERATION STRING"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[0] == Custom String("NAV_ACC_REVERSING");
		Speed Of In Direction(Event Player.VAR_RACER_VEHICLE, World Vector Of(Forward, Event Player.VAR_RACER_VEHICLE, Rotation)) < 0.100;
	}

	actions
	{
		Call Subroutine(SUB_VEH_CHASE_GRIP_RESET_BOOST);
		Event Player.VAR_VEH_ACCELER_DIRECTION = -1;
		If(Hero Of(Event Player) == Hero(Lúcio));
			Event Player.VAR_VEH_MOVE_SPEED = 50.500;
		Else;
			Event Player.VAR_VEH_MOVE_SPEED = 75;
		End;
		Set Move Speed(Event Player.VAR_RACER_VEHICLE, Event Player.VAR_VEH_MOVE_SPEED);
	}
}

rule("CAR ACCELERATION MECHANICS: Reverse Car")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == True;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [0] - ACCELERATION STRING"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[0] == Custom String("NAV_ACC_REVERSING");
		Event Player.VAR_VEH_ACCELER_DIRECTION == -1;
	}

	actions
	{
		Call Subroutine(SUB_VEH_CHASE_GRIP_RESET_BOOST);
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - VEHICLE MECHANICS \n [0] - ACCELERATION - DESTINATION (RECEIVER)"
		Event Player.VAR_ARRAY_CAR_MECHANICS[0] = 1;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - VEHICLE MECHANICS \n [1] - ACCELERATION - RATE (RECEIVER)"
		Event Player.VAR_ARRAY_CAR_MECHANICS[1] = 0.750;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [8] - BLINKERS ENABLED"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[8] = False;
	}
}

rule("CAR ACCELERATION MECHANICS: Brake Car (Accelerate)")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == True;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [0] - ACCELERATION STRING"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[0] == Custom String("NAV_ACC_ACCELERATING");
		Event Player.VAR_VEH_ACCELER_DIRECTION == -1;
	}

	actions
	{
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - VEHICLE MECHANICS \n [0] - ACCELERATION - DESTINATION (RECEIVER)"
		Event Player.VAR_ARRAY_CAR_MECHANICS[0] = 0;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - VEHICLE MECHANICS \n [1] - ACCELERATION - RATE (RECEIVER)"
		Event Player.VAR_ARRAY_CAR_MECHANICS[1] = 1;
	}
}

disabled rule("CAR TURNING MECHANICS")
{
	event
	{
		Ongoing - Global;
	}
}

rule("CAR TURNING MECHANICS: Turn Left (Steering Reset Boost)")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == True;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [1] - STEERING STRING"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[1] == Custom String("NAV_STEER_LEFT");
		Event Player.VAR_VEH_STEERING_RIGHT_VALUE > 0;
	}

	actions
	{
		Call Subroutine(SUB_VEH_CHASE_STEER_RESET_BOOST);
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - VEHICLE MECHANICS - ARRAY TABLE - VEHICLE MECHANICS VALUES \n [5] -  MAIN STEERING ACCELERATION - RATE (RECEIVER) \n [3] - MAIN STEERING ACCELERATION - RATE (BOOSTED)"
		Event Player.VAR_ARRAY_CAR_MECHANICS[5] = Event Player.VAR_ARRAY_CAR_MECHANICS_VALUES[3];
	}
}

rule("CAR TURNING MECHANICS: Turn Left")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == True;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [1] - STEERING STRING"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[1] == Custom String("NAV_STEER_LEFT");
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [3] - HANDBRAKE PULLED"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[3] == False;
		Event Player.VAR_VEH_STEERING_RIGHT_VALUE == 0;
	}

	actions
	{
		Event Player.VAR_VSL_TXT_STUNT_X_POS = 2.500;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - VEHICLE MECHANICS - ARRAY TABLE - VEHICLE MECHANICS VALUES \n [2] - MAIN STEERING ACCELERATION - DESTINATION (RECEIVER) \n [0] - MAIN STEERING ACCELERATION - DESTINATION (REGULAR)"
		Event Player.VAR_ARRAY_CAR_MECHANICS[2] = Global.VAR_PLAYER_RACER.VAR_ARRAY_CAR_MECHANICS_VALUES[0];
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - VEHICLE MECHANICS - ARRAY TABLE - VEHICLE MECHANICS VALUES \n [3] - LEFT STEERING ACCELERATION - DESTINATION (RECEIVER) \n [0] - MAIN STEERING ACCELERATION - DESTINATION (REGULAR)"
		Event Player.VAR_ARRAY_CAR_MECHANICS[3] = Global.VAR_PLAYER_RACER.VAR_ARRAY_CAR_MECHANICS_VALUES[0];
	}
}

rule("CAR TURNING MECHANICS: Turn Right (Steering Reset Boost)")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == True;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [1] - STEERING STRING"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[1] == Custom String("NAV_STEER_RIGHT");
		Event Player.VAR_VEH_STEERING_LEFT_VALUE > 0;
	}

	actions
	{
		Call Subroutine(SUB_VEH_CHASE_STEER_RESET_BOOST);
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - VEHICLE MECHANICS - ARRAY TABLE - VEHICLE MECHANICS VALUES \n [5] -  MAIN STEERING ACCELERATION - RATE (RECEIVER) \n [3] - MAIN STEERING ACCELERATION - RATE (BOOSTED)"
		Event Player.VAR_ARRAY_CAR_MECHANICS[5] = Event Player.VAR_ARRAY_CAR_MECHANICS_VALUES[3];
	}
}

rule("CAR TURNING MECHANICS: Turn Right")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == True;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [1] - STEERING STRING"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[1] == Custom String("NAV_STEER_RIGHT");
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [3] - HANDBRAKE PULLED"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[3] == False;
		Event Player.VAR_VEH_STEERING_LEFT_VALUE == 0;
	}

	actions
	{
		Event Player.VAR_VSL_TXT_STUNT_X_POS = -2.500;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - VEHICLE MECHANICS - ARRAY TABLE - VEHICLE MECHANICS VALUES \n [2] - MAIN STEERING ACCELERATION - DESTINATION (RECEIVER) \n [0] - MAIN STEERING ACCELERATION - DESTINATION (REGULAR)"
		Event Player.VAR_ARRAY_CAR_MECHANICS[2] = Global.VAR_PLAYER_RACER.VAR_ARRAY_CAR_MECHANICS_VALUES[0];
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - VEHICLE MECHANICS - ARRAY TABLE - VEHICLE MECHANICS VALUES \n [4] - RIGHT STEERING ACCELERATION - DESTINATION (RECEIVER) \n [0] - MAIN STEERING ACCELERATION - DESTINATION (REGULAR)"
		Event Player.VAR_ARRAY_CAR_MECHANICS[4] = Global.VAR_PLAYER_RACER.VAR_ARRAY_CAR_MECHANICS_VALUES[0];
	}
}

rule("CAR TURNING MECHANICS SUBROUTINE: Steering Reset Boost")
{
	event
	{
		Subroutine;
		SUB_VEH_CHASE_STEER_RESET_BOOST;
	}

	actions
	{
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - VEHICLE MECHANICS \n [2] - MAIN STEERING ACCELERATION - DESTINATION (RECEIVER)"
		Event Player.VAR_ARRAY_CAR_MECHANICS[2] = 0;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - VEHICLE MECHANICS \n [3] - LEFT STEERING ACCELERATION - DESTINATION (RECEIVER)"
		Event Player.VAR_ARRAY_CAR_MECHANICS[3] = 0;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - VEHICLE MECHANICS \n [4] - RIGHT STEERING ACCELERATION - DESTINATION (RECEIVER)"
		Event Player.VAR_ARRAY_CAR_MECHANICS[4] = 0;
	}
}

rule("CAR TURNING MECHANICS: Turn Cycle Degree Plus Trigger")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == True;
		Event Player.VAR_VEH_FACING == 180;
	}

	actions
	{
		Event Player.VAR_VEH_FACING = -179.500;
	}
}

rule("CAR TURNING MECHANICS: Turn Cycle Degree Minus Trigger")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == True;
		Event Player.VAR_VEH_FACING == -180;
	}

	actions
	{
		Event Player.VAR_VEH_FACING = 179.500;
	}
}

rule("CAR TURNING MECHANICS: Stop Turning")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == True;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [1] - STEERING STRING"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[1] == Custom String("NAV_STEER_RESET");
	}

	actions
	{
		Call Subroutine(SUB_VEH_CHASE_STEER_RESET_BOOST);
		Event Player.VAR_VEH_GRIP_DEST = 0;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - VEHICLE MECHANICS - ARRAY TABLE - VEHICLE MECHANICS VALUES \n [5] -  MAIN STEERING ACCELERATION - RATE (RECEIVER) \n [4] - MAIN STEERING ACCELERATION - RATE (RELEASED)"
		Event Player.VAR_ARRAY_CAR_MECHANICS[5] = Event Player.VAR_ARRAY_CAR_MECHANICS_VALUES[4];
	}
}

disabled rule("CAR DRIFTING MECHANICS")
{
	event
	{
		Ongoing - Global;
	}
}

rule("CAR DRIFTING MECHANICS: Enter Drift")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{

		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == True;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [0] - ACCELERATION STRING"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[0] == Custom String("NAV_ACC_REVERSING");
		Event Player.VAR_VEH_ACCELER_DIRECTION == 1;
		Event Player.VAR_VEH_DRIFT_TRIGGER != True;
		Event Player.VAR_VEH_STEERING_CNTR_VALUE >= 10;
		Is In Air(Event Player.VAR_RACER_VEHICLE) == False;
	}

	actions
	{
		Event Player.VAR_VEH_DRIFT_TRIGGER = True;
		Call Subroutine(SUB_VEH_STUNTS_SCORE_AND_RESET);
		Event Player.VAR_STUNT_DRIFT_AWARD_TRIGGER = True;
	}
}

rule("CAR DRIFTING MECHANICS: Start Drift (Add Gas)")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == True;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [0] - ACCELERATION STRING"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[0] == Custom String("NAV_ACC_ACCELERATING");
		Event Player.VAR_VEH_DRIFT_TRIGGER == True;
		Is In Air(Event Player.VAR_RACER_VEHICLE) == False;
	}

	actions
	{
		Event Player.VAR_VEH_GRIP_RATE = 0.750;
	}
}

rule("CAR DRIFTING MECHANICS: Start Recovering Grip")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == True;
		Event Player.VAR_VEH_DRIFT_TRIGGER == True;
		Event Player.VAR_VEH_GRIP_RECOVER_TRIGGER == False;
		(Event Player.VAR_VEH_DRIFT_GRIP >= 0.150 || Event Player.VAR_VEH_DRIFT_GRIP <= -0.150) == True;
	}

	actions
	{
		Event Player.VAR_VEH_GRIP_RECOVER_TRIGGER = True;
		If(Global.VAR_TEST_DRIFT_GRIP_CHECK_BOOL == True);
			Global.VAR_TEST_DRIFT_GRIP_STRINGS = Custom String("  {0} Grip Lost ", Icon String(Warning));
		End;
	}
}

rule("CAR DRIFTING MECHANICS: Recover Grip (Braking)")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == True;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [0] - ACCELERATION STRING"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[0] == Custom String("NAV_ACC_REVERSING");
		Event Player.VAR_VEH_GRIP_RECOVER_TRIGGER == True;
	}

	actions
	{
		Event Player.VAR_VEH_GRIP_DEST = 0;
		Event Player.VAR_VEH_GRIP_RATE = 1;
	}
}

rule("CAR DRIFTING MECHANICS: Recover Grip (Throttle Released)")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == True;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [0] - ACCELERATION STRING"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[0] == Custom String("NAV_ACC_RELEASED");
		Event Player.VAR_VEH_GRIP_RECOVER_TRIGGER == True;
		Is In Air(Event Player) == False;
	}

	actions
	{
		Event Player.VAR_VEH_GRIP_DEST = 0;
		Event Player.VAR_VEH_GRIP_RATE = 0.150;
	}
}

rule("CAR DRIFTING MECHANICS: Recover Grip")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == True;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [0] - ACCELERATION STRING"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[0] != Custom String("NAV_ACC_REVERSING");
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [3] - HANDBRAKE PULLED"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[3] != True;
		Event Player.VAR_VEH_DRIFT_TRIGGER == True;
		Event Player.VAR_VEH_GRIP_RECOVER_TRIGGER == True;
		(Global.VAR_PLAYER_RACER.VAR_VEH_DRIFT_GRIP <= 0.100 && Global.VAR_PLAYER_RACER.VAR_VEH_DRIFT_GRIP >= -0.100) == True;
	}

	actions
	{
		Wait(0.250, Abort When False);
		If(Global.VAR_TEST_DRIFT_GRIP_CHECK_BOOL == True);
			Global.VAR_TEST_DRIFT_GRIP_STRINGS = Custom String("  {0} Grip Recovered ", Icon String(Checkmark));
		End;
		Call Subroutine(SUB_VEH_CHASE_GRIP_RESET_BOOST);
	}
}

rule("CAR DRIFTING MECHANICS: Recover Grip When Not Entered Into Drift")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == True;
		Event Player.VAR_VEH_DRIFT_TRIGGER == True;
		Event Player.VAR_VEH_GRIP_RECOVER_TRIGGER == False;
	}

	actions
	{
		Wait(0.500, Abort When False);
		Call Subroutine(SUB_VEH_CHASE_GRIP_RESET_BOOST);
	}
}

rule("CAR DRIFTING MECHANICS: Drift Left Trigger")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == True;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [0] - ACCELERATION STRING"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[0] == Custom String("NAV_ACC_ACCELERATING");
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [1] - STEERING STRING"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[1] == Custom String("NAV_STEER_LEFT");
		Event Player.VAR_VEH_DRIFT_TRIGGER == True;
		Is In Air(Event Player.VAR_RACER_VEHICLE) == False;
	}

	actions
	{
		Event Player.VAR_VEH_GRIP_DEST = -1;
	}
}

rule("CAR DRIFTING MECHANICS: Drift Right Trigger")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == True;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [0] - ACCELERATION STRING"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[0] == Custom String("NAV_ACC_ACCELERATING");
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [1] - STEERING STRING"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[1] == Custom String("NAV_STEER_RIGHT");
		Event Player.VAR_VEH_DRIFT_TRIGGER == True;
		Is In Air(Event Player.VAR_RACER_VEHICLE) == False;
	}

	actions
	{
		Event Player.VAR_VEH_GRIP_DEST = 1;
	}
}

rule("CAR DRIFTING MECHANICS SUBROUTINE: Grip Reset Boost")
{
	event
	{
		Subroutine;
		SUB_VEH_CHASE_GRIP_RESET_BOOST;
	}

	actions
	{
		Global.VAR_PLAYER_RACER.VAR_VEH_GRIP_DEST = 0;
		Global.VAR_PLAYER_RACER.VAR_VEH_GRIP_RATE = 1;
		Global.VAR_PLAYER_RACER.VAR_VEH_DRIFT_TRIGGER = False;
		Global.VAR_PLAYER_RACER.VAR_VEH_GRIP_RECOVER_TRIGGER = False;
	}
}

disabled rule("CAR HANDBRAKE MECHANICS TAB")
{
	event
	{
		Ongoing - Global;
	}
}

rule("CAR HANDBRAKE MECHANICS: Handbrake Held")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == True;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [3] - HANDBRAKE PULLED"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[3] == True;
	}

	actions
	{
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - VEHICLE MECHANICS \n [0] - ACCELERATION - DESTINATION (RECEIVER)"
		Event Player.VAR_ARRAY_CAR_MECHANICS[0] = 0;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - VEHICLE MECHANICS \n [1] - ACCELERATION - RATE (RECEIVER)"
		Event Player.VAR_ARRAY_CAR_MECHANICS[1] = 0.250;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - VEHICLE MECHANICS - ARRAY TABLE - VEHICLE MECHANICS VALUES \n [5] -  MAIN STEERING ACCELERATION - RATE (RECEIVER) \n [3] - MAIN STEERING ACCELERATION - RATE (BOOSTED)"
		Event Player.VAR_ARRAY_CAR_MECHANICS[5] = Event Player.VAR_ARRAY_CAR_MECHANICS_VALUES[3];
		If(Event Player.VAR_VEH_ACCELER_DIRECTION == 1);
			Event Player.VAR_VEH_DRIFT_TRIGGER = True;
			Event Player.VAR_STUNT_DRIFT_AWARD_TRIGGER = True;
		End;
	}
}

rule("CAR HANDBRAKE MECHANICS: Handbrake Held (STEERING LEFT)")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == True;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [1] - STEERING STRING"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[1] == Custom String("NAV_STEER_LEFT");
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [7] - STEERING ENABLED"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[7] == True;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [3] - HANDBRAKE PULLED"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[3] == True;
		Event Player.VAR_VEH_STEERING_RIGHT_VALUE == 0;
	}

	actions
	{
		Event Player.VAR_VEH_STEERING_DIRECTION = 180;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - VEHICLE MECHANICS - ARRAY TABLE - VEHICLE MECHANICS VALUES \n [2] - MAIN STEERING ACCELERATION - DESTINATION (RECEIVER) \n [1] - MAIN STEERING ACCELERATION - DESTINATION (HANDBRAKING)"
		Event Player.VAR_ARRAY_CAR_MECHANICS[2] = Event Player.VAR_ARRAY_CAR_MECHANICS_VALUES[1];
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - VEHICLE MECHANICS - ARRAY TABLE - VEHICLE MECHANICS VALUES \n [3] - LEFT STEERING ACCELERATION - DESTINATION (RECEIVER) \n [1] - MAIN STEERING ACCELERATION - DESTINATION (HANDBRAKING)"
		Event Player.VAR_ARRAY_CAR_MECHANICS[3] = Event Player.VAR_ARRAY_CAR_MECHANICS_VALUES[1];
	}
}

rule("CAR HANDBRAKE MECHANICS: Handbrake Held (STEERING RIGHT)")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == True;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [1] - STEERING STRING"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[1] == Custom String("NAV_STEER_RIGHT");
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [7] - STEERING ENABLED"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[7] == True;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [3] - HANDBRAKE PULLED"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[3] == True;
		Event Player.VAR_VEH_STEERING_LEFT_VALUE == 0;
	}

	actions
	{
		Event Player.VAR_VEH_STEERING_DIRECTION = -180;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - VEHICLE MECHANICS - ARRAY TABLE - VEHICLE MECHANICS VALUES \n [2] - MAIN STEERING ACCELERATION - DESTINATION (RECEIVER) \n [1] - MAIN STEERING ACCELERATION - DESTINATION (HANDBRAKING)"
		Event Player.VAR_ARRAY_CAR_MECHANICS[2] = Event Player.VAR_ARRAY_CAR_MECHANICS_VALUES[1];
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - VEHICLE MECHANICS - ARRAY TABLE - VEHICLE MECHANICS VALUES \n [4] - RIGHT STEERING ACCELERATION - DESTINATION (RECEIVER) \n [1] - MAIN STEERING ACCELERATION - DESTINATION (HANDBRAKING)"
		Event Player.VAR_ARRAY_CAR_MECHANICS[4] = Event Player.VAR_ARRAY_CAR_MECHANICS_VALUES[1];
	}
}

rule("CAR HANDBRAKE MECHANICS: Handbrake Released (STEERING LEFT)")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == True;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [1] - STEERING STRING"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[1] == Custom String("NAV_STEER_LEFT");
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [3] - HANDBRAKE PULLED"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[3] == False;
		Event Player.VAR_VEH_STEERING_RIGHT_VALUE == 0;
	}

	actions
	{
		Event Player.VAR_VEH_STEERING_DIRECTION = 180;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - VEHICLE MECHANICS - ARRAY TABLE - VEHICLE MECHANICS VALUES \n [5] -  MAIN STEERING ACCELERATION - RATE (RECEIVER) \n [2] - MAIN STEERING ACCELERATION - RATE (REGULAR)"
		Event Player.VAR_ARRAY_CAR_MECHANICS[5] = Event Player.VAR_ARRAY_CAR_MECHANICS_VALUES[2];
	}
}

rule("CAR HANDBRAKE MECHANICS: Handbrake Released (STEERING RIGHT)")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == True;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [1] - STEERING STRING"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[1] == Custom String("NAV_STEER_RIGHT");
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [3] - HANDBRAKE PULLED"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[3] == False;
		Event Player.VAR_VEH_STEERING_LEFT_VALUE == 0;
	}

	actions
	{
		Event Player.VAR_VEH_STEERING_DIRECTION = -180;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - VEHICLE MECHANICS - ARRAY TABLE - VEHICLE MECHANICS VALUES \n [5] -  MAIN STEERING ACCELERATION - RATE (RECEIVER) \n [2] - MAIN STEERING ACCELERATION - RATE (REGULAR)"
		Event Player.VAR_ARRAY_CAR_MECHANICS[5] = Event Player.VAR_ARRAY_CAR_MECHANICS_VALUES[2];
	}
}

disabled rule("NITROUS MECHANICS (FOR INDEXES REFER TO ARRAY TABLES: NITROUS MECHANICS / PLAYER FEEDBACKS)")
{
	event
	{
		Ongoing - Global;
	}
}

rule("NITROUS MECHANIC: Trigger Nitrous")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		"FOR INDEXES REFER TO: MENU \\ ARRAY TABLE - INTERNAL STORAGE VARIABLE \n [4] - NITROUS:"
		Global.VAR_GBL_INTRNL_STORED_VALUES[4] != 0;
		Event Player.VAR_NITROUS_BOOL_IS_USED == False;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [2] - NITROUS TRIGGERED"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[2] == True;
		Event Player.VAR_NITROUS_CURR_VAL_TANK > 5;
		Speed Of In Direction(Event Player.VAR_RACER_VEHICLE, World Vector Of(Forward, Event Player.VAR_RACER_VEHICLE, Rotation)) >= 4;
	}

	actions
	{
		Event Player.VAR_NITROUS_BOOL_IS_USED = True;
		"SET NITROUS REGEN SIGNAL"
		Event Player.VAR_NITROUS_BOOL_REGEN_SIGNAL = False;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - NITROUS MECHANICS \n [0] - NITROUS DESTINATION"
		Event Player.VAR_NITROUS_ARRAY_MECHANICS[0] = 0;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - PLAYER FEEDBACKS \n [0] - NITROUS SOUND START/END VOLUME"
		Play Effect(All Players(All Teams), Winston Jump Pack Landing Sound, Color(White), Event Player,
			Event Player.VAR_ARRAY_CAR_PLAYER_FEEDBACKS[0]);
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - PLAYER FEEDBACKS \n [1] - NITROUS SOUND LOOP VOLUME"
		Event Player.VAR_ARRAY_CAR_PLAYER_FEEDBACKS[1] = 200;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - PLAYER FEEDBACKS - ARRAY TABLE - LIGHT CUSTOMIZATION STORED \n [2] - NITROUS CURRENT COLOR \n [0 - FIRST OF] - NITROUS COLOR"
		Event Player.VAR_ARRAY_CAR_PLAYER_FEEDBACKS[2] = First Of(Event Player.VAR_VEH_ARRAY_LIGHT_STORED);
		Call Subroutine(SUB_VEH_CHASE_GRIP_RESET_BOOST);
		Call Subroutine(SUB_VEH_NITROUS_CHANGE_SPEED);
	}
}

rule("NITROUS MECHANIC: Nitrous In Use (Regular)")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == True;
		Event Player.VAR_NITROUS_BOOL_IS_USED == True;
		Event Player.VAR_NITROUS_CURR_VAL_TANK != 0;
		Is In Air(Event Player.VAR_RACER_VEHICLE) == False;
	}

	actions
	{
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - NITROUS MECHANICS \n [1] - NITROUS CURRENT DEPLETION / REGEN RATE \n [5] - NITROUS DEPLETION RATE (REGULAR)"
		Event Player.VAR_NITROUS_ARRAY_MECHANICS[1] = Event Player.VAR_NITROUS_ARRAY_MECHANICS[5];
	}
}

rule("NITROUS MECHANIC: Nitrous In Use (Air)")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == True;
		Event Player.VAR_NITROUS_BOOL_IS_USED == True;
		Event Player.VAR_NITROUS_CURR_VAL_TANK != 0;
		Is In Air(Event Player.VAR_RACER_VEHICLE) == True;
	}

	actions
	{
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - NITROUS MECHANICS \n [1] - NITROUS CURRENT DEPLETION RATE \n [7] - NITROUS DEPLETION RATE (AIRBORNE)"
		Event Player.VAR_NITROUS_ARRAY_MECHANICS[1] = Event Player.VAR_NITROUS_ARRAY_MECHANICS[7];
	}
}

rule("NITROUS MECHANIC SUBROUTINE: Double Move Speed")
{
	event
	{
		Subroutine;
		SUB_VEH_NITROUS_CHANGE_SPEED;
	}

	actions
	{
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - NITROUS MECHANICS \n [4] - NITROUS POWER MULTIPLIER"
		Set Move Speed(Global.VAR_PLAYER_RACER.VAR_RACER_VEHICLE,
			Global.VAR_PLAYER_RACER.VAR_VEH_MOVE_SPEED * Global.VAR_PLAYER_RACER.VAR_NITROUS_ARRAY_MECHANICS[4]);
	}
}

rule("NITROUS MECHANIC: Nitrous Depleted")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == True;
		Event Player.VAR_NITROUS_BOOL_REGEN_SIGNAL == False;
		Event Player.VAR_NITROUS_CURR_VAL_TANK == 0;
	}

	actions
	{
		Call Subroutine(SUB_VEH_NITROUS_STOP);
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - PLAYER FEEDBACKS \n [3] - NITROUS HUD CURRENT COLOR"
		Event Player.VAR_ARRAY_CAR_PLAYER_FEEDBACKS[3] = Color(Red);
	}
}

rule("NITROUS MECHANIC: Nitrous Released")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == True;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [2] - NITROUS TRIGGERED"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[2] == False;
		Is Alive(Event Player.VAR_RACER_VEHICLE) == True;
	}

	actions
	{
		If(Event Player.VAR_NITROUS_CURR_VAL_TANK != 0);
			Call Subroutine(SUB_VEH_NITROUS_STOP);
		End;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - NITROUS MECHANICS \n [0] - NITROUS DESTINATION \n [2] - NITROUS MAX TANK"
		Event Player.VAR_NITROUS_ARRAY_MECHANICS[0] = Event Player.VAR_NITROUS_ARRAY_MECHANICS[2];
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - PLAYER FEEDBACKS \n [3] - NITROUS HUD CURRENT COLOR"
		Event Player.VAR_ARRAY_CAR_PLAYER_FEEDBACKS[3] = Event Player.VAR_VEH_ARRAY_LIGHT_STORED[0];
		Event Player.VAR_NITROUS_BOOL_IS_USED = False;
		Wait(0.500, Abort When False);
		Event Player.VAR_NITROUS_BOOL_REGEN_SIGNAL = True;
	}
}

rule("NITROUS MECHANIC SUBROUTINE: Stop Nitrous")
{
	event
	{
		Subroutine;
		SUB_VEH_NITROUS_STOP;
	}

	actions
	{
		Set Move Speed(Event Player.VAR_RACER_VEHICLE, Event Player.VAR_VEH_MOVE_SPEED);
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - PLAYER FEEDBACKS \n [1] - NITROUS SOUND LOOP VOLUME"
		Event Player.VAR_ARRAY_CAR_PLAYER_FEEDBACKS[1] = 0;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - PLAYER FEEDBACKS \n [0] - NITROUS SOUND START/END VOLUME"
		Play Effect(All Players(All Teams), Symmetra Teleporter Reappear Sound, Color(White), Event Player,
			Event Player.VAR_ARRAY_CAR_PLAYER_FEEDBACKS[0]);
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - PLAYER FEEDBACKS \n [2] - NITROUS CURRENT COLOR"
		Event Player.VAR_ARRAY_CAR_PLAYER_FEEDBACKS[2] = Color(Black);
	}
}

rule("NITROUS MECHANIC: Nitrous Replenishes when Drifting")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		"FOR INDEXES REFER TO: MENU \\ ARRAY TABLE - INTERNAL STORAGE VARIABLE \n [4] - NITROUS: (REGENERATION VIA STUNTS VALUE)"
		Global.VAR_GBL_INTRNL_STORED_VALUES[4] == 2;
		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == True;
		Event Player.VAR_NITROUS_BOOL_IS_USED == False;
		Event Player.VAR_VSL_STUNT_DRIFT_TRIGGER == True;
	}

	actions
	{
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - NITROUS MECHANICS \n [1] - NITROUS CURRENT DEPLETION / REGEN RATE \n [9] - NITROUS REGEN RATE (DRIFTING)"
		Event Player.VAR_NITROUS_ARRAY_MECHANICS[1] = Event Player.VAR_NITROUS_ARRAY_MECHANICS[9];
	}
}

rule("NITROUS MECHANIC: Nitrous Replenishes when Airborne")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		"FOR INDEXES REFER TO: MENU \\ ARRAY TABLE - INTERNAL STORAGE VARIABLE \n [4] - NITROUS: (REGENERATION VIA STUNTS VALUE)"
		Global.VAR_GBL_INTRNL_STORED_VALUES[4] == 2;
		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == True;
		Event Player.VAR_NITROUS_BOOL_IS_USED == False;
		Event Player.VAR_VSL_STUNT_AIR_TRIGGER == True;
	}

	actions
	{
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - NITROUS MECHANICS \n [1] - NITROUS CURRENT DEPLETION / REGEN RATE \n [10] - NITROUS REGEN RATE (AIRBORNE)"
		Event Player.VAR_NITROUS_ARRAY_MECHANICS[1] = Event Player.VAR_NITROUS_ARRAY_MECHANICS[10];
	}
}

rule("NITROUS MECHANIC: Nitrous Stops Replenishing when not performing stunts")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		"FOR INDEXES REFER TO: MENU \\ ARRAY TABLE - INTERNAL STORAGE VARIABLE \n [4] - NITROUS: (REGENERATION VIA STUNTS VALUE)"
		Global.VAR_GBL_INTRNL_STORED_VALUES[4] == 2;
		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == True;
		Event Player.VAR_NITROUS_BOOL_IS_USED == False;
		Event Player.VAR_VSL_STUNT_DRIFT_TRIGGER == False;
		Event Player.VAR_VSL_STUNT_AIR_TRIGGER == False;
	}

	actions
	{
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - NITROUS MECHANICS \n [1] - NITROUS CURRENT DEPLETION / REGEN RATE"
		Event Player.VAR_NITROUS_ARRAY_MECHANICS[1] = 0;
	}
}

rule("NITROUS MECHANIC: Nitrous Self-Replenishes when Unused")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		"FOR INDEXES REFER TO: MENU \\ ARRAY TABLE - INTERNAL STORAGE VARIABLE \n [4] - NITROUS: (SELF-REGENERATING VALUE)"
		Global.VAR_GBL_INTRNL_STORED_VALUES[4] == 1;
		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == True;
		Event Player.VAR_NITROUS_BOOL_IS_USED == False;
		Event Player.VAR_NITROUS_BOOL_REGEN_SIGNAL == True;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - NITROUS MECHANICS \n [2] - NITROUS MAX TANK"
		Event Player.VAR_NITROUS_CURR_VAL_TANK <= Event Player.VAR_NITROUS_ARRAY_MECHANICS[2];
	}

	actions
	{
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - NITROUS MECHANICS \n [0] - NITROUS DESTINATION \n [2] - NITROUS MAX TANK"
		Event Player.VAR_NITROUS_ARRAY_MECHANICS[0] = Event Player.VAR_NITROUS_ARRAY_MECHANICS[2];
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - NITROUS MECHANICS \n [1] - NITROUS CURRENT DEPLETION / REGEN RATE \n [8] - NITROUS REGEN RATE (SELF-REPLENISH)"
		Event Player.VAR_NITROUS_ARRAY_MECHANICS[1] = Event Player.VAR_NITROUS_ARRAY_MECHANICS[8];
	}
}

disabled rule("STUNT MECHANICS TAB")
{
	event
	{
		Ongoing - Global;
	}
}

rule("STUNT MECHANICS SUBROUTINE: GIVE AND RESET SCORE")
{
	event
	{
		Subroutine;
		SUB_VEH_STUNTS_SCORE_AND_RESET;
	}

	actions
	{
		If(Event Player.VAR_STUNT_DRIFT_AWARD_TRIGGER == True);
			Event Player.VAR_STUNTS_SCORE += Event Player.VAR_STUNT_CHASE_VAL_DRIFT_AWARD;
		End;
		"RESET DRIFT STUNT LEVEL TO 0"
		Event Player.VAR_STUNT_CURR_VAL_DRIFT_LVL = 0;
		Event Player.VAR_STUNT_CHASE_VAL_DRIFT_AWARD = 0;
	}
}

rule("STUNT MECHANICS: PLAYER DRIFTS")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_VSL_STUNTS_ENABLED == True;
		Event Player.VAR_VEH_DRIFT_TRIGGER == True;
		(Event Player.VAR_VEH_DRIFT_GRIP >= 0.100 || Event Player.VAR_VEH_DRIFT_GRIP <= -0.100) == True;
		Speed Of In Direction(Event Player, World Vector Of(Forward, Event Player, Rotation)) >= 4;
		Is In Air(Event Player.VAR_RACER_VEHICLE) == False;
	}

	actions
	{
		Call Subroutine(SUB_VEH_STUNTS_IS_DRIFTING);
		Call Subroutine(SUB_VEH_STUNTS_SCORE_AND_RESET);
	}
}

rule("STUNT MECHANICS SUBROUTINE: PLAYER DRIFTS")
{
	event
	{
		Subroutine;
		SUB_VEH_STUNTS_IS_DRIFTING;
	}

	actions
	{
		If(Global.VAR_TEST_DRIFT_CHECK_BOOL == True);
			Global.VAR_TEST_DRIFT_CHECK_STRINGS = Custom String(" {0} CAR IS DRIFTING (REGULAR)", Icon String(Checkmark));
		End;
		"Chase Drift Award \n [0] - DRIFT AWARD (CHASE DESTINATION) \n [1] - DRIFT AWARD (CHASE RATE)"
		Chase Player Variable At Rate(Event Player, VAR_STUNT_CHASE_VAL_DRIFT_AWARD, First Of(Global.VAR_GLB_ARRAY_STUNT_MECHANICS),
			Global.VAR_GLB_ARRAY_STUNT_MECHANICS[1], Destination and Rate);
		Event Player.VAR_STUNT_CURR_TYPE = Custom String("STUNT_DRIFT");
		"SET DRIFT STRING TO: DRIFT"
		If(Event Player.VAR_VEH_DRIFT_TYPE != Custom String("E_BRAKE_DRIFT"));
			Event Player.VAR_VSL_TXT_STUNT_DRIFT_STRING = First Of(Global.VAR_GLB_ARRAY_STRING_STUNT);
		"SET DRIFT STRING TO: E-DRIFT"
		Else If(Event Player.VAR_VEH_DRIFT_TYPE == Custom String("E_BRAKE_DRIFT"));
			Event Player.VAR_VSL_TXT_STUNT_DRIFT_STRING = Global.VAR_GLB_ARRAY_STRING_STUNT[1];
		End;
		Event Player.VAR_VSL_STUNT_DRIFT_TRIGGER = True;
	}
}

rule("STUNT MECHANICS: PLAYER IS NOT DRIFTING")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_VSL_STUNTS_ENABLED == True;
		Event Player.VAR_VEH_DRIFT_TRIGGER == False;
	}

	actions
	{
		If(Global.VAR_TEST_DRIFT_CHECK_BOOL == True);
			Global.VAR_TEST_DRIFT_CHECK_STRINGS = Custom String(" {0} CAR IS NOT DRIFTING ", Icon String(Warning));
		End;
		Event Player.VAR_STUNT_CURR_TYPE = Custom String("STUNT_RESET");
		Stop Chasing Player Variable(Event Player, VAR_STUNT_CHASE_VAL_DRIFT_AWARD);
		Wait(0.100, Abort When False);
		Event Player.VAR_STUNTS_SCORE += Event Player.VAR_STUNT_CHASE_VAL_DRIFT_AWARD;
		Event Player.VAR_STUNT_DRIFT_AWARD_TRIGGER = False;
		Event Player.VAR_VSL_STUNT_DRIFT_TRIGGER = False;
	}
}

rule("STUNT MECHANICS: CANCEL DRIFT WHEN BELOW SET SPEED")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_VSL_STUNTS_ENABLED == True;
		Event Player.VAR_VSL_STUNT_DRIFT_TRIGGER == True;
		Speed Of In Direction(Event Player.VAR_RACER_VEHICLE, World Vector Of(Forward, Event Player.VAR_PLAYER_IS_RACER, Rotation)) <= 4;
		Is In Air(Event Player) == False;
	}

	actions
	{
		Wait(0.100, Abort When False);
		If(Global.VAR_TEST_DRIFT_CHECK_BOOL == True);
			Global.VAR_TEST_DRIFT_CHECK_STRINGS = Custom String(" {0} CAR IS NOT DRIFTING (LOW SPEED) ", Icon String(Warning));
		End;
		Stop Chasing Player Variable(Event Player, VAR_STUNT_CHASE_VAL_DRIFT_AWARD);
		Event Player.VAR_STUNT_CURR_TYPE = Custom String("STUNT_RESET");
		Event Player.VAR_VSL_STUNT_DRIFT_TRIGGER = False;
	}
}

rule("STUNT MECHANICS: PLAYER IS AIRBORNE")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_RACER_VEHICLE_IS_ALIVE == True;
		Event Player.VAR_VSL_STUNTS_ENABLED == True;
		Is In Air(Event Player.VAR_RACER_VEHICLE) == True;
	}

	actions
	{
		Call Subroutine(SUB_VEH_STUNTS_IS_FLYING);
	}
}

rule("STUNT MECHANICS SUBROUTINE: PLAYER IS AIRBORNE")
{
	event
	{
		Subroutine;
		SUB_VEH_STUNTS_IS_FLYING;
	}

	actions
	{
		If(Global.VAR_TEST_DRIFT_CHECK_BOOL == True);
			Global.VAR_TEST_DRIFT_CHECK_STRINGS = Custom String(" {0} CAR IS AIRBORNE ", Icon String(Warning));
		End;
		Stop Chasing Player Variable(Event Player, VAR_STUNT_CHASE_VAL_DRIFT_AWARD);
		Event Player.VAR_VSL_STUNT_DRIFT_TRIGGER = False;
		Event Player.VAR_STUNT_CURR_TYPE = Custom String("STUNT_AIR");
		"RESET AIR STUNT LEVEL TO 0"
		Event Player.VAR_STUNT_CURR_VAL_AIR_LVL = 0;
		Event Player.VAR_STUNT_CHASE_VAL_AIR_AWARD = 0;
		"Chase Air Award \n [2] - AIR AWARD (CHASE DESTINATION) \n [3] - AIR AWARD (CHASE RATE)"
		Chase Player Variable At Rate(Event Player, VAR_STUNT_CHASE_VAL_AIR_AWARD, Global.VAR_GLB_ARRAY_STUNT_MECHANICS[2],
			Global.VAR_GLB_ARRAY_STUNT_MECHANICS[3], Destination and Rate);
		Event Player.VAR_VSL_STUNT_AIR_TRIGGER = True;
	}
}

rule("STUNT MECHANICS: PLAYER IS NOT AIRBORNE")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_VSL_STUNTS_ENABLED == True;
		Event Player.VAR_STUNT_CHASE_VAL_AIR_AWARD >= 0;
		Is In Air(Event Player.VAR_RACER_VEHICLE) == False;
	}

	actions
	{
		Event Player.VAR_VSL_STUNT_AIR_TRIGGER = False;
		Stop Chasing Player Variable(Event Player, VAR_STUNT_CHASE_VAL_AIR_AWARD);
		Wait(0.100, Abort When False);
		Event Player.VAR_STUNTS_SCORE += Event Player.VAR_STUNT_CHASE_VAL_AIR_AWARD;
	}
}

rule("STUNT MECHANICS: BREAK STUNTS WHEN CRASHED")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_RACER_VEHICLE_IS_ALIVE == True;
		disabled Event Player.VAR_VSL_STUNTS_ENABLED == True;
		(Event Player.VAR_VSL_STUNT_DRIFT_TRIGGER || Event Player.VAR_VSL_STUNT_AIR_TRIGGER) == True;
		Speed Of In Direction(Event Player.VAR_RACER_VEHICLE, World Vector Of(Forward, Event Player.VAR_RACER_VEHICLE, Rotation)) <= 4;
	}

	actions
	{
		Call Subroutine(SUB_VEH_STUNTS_BREAK);
	}
}

rule("STUNT MECHANICS SUBROUTINE: BREAK STUNTS WHEN CRASHED OR WRECKED")
{
	event
	{
		Subroutine;
		SUB_VEH_STUNTS_BREAK;
	}

	actions
	{
		Event Player.VAR_VSL_STUNTS_ENABLED = False;
		Stop Chasing Player Variable(Event Player, VAR_STUNT_CHASE_VAL_DRIFT_AWARD);
		Stop Chasing Player Variable(Event Player, VAR_STUNT_CHASE_VAL_AIR_AWARD);
		"RESET DRIFT STUNT LEVEL TO 0"
		Event Player.VAR_STUNT_CURR_VAL_DRIFT_LVL = 0;
		Event Player.VAR_STUNT_CHASE_VAL_DRIFT_AWARD = 0;
		"RESET AIR STUNT LEVEL TO 0"
		Event Player.VAR_STUNT_CURR_VAL_AIR_LVL = 0;
		Event Player.VAR_STUNT_CHASE_VAL_AIR_AWARD = 0;
		Event Player.VAR_VSL_STUNT_DRIFT_TRIGGER = False;
		Event Player.VAR_VSL_STUNT_AIR_TRIGGER = False;
		Event Player.VAR_VSL_TXT_STUNT_CHASED_R = 0;
		Event Player.VAR_VSL_TXT_STUNT_INFO_WAIT = 0.500;
	}
}

rule("STUNT MECHANICS: RE-ENABLE STUNTS AFTER CRASHING / WRECKING")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_RACER_VEHICLE_IS_ALIVE == True;
		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == True;
		Event Player.VAR_VSL_STUNTS_ENABLED != True;
	}

	actions
	{
		Wait(2, Restart When True);
		Event Player.VAR_VSL_STUNTS_ENABLED = True;
		Event Player.VAR_VSL_TXT_STUNT_INFO_WAIT = 3;
	}
}

disabled rule("STUNT MECHANICS VISUALS")
{
	event
	{
		Ongoing - Global;
	}
}

rule("STUNT VISUALS MECHANICS: START-UP CHASING VISUALS (GLOBALS)")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		Global.VAR_GLB_VEHICLE_DEPLOY_STATUS == Custom String("READY");
	}

	actions
	{
		Chase Global Variable At Rate(VAR_GPL_RACE_VSL_COUNTDOWN_A, 0, 510, Destination and Rate);
	}
}

rule("STUNT VISUALS MECHANICS: START-UP CHASING VISUALS (PLAYERS)")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Has Spawned(Event Player) == True;
		Global.VAR_GLB_VEHICLE_DEPLOY_STATUS == Custom String("READY");
	}

	actions
	{
		"Chase In-World Stunts Visual Texts"
		Chase Player Variable At Rate(Event Player, VAR_VSL_TXT_STUNT_CHASED_X, Event Player.VAR_VSL_TXT_STUNT_X_POS, 50,
			Destination and Rate);
		Chase Player Variable At Rate(Event Player, VAR_VSL_TXT_STUNT_DRIFT_CHASED_Z, Event Player.VAR_VSL_TXT_ALL_DEST_Z, 3,
			Destination and Rate);
		Chase Player Variable At Rate(Event Player, VAR_VSL_TXT_STUNT_AIR_CHASED_Z, Event Player.VAR_VSL_TXT_ALL_DEST_Z, 3,
			Destination and Rate);
		Chase Player Variable At Rate(Event Player, VAR_VSL_TXT_STUNT_CHASED_R, 255, 510, Destination and Rate);
		"FOR INDEXES REFER TO: MENU \\ ARRAY TABLE - INTERNAL STORAGE VARIABLE \n [7] - CURRENT MODE:"
		If(Global.VAR_GBL_INTRNL_STORED_VALUES[7] == 2);
			"Chase In-World Dynamite Trial Timer Visual Texts"
			Chase Player Variable At Rate(Event Player, VAR_VSL_TXT_DT_TMR_CHASED_Z, Event Player.VAR_VSL_TXT_ALL_DEST_Z, 3,
				Destination and Rate);
			Chase Player Variable At Rate(Event Player, VAR_VSL_TXT_DT_TMR_CHASED_R, 255, 510, Destination and Rate);
			Chase Player Variable At Rate(Event Player, VAR_VSL_TXT_DT_TMR_CHASED_G, 255, 510, Destination and Rate);
			Chase Player Variable At Rate(Event Player, VAR_VSL_TXT_DT_TMR_CHASED_B, 255, 510, Destination and Rate);
		End;
	}
}

rule("STUNT VISUALS MECHANICS: SHOW DRIFT INFO IF PERFORMING DRIFT")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == True;
		Event Player.VAR_VSL_STUNT_DRIFT_TRIGGER == True;
	}

	actions
	{
		Stop Chasing Player Variable(Event Player, VAR_VSL_TXT_STUNT_DRIFT_CHASED_A);
		Event Player.VAR_VSL_TXT_STUNT_DRIFT_CHASED_A = 255;
	}
}

rule("STUNT VISUALS MECHANICS: CUE PLAYER IF NEXT DRIFT LEVEL IS REACHED")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == True;
		Event Player.VAR_VSL_STUNT_DRIFT_TRIGGER == True;
		Is True For Any(Global.VAR_GLB_ARRAY_VAL_DRIFT_AWARD,
			Event Player.VAR_STUNT_CHASE_VAL_DRIFT_AWARD >= Global.VAR_GLB_ARRAY_VAL_DRIFT_AWARD[Event Player.VAR_STUNT_CURR_VAL_DRIFT_LVL])
			== True;
		Event Player.VAR_STUNT_CURR_VAL_DRIFT_LVL != 5;
	}

	actions
	{
		Play Effect(All Players(All Teams), Sombra Translocator Disappear Sound, Color(White), Global.VAR_PLAYER_RACER, 500);
		Event Player.VAR_STUNT_CURR_VAL_DRIFT_LVL += 1;
		Event Player.VAR_VSL_TXT_STUNT_DRIFT_CHASED_Z = Event Player.VAR_VSL_TXT_ALL_BOUNCE_Z;
		Event Player.VAR_VSL_TXT_STUNT_DRIFT_CHASED_A = 255;
	}
}

rule("STUNT VISUALS MECHANICS: HIDE DRIFT INFO IF NOT PERFORMING DRIFT")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == True;
		Event Player.VAR_VSL_STUNT_DRIFT_TRIGGER == False;
	}

	actions
	{
		Wait(Event Player.VAR_VSL_TXT_STUNT_INFO_WAIT, Abort When False);
		Chase Player Variable At Rate(Event Player, VAR_VSL_TXT_STUNT_DRIFT_CHASED_A, 0, 1000, Destination and Rate);
	}
}

rule("STUNT VISUALS MECHANICS: SHOW AIR INFO IF PERFORMING AIR")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == True;
		Event Player.VAR_VSL_STUNT_AIR_TRIGGER == True;
	}

	actions
	{
		Stop Chasing Player Variable(Event Player, VAR_VSL_TXT_STUNT_AIR_CHASED_A);
		Event Player.VAR_VSL_TXT_STUNT_AIR_CHASED_A = 255;
	}
}

rule("STUNT VISUALS MECHANICS: CUE PLAYER IF NEXT AIR LEVEL IS REACHED")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == True;
		Event Player.VAR_VSL_STUNT_AIR_TRIGGER == True;
		Is True For Any(Global.VAR_GLB_ARRAY_VAL_AIR_AWARD,
			Event Player.VAR_STUNT_CHASE_VAL_AIR_AWARD >= Global.VAR_GLB_ARRAY_VAL_AIR_AWARD[Event Player.VAR_STUNT_CURR_VAL_AIR_LVL])
			== True;
		Event Player.VAR_STUNT_CURR_VAL_AIR_LVL != 5;
	}

	actions
	{
		Event Player.VAR_STUNT_CURR_VAL_AIR_LVL += 1;
		Play Effect(All Players(All Teams), Sombra Translocator Disappear Sound, Color(White), Global.VAR_PLAYER_RACER, 500);
		Event Player.VAR_VSL_TXT_STUNT_AIR_CHASED_Z = Event Player.VAR_VSL_TXT_ALL_BOUNCE_Z;
		Event Player.VAR_VSL_TXT_STUNT_AIR_CHASED_A = 255;
	}
}

rule("STUNT VISUALS MECHANICS: HIDE AIR INFO IF NOT PERFORMING AIR")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == True;
		Event Player.VAR_VSL_STUNT_AIR_TRIGGER == False;
	}

	actions
	{
		Wait(Event Player.VAR_VSL_TXT_STUNT_INFO_WAIT, Abort When False);
		Chase Player Variable At Rate(Event Player, VAR_VSL_TXT_STUNT_AIR_CHASED_A, 0, 1000, Destination and Rate);
	}
}

disabled rule("VISUAL CAR MECHANICS TAB (FOR INDEXES REFER TO ARRAY TABLES: LIGHT CUSTOMIZATION STORED / PLAYER FEEDBACKS)")
{
	event
	{
		Ongoing - Global;
	}
}

rule("VISUAL CAR MECHANICS: Turn Rear Lights Off When Accelerating")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == True;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [0] - ACCELERATION STRING"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[0] == Custom String("NAV_ACC_ACCELERATING");
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [6] - ENGINE STATUS"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[6] == True;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [8] - BLINKERS ENABLED"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[8] != True;
	}

	actions
	{
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - PLAYER FEEDBACKS \n [5] - LEFT REAR LIGHT CURRENT COLOR"
		Event Player.VAR_ARRAY_CAR_PLAYER_FEEDBACKS[5] = Color(Black);
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - PLAYER FEEDBACKS \n [6] - RIGHT REAR LIGHT CURRENT COLOR"
		Event Player.VAR_ARRAY_CAR_PLAYER_FEEDBACKS[6] = Color(Black);
	}
}

rule("VISUAL CAR MECHANICS: Turn Rear Lights On When Braking")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == True;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [0] - ACCELERATION STRING"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[0] == Custom String("NAV_ACC_REVERSING");
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [6] - ENGINE STATUS"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[6] == True;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [8] - BLINKERS ENABLED"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[8] != True;
	}

	actions
	{
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - PLAYER FEEDBACKS - ARRAY TABLE - LIGHT CUSTOMIZATION STORED \n [5] - LEFT REAR LIGHT CURRENT COLOR \n [2] - REAR LIGHTS COLOR"
		Event Player.VAR_ARRAY_CAR_PLAYER_FEEDBACKS[5] = Event Player.VAR_VEH_ARRAY_LIGHT_STORED[2];
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - PLAYER FEEDBACKS - ARRAY TABLE - LIGHT CUSTOMIZATION STORED \n [6] - RIGHT REAR LIGHT CURRENT COLOR \n [2] - REAR LIGHTS COLOR"
		Event Player.VAR_ARRAY_CAR_PLAYER_FEEDBACKS[6] = Event Player.VAR_VEH_ARRAY_LIGHT_STORED[2];
	}
}

rule("VISUAL CAR MECHANICS: Start Blinkers")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == True;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [8] - BLINKERS ENABLED"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[8] == True;
	}

	actions
	{
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [9] - LEFT BLINKER ON"
		If(Event Player.VAR_ARRAY_CAR_NAVIGATION[9] == True);
			"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - PLAYER FEEDBACKS - ARRAY TABLE - LIGHT CUSTOMIZATION STORED \n [5] - LEFT REAR LIGHT CURRENT COLOR \n [3] - BLINKER COLOR"
			Event Player.VAR_ARRAY_CAR_PLAYER_FEEDBACKS[5] = Event Player.VAR_VEH_ARRAY_LIGHT_STORED[3];
		End;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [10] - RIGHT BLINKER ON"
		If(Event Player.VAR_ARRAY_CAR_NAVIGATION[10] == True);
			"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - PLAYER FEEDBACKS - ARRAY TABLE - LIGHT CUSTOMIZATION STORED \n [6] - RIGHT REAR LIGHT CURRENT COLOR \n [3] - BLINKER COLOR"
			Event Player.VAR_ARRAY_CAR_PLAYER_FEEDBACKS[6] = Event Player.VAR_VEH_ARRAY_LIGHT_STORED[3];
		End;
		Wait(0.340, Ignore Condition);
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - PLAYER FEEDBACKS \n [5] - LEFT REAR LIGHT CURRENT COLOR"
		Event Player.VAR_ARRAY_CAR_PLAYER_FEEDBACKS[5] = Color(Black);
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - PLAYER FEEDBACKS \n [6] - RIGHT REAR LIGHT CURRENT COLOR"
		Event Player.VAR_ARRAY_CAR_PLAYER_FEEDBACKS[6] = Color(Black);
		Wait(0.340, Ignore Condition);
		Loop If Condition Is True;
	}
}

rule("VISUAL CAR MECHANICS: Stop Blinkers When Speeding Up")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == True;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [8] - BLINKERS ENABLED"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[8] == True;
		Speed Of(Event Player.VAR_RACER_VEHICLE) >= 5;
	}

	actions
	{
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [8] - BLINKERS ENABLED"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[8] = False;
	}
}

disabled rule("SAFEGUARD MECHANICS TAB")
{
	event
	{
		Ongoing - Global;
	}
}

rule("SAFEGUARD MECHANICS: Vehicle Wrecked")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_RACER_VEHICLE_IS_READY == True;
		Event Player.VAR_RACER_VEHICLE_IS_ALIVE == False;
	}

	actions
	{
		Wait(0.100, Abort When False);
		"FOR INDEXES REFER TO: MENU \\ ARRAY TABLE - INTERNAL STORAGE VARIABLE \n [7] - CURRENT MODE:"
		If(Global.VAR_GBL_INTRNL_STORED_VALUES[7] != 2);
			"FOR INDEXES REFER TO: GAME IN PROGRESS \\ GLOBAL \\ ARRAY TABLE - IN-GAME STRINGS \n [10] - You crashed!"
			Big Message(Event Player, Global.VAR_GLB_ARRAY_STRING_IN_GAME[10]);
		Else;
			"FOR INDEXES REFER TO: GAME IN PROGRESS \\ GLOBAL \\ ARRAY TABLE - IN-GAME STRINGS \n [18] - BAD LUCK!"
			Big Message(Event Player, Global.VAR_GLB_ARRAY_STRING_IN_GAME[18]);
			Stop Chasing Player Variable(Event Player, VAR_VAL_DT_MODE_CHASE_TIME);
			Stop Chasing Player Variable(Event Player, VAR_VSL_TXT_CLK_CLK_SECONDS);
			Stop Chasing Player Variable(Event Player, VAR_VSL_TXT_CLK_LAP_SECONDS);
			Event Player.VAR_VSL_TXT_DT_TMR_TRIGGER = False;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - IN-GAME STRINGS"
		End;
		"DETACH RACER FROM VEHICLE"
		Stop Forcing Player Position(Event Player);
		Set Status(Event Player, Null, Rooted, 9999);
		"PREVENT RACER FROM ENVIRONMENT KILL"
		Set Gravity(Event Player, 0);
		Apply Impulse(Event Player, Up, 0.010, To World, Cancel Contrary Motion);
		Stop Facing(Event Player.VAR_RACER_VEHICLE);
		"PREVENT RACER'S VEHICLE FROM FALLING OFF THE MAP"
		Set Gravity(Event Player.VAR_RACER_VEHICLE, 0);
		Apply Impulse(Event Player.VAR_RACER_VEHICLE, Up, 0.010, To World, Cancel Contrary Motion);
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [6] - ENGINE STATUS - DISABLED WHEN WRECKED"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[6] = 0;
		Call Subroutine(SUB_VEH_ENGINE_OFF);
		Call Subroutine(SUB_VEH_STUNTS_BREAK);
		Event Player.VAR_RACER_INPUT_ENABLED = False;
	}
}

rule("SAFEGUARD MECHANICS: Racer Fell Outside The Map")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_RACER_VEHICLE_IS_READY == True;
		Is Alive(Event Player) == False;
	}

	actions
	{
		Kill(Event Player.VAR_RACER_VEHICLE, Null);
	}
}

rule("SAFEGUARD MECHANICS: Keep Notifying Player to Respawn/Restart")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_RACER_VEHICLE_IS_READY == True;
		Event Player.VAR_RACER_VEHICLE_IS_ALIVE == False;
		Event Player.VAR_VEH_FUNCTION_COOLDOWN == False;
	}

	actions
	{
		Wait(4, Abort When False);
		"FOR INDEXES REFER TO: MENU \\ ARRAY TABLE - INTERNAL STORAGE VARIABLE \n [7] - CURRENT MODE:"
		If(Global.VAR_GBL_INTRNL_STORED_VALUES[7] != 2);
			"FOR INDEXES REFER TO: GAME IN PROGRESS \\ GLOBAL \\ ARRAY TABLE - IN-GAME STRINGS \n [6] - PRESS / [8] - TO RESPAWN"
			Small Message(Event Player, Custom String("  {0} {1} {2}  ", Global.VAR_GLB_ARRAY_STRING_IN_GAME[6], Input Binding String(Button(
				Reload)), Global.VAR_GLB_ARRAY_STRING_IN_GAME[8]));
		Else;
			"FOR INDEXES REFER TO: GAME IN PROGRESS \\ GLOBAL \\ ARRAY TABLE - IN-GAME STRINGS \n [6] - PRESS / [9] - TO RESTART"
			Small Message(Event Player, Custom String("  {0} {1} {2}  ", Global.VAR_GLB_ARRAY_STRING_IN_GAME[6], Input Binding String(Button(
				Reload)), Global.VAR_GLB_ARRAY_STRING_IN_GAME[9]));
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - IN-GAME STRINGS"
		End;
		Loop If Condition Is True;
	}
}

rule("SAFEGUARD MECHANICS: Vehicle Wrecked - Respawn/Restart")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_RACER_VEHICLE_IS_ALIVE == False;
		Event Player.VAR_VEH_FUNCTION_COOLDOWN == False;
		Is Button Held(Event Player, Button(Reload)) == True;
	}

	actions
	{
		Event Player.VAR_VEH_FUNCTION_COOLDOWN = True;
		"FOR INDEXES REFER TO: MENU \\ ARRAY TABLE - INTERNAL STORAGE VARIABLE \n [7] - CURRENT MODE:"
		If(Global.VAR_GBL_INTRNL_STORED_VALUES[7] != 2);
			"FOR INDEXES REFER TO: GAME IN PROGRESS \\ GLOBAL \\ ARRAY TABLE - IN-GAME STRINGS \n [11] - Respawning..."
			Small Message(Event Player, Custom String("  {0} {1} ", Icon String(Warning), Global.VAR_GLB_ARRAY_STRING_IN_GAME[11]));
		Else;
			"FOR INDEXES REFER TO: GAME IN PROGRESS \\ GLOBAL \\ ARRAY TABLE - IN-GAME STRINGS \n [12] - Restarting..."
			Small Message(Event Player, Custom String("  {0} {1} ", Icon String(Warning), Global.VAR_GLB_ARRAY_STRING_IN_GAME[12]));
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - IN-GAME STRINGS"
		End;
		Wait(1, Ignore Condition);
		Event Player.VAR_VEH_FUNCTION_COOLDOWN = False;
		"Resurrect Vehicle"
		Resurrect(Event Player.VAR_RACER_VEHICLE);
		Teleport(Event Player.VAR_RACER_VEHICLE, Event Player.VAR_RACER_VEHICLE_RES_POS);
		Event Player.VAR_VEH_FACING = Event Player.VAR_RACER_VEHICLE_RES_FACE;
		Set Facing(Event Player.VAR_RACER_VEHICLE, Direction From Angles(Event Player.VAR_RACER_VEHICLE_RES_FACE, 0), To World);
		Set Gravity(Event Player.VAR_RACER_VEHICLE, 100);
		"Resurrect Racer"
		Resurrect(Event Player);
		Set Gravity(Event Player, 100);
		Teleport(Event Player, Event Player.VAR_RACER_VEHICLE_RES_POS);
		Clear Status(Event Player, Rooted);
		If(Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == True);
			Start Forcing Player Position(Event Player, Update Every Frame(Eye Position(Event Player.VAR_RACER_VEHICLE)), True);
		Else;
			Event Player.VAR_RACER_INPUT_ENABLED = True;
		End;
		"FOR INDEXES REFER TO: MENU \\ ARRAY TABLE - INTERNAL STORAGE VARIABLE \n [7] - CURRENT MODE:"
		If(Global.VAR_GBL_INTRNL_STORED_VALUES[7] != 2);
			Event Player.VAR_RACER_INPUT_ENABLED = True;
			"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [6] - ENGINE STATUS - RE-ENABLED AFTER RESPAWNING IN RACE MODE"
			Event Player.VAR_ARRAY_CAR_NAVIGATION[6] = 1;
			Event Player.VAR_NITROUS_CURR_VAL_TANK = Event Player.VAR_RACER_VEHICLE_RES_NITROUS;
		Else;
			Global.VAR_GLB_RACE_STATUS = Custom String("RACE_READY");
		End;
		Event Player.VAR_VSL_TXT_STUNT_INFO_WAIT = 3;
	}
}

rule("Project: Streetwatch - Original Build by GraczCourier (now known as RaidVentador_Courier_13)")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		"GAMEMODE CORE (DO NUT TOUCH)"
		Has Spawned(Global.VAR_PLAYER_RACER) == True;
	}

	actions
	{
		Disable Inspector Recording;
		If((Global.COCONUT == Custom String("GRACZCOURIER") && Global.ALPINE_CHOCOLATE_WIT_CEMENT == Custom String("GRACZC0URIER"))
			== True);
			Global.A_PIECE_OF_ASPHALT_THAT_I_FOUND = True;
		Else If((Global.COCONUT == Custom String("GRACZCOURIER") && Global.ALPINE_CHOCOLATE_WIT_CEMENT == Custom String("GRACZCOURIER"))
				== True);
			Global.A_PIECE_OF_ASPHALT_THAT_I_FOUND = False;
		End;
		"Remove Later"
		Global.THE_RAVEN_CAN_ONLY_WATCH_OMENS = True;
		Enable Inspector Recording;
	}
}

rule("Project: Streetwatch - Original Build by GraczCourier (now known as RaidVentador_Courier_13)")
{
	event
	{
		Subroutine;
		SUB_CORE;
	}

	actions
	{
		Global.COCONUT = Custom String("Y0U SH0ULDN'7 H2V3 D0N3 7HA7");
		Loop;
	}
}

disabled rule("MODE MECHANICS TAB")
{
	event
	{
		Ongoing - Global;
	}
}

rule("MODE MECHANICS: INITIAL SETUP")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Global.VAR_GLB_VEHICLE_DEPLOY_STATUS == Custom String("READY");
	}

	actions
	{
		"FOR INDEXES REFER TO: MENU \\ ARRAY TABLE - INTERNAL STORAGE VARIABLE \n [5] - STARTING NITROUS PERCENT:"
		Global.VAR_PLAYER_RACER.VAR_RACER_VEHICLE_RES_NITROUS = Global.VAR_GBL_INTRNL_STORED_VALUES[5];
		"FOR INDEXES REFER TO: MENU \\ ARRAY TABLE - INTERNAL STORAGE VARIABLE \n [7] - CURRENT MODE:"
		If(Global.VAR_GBL_INTRNL_STORED_VALUES[7] != 0);
			Global.VAR_GLB_RACE_STATUS = Custom String("RACE_READY");
		End;
		"FOR INDEXES REFER TO: MENU \\ ARRAY TABLE - INTERNAL STORAGE VARIABLE \n [9] - IS REVERSED?:"
		If(Global.VAR_GBL_INTRNL_STORED_VALUES[9] == False);
			Event Player.VAR_RACER_VEHICLE_RES_POS = Global.VAR_GLB_VEH_REG_START_POS;
			Event Player.VAR_RACER_VEHICLE_RES_FACE = Global.VAR_GLB_VEH_REG_START_FACE;
			Set Facing(Event Player.VAR_RACER_VEHICLE, Direction From Angles(Global.VAR_GLB_VEH_REG_START_FACE, 0), To World);
			Teleport(Event Player, Global.VAR_GLB_VEH_REG_START_POS);
			Teleport(Event Player.VAR_RACER_VEHICLE, Global.VAR_GLB_VEH_REG_START_POS);
		Else;
			Event Player.VAR_RACER_VEHICLE_RES_POS = Global.VAR_GLB_VEH_REV_START_POS;
			Event Player.VAR_RACER_VEHICLE_RES_FACE = Global.VAR_GLB_VEH_REV_START_FACE;
			Set Facing(Event Player.VAR_RACER_VEHICLE, Direction From Angles(Global.VAR_GLB_VEH_REV_START_FACE, 0), To World);
			Teleport(Event Player, Global.VAR_GLB_VEH_REV_START_POS);
			Teleport(Event Player.VAR_RACER_VEHICLE, Global.VAR_GLB_VEH_REV_START_POS);
		End;
	}
}

rule("MODE MECHANICS: MAKE VEHICLE READY")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Global.VAR_GLB_VEHICLE_DEPLOY_STATUS == Custom String("DEPLOYED");
	}

	actions
	{
		Event Player.VAR_RACER_VEHICLE_IS_READY = True;
		Event Player.VAR_RACER_INPUT_ENABLED = True;
		"FOR INDEXES REFER TO: MENU \\ ARRAY TABLE - INTERNAL STORAGE VARIABLE \n [3] - START OUTSIDE THE CAR?"
		If(Global.VAR_GBL_INTRNL_STORED_VALUES[3] == False);
			Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE = True;
			"FOR INDEXES REFER TO: MENU \\ ARRAY TABLE - INTERNAL STORAGE VARIABLE \n [7] - CURRENT MODE:"
			If(Global.VAR_GBL_INTRNL_STORED_VALUES[7] == 0);
				"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [6] - ENGINE STATUS - ENABLED AT THE START IN FREE DRIVE"
				Event Player.VAR_ARRAY_CAR_NAVIGATION[6] = 1;
			End;
		End;
	}
}

rule("MODE MECHANICS: SET TARGET SCORE TO RED")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_RACER_VEHICLE_IS_READY == True;
		"FOR INDEXES REFER TO: MENU \\ ARRAY TABLE - INTERNAL STORAGE VARIABLE \n [10] - SCORE CONDITION:"
		Global.VAR_GBL_INTRNL_STORED_VALUES[10] == 1;
		"FOR INDEXES REFER TO: MENU \\ ARRAY TABLE - INTERNAL STORAGE VARIABLE \n [11] - SCORE THRESHOLD:"
		Event Player.VAR_STUNTS_SCORE <= Global.VAR_GBL_INTRNL_STORED_VALUES[11];
	}

	actions
	{
		Event Player.VAR_VSL_HUD_TGT_SCORE_COLOR = Color(Red);
		Event Player.VAR_VSL_HUD_TGT_SCORE_ICON = Icon String(X);
	}
}

rule("MODE MECHANICS: SET TARGET SCORE TO WHITE")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_RACER_VEHICLE_IS_READY == True;
		"FOR INDEXES REFER TO: MENU \\ ARRAY TABLE - INTERNAL STORAGE VARIABLE \n [10] - SCORE CONDITION:"
		Global.VAR_GBL_INTRNL_STORED_VALUES[10] == 1;
		"FOR INDEXES REFER TO: MENU \\ ARRAY TABLE - INTERNAL STORAGE VARIABLE \n [11] - SCORE THRESHOLD:"
		Event Player.VAR_STUNTS_SCORE >= Global.VAR_GBL_INTRNL_STORED_VALUES[11];
		Event Player.VAR_VSL_HUD_TGT_SCORE_TRIGGER == False;
	}

	actions
	{
		Event Player.VAR_VSL_HUD_TGT_SCORE_COLOR = Color(White);
		Event Player.VAR_VSL_HUD_TGT_SCORE_TRIGGER = True;
		Event Player.VAR_VSL_HUD_TGT_SCORE_ICON = Icon String(Checkmark);
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ GLOBAL \\ ARRAY TABLE - IN-GAME STRINGS \n [24] - TARGET SCORE REACHED!"
		Small Message(Global.VAR_PLAYER_RACER, Custom String("  {0} {1}", Icon String(Checkmark),
			Global.VAR_GLB_ARRAY_STRING_IN_GAME[24]));
	}
}

disabled rule("VEHICLE EVENTS MECHANICS")
{
	event
	{
		Ongoing - Global;
	}
}

rule("VEHICLE EVENTS MECHANICS: VEHICLE IS NOT WRECKED")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_RACER_VEHICLE_IS_READY == True;
		Is Alive(Event Player.VAR_RACER_VEHICLE) == True;
	}

	actions
	{
		Event Player.VAR_RACER_VEHICLE_IS_ALIVE = True;
	}
}

rule("VEHICLE EVENTS MECHANICS: VEHICLE IS WRECKED")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_RACER_VEHICLE_IS_READY == True;
		Is Alive(Event Player.VAR_RACER_VEHICLE) == False;
	}

	actions
	{
		Event Player.VAR_RACER_VEHICLE_IS_ALIVE = False;
	}
}

rule("VEHICLE EVENTS MECHANICS: VEHICLE IS NOT AIRBORNE")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_RACER_VEHICLE_IS_READY == True;
		Is Alive(Event Player.VAR_RACER_VEHICLE) == True;
		Is In Air(Event Player.VAR_RACER_VEHICLE) == False;
	}

	actions
	{
		Event Player.VAR_RACER_VEHICLE.VAR_RACER_VEHICLE_IS_AIRBORNE = False;
	}
}

rule("VEHICLE EVENTS MECHANICS: VEHICLE IS AIRBORNE")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_RACER_VEHICLE_IS_READY == True;
		Is Alive(Event Player.VAR_RACER_VEHICLE) == True;
		Is In Air(Event Player.VAR_RACER_VEHICLE) == True;
	}

	actions
	{
		Event Player.VAR_RACER_VEHICLE_IS_AIRBORNE = True;
	}
}

rule("VEHICLE MECHANICS: PLAYER DRIVES UP THE RAMP")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Is Alive(Event Player.VAR_RACER_VEHICLE) == True;
		Speed Of In Direction(Event Player.VAR_RACER_VEHICLE, World Vector Of(Forward, Event Player.VAR_RACER_VEHICLE, Rotation)) >= 5;
		Distance Between(Eye Position(Event Player.VAR_RACER_VEHICLE), Ray Cast Hit Position(Eye Position(Event Player.VAR_RACER_VEHICLE),
			Eye Position(Event Player.VAR_RACER_VEHICLE) + World Vector Of(Vector(0, -1, 1), Event Player.VAR_RACER_VEHICLE, Rotation)
			* 20, Event Player.VAR_RACER_VEHICLE, Event Player.VAR_RACER_VEHICLE, True)) <= 2;
		Is In Air(Event Player.VAR_RACER_VEHICLE) == False;
	}

	actions
	{
		Event Player.VAR_RACER_VEHICLE.VAR_VEH_RAMP_TRIGGER = True;
	}
}

rule("VEHICLE MECHANICS: PLAYER DRIVES OFF THE RAMP")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Is Alive(Event Player.VAR_RACER_VEHICLE) == True;
		Event Player.VAR_RACER_VEHICLE.VAR_VEH_RAMP_TRIGGER == True;
		Distance Between(Eye Position(Event Player.VAR_RACER_VEHICLE), Ray Cast Hit Position(Eye Position(Event Player.VAR_RACER_VEHICLE),
			Eye Position(Event Player.VAR_RACER_VEHICLE) + World Vector Of(Vector(0, -1, 1), Event Player.VAR_RACER_VEHICLE, Rotation)
			* 20, Event Player.VAR_RACER_VEHICLE, Event Player.VAR_RACER_VEHICLE, True)) >= 2;
		Is In Air(Event Player.VAR_RACER_VEHICLE) == False;
	}

	actions
	{
		Event Player.VAR_RACER_VEHICLE.VAR_VEH_RAMP_TRIGGER = False;
		Apply Impulse(Event Player.VAR_RACER_VEHICLE, Up, 6, To World, Cancel Contrary Motion);
	}
}

rule("VEHICLE MECHANICS: CANCEL RAMP JUMP OFF IF LOST TOO MUCH SPEED")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Is Alive(Event Player.VAR_RACER_VEHICLE) == True;
		Event Player.VAR_RACER_VEHICLE.VAR_VEH_RAMP_TRIGGER == True;
		Speed Of In Direction(Event Player.VAR_RACER_VEHICLE, World Vector Of(Forward, Event Player.VAR_RACER_VEHICLE, Rotation)) <= 5;
		Is In Air(Event Player.VAR_RACER_VEHICLE) == False;
	}

	actions
	{
		Event Player.VAR_RACER_VEHICLE.VAR_VEH_RAMP_TRIGGER = False;
	}
}

rule("VEHICLE MECHANICS: PLAYER JUMPS OFF THE SLOPE")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_RACER_VEHICLE_IS_READY == True;
		Is Alive(Event Player.VAR_RACER_VEHICLE) == True;
		Speed Of In Direction(Event Player.VAR_RACER_VEHICLE, World Vector Of(Forward, Event Player.VAR_RACER_VEHICLE, Rotation)) >= 7.500;
		Distance Between(Eye Position(Event Player.VAR_RACER_VEHICLE), Ray Cast Hit Position(Eye Position(Event Player.VAR_RACER_VEHICLE),
			Eye Position(Event Player.VAR_RACER_VEHICLE) + World Vector Of(Vector(0, -1, 1), Event Player.VAR_RACER_VEHICLE, Rotation)
			* 20, Event Player.VAR_RACER_VEHICLE, Event Player.VAR_RACER_VEHICLE, True)) > 3.500;
		Distance Between(Eye Position(Event Player.VAR_RACER_VEHICLE), Ray Cast Hit Position(Eye Position(Event Player.VAR_RACER_VEHICLE),
			Eye Position(Event Player.VAR_RACER_VEHICLE) + World Vector Of(Backward, Event Player.VAR_RACER_VEHICLE, Rotation) * 20,
			Event Player.VAR_RACER_VEHICLE, Event Player.VAR_RACER_VEHICLE, True)) >= 7.500;
		Is In Air(Event Player.VAR_RACER_VEHICLE) == False;
	}

	actions
	{
		Apply Impulse(Event Player.VAR_RACER_VEHICLE, Up, 2, To World, Incorporate Contrary Motion);
	}
}

rule("INPUT NAVIGATION MECHANICS: PLAYER ENTERS / EXITS VEHICLE")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_RACER_VEHICLE_IS_ALIVE == True;
		Event Player.VAR_RACER_INPUT_ENABLED == True;
		Is Button Held(Event Player, Button(Interact)) == True;
		Event Player.VAR_VEH_FUNCTION_COOLDOWN == False;
	}

	actions
	{
		Wait Until(!Is Button Held(Event Player, Button(Interact)), 99999);
		"ENTER VEHICLE"
		If(Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == False);
			If(Distance Between(Event Player, Event Player.VAR_RACER_VEHICLE) <= 3);
				Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE = True;
			End;
		"EXIT VEHICLE"
		Else;
			Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE = False;
			Stop Camera(Event Player);
		End;
		Call Subroutine(SUB_VEH_INPUT_FUNC_COOLDOWN);
	}
}

rule("INPUT NAVIGATION MECHANICS: / ACCELERATION PRESSED")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_RACER_VEHICLE_IS_ALIVE == True;
		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == True;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [6] - ENGINE STATUS"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[6] == True;
		Z Component Of(Throttle Of(Event Player)) > 0;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [3] - HANDBRAKE PULLED"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[3] == False;
	}

	actions
	{
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [0] - ACCELERATION STRING"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[0] = Custom String("NAV_ACC_ACCELERATING");
	}
}

rule("INPUT NAVIGATION MECHANICS: / ACCELERATION RELEASED")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_RACER_VEHICLE_IS_ALIVE == True;
		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == True;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [3] - HANDBRAKE PULLED"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[3] == False;
		Z Component Of(Throttle Of(Event Player)) == 0;
	}

	actions
	{
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [0] - ACCELERATION STRING"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[0] = Custom String("NAV_ACC_RELEASED");
	}
}

rule("INPUT NAVIGATION MECHANICS: / REVERSE PRESSED")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_RACER_VEHICLE_IS_ALIVE == True;
		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == True;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [6] - ENGINE STATUS"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[6] == True;
		Z Component Of(Throttle Of(Event Player)) < 0;
		Is Button Held(Event Player, Button(Jump)) == False;
	}

	actions
	{
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [0] - ACCELERATION STRING"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[0] = Custom String("NAV_ACC_REVERSING");
		Event Player.VAR_VEH_DRIFT_TYPE = Custom String("REGULAR_DRIFT");
	}
}

rule("INPUT NAVIGATION MECHANICS: / PLAYER STEERS LEFT")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_RACER_VEHICLE_IS_ALIVE == True;
		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == True;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [7] - STEERING ENABLED"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[7] == True;
		X Component Of(Throttle Of(Event Player)) > 0;
	}

	actions
	{
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [1] - STEERING STRING"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[1] = Custom String("NAV_STEER_LEFT");
	}
}

rule("INPUT NAVIGATION MECHANICS: / PLAYER STEERS RIGHT")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_RACER_VEHICLE_IS_ALIVE == True;
		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == True;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [7] - STEERING ENABLED"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[7] == True;
		X Component Of(Throttle Of(Event Player)) < 0;
	}

	actions
	{
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [1] - STEERING STRING"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[1] = Custom String("NAV_STEER_RIGHT");
	}
}

rule("INPUT NAVIGATION MECHANICS: / PLAYER STOPS STEERING")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_RACER_VEHICLE_IS_ALIVE == True;
		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == True;
		Absolute Value(X Component Of(Throttle Of(Event Player))) <= 0.100;
	}

	actions
	{
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [1] - STEERING STRING"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[1] = Custom String("NAV_STEER_RESET");
	}
}

rule("INPUT NAVIGATION MECHANICS: / HANDBRAKE PULLED")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_RACER_VEHICLE_IS_ALIVE == True;
		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == True;
		Is Button Held(Event Player, Button(Jump)) == True;
	}

	actions
	{
		If(Global.VAR_TEST_DRIFT_CHECK_BOOL == True);
			Global.VAR_TEST_DRIFT_CHECK_STRINGS = Custom String(" {0} CAR IS DRIFTING (HANDBRAKE PULLED)", Icon String(Checkmark));
		End;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [0] - ACCELERATION STRING"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[0] = Custom String("NAV_ACC_HANDBRAKING");
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [3] - HANDBRAKE PULLED"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[3] = True;
		Event Player.VAR_VEH_DRIFT_TYPE = Custom String("E_BRAKE_DRIFT");
	}
}

rule("INPUT NAVIGATION MECHANICS: / HANDBRAKE RELEASED")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_RACER_VEHICLE_IS_ALIVE == True;
		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == True;
		Is Button Held(Event Player, Button(Jump)) == False;
	}

	actions
	{
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [3] - HANDBRAKE PULLED"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[3] = False;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - VEHICLE MECHANICS - ARRAY TABLE - VEHICLE MECHANICS VALUES \n [5] -  MAIN STEERING ACCELERATION - RATE (RECEIVER) \n [2] - MAIN STEERING ACCELERATION - RATE (REGULAR)"
		Event Player.VAR_ARRAY_CAR_MECHANICS[5] = Event Player.VAR_ARRAY_CAR_MECHANICS_VALUES[2];
	}
}

rule("INPUT NAVIGATION MECHANICS: / SWITCH CAMERA")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_RACER_VEHICLE_IS_ALIVE == True;
		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == True;
		Event Player.VAR_VEH_FUNCTION_COOLDOWN == False;
		Is Button Held(Event Player, Button(Melee)) == False;
		Is Button Held(Event Player, Button(Ultimate)) == True;
	}

	actions
	{
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [4] - FUNCTIONS"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[4] = Custom String("NAV_FUNC_SWITCH_CAMERA");
		Call Subroutine(SUB_VEH_INPUT_FUNC_COOLDOWN);
	}
}

rule("INPUT NAVIGATION MECHANICS: / PLAYER LOOKS BACKWARDS")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_RACER_VEHICLE_IS_ALIVE == True;
		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == True;
		Event Player.VAR_RACER_VEHICLE_IS_READY == True;
		Is Button Held(Event Player, Button(Crouch)) == True;
	}

	actions
	{
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [5] - LOOK BACK TRIGGER"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[5] = True;
		Wait Until(!Is Button Held(Event Player, Button(Crouch)), 99999);
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [5] - LOOK BACK TRIGGER"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[5] = False;
	}
}

rule("INPUT NAVIGATION MECHANICS: / PLAYER PRESSES NITROUS")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_RACER_VEHICLE_IS_ALIVE == True;
		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == True;
		Is Button Held(Event Player, Button(Ability 1)) == True;
	}

	actions
	{
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [2] - NITROUS TRIGGERED"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[2] = True;
		Wait Until(Is Button Held(Event Player, Button(Ability 1)) == False, 99999);
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [2] - NITROUS TRIGGERED"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[2] = False;
	}
}

rule("INPUT NAVIGATION MECHANICS: / CAR FUNCTIONS - TURN ON BLINKERS")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_RACER_VEHICLE_IS_ALIVE == True;
		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == True;
		Event Player.VAR_VEH_FUNCTION_COOLDOWN == False;
		Is Button Held(Event Player, Button(Melee)) == True;
		(Is Button Held(Event Player, Button(Jump)) == True || X Component Of(Throttle Of(Event Player)) > 0 || X Component Of(Throttle Of(
			Event Player)) < 0) == True;
		Speed Of(Event Player.VAR_RACER_VEHICLE) <= 1;
	}

	actions
	{
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [8] - BLINKERS ENABLED"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[8] = True;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [9] - LEFT BLINKER ON"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[9] = False;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [10] - RIGHT BLINKER ON"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[10] = False;
		"LEFT"
		If(X Component Of(Throttle Of(Event Player)) > 0);
			"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [9] - LEFT BLINKER ON"
			Event Player.VAR_ARRAY_CAR_NAVIGATION[9] = True;
		"RIGHT"
		Else If(X Component Of(Throttle Of(Event Player)) < 0);
			"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [10] - RIGHT BLINKER ON"
			Event Player.VAR_ARRAY_CAR_NAVIGATION[10] = True;
		"BOTH"
		Else If(Is Button Held(Event Player, Button(Jump)) == True);
			"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [9] - LEFT BLINKER ON"
			Event Player.VAR_ARRAY_CAR_NAVIGATION[9] = True;
			"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [10] - RIGHT BLINKER ON"
			Event Player.VAR_ARRAY_CAR_NAVIGATION[10] = True;
		End;
		Call Subroutine(SUB_VEH_INPUT_FUNC_COOLDOWN);
	}
}

rule("INPUT NAVIGATION MECHANICS: / CAR FUNCTIONS - TURN OFF BLINKERS")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_RACER_VEHICLE_IS_ALIVE == True;
		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == True;
		Event Player.VAR_VEH_FUNCTION_COOLDOWN == False;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [8] - BLINKERS ENABLED"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[8] == True;
		Is Button Held(Event Player, Button(Melee)) == True;
		Speed Of(Event Player.VAR_RACER_VEHICLE) <= 1;
	}

	actions
	{
		Wait(0.250, Abort When False);
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [8] - BLINKERS ENABLED"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[8] = False;
		Call Subroutine(SUB_VEH_INPUT_FUNC_COOLDOWN);
	}
}

rule("INPUT NAVIGATION MECHANICS: / CAR FUNCTIONS - RADIO & ENGINE")
{
	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Event Player.VAR_RACER_VEHICLE_IS_ALIVE == True;
		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == True;
		Event Player.VAR_RACER_INPUT_ENABLED == True;
		Event Player.VAR_VEH_FUNCTION_COOLDOWN == False;
		Is Button Held(Event Player, Button(Melee)) == True;
		(Is Button Held(Event Player, Button(Reload)) || Is Button Held(Event Player, Button(Primary Fire)) || Is Button Held(Event Player,
			Button(Secondary Fire))) == True;
	}

	actions
	{
		If(Is Button Held(Event Player, Button(Reload)));
			"TURN OFF ENGINE"
			If(Event Player.VAR_ARRAY_CAR_NAVIGATION[6] == 1);
				"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [6] - ENGINE STATUS - DISABLED MANUALLY"
				Event Player.VAR_ARRAY_CAR_NAVIGATION[6] = 2;
			"TURN ON ENGINE"
			Else;
				"FOR INDEXES REFER TO: GAME IN PROGRESS \\ GLOBAL \\ ARRAY TABLE - IN-GAME STRINGS \n [2] - ENGINE ON"
				Small Message(Event Player, Custom String("  {0} {1} ", Icon String(Warning), Global.VAR_GLB_ARRAY_STRING_IN_GAME[2]));
				"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [6] - ENGINE STATUS - ENABLED MANUALLY"
				Event Player.VAR_ARRAY_CAR_NAVIGATION[6] = 1;
			End;
		End;
		"PREV RADIO"
		If(Is Button Held(Event Player, Button(Primary Fire)));
			"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [4] - FUNCTIONS"
			Event Player.VAR_ARRAY_CAR_NAVIGATION[4] = Custom String("NAV_FUNC_PREV_RADIO");
		"NEXT RADIO"
		Else If(Is Button Held(Event Player, Button(Secondary Fire)));
			"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [4] - FUNCTIONS"
			Event Player.VAR_ARRAY_CAR_NAVIGATION[4] = Custom String("NAV_FUNC_NEXT_RADIO");
		End;
		Call Subroutine(SUB_VEH_INPUT_FUNC_COOLDOWN);
	}
}

rule("INPUT NAVIGATION MECHANICS SUBROUTINE: FUNCTIONS COOLDOWN")
{
	event
	{
		Subroutine;
		SUB_VEH_INPUT_FUNC_COOLDOWN;
	}

	actions
	{
		Event Player.VAR_VEH_FUNCTION_COOLDOWN = True;
		Wait(0.100, Ignore Condition);
		Event Player.VAR_VEH_FUNCTION_COOLDOWN = False;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [4] - FUNCTIONS"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[4] = Custom String("NAV_FUNC_RESET");
	}
}

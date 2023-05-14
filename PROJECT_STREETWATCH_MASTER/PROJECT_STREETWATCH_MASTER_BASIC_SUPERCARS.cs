settings
{
	main
	{
		Description: "Project: Streetwatch by GraczCourier (now known as RaidVentador_Courier_13) \n OVERDRIVE UPDATE \n \n Gamemode Homepage: \n https://workshop.codes/4XQP4 \n Support the Creator via Ko-Fi:\n https://ko-fi.com/raidventador_courier_13 \n \n Special Thanks to:\n Deltin and Lotto for help and contribution"
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
				Blizzard World 972777519512068154 972777519512068194
				Busan 972777519512068153 972777519512068154
				Circuit royal 972777519512068153 972777519512068154
				Colosseo 972777519512068292 972777519512068154
				King's Row 972777519512068153 972777519512068292
				New Queen Street 972777519512068197 972777519512068154
				Paris 972777519512063901
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
				Black Forest 972777519512063901
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
		37: VAR_DRIVEABLE_VEHICLE_HUD
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
		88: VAR_GPL_RACE_START_CLOCKS
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
		6: VAR_GPL_MODE_CP_TYPE
		7: VAR_GPL_MODE_CP_CURR_COLOR
		8: VAR_GPL_MODE_CP_CURRENT
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
		76: VAR_VSL_TXT_CLK_TIME_TRIGGER
		77: VAR_VSL_TXT_CLK_LST_SECONDS
		78: VAR_VSL_TXT_CLK_LST_MINUTES
		79: VAR_VSL_TXT_DT_TMR_CHASED_Z
		80: VAR_VSL_TXT_DT_TMR_CHASED_R
		81: VAR_VSL_TXT_DT_TMR_CHASED_G
		82: VAR_VSL_TXT_DT_TMR_CHASED_B
		83: VAR_VSL_TXT_DT_TMR_WAIT_VALUE
		84: VAR_VSL_TXT_DT_TMR_TRIGGER
		85: VAR_VSL_TXT_DT_TMR_DEST
		86: VAR_VAL_DT_MODE_CHASE_TIME
		87: VAR_VSL_HUD_CLK_BST_COLOR
		88: VAR_VSL_HUD_CLK_BST_COLOR_BLINK
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
	36: SUB_GPL_MODE_CHECKPOINT_REACHED
	37: SUB_GPL_MODE_CHECKPOINT_RESPAWN
	38: SUB_GPL_MODE_CHECKPOINT_RESET
	39: SUB_GPL_VSL_BST_CLOCK_BLINK
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
		Global.VAR_MENU_ARRAY_STRING_CAR = Array(Custom String("2016's Lamborghini Aventador SuperVeloce"), Custom String(
			"2021's Koenigsegg Jesko"), Custom String("2020's Lamborghini Sián FKP 37"), Custom String("2020's Pininfarina Battista"),
			Custom String("2018's McLaren Senna"), Custom String("2013's Ferrari LaFerrari"), Custom String("2013's McLaren P1"),
			Custom String("2013's Porsche 918"));
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

disabled rule("Cars / Basic Supercars Pack")
{
	event
	{
		Ongoing - Global;
	}
}

rule("#1 Lamborghini Aventador SuperVeloce 2016 (Mesh Array Tables)")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		"FOR INDEXES REFER TO: MENU \\ ARRAY TABLE - INTERNAL STORAGE VARIABLE \n [1] - CURRENT CAR \n Rule Elements Count: 2754"
		Global.VAR_GBL_INTRNL_STORED_VALUES[1] == 0;
		Entity Exists(Global.VAR_PLAYER_RACER) == True;
	}

	actions
	{
		"VERTICES COUNT: 258 \n EDGE COUNT: 230 \n Car models ported with Deltin's OSTW for Visual Studio Code"
		Global.VAR_VEH_MESH_VRTCS_FRONT_BUMPER = Array(Vector(Empty Array, 0.479, 3.242), Vector(0.568, 0.499, 3.118), Vector(1.009, 0.573,
			2.850), Vector(0.534, 0.730, 2.830), Vector(Empty Array, 0.327, 3.181), Vector(Empty Array, 0.730, 2.945), Vector(0.732, 0.323,
			2.868), Vector(-0.568, 0.499, 3.118), Vector(-1.009, 0.573, 2.850), Vector(-0.534, 0.730, 2.830), Vector(-0.732, 0.323, 2.868),
			Vector(-0.539, 0.529, 3.063), Vector(0.539, 0.529, 3.063));
		Global.VAR_VEH_MESH_VRTCS_FRONT_HOOD = Array(Vector(0.534, 0.730, 2.830), Vector(Empty Array, 1.030, 2.015), Vector(0.389, 1.032,
			1.988), Vector(Empty Array, 0.730, 2.945), Vector(0.729, 0.759, 2.765), Vector(0.996, 1.011, 2.117), Vector(0.818, 0.822,
			2.607), Vector(1.122, 1.059, 1.546), Vector(-0.534, 0.730, 2.830), Vector(-0.389, 1.032, 1.988), Vector(-0.729, 0.759, 2.765),
			Vector(-0.996, 1.011, 2.117), Vector(-0.818, 0.822, 2.607), Vector(-1.122, 1.059, 1.546));
		Global.VAR_VEH_MESH_VRTCS_BODY = Array(Vector(1.151, 0.574, 2.619), Vector(1.009, 0.573, 2.850), Vector(1.254, 0.286, 2.337),
			Vector(1.146, 0.887, 2.382), Vector(1.319, 0.836, 1.171), Vector(1.304, 0.299, 1.173), Vector(1.303, 0.171, -1.475), Vector(
			0.807, 1.432, 0.479), Vector(0.755, 1.446, -1.075), Vector(1.311, 0.538, -1.455), Vector(1.371, 0.920, -2.287), Vector(1.354,
			0.936, -1.726), Vector(Empty Array, 1.464, 0.559), Vector(1.249, 1.050, 1.689), Vector(1.329, 0.698, 2.125), Vector(1.186,
			1.198, -1.498), Vector(1.330, 0.893, 1.698), Vector(1.198, 1.117, -0.723), Vector(1.344, 0.804, -1.630), Vector(1.233, 0.997,
			-0.575), Vector(1.190, 0.466, -0.378), Vector(1.225, 0.937, 1.015), Vector(1.281, 0.184, 2.169), Vector(1.331, 0.697, 2.069),
			Vector(1.346, 0.553, -2.482), Vector(0.769, 1.494, -0.310), Vector(1.122, 1.059, 1.546), Vector(-1.151, 0.574, 2.619), Vector(
			-1.009, 0.573, 2.850), Vector(-1.146, 0.887, 2.382), Vector(-1.321, 0.771, 1.328), Vector(-1.304, 0.299, 1.173), Vector(-1.303,
			0.171, -1.475), Vector(-0.807, 1.432, 0.479), Vector(-0.755, 1.446, -1.075), Vector(-1.311, 0.538, -1.455), Vector(-1.371,
			0.920, -2.287), Vector(-1.354, 0.936, -1.726), Vector(-1.249, 1.050, 1.689), Vector(-1.329, 0.698, 2.125), Vector(-1.186,
			1.198, -1.498), Vector(-1.316, 0.342, 1.081), Vector(-1.330, 0.893, 1.698), Vector(-1.198, 1.117, -0.723), Vector(-1.344,
			0.804, -1.630), Vector(-1.319, 0.836, 1.171), Vector(-1.233, 0.997, -0.575), Vector(-1.190, 0.466, -0.378), Vector(-1.156,
			1.079, -2.845), Vector(-1.225, 0.937, 1.015), Vector(-1.281, 0.184, 2.169), Vector(-1.331, 0.697, 2.069), Vector(-0.769, 1.494,
			-0.310), Vector(-1.122, 1.059, 1.546), Vector(-1.254, 0.286, 2.337), Vector(-1.302, 0.286, 2.177), Vector(1.302, 0.286, 2.177),
			Vector(1.316, 0.342, 1.081), Vector(1.239, 0.721, -2.732), Vector(1.156, 1.079, -2.845), Vector(-1.239, 0.721, -2.732), Vector(
			-1.346, 0.553, -2.482), Vector(Empty Array, 1.470, -0.972), Vector(Empty Array, 1.519, -0.207), Vector(1.321, 0.771, 1.328));
		Global.VAR_VEH_MESH_VRTCS_ENGINE_HOOD = Array(Vector(Empty Array, 1.150, -2.882), Vector(0.755, 1.446, -1.075), Vector(0.398,
			1.495, -0.876), Vector(0.673, 1.198, -2.774), Vector(-0.755, 1.446, -1.075), Vector(-0.398, 1.495, -0.876), Vector(-0.673,
			1.198, -2.774), Vector(0.928, 1.184, -2.668), Vector(0.976, 1.206, -2.439), Vector(-0.928, 1.184, -2.668), Vector(-0.976,
			1.206, -2.439), Vector(Empty Array, 1.470, -0.972), Vector(0.432, 1.148, -2.825), Vector(-0.432, 1.148, -2.825), Vector(0.540,
			1.439, -1.328), Vector(0.627, 1.277, -2.378), Vector(-0.627, 1.277, -2.378), Vector(-0.540, 1.439, -1.328), Vector(0.385,
			1.182, -2.537), Vector(-0.385, 1.182, -2.537), Vector(-0.369, 1.453, -1.209), Vector(Empty Array, 1.182, -2.616), Vector(0.369,
			1.453, -1.209), Vector(Empty Array, 1.428, -1.292));
		Global.VAR_VEH_MESH_VRTCS_REAR_BUMPER = Array(Vector(0.928, 1.184, -2.668), Vector(1.156, 1.079, -2.845), Vector(0.546, 1.143,
			-3.172), Vector(0.698, 0.660, -3.165), Vector(1.149, 0.299, -2.884), Vector(-0.928, 1.184, -2.668), Vector(-0.698, 0.660,
			-3.165), Vector(-1.156, 1.079, -2.845), Vector(-0.546, 1.143, -3.172), Vector(-1.149, 0.299, -2.884));
		Global.VAR_VEH_MESH_VRTCS_HEADLIGHTS = Array(Vector(0.875, 0.678, 2.836), Vector(1.111, 0.903, 2.335), Vector(0.729, 0.759, 2.765),
			Vector(1.025, 0.692, 2.746), Vector(-0.875, 0.678, 2.836), Vector(-1.111, 0.903, 2.335), Vector(-0.729, 0.759, 2.765), Vector(
			-1.025, 0.692, 2.746));
		Global.VAR_VEH_MESH_VRTCS_L_R_LIGHTS = Array(Vector(0.555, 1.049, -3.107), Vector(1.131, 1.010, -2.858));
		Global.VAR_VEH_MESH_VRTCS_R_R_LIGHTS = Array(Vector(-0.555, 1.049, -3.107), Vector(-1.131, 1.010, -2.858));
		Global.VAR_VEH_MESH_VRTCS_NITROUS = Array(Vector(0.248, 0.412, -3.064), Vector(-0.248, 0.412, -3.064));
		Global.VAR_VEH_MESH_VRTCS_CARBON_PARTS = Array(Vector(1.350, 0.508, -0.792), Vector(0.737, 0.704, -3.148), Vector(1.273, 0.953,
			-1.046), Vector(1.229, 0.940, 0.827), Vector(0.846, 1.392, -0.812), Vector(1.027, 1.143, -0.470), Vector(0.477, 1.059, -3.084),
			Vector(1.291, 1.155, 1.002), Vector(1.539, 1.161, 0.827), Vector(Empty Array, 0.190, 3.227), Vector(0.840, 0.165, 2.993),
			Vector(1.281, 0.184, 2.169), Vector(0.714, 0.185, 2.963), Vector(0.790, 0.299, 2.881), Vector(1.155, 0.324, 2.582), Vector(
			1.304, 0.299, 1.173), Vector(1.328, 0.368, -0.379), Vector(1.302, 0.171, -1.475), Vector(1.282, 0.166, 1.228), Vector(0.330,
			0.263, -3.069), Vector(0.330, 0.462, -3.191), Vector(0.532, 0.462, -3.159), Vector(1.248, 0.598, -2.838), Vector(1.307, 0.219,
			-2.464), Vector(1.135, 0.268, -2.813), Vector(1.252, 0.292, -2.709), Vector(1.059, 1.381, -2.976), Vector(1.075, 1.339,
			-2.690), Vector(-0.439, 1.415, -2.919), Vector(0.497, 0.858, -3.140), Vector(0.449, 1.407, -2.926), Vector(0.532, 0.286,
			-3.044), Vector(0.733, 0.457, -3.111), Vector(0.733, 0.286, -2.999), Vector(1.049, 0.184, 2.830), Vector(0.568, 0.481, 3.084),
			Vector(1.028, 0.552, 2.729), Vector(1.346, 0.553, -2.482), Vector(0.439, 1.415, -2.919), Vector(0.439, 1.450, -3.234), Vector(
			0.765, 1.460, -0.511), Vector(0.955, 1.261, -0.980), Vector(0.830, 1.263, -2.300), Vector(0.758, 1.425, -1.206), Vector(0.976,
			1.206, -2.439), Vector(1.106, 1.234, -1.715), Vector(0.496, 0.858, -3.064), Vector(-1.350, 0.508, -0.792), Vector(-0.737,
			0.704, -3.148), Vector(-1.273, 0.953, -1.046), Vector(-1.229, 0.940, 0.827), Vector(-0.846, 1.392, -0.812), Vector(-1.027,
			1.143, -0.470), Vector(-0.477, 1.059, -3.084), Vector(-1.291, 1.155, 1.002), Vector(-1.539, 1.161, 0.827), Vector(-0.840,
			0.165, 2.993), Vector(-1.281, 0.184, 2.169), Vector(-0.714, 0.185, 2.963), Vector(-0.790, 0.299, 2.881), Vector(-1.155, 0.324,
			2.582), Vector(-1.304, 0.299, 1.173), Vector(-1.328, 0.368, -0.379), Vector(-1.302, 0.171, -1.475), Vector(-1.282, 0.166,
			1.228), Vector(-0.330, 0.263, -3.069), Vector(-0.330, 0.462, -3.191), Vector(-0.532, 0.462, -3.159), Vector(-1.248, 0.598,
			-2.838), Vector(-1.307, 0.219, -2.464), Vector(-1.135, 0.268, -2.813), Vector(-1.252, 0.292, -2.709), Vector(-1.059, 1.381,
			-2.976), Vector(-1.075, 1.339, -2.690), Vector(-0.497, 0.858, -3.140), Vector(-0.449, 1.407, -2.926), Vector(-0.532, 0.286,
			-3.044), Vector(-0.733, 0.457, -3.111), Vector(-0.733, 0.286, -2.999), Vector(-1.049, 0.184, 2.830), Vector(-0.568, 0.481,
			3.084), Vector(-1.028, 0.552, 2.729), Vector(-1.346, 0.553, -2.482), Vector(0.369, 1.398, -1.196), Vector(-0.439, 1.450,
			-3.234), Vector(-0.765, 1.460, -0.511), Vector(-0.955, 1.261, -0.980), Vector(-0.830, 1.263, -2.300), Vector(-0.758, 1.425,
			-1.206), Vector(-0.976, 1.206, -2.439), Vector(-1.106, 1.234, -1.715), Vector(-0.369, 1.398, -1.196), Vector(-0.496, 0.858,
			-3.064), Vector(0.619, 0.708, -3.045), Vector(-0.619, 0.708, -3.045), Vector(1.156, 0.966, 0.916), Vector(-1.156, 0.966,
			0.916), Vector(0.944, 1.274, 0.881), Vector(-0.944, 1.274, 0.881), Vector(0.337, 1.393, -1.480), Vector(-0.337, 1.393, -1.480),
			Vector(0.002, 1.369, -1.557), Vector(0.384, 1.346, -1.498), Vector(-0.384, 1.346, -1.498), Vector(0.362, 1.346, -1.820),
			Vector(-0.362, 1.346, -1.820), Vector(-0.407, 1.283, -1.837), Vector(0.407, 1.283, -1.837), Vector(-0.372, 1.283, -2.198),
			Vector(0.372, 1.283, -2.198), Vector(0.002, 1.315, -1.889), Vector(0.002, 1.251, -2.278), Vector(-0.564, 1.249, -2.257),
			Vector(0.564, 1.249, -2.257), Vector(0.538, 1.318, -1.873), Vector(-0.538, 1.318, -1.873), Vector(0.513, 1.370, -1.552),
			Vector(-0.513, 1.370, -1.552));
		Global.VAR_VEH_MESH_EDGES_FRONT_BUMPER = Array(1, 2, 1, 3, 0, 5, 7, 8, 7, 9, 4, 6, 4, 10, 0, 11, 0, 12);
		Global.VAR_VEH_MESH_EDGES_FRONT_HOOD = Array(2, 7, 0, 2, 0, 4, 6, 5, 3, 1, 0, 3, 5, 7, 1, 2, 9, 13, 8, 9, 8, 10, 12, 11, 8, 3, 11,
			13, 1, 9);
		Global.VAR_VEH_MESH_EDGES_BODY = Array(1, 0, 0, 14, 1, 3, 0, 2, 16, 64, 64, 5, 26, 7, 8, 15, 11, 10, 6, 9, 9, 11, 25, 8, 7, 12, 3,
			13, 17, 18, 15, 21, 19, 20, 22, 23, 23, 16, 10, 24, 7, 25, 26, 21, 13, 26, 28, 27, 27, 39, 28, 29, 38, 45, 49, 45, 30, 31, 53,
			33, 34, 40, 37, 36, 32, 35, 35, 37, 52, 34, 33, 12, 29, 38, 43, 44, 40, 49, 46, 47, 50, 51, 51, 42, 48, 36, 33, 52, 53, 49, 48,
			40, 38, 53, 21, 4, 41, 45, 54, 55, 58, 59, 42, 30, 59, 10, 59, 15, 27, 54, 36, 61, 2, 56, 60, 48, 24, 58, 61, 60, 63, 62, 12,
			63, 37, 40, 11, 15, 57, 4, 13, 4, 38, 42, 13, 16);
		Global.VAR_VEH_MESH_EDGES_ENGINE_HOOD = Array(12, 3, 11, 2, 4, 5, 13, 6, 1, 2, 7, 8, 9, 10, 3, 7, 6, 9, 5, 11, 0, 12, 0, 13, 16,
			17, 15, 14, 23, 20, 19, 21, 22, 23, 15, 18, 16, 19, 21, 18, 14, 22, 17, 20, 3, 15, 6, 16);
		Global.VAR_VEH_MESH_EDGES_REAR_BUMPER = Array(1, 2, 0, 1, 6, 3, 7, 8, 9, 6, 5, 7, 2, 8, 4, 3);
		Global.VAR_VEH_MESH_EDGES_HEADLIGHTS = Array(2, 1, 0, 2, 3, 1, 0, 3, 6, 5, 4, 6, 7, 5, 4, 7);
		Global.VAR_VEH_MESH_EDGES_L_R_LIGHTS = Array(0, 1);
		Global.VAR_VEH_MESH_EDGES_R_R_LIGHTS = Array(0, 1);
		Global.VAR_VEH_MESH_EDGES_NITROUS = Array(1, 0);
		Global.VAR_VEH_MESH_EDGES_CARBON_PARTS = Array(6, 29, 0, 2, 4, 41, 26, 27, 22, 1, 3, 7, 7, 8, 12, 10, 10, 13, 15, 16, 16, 17, 15,
			18, 18, 17, 21, 31, 37, 23, 23, 25, 38, 28, 39, 26, 20, 19, 29, 1, 30, 46, 25, 22, 32, 33, 34, 11, 10, 34, 9, 12, 24, 25, 13,
			35, 36, 14, 22, 37, 27, 38, 40, 5, 14, 34, 43, 42, 42, 44, 44, 45, 43, 45, 53, 74, 47, 49, 51, 86, 72, 73, 68, 48, 50, 54, 54,
			55, 58, 56, 56, 59, 61, 62, 62, 63, 61, 64, 64, 63, 67, 76, 82, 69, 69, 71, 84, 72, 66, 65, 74, 48, 75, 92, 71, 68, 77, 78, 79,
			57, 56, 79, 9, 58, 70, 71, 59, 80, 81, 60, 68, 82, 85, 52, 60, 79, 88, 87, 87, 89, 89, 90, 88, 90, 84, 39, 73, 28, 94, 93, 95,
			97, 96, 98, 91, 100, 103, 105, 83, 99, 102, 104, 106, 108, 107, 109, 109, 111, 108, 111, 105, 110, 104, 110, 100, 101, 99, 101,
			108, 112, 109, 113, 104, 114, 105, 115, 99, 116, 100, 117);
		"PASTE YOUR CAR HERE - Original Gamemode Creator: GraczCourier (now known as RaidVentador_Courier_13)"
		Global.VAR_PLAYER_RACER.VAR_VEH_COLOR_DEFAULT = Color(Blue);
		Call Subroutine(SUB_VEH_VSL_GET_COLORS);
	}
}

rule("#2 Koenigsegg Jesko 2021 (Mesh Array Tables)")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		"FOR INDEXES REFER TO: MENU \\ ARRAY TABLE - INTERNAL STORAGE VARIABLE \n [1] - CURRENT CAR \n Rule Elements Count: 2597"
		Global.VAR_GBL_INTRNL_STORED_VALUES[1] == 1;
		Entity Exists(Global.VAR_PLAYER_RACER) == True;
	}

	actions
	{
		"VERTICES COUNT: 250 \n EDGE COUNT: 205 \n Car models ported with Deltin's OSTW for Visual Studio Code"
		Global.VAR_VEH_MESH_VRTCS_FRONT_BUMPER = Array(Vector(Empty Array, 0.453, 3.094), Vector(Empty Array, 0.453, 3.094), Vector(1.418,
			0.187, 2.271), Vector(1.335, 0.909, 2.359), Vector(1.381, 0.620, 1.284), Vector(1.297, 0.975, 1.180), Vector(1.204, 0.528,
			2.675), Vector(1.175, 0.322, 2.642), Vector(0.629, 0.482, 2.935), Vector(1.407, 0.302, 2.281), Vector(1.356, 0.858, 1.215),
			Vector(1.335, 1.087, 1.799), Vector(1.025, 0.532, 2.730), Vector(1.384, 0.982, 1.795), Vector(1.051, 1.092, 0.929), Vector(
			1.383, 0.666, 2.303), Vector(-1.418, 0.187, 2.271), Vector(-1.335, 0.909, 2.359), Vector(-1.381, 0.620, 1.284), Vector(-1.297,
			0.975, 1.180), Vector(-1.204, 0.528, 2.675), Vector(-1.175, 0.322, 2.642), Vector(-0.629, 0.482, 2.935), Vector(-1.407, 0.302,
			2.281), Vector(-1.356, 0.858, 1.215), Vector(-1.335, 1.087, 1.799), Vector(-1.025, 0.532, 2.730), Vector(-1.384, 0.982, 1.795),
			Vector(-1.051, 1.092, 0.929), Vector(-1.383, 0.666, 2.303), Vector(-1.350, 0.632, 1.115), Vector(1.350, 0.632, 1.115), Vector(
			Empty Array, 0.653, 2.935));
		Global.VAR_VEH_MESH_VRTCS_FRONT_HOOD = Array(Vector(0.656, 0.724, 2.738), Vector(0.875, 1.001, 1.926), Vector(1.051, 1.092, 0.929),
			Vector(-0.656, 0.724, 2.738), Vector(-0.875, 1.001, 1.926), Vector(-1.051, 1.092, 0.929), Vector(-0.241, 0.653, 2.935), Vector(
			0.241, 0.653, 2.935));
		Global.VAR_VEH_MESH_VRTCS_BODY = Array(Vector(Empty Array, 1.507, 0.862), Vector(1.381, 0.620, 1.284), Vector(1.354, 0.174, 1.312),
			Vector(1.402, 0.752, -1.472), Vector(0.715, 1.470, 0.316), Vector(1.349, 1.058, -0.698), Vector(1.301, 0.490, -0.348), Vector(
			1.187, 0.366, 0.817), Vector(0.365, 1.511, 0.782), Vector(1.382, 0.166, -1.501), Vector(1.055, 1.074, 0.831), Vector(0.255,
			1.553, -0.635), Vector(1.397, 0.976, -1.363), Vector(0.760, 1.405, -0.689), Vector(Empty Array, 1.612, 0.327), Vector(1.019,
			1.162, -0.719), Vector(1.133, 1.030, 0.898), Vector(1.251, 1.200, -0.709), Vector(1.381, 0.435, -0.782), Vector(1.344, 0.280,
			0.913), Vector(-1.381, 0.620, 1.284), Vector(-1.354, 0.174, 1.312), Vector(-1.402, 0.752, -1.472), Vector(-1.284, 0.943,
			1.029), Vector(-0.715, 1.470, 0.316), Vector(-1.349, 1.058, -0.698), Vector(-1.301, 0.490, -0.348), Vector(-1.187, 0.366,
			0.817), Vector(-0.365, 1.511, 0.782), Vector(-1.382, 0.166, -1.501), Vector(-1.055, 1.074, 0.831), Vector(-0.255, 1.553,
			-0.635), Vector(-1.397, 0.976, -1.363), Vector(-0.760, 1.405, -0.689), Vector(-1.019, 1.162, -0.719), Vector(-1.133, 1.030,
			0.898), Vector(-1.381, 0.435, -0.782), Vector(-1.344, 0.280, 0.913), Vector(1.284, 0.943, 1.029), Vector(1.284, 0.935, 1.206),
			Vector(1.405, 1.035, -1.801), Vector(-1.284, 0.935, 1.206), Vector(-1.405, 1.035, -1.801), Vector(-1.350, 0.632, 1.115),
			Vector(1.350, 0.632, 1.115), Vector(-1.251, 1.200, -0.709), Vector(1.403, 0.960, -2.339), Vector(-1.403, 0.960, -2.339));
		Global.VAR_VEH_MESH_VRTCS_ENGINE_HOOD = Array(Vector(1.417, 0.965, -2.331), Vector(0.902, 1.208, -2.113), Vector(1.246, 1.259,
			-1.996), Vector(1.349, 1.058, -0.698), Vector(0.760, 1.405, -0.689), Vector(1.019, 1.162, -0.719), Vector(1.207, 1.107,
			-2.710), Vector(0.403, 0.899, -2.894), Vector(0.803, 1.041, -3.015), Vector(1.251, 1.200, -0.709), Vector(-0.492, 0.947,
			-3.098), Vector(-0.902, 1.208, -2.113), Vector(-1.246, 1.259, -1.996), Vector(-1.349, 1.058, -0.698), Vector(-1.417, 0.965,
			-2.331), Vector(-0.760, 1.405, -0.689), Vector(-1.019, 1.162, -0.719), Vector(-1.207, 1.107, -2.710), Vector(-0.403, 0.899,
			-2.894), Vector(Empty Array, 0.926, -3.172), Vector(-0.803, 1.041, -3.015), Vector(Empty Array, 0.903, -3.010), Vector(0.659,
			0.947, -3.098), Vector(0.492, 0.947, -3.098), Vector(-0.659, 0.947, -3.098), Vector(1.405, 1.068, -1.989), Vector(-1.405,
			1.068, -1.989), Vector(-1.251, 1.200, -0.709));
		Global.VAR_VEH_MESH_VRTCS_REAR_BUMPER = Array(Vector(1.293, 0.342, -2.590), Vector(0.882, 0.299, -3.033), Vector(0.914, 0.838,
			-3.038), Vector(1.113, 0.487, -2.873), Vector(Empty Array, 0.901, -3.229), Vector(-1.293, 0.342, -2.590), Vector(-0.882, 0.299,
			-3.033), Vector(-0.914, 0.838, -3.038), Vector(-1.113, 0.487, -2.873), Vector(1.402, 0.782, -2.540), Vector(-1.402, 0.782,
			-2.540), Vector(1.403, 0.966, -2.414), Vector(-1.403, 0.966, -2.414), Vector(1.403, 0.960, -2.339), Vector(-1.403, 0.960,
			-2.339), Vector(1.331, 1.727, -2.137), Vector(1.286, 1.583, -2.245), Vector(1.286, 1.486, -2.580), Vector(0.330, 1.473,
			-3.171), Vector(1.286, 1.563, -2.687), Vector(1.286, 1.572, -2.702), Vector(-1.331, 1.727, -2.137), Vector(-1.286, 1.583,
			-2.245), Vector(-1.286, 1.486, -2.580), Vector(-0.330, 1.473, -3.171), Vector(-1.286, 1.563, -2.687), Vector(-1.286, 1.572,
			-2.702), Vector(0.213, 1.398, -3.045), Vector(-0.213, 1.398, -3.045));
		Global.VAR_VEH_MESH_VRTCS_HEADLIGHTS = Array(Vector(1.157, 0.958, 2.157), Vector(1.030, 0.714, 2.618), Vector(-1.157, 0.958,
			2.157), Vector(-1.030, 0.714, 2.618));
		Global.VAR_VEH_MESH_VRTCS_L_R_LIGHTS = Array(Vector(0.859, 0.999, -2.951), Vector(1.290, 1.018, -2.518));
		Global.VAR_VEH_MESH_VRTCS_R_R_LIGHTS = Array(Vector(-0.859, 0.999, -2.951), Vector(-1.290, 1.018, -2.518));
		Global.VAR_VEH_MESH_VRTCS_NITROUS = Array(Vector(0.167, 0.774, -3.254), Vector(-0.167, 0.774, -3.254));
		Global.VAR_VEH_MESH_VRTCS_CARBON_PARTS = Array(Vector(Empty Array, 0.453, 3.094), Vector(1.418, 0.187, 2.271), Vector(1.354, 0.174,
			1.312), Vector(1.456, 0.267, -1.494), Vector(1.355, 0.178, -1.048), Vector(0.167, 0.679, -3.271), Vector(0.807, 0.218, 3.123),
			Vector(1.382, 0.166, -1.501), Vector(0.255, 1.553, -0.635), Vector(0.193, 1.612, 0.235), Vector(0.330, 1.478, -3.143), Vector(
			0.288, 1.236, -1.989), Vector(0.204, 0.963, -2.694), Vector(1.301, 1.471, -2.400), Vector(1.004, 0.692, -2.946), Vector(
			Empty Array, 0.505, -3.226), Vector(0.189, 0.191, -3.054), Vector(0.213, 0.484, -3.122), Vector(0.614, 0.177, -3.054), Vector(
			0.620, 0.496, -3.122), Vector(0.901, 0.277, -3.099), Vector(0.774, 0.494, -3.122), Vector(1.040, 0.616, -2.899), Vector(1.311,
			1.384, -2.397), Vector(1.339, 0.207, 2.744), Vector(0.629, 0.482, 2.935), Vector(0.581, 0.321, 2.841), Vector(0.328, 1.452,
			-1.074), Vector(1.349, 0.204, 2.690), Vector(1.311, 1.357, -2.656), Vector(Empty Array, 1.612, 0.327), Vector(0.320, 1.376,
			-2.708), Vector(Empty Array, 0.266, 3.010), Vector(-1.418, 0.187, 2.271), Vector(-1.354, 0.174, 1.312), Vector(-1.456, 0.267,
			-1.494), Vector(-1.355, 0.178, -1.048), Vector(-0.167, 0.679, -3.271), Vector(-1.339, 0.207, 2.744), Vector(-1.382, 0.166,
			-1.501), Vector(-0.255, 1.553, -0.635), Vector(-0.193, 1.612, 0.235), Vector(-0.330, 1.478, -3.143), Vector(-0.288, 1.236,
			-1.989), Vector(-0.204, 0.963, -2.694), Vector(-1.301, 1.471, -2.400), Vector(-1.004, 0.692, -2.946), Vector(-0.189, 0.191,
			-3.054), Vector(-0.213, 0.484, -3.122), Vector(-0.614, 0.177, -3.054), Vector(-0.620, 0.496, -3.122), Vector(-0.901, 0.277,
			-3.099), Vector(-0.774, 0.494, -3.122), Vector(-1.040, 0.616, -2.899), Vector(-1.311, 1.384, -2.397), Vector(-0.807, 0.218,
			3.123), Vector(-0.629, 0.482, 2.935), Vector(-0.581, 0.321, 2.841), Vector(-0.328, 1.452, -1.074), Vector(-1.349, 0.204,
			2.690), Vector(-1.311, 1.357, -2.656), Vector(-1.286, 1.583, -2.245), Vector(-0.320, 1.376, -2.708), Vector(-1.286, 1.572,
			-2.702), Vector(Empty Array, 0.218, 3.243), Vector(1.451, 0.274, 2.325), Vector(-1.451, 0.274, 2.325), Vector(Empty Array,
			0.921, 2.367), Vector(0.522, 0.963, 2.094), Vector(0.312, 0.929, 2.316), Vector(-0.522, 0.963, 2.094), Vector(-0.312, 0.929,
			2.316), Vector(1.033, 0.982, 2.128), Vector(1.123, 1.080, 1.521), Vector(-1.033, 0.982, 2.128), Vector(-1.123, 1.080, 1.521),
			Vector(1.160, 1, 0.666), Vector(1.512, 1.247, 0.450), Vector(1.308, 1.171, 0.558), Vector(-1.160, 1, 0.666), Vector(-1.512,
			1.247, 0.450), Vector(-1.308, 1.171, 0.558), Vector(0.715, 1.470, 0.316), Vector(0.630, 1.079, 1.516), Vector(1.055, 1.074,
			0.831), Vector(-0.715, 1.470, 0.316), Vector(-1.055, 1.074, 0.831), Vector(-0.630, 1.079, 1.516), Vector(-0.315, 1.079, 1.725),
			Vector(0.315, 1.079, 1.725), Vector(1.286, 1.583, -2.245), Vector(1.286, 1.572, -2.702), Vector(-0.351, 0.618, -3.203), Vector(
			0.351, 0.618, -3.203));
		Global.VAR_VEH_MESH_EDGES_FRONT_BUMPER = Array(32, 0, 13, 4, 3, 6, 15, 13, 11, 3, 7, 12, 5, 14, 12, 8, 11, 13, 2, 15, 5, 10, 5, 11,
			7, 9, 27, 18, 17, 20, 29, 27, 25, 17, 21, 26, 19, 28, 26, 22, 25, 27, 16, 29, 19, 24, 19, 25, 21, 23, 8, 1, 22, 1, 24, 30, 10,
			31);
		Global.VAR_VEH_MESH_EDGES_FRONT_HOOD = Array(1, 0, 2, 1, 4, 3, 5, 4, 3, 6, 6, 7, 0, 7);
		Global.VAR_VEH_MESH_EDGES_BODY = Array(0, 8, 1, 2, 5, 6, 6, 7, 4, 8, 38, 7, 13, 11, 9, 3, 18, 12, 17, 15, 0, 14, 13, 15, 4, 13, 3,
			40, 5, 17, 44, 19, 19, 18, 10, 15, 0, 28, 20, 21, 25, 26, 26, 27, 24, 28, 33, 31, 29, 22, 36, 32, 33, 34, 24, 33, 23, 30, 45,
			35, 43, 37, 37, 36, 30, 34, 38, 10, 22, 42, 23, 27, 5, 39, 25, 41, 17, 16, 45, 34, 25, 45, 40, 46, 42, 47);
		Global.VAR_VEH_MESH_EDGES_ENGINE_HOOD = Array(5, 23, 2, 6, 1, 5, 22, 8, 4, 7, 8, 1, 0, 6, 8, 6, 16, 10, 12, 17, 11, 16, 13, 26, 24,
			20, 15, 18, 20, 11, 14, 17, 20, 17, 24, 19, 21, 18, 7, 21, 22, 19, 3, 25, 12, 27, 2, 9);
		Global.VAR_VEH_MESH_EDGES_REAR_BUMPER = Array(9, 0, 2, 11, 1, 3, 0, 1, 2, 3, 10, 5, 6, 8, 5, 6, 7, 8, 4, 2, 4, 7, 7, 12, 13, 9, 14,
			10, 19, 18, 15, 20, 16, 15, 25, 24, 21, 26, 22, 21, 18, 24, 17, 27, 23, 28, 27, 28);
		Global.VAR_VEH_MESH_EDGES_HEADLIGHTS = Array(0, 1, 2, 3);
		Global.VAR_VEH_MESH_EDGES_L_R_LIGHTS = Array(1, 0);
		Global.VAR_VEH_MESH_EDGES_R_R_LIGHTS = Array(1, 0);
		Global.VAR_VEH_MESH_EDGES_NITROUS = Array(0, 1);
		Global.VAR_VEH_MESH_EDGES_CARBON_PARTS = Array(3, 4, 8, 9, 10, 11, 17, 16, 19, 18, 15, 21, 20, 21, 6, 24, 25, 26, 14, 5, 8, 27, 65,
			28, 9, 30, 64, 55, 2, 7, 27, 10, 29, 23, 13, 31, 44, 58, 12, 27, 35, 36, 6, 26, 40, 41, 42, 43, 48, 47, 50, 49, 31, 62, 51, 52,
			55, 57, 56, 57, 46, 37, 40, 58, 66, 59, 54, 61, 41, 30, 6, 64, 38, 33, 34, 39, 58, 42, 60, 54, 45, 62, 63, 60, 5, 37, 12, 44,
			8, 40, 15, 52, 0, 32, 24, 1, 55, 38, 69, 67, 68, 69, 71, 67, 70, 71, 73, 72, 75, 74, 78, 77, 76, 78, 81, 80, 79, 81, 84, 83,
			89, 83, 84, 82, 86, 87, 86, 85, 87, 88, 88, 89, 91, 90, 53, 92, 22, 93, 23, 90, 91, 29, 92, 93, 63, 61);
		"PASTE YOUR CAR HERE - Original Gamemode Creator: GraczCourier (now known as RaidVentador_Courier_13)"
		Global.VAR_PLAYER_RACER.VAR_VEH_COLOR_DEFAULT = Color(Gray);
		Call Subroutine(SUB_VEH_VSL_GET_COLORS);
	}
}

rule("#3 Lamborghini Sián FKP 37 2021 (Mesh Array Tables)")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		"FOR INDEXES REFER TO: MENU \\ ARRAY TABLE - INTERNAL STORAGE VARIABLE \n [1] - CURRENT CAR \n Rule Elements Count: 2642"
		Global.VAR_GBL_INTRNL_STORED_VALUES[1] == 2;
		Entity Exists(Global.VAR_PLAYER_RACER) == True;
	}

	actions
	{
		"VERTICES COUNT: 250 \n EDGE COUNT: 210 \n Car models ported with Deltin's OSTW for Visual Studio Code"
		Global.VAR_VEH_MESH_VRTCS_FRONT_BUMPER = Array(Vector(0.783, 0.175, 3.052), Vector(0.001, 0.175, 3.214), Vector(-0.782, 0.175,
			3.052));
		Global.VAR_VEH_MESH_VRTCS_FRONT_HOOD = Array(Vector(0.586, 0.483, 3.099), Vector(0.241, 0.943, 2.266), Vector(0.930, 1.026, 1.752),
			Vector(1.088, 0.966, 1.973), Vector(0.001, 0.456, 3.252), Vector(-0.585, 0.483, 3.099), Vector(-0.928, 1.026, 1.752), Vector(
			-0.240, 0.943, 2.266), Vector(-1.087, 0.966, 1.973), Vector(0.308, 0.866, 2.450), Vector(-0.306, 0.866, 2.450));
		Global.VAR_VEH_MESH_VRTCS_BODY = Array(Vector(1.275, 0.177, 2.085), Vector(1.299, 0.596, 2.080), Vector(1.249, 0.911, 1.629),
			Vector(1.308, 0.370, -0.233), Vector(1.264, 0.250, 1.215), Vector(1.170, 0.285, 2.506), Vector(1.065, 0.228, 2.772), Vector(
			0.640, 0.442, 3.026), Vector(1.308, 0.365, -0.140), Vector(1.201, 0.541, -0.413), Vector(1.299, 0.798, 0.145), Vector(1.216,
			1.092, 0.961), Vector(0.756, 1.383, 0.499), Vector(0.868, 1.349, -0.877), Vector(0.001, 1.418, 0.575), Vector(0.685, 1.444,
			-0.086), Vector(1.280, 0.720, 1.257), Vector(1.187, 0.932, 2.072), Vector(1.471, 1.115, 0.828), Vector(0.702, 1.424, -0.855),
			Vector(0.161, 1.430, 0.394), Vector(0.303, 1.437, -0.856), Vector(1.281, 0.668, 1.203), Vector(1.202, 0.177, 1.214), Vector(
			1.237, 1.011, -0.616), Vector(0.232, 1.470, -0.231), Vector(1.088, 0.966, 1.973), Vector(1.104, 1.047, 1.552), Vector(1.037,
			1.097, -0.468), Vector(1.200, 0.911, 1.001), Vector(1.159, 0.529, 2.670), Vector(1.290, 0.268, 2.123), Vector(-1.273, 0.177,
			2.085), Vector(-1.297, 0.596, 2.080), Vector(-1.247, 0.911, 1.629), Vector(-1.306, 0.370, -0.233), Vector(-1.263, 0.250,
			1.215), Vector(-1.168, 0.285, 2.506), Vector(-1.064, 0.228, 2.772), Vector(-0.639, 0.442, 3.026), Vector(-1.306, 0.365,
			-0.140), Vector(-1.199, 0.541, -0.413), Vector(-1.297, 0.798, 0.145), Vector(-1.215, 1.092, 0.961), Vector(-0.754, 1.383,
			0.499), Vector(-0.867, 1.349, -0.877), Vector(-0.684, 1.444, -0.086), Vector(-1.278, 0.720, 1.257), Vector(-1.186, 0.932,
			2.072), Vector(-1.470, 1.115, 0.828), Vector(-0.701, 1.424, -0.855), Vector(-0.159, 1.430, 0.394), Vector(-0.302, 1.437,
			-0.856), Vector(-1.280, 0.668, 1.203), Vector(-1.200, 0.177, 1.214), Vector(-1.236, 1.011, -0.616), Vector(-0.231, 1.470,
			-0.231), Vector(-1.087, 0.966, 1.973), Vector(-1.102, 1.047, 1.552), Vector(-1.035, 1.097, -0.468), Vector(-1.199, 0.911,
			1.001), Vector(-1.158, 0.529, 2.670), Vector(-1.289, 0.268, 2.123), Vector(-1.243, 1.030, 1.552), Vector(1.244, 1.030, 1.552),
			Vector(1.305, 0.617, -1.422), Vector(1.343, 0.948, -1.909), Vector(1.242, 0.541, -2.393), Vector(1.204, 0.960, -2.717), Vector(
			1.327, 1.004, -1.876), Vector(1.055, 0.786, 2.346), Vector(1.231, 0.178, -1.400), Vector(1.199, 1.088, -2.244), Vector(1.088,
			1.178, -2.003), Vector(1.335, 0.925, -1.060), Vector(-1.304, 0.617, -1.422), Vector(-1.342, 0.948, -1.909), Vector(-1.241,
			0.541, -2.393), Vector(-1.203, 0.960, -2.717), Vector(-1.326, 1.004, -1.876), Vector(-0.867, 1.349, -0.877), Vector(-0.701,
			1.424, -0.855), Vector(-1.054, 0.786, 2.346), Vector(-1.230, 0.178, -1.400), Vector(-1.197, 1.088, -2.244), Vector(-1.086,
			1.178, -2.003), Vector(-1.333, 0.925, -1.060), Vector(0.930, 1.026, 1.752), Vector(-0.928, 1.026, 1.752));
		Global.VAR_VEH_MESH_VRTCS_ENGINE_HOOD = Array(Vector(1.033, 1.164, -2.446), Vector(0.868, 1.349, -0.877), Vector(0.182, 1.045,
			-2.868), Vector(0.702, 1.424, -0.855), Vector(0.303, 1.437, -0.856), Vector(1.237, 1.011, -0.616), Vector(0.938, 1.214,
			-1.810), Vector(1.088, 1.178, -2.003), Vector(0.664, 1.281, -1.803), Vector(0.476, 1.250, -2.069), Vector(0.573, 1.147,
			-2.729), Vector(-1.032, 1.164, -2.446), Vector(-0.867, 1.349, -0.877), Vector(-0.180, 1.045, -2.868), Vector(-0.701, 1.424,
			-0.855), Vector(-0.302, 1.437, -0.856), Vector(-1.236, 1.011, -0.616), Vector(-0.936, 1.214, -1.810), Vector(-1.086, 1.178,
			-2.003), Vector(-0.663, 1.281, -1.803), Vector(-0.475, 1.250, -2.069), Vector(-0.572, 1.147, -2.729));
		Global.VAR_VEH_MESH_VRTCS_REAR_BUMPER = Array(Vector(1.152, 0.786, -2.691), Vector(0.769, 0.790, -3.023), Vector(0.236, 0.942,
			-3.238), Vector(0.795, 0.399, -2.839), Vector(1.044, 1.078, -2.701), Vector(0.841, 0.492, -2.719), Vector(0.564, 1.055,
			-3.088), Vector(-1.151, 0.786, -2.691), Vector(-0.768, 0.790, -3.023), Vector(-0.235, 0.942, -3.238), Vector(-0.794, 0.399,
			-2.839), Vector(-1.043, 1.078, -2.701), Vector(-0.840, 0.492, -2.719), Vector(-1.157, 0.522, -2.529), Vector(-0.563, 1.055,
			-3.088), Vector(1.159, 0.522, -2.529));
		Global.VAR_VEH_MESH_VRTCS_HEADLIGHTS = Array(Vector(0.630, 0.463, 3.121), Vector(1.053, 0.323, 2.683), Vector(0.881, 0.490, 2.964),
			Vector(1.027, 0.681, 2.550), Vector(-0.629, 0.463, 3.121), Vector(-1.052, 0.323, 2.683), Vector(-0.880, 0.490, 2.964), Vector(
			-1.026, 0.681, 2.550));
		Global.VAR_VEH_MESH_VRTCS_L_R_LIGHTS = Array(Vector(0.565, 0.980, -3.051), Vector(1.048, 0.980, -2.792), Vector(0.236, 1.010,
			-3.238), Vector(0.001, 1.010, -3.238));
		Global.VAR_VEH_MESH_VRTCS_R_R_LIGHTS = Array(Vector(-0.563, 0.980, -3.051), Vector(-1.047, 0.980, -2.792), Vector(-0.235, 1.010,
			-3.238), Vector(0.001, 1.010, -3.238));
		Global.VAR_VEH_MESH_VRTCS_NITROUS = Array(Vector(0.487, 0.641, -3.141), Vector(0.487, 0.641, -3.241), Vector(-0.486, 0.641,
			-3.141), Vector(-0.486, 0.641, -3.241));
		Global.VAR_VEH_MESH_VRTCS_CARBON_PARTS = Array(Vector(1.275, 0.177, 2.085), Vector(1.242, 0.541, -2.393), Vector(1.335, 0.923,
			-1.059), Vector(1.308, 0.370, -0.233), Vector(1.216, 1.092, 0.961), Vector(0.795, 0.399, -2.839), Vector(0.303, 1.437, -0.856),
			Vector(0.401, 1.175, -2.242), Vector(0.783, 0.175, 3.052), Vector(1.216, 1.018, -0.815), Vector(1.168, 0.175, 2.659), Vector(
			0.556, 0.396, 3.148), Vector(0.657, 0.340, 3.053), Vector(1.179, 0.341, -2.403), Vector(1.187, 0.402, -2.606), Vector(1.045,
			1.103, -2.882), Vector(1.048, 1.260, -2.694), Vector(1.086, 1.250, -2.281), Vector(0.157, 1.096, -2.555), Vector(0.762, 0.619,
			-3.016), Vector(0.613, 0.641, -3.141), Vector(0.550, 0.539, -3.168), Vector(0.333, 0.625, -3.200), Vector(0.781, 0.193,
			-2.327), Vector(0.472, 0.245, -2.685), Vector(0.288, 0.593, -3.152), Vector(0.288, 0.211, -2.519), Vector(0.001, 1.390,
			-1.165), Vector(0.374, 1.195, -1.915), Vector(0.327, 1.277, -1.521), Vector(0.001, 1.301, -1.367), Vector(-0.370, 1.154,
			-2.062), Vector(0.371, 1.154, -2.062), Vector(0.001, 1.237, -1.687), Vector(0.245, 1.018, 1.848), Vector(0.391, 0.532, -3.177),
			Vector(0.468, 0.538, -3.141), Vector(0.548, 0.724, -3.141), Vector(0.413, 0.724, -3.164), Vector(1.149, 0.967, -2.837), Vector(
			1.104, 1.047, 1.552), Vector(1.118, 1.160, -2.078), Vector(0.001, 1.054, -2.863), Vector(1.182, 0.912, 0.845), Vector(-1.273,
			0.177, 2.085), Vector(-1.241, 0.541, -2.393), Vector(-1.333, 0.923, -1.059), Vector(-1.306, 0.370, -0.233), Vector(-1.215,
			1.092, 0.961), Vector(-0.302, 1.437, -0.856), Vector(-0.400, 1.175, -2.242), Vector(-0.782, 0.175, 3.052), Vector(-1.214,
			1.018, -0.815), Vector(-1.167, 0.175, 2.659), Vector(-0.554, 0.396, 3.148), Vector(-0.656, 0.340, 3.053), Vector(-1.178, 0.341,
			-2.403), Vector(-1.185, 0.402, -2.606), Vector(-1.044, 1.103, -2.882), Vector(-1.047, 1.260, -2.694), Vector(-1.085, 1.250,
			-2.281), Vector(-0.156, 1.096, -2.555), Vector(-0.760, 0.619, -3.016), Vector(-0.612, 0.641, -3.141), Vector(-0.548, 0.539,
			-3.168), Vector(-0.332, 0.625, -3.200), Vector(0, 1.390, -1.165), Vector(-0.373, 1.195, -1.915), Vector(-0.325, 1.277, -1.521),
			Vector(-0.244, 1.018, 1.848), Vector(-0.390, 0.532, -3.177), Vector(-0.547, 0.724, -3.141), Vector(-0.412, 0.724, -3.164),
			Vector(-1.148, 0.967, -2.837), Vector(-1.102, 1.047, 1.552), Vector(-1.117, 1.160, -2.078), Vector(-1.180, 0.912, 0.845),
			Vector(-0.255, 0.315, 3.223), Vector(-0.794, 0.399, -2.839), Vector(-0.780, 0.193, -2.327), Vector(1.202, 0.177, 1.214),
			Vector(1.231, 0.178, -1.400), Vector(-1.200, 0.177, 1.214), Vector(-1.230, 0.178, -1.400), Vector(-0.471, 0.245, -2.685),
			Vector(-0.287, 0.593, -3.152), Vector(-0.287, 0.211, -2.519), Vector(-0.467, 0.538, -3.141), Vector(0.256, 0.315, 3.223));
		Global.VAR_VEH_MESH_EDGES_FRONT_BUMPER = Array(1, 2, 1, 0);
		Global.VAR_VEH_MESH_EDGES_FRONT_HOOD = Array(0, 1, 0, 3, 0, 4, 5, 8, 6, 7, 5, 4, 2, 1, 5, 7, 1, 7, 9, 10, 3, 2, 8, 6);
		Global.VAR_VEH_MESH_EDGES_BODY = Array(0, 1, 1, 2, 3, 4, 6, 7, 8, 9, 9, 10, 11, 18, 19, 13, 12, 14, 12, 15, 5, 30, 10, 24, 22, 23,
			29, 28, 2, 22, 15, 19, 17, 64, 22, 10, 25, 21, 19, 21, 13, 28, 20, 25, 29, 64, 29, 16, 1, 30, 30, 17, 6, 31, 32, 33, 33, 34,
			35, 36, 38, 39, 40, 41, 41, 42, 43, 49, 44, 14, 44, 46, 37, 61, 42, 55, 53, 54, 60, 59, 34, 53, 46, 50, 48, 63, 53, 42, 56, 52,
			50, 52, 45, 59, 51, 56, 60, 63, 60, 47, 33, 61, 61, 48, 38, 62, 20, 51, 26, 27, 27, 12, 27, 29, 57, 58, 58, 44, 58, 60, 24, 28,
			55, 59, 68, 69, 69, 74, 66, 67, 65, 66, 72, 73, 71, 65, 68, 72, 77, 78, 78, 79, 79, 86, 76, 77, 81, 80, 75, 76, 84, 85, 83, 75,
			78, 84, 67, 68, 27, 87, 58, 88);
		Global.VAR_VEH_MESH_EDGES_ENGINE_HOOD = Array(10, 6, 1, 6, 10, 2, 3, 8, 0, 10, 8, 9, 5, 7, 7, 6, 10, 4, 21, 17, 12, 17, 21, 13, 14,
			19, 11, 21, 19, 20, 16, 18, 18, 17, 21, 15, 2, 13);
		Global.VAR_VEH_MESH_EDGES_REAR_BUMPER = Array(1, 3, 0, 1, 1, 2, 6, 4, 1, 5, 2, 6, 8, 10, 7, 8, 8, 9, 12, 13, 14, 11, 8, 12, 9, 14,
			2, 9, 5, 15);
		Global.VAR_VEH_MESH_EDGES_HEADLIGHTS = Array(2, 1, 2, 3, 0, 2, 6, 5, 6, 7, 4, 6);
		Global.VAR_VEH_MESH_EDGES_L_R_LIGHTS = Array(0, 1, 2, 3);
		Global.VAR_VEH_MESH_EDGES_R_R_LIGHTS = Array(0, 1, 3, 2);
		Global.VAR_VEH_MESH_EDGES_NITROUS = Array(0, 1, 2, 3);
		Global.VAR_VEH_MESH_EDGES_CARBON_PARTS = Array(2, 3, 88, 77, 13, 14, 39, 15, 16, 17, 19, 20, 20, 21, 36, 24, 25, 26, 15, 16, 35,
			22, 8, 10, 30, 29, 31, 32, 9, 2, 43, 4, 6, 7, 10, 0, 5, 19, 7, 18, 1, 13, 23, 5, 42, 27, 28, 33, 40, 34, 21, 35, 20, 37, 37,
			38, 22, 38, 14, 39, 17, 41, 8, 11, 46, 47, 56, 57, 73, 58, 59, 60, 62, 63, 63, 64, 58, 59, 70, 65, 51, 53, 30, 68, 52, 46, 76,
			48, 49, 50, 53, 44, 50, 61, 45, 56, 42, 66, 67, 33, 74, 69, 64, 70, 63, 71, 71, 72, 65, 72, 57, 73, 60, 75, 51, 54, 22, 65, 18,
			61, 79, 78, 78, 62, 80, 81, 82, 83, 87, 84, 85, 86, 34, 69, 12, 88, 55, 77);
		"PASTE YOUR CAR HERE - Original Gamemode Creator: GraczCourier (now known as RaidVentador_Courier_13)"
		Global.VAR_PLAYER_RACER.VAR_VEH_COLOR_DEFAULT = Color(Green);
		Call Subroutine(SUB_VEH_VSL_GET_COLORS);
	}
}

rule("#4 Pininfarina Battista 2020 (Mesh Array Tables)")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		"FOR INDEXES REFER TO: MENU \\ ARRAY TABLE - INTERNAL STORAGE VARIABLE \n [1] - CURRENT CAR \n Rule Elements Count: 2830"
		Global.VAR_GBL_INTRNL_STORED_VALUES[1] == 3;
		Entity Exists(Global.VAR_PLAYER_RACER) == True;
	}

	actions
	{
		"VERTICES COUNT: 274 \n EDGE COUNT: 218 \n Car models ported with Deltin's OSTW for Visual Studio Code"
		Global.VAR_VEH_MESH_VRTCS_FRONT_BUMPER = Array(Vector(1.353, 0.807, 2.128), Vector(1.332, 0.189, 2.233), Vector(1.089, 0.220,
			2.784), Vector(0.281, 0.560, 3.288), Vector(1.208, 0.880, 2.383), Vector(1.181, 0.304, 2.606), Vector(1.135, 0.663, 2.694),
			Vector(1.052, 0.523, 2.784), Vector(0.708, 0.204, 3.109), Vector(1.342, 0.748, 2.188), Vector(0.633, 0.475, 3.093), Vector(
			0.651, 0.596, 3.102), Vector(-1.353, 0.807, 2.128), Vector(-1.332, 0.189, 2.233), Vector(-1.089, 0.220, 2.784), Vector(-0.328,
			0.188, 3.268), Vector(-0.273, 0.446, 3.240), Vector(-1.208, 0.880, 2.383), Vector(-1.181, 0.304, 2.606), Vector(-1.135, 0.663,
			2.694), Vector(-0.281, 0.560, 3.288), Vector(-0.708, 0.204, 3.109), Vector(-1.342, 0.748, 2.188), Vector(-0.633, 0.475, 3.093),
			Vector(-0.651, 0.596, 3.102), Vector(0.273, 0.446, 3.240), Vector(0.953, 0.633, 2.887), Vector(-0.953, 0.633, 2.887), Vector(
			-1.052, 0.523, 2.784), Vector(0.328, 0.188, 3.268));
		Global.VAR_VEH_MESH_VRTCS_FRONT_HOOD = Array(Vector(-0.577, 0.930, 2.264), Vector(0.488, 0.801, 2.605), Vector(0.601, 1.026,
			1.958), Vector(0.810, 0.897, 2.447), Vector(0.833, 1.066, 1.610), Vector(1.042, 1.056, 1.067), Vector(0.372, 0.865, 2.669),
			Vector(-0.488, 0.801, 2.605), Vector(-0.601, 1.026, 1.958), Vector(-0.810, 0.897, 2.447), Vector(-0.833, 1.066, 1.610), Vector(
			-1.042, 1.056, 1.067), Vector(-0.372, 0.865, 2.669), Vector(0, 1.009, 2.100), Vector(0.577, 0.930, 2.264), Vector(-0.326,
			1.018, 2.061), Vector(0.326, 1.018, 2.061), Vector(1.352, 0.875, 1.370), Vector(1.353, 0.998, 1.769), Vector(1.353, 0.807,
			2.128), Vector(1.040, 0.985, 2.331), Vector(1.187, 1.118, 1.715), Vector(0.818, 0.757, 2.809), Vector(-1.352, 0.875, 1.370),
			Vector(-1.353, 0.998, 1.769), Vector(-1.353, 0.807, 2.128), Vector(-1.040, 0.985, 2.331), Vector(-1.187, 1.118, 1.715), Vector(
			-1.158, 1.064, 1.099), Vector(-0.818, 0.757, 2.809), Vector(1.158, 1.064, 1.099));
		Global.VAR_VEH_MESH_VRTCS_BODY = Array(Vector(1.353, 0.223, -1.438), Vector(1.353, 0.752, -1.469), Vector(1.154, 1.167, -2.639),
			Vector(0.204, 1.201, -2.679), Vector(0.943, 1.209, -1.400), Vector(-1.353, 0.223, -1.438), Vector(-1.353, 0.752, -1.469),
			Vector(-1.154, 1.167, -2.639), Vector(-0.204, 1.201, -2.679), Vector(-0.943, 1.209, -1.400), Vector(-1.227, 1.117, -0.799),
			Vector(-1.210, 1.274, -1.891), Vector(-1.263, 1.142, -2.503), Vector(-1.306, 1.129, -2.205), Vector(1.145, 1.041, 0.744),
			Vector(1.341, 0.289, 1.239), Vector(1.227, 1.117, -0.799), Vector(1.352, 0.875, 1.370), Vector(1.350, 0.537, 1.210), Vector(
			1.200, 0.945, -0.745), Vector(1.099, 1.149, -0.295), Vector(1.254, 0.323, -0.455), Vector(0.856, 1.335, -0.850), Vector(1.158,
			1.064, 1.099), Vector(1.311, 0.956, -0.753), Vector(-1.145, 1.041, 0.744), Vector(-1.341, 0.289, 1.239), Vector(-1.352, 0.875,
			1.370), Vector(-1.350, 0.537, 1.210), Vector(-1.200, 0.945, -0.745), Vector(-1.099, 1.149, -0.295), Vector(-1.254, 0.323,
			-0.455), Vector(-0.856, 1.335, -0.850), Vector(-1.158, 1.064, 1.099), Vector(-1.311, 0.956, -0.753), Vector(1.314, 0.260,
			-1.431), Vector(1.353, 0.810, -2.403), Vector(1.210, 1.274, -1.891), Vector(1.353, 1.046, -1.943), Vector(1.263, 1.142,
			-2.503), Vector(1.306, 1.129, -2.205), Vector(-1.314, 0.260, -1.431), Vector(-1.353, 0.810, -2.403), Vector(-1.267, 0.498,
			-0.540), Vector(-1.353, 1.046, -1.943), Vector(1.267, 0.498, -0.540), Vector(-1.337, 0.189, 1.250), Vector(1.337, 0.189,
			1.250));
		Global.VAR_VEH_MESH_VRTCS_ENGINE_HOOD = Array(Vector(1.104, 0.821, -2.823), Vector(1.293, 0.330, -2.477), Vector(1.176, 0.810,
			-2.802), Vector(0.593, 0.833, -3.107), Vector(1.113, 1.033, -2.845), Vector(0.204, 1.132, -2.519), Vector(-0.205, 1.017,
			-3.185), Vector(0.508, 1.015, -3.172), Vector(0, 1.015, -3.198), Vector(0.856, 1.335, -0.850), Vector(1.244, 0.415, -2.710),
			Vector(0.317, 0.726, -3.136), Vector(0.592, 1.274, -1.638), Vector(-1.104, 0.821, -2.823), Vector(-1.293, 0.330, -2.477),
			Vector(-1.176, 0.810, -2.802), Vector(-0.593, 0.833, -3.107), Vector(-1.113, 1.033, -2.845), Vector(-0.204, 1.132, -2.519),
			Vector(0.205, 1.017, -3.185), Vector(-0.508, 1.015, -3.172), Vector(-0.856, 1.335, -0.850), Vector(-1.244, 0.415, -2.710),
			Vector(-0.317, 0.726, -3.136), Vector(-0.592, 1.274, -1.638), Vector(1.172, 1.068, -2.712), Vector(1.364, 0.957, -2.252),
			Vector(-1.172, 1.068, -2.712), Vector(-1.364, 0.957, -2.252), Vector(1.353, 0.810, -2.403), Vector(-1.353, 0.810, -2.403));
		Global.VAR_VEH_MESH_VRTCS_REAR_BUMPER = Array(Vector(0.204, 1.201, -2.679), Vector(0.304, 1.232, -2.506), Vector(0.923, 1.200,
			-2.518), Vector(1.048, 1.170, -2.740), Vector(-0.304, 1.232, -2.506), Vector(-0.923, 1.200, -2.518), Vector(-1.048, 1.170,
			-2.740), Vector(0.182, 1.163, -3.160), Vector(-0.182, 1.163, -3.160), Vector(-0.204, 1.201, -2.679));
		Global.VAR_VEH_MESH_VRTCS_HEADLIGHTS = Array(Vector(1.033, 0.775, 2.581), Vector(1.093, 0.836, 2.581), Vector(0.365, 0.713, 3.061),
			Vector(0.840, 0.731, 2.832), Vector(1.033, 0.836, 2.581), Vector(1.093, 0.775, 2.581), Vector(-1.033, 0.775, 2.581), Vector(
			-1.093, 0.836, 2.581), Vector(-0.365, 0.713, 3.061), Vector(-0.840, 0.731, 2.832), Vector(-1.033, 0.836, 2.581), Vector(-1.093,
			0.775, 2.581));
		Global.VAR_VEH_MESH_VRTCS_L_R_LIGHTS = Array(Vector(0.182, 1.163, -3.160), Vector(1.139, 1.153, -2.776), Vector(0.530, 1.163,
			-3.122), Vector(1.263, 1.142, -2.503));
		Global.VAR_VEH_MESH_VRTCS_R_R_LIGHTS = Array(Vector(-0.182, 1.163, -3.160), Vector(-1.139, 1.153, -2.776), Vector(-0.530, 1.163,
			-3.122), Vector(-1.263, 1.142, -2.503));
		Global.VAR_VEH_MESH_VRTCS_NITROUS = Array(Vector(1.067, 0.410, -2.844), Vector(0.707, 0.407, -3.071), Vector(-1.067, 0.410,
			-2.844), Vector(-0.707, 0.407, -3.071));
		Global.VAR_VEH_MESH_VRTCS_CARBON_PARTS = Array(Vector(1.044, 0.758, 2.602), Vector(1.353, 0.223, -1.438), Vector(1.337, 0.189,
			1.250), Vector(1.288, 0.230, -2.455), Vector(0.856, 0.721, 2.830), Vector(1.332, 0.189, 2.233), Vector(0, 1.097, 1.671),
			Vector(0.236, 0.970, 2.091), Vector(0.775, 1.515, 0.347), Vector(0.856, 1.335, -0.850), Vector(0.565, 1.097, 1.514), Vector(
			1.090, 0.319, -2.913), Vector(0.685, 0.320, -3.136), Vector(0.541, 0.410, -3.186), Vector(1.177, 0.380, -2.770), Vector(1.026,
			0.464, 2.719), Vector(1.233, 0.179, 2.734), Vector(0.883, 0.165, 3.080), Vector(1.128, 0.272, 2.549), Vector(0.738, 1.552,
			-0.152), Vector(0.763, 0.251, 2.847), Vector(0.708, 0.361, 2.933), Vector(1.101, 0.277, 2.617), Vector(0.257, 1.644, -0.011),
			Vector(0.676, 1.485, -0.868), Vector(1.063, 0.704, -2.921), Vector(0.286, 0.630, -3.256), Vector(0.517, 0.705, -3.168), Vector(
			0.441, 0.506, -3.259), Vector(Empty Array, 1.577, 0.472), Vector(1.050, 1.084, 0.891), Vector(1.300, 1.180, 0.795), Vector(
			1.096, 0.859, 2.585), Vector(1.195, 0.913, 2.363), Vector(0.681, 0.433, 3.007), Vector(0.161, 1.540, -0.880), Vector(1.042,
			1.056, 1.067), Vector(1.130, 0.482, -2.813), Vector(0.256, 0.461, -3.210), Vector(0.256, 0.288, -3.099), Vector(0.364, 0.465,
			-3.172), Vector(1.479, 1.227, 0.533), Vector(0.416, 1.141, -2.299), Vector(0.981, 1.243, -0.892), Vector(1.095, 1.149, -1.094),
			Vector(0.613, 1.338, -1.425), Vector(0.235, 1.215, -2.147), Vector(0.171, 1.169, -2.310), Vector(0.274, 1.119, 1.704), Vector(
			-1.044, 0.758, 2.602), Vector(-1.288, 0.230, -2.455), Vector(-0.856, 0.721, 2.830), Vector(-1.332, 0.189, 2.233), Vector(
			-0.236, 0.970, 2.091), Vector(-0.775, 1.515, 0.347), Vector(-0.856, 1.335, -0.850), Vector(-0.565, 1.097, 1.514), Vector(
			-1.090, 0.319, -2.913), Vector(-0.685, 0.320, -3.136), Vector(-0.541, 0.410, -3.186), Vector(-1.177, 0.380, -2.770), Vector(
			-1.026, 0.464, 2.719), Vector(-1.233, 0.179, 2.734), Vector(-0.883, 0.165, 3.080), Vector(-1.128, 0.272, 2.549), Vector(-0.738,
			1.552, -0.152), Vector(-0.763, 0.251, 2.847), Vector(-0.708, 0.361, 2.933), Vector(-1.101, 0.277, 2.617), Vector(-0.257, 1.644,
			-0.011), Vector(-0.676, 1.485, -0.868), Vector(-1.063, 0.704, -2.921), Vector(-0.287, 0.630, -3.256), Vector(-0.517, 0.705,
			-3.168), Vector(-0.441, 0.506, -3.259), Vector(-1.050, 1.084, 0.891), Vector(-1.300, 1.180, 0.795), Vector(-1.096, 0.859,
			2.585), Vector(-1.195, 0.913, 2.363), Vector(-0.681, 0.433, 3.007), Vector(-0.161, 1.540, -0.880), Vector(-1.042, 1.056,
			1.067), Vector(-1.130, 0.482, -2.813), Vector(-0.256, 0.461, -3.210), Vector(-0.256, 0.288, -3.099), Vector(-0.364, 0.465,
			-3.172), Vector(-1.479, 1.227, 0.533), Vector(-0.416, 1.141, -2.299), Vector(-0.981, 1.243, -0.892), Vector(-1.095, 1.149,
			-1.094), Vector(-0.613, 1.338, -1.425), Vector(-0.235, 1.215, -2.147), Vector(-0.171, 1.169, -2.310), Vector(-0.274, 1.119,
			1.704), Vector(0.183, 1.174, -3.001), Vector(-0.183, 1.174, -3.001), Vector(0.204, 1.201, -2.679), Vector(-0.204, 1.201,
			-2.679), Vector(-1.353, 0.223, -1.438), Vector(-1.337, 0.189, 1.250));
		Global.VAR_VEH_MESH_EDGES_FRONT_BUMPER = Array(0, 1, 5, 2, 2, 8, 6, 9, 7, 10, 0, 4, 6, 11, 12, 13, 21, 15, 18, 14, 14, 21, 19, 22,
			28, 23, 12, 17, 19, 24, 24, 20, 23, 16, 11, 3, 10, 25, 16, 25, 20, 3, 27, 18, 26, 5, 29, 15, 8, 29);
		Global.VAR_VEH_MESH_EDGES_FRONT_HOOD = Array(6, 3, 5, 4, 10, 0, 15, 13, 1, 2, 12, 9, 11, 10, 7, 8, 6, 12, 16, 13, 4, 14, 8, 15, 2,
			16, 18, 19, 20, 22, 21, 20, 18, 21, 17, 18, 24, 25, 26, 29, 27, 26, 28, 27, 24, 27, 23, 24, 11, 28, 30, 21, 5, 30);
		Global.VAR_VEH_MESH_EDGES_BODY = Array(1, 0, 3, 4, 6, 5, 8, 9, 9, 10, 11, 7, 10, 11, 12, 13, 16, 17, 47, 18, 24, 16, 17, 23, 20,
			14, 22, 20, 19, 22, 14, 23, 17, 18, 46, 28, 27, 33, 30, 25, 32, 30, 29, 32, 25, 33, 31, 34, 27, 28, 21, 24, 4, 16, 10, 27, 34,
			10, 36, 38, 37, 38, 39, 40, 35, 45, 42, 44, 41, 43, 38, 1, 37, 2, 44, 6, 11, 44, 16, 37, 15, 21, 26, 31);
		Global.VAR_VEH_MESH_EDGES_ENGINE_HOOD = Array(0, 3, 4, 7, 5, 19, 1, 10, 10, 2, 12, 5, 3, 11, 2, 4, 9, 12, 13, 16, 14, 30, 17, 20,
			18, 6, 14, 22, 22, 15, 24, 18, 16, 23, 15, 17, 21, 24, 20, 8, 7, 8, 11, 23, 26, 25, 28, 27, 1, 29, 25, 4, 27, 17);
		Global.VAR_VEH_MESH_EDGES_REAR_BUMPER = Array(0, 1, 1, 2, 2, 3, 4, 5, 5, 6, 8, 9, 9, 4, 7, 0);
		Global.VAR_VEH_MESH_EDGES_HEADLIGHTS = Array(0, 1, 3, 2, 4, 5, 6, 7, 9, 8, 10, 11, 2, 8);
		Global.VAR_VEH_MESH_EDGES_L_R_LIGHTS = Array(1, 2, 2, 0, 1, 3);
		Global.VAR_VEH_MESH_EDGES_R_R_LIGHTS = Array(1, 2, 2, 0, 1, 3);
		Global.VAR_VEH_MESH_EDGES_NITROUS = Array(1, 0, 3, 2);
		Global.VAR_VEH_MESH_EDGES_CARBON_PARTS = Array(31, 41, 4, 0, 34, 20, 29, 8, 37, 28, 12, 11, 13, 12, 16, 17, 21, 22, 24, 45, 9, 24,
			27, 25, 26, 28, 30, 31, 8, 23, 32, 33, 19, 24, 36, 10, 36, 8, 8, 19, 18, 15, 1, 2, 11, 3, 5, 16, 23, 35, 24, 35, 26, 27, 25,
			14, 38, 39, 42, 43, 43, 44, 46, 47, 7, 48, 76, 86, 51, 49, 79, 66, 29, 54, 82, 74, 58, 57, 59, 58, 62, 63, 67, 68, 70, 90, 55,
			70, 73, 71, 72, 74, 75, 76, 54, 69, 77, 78, 65, 70, 81, 56, 81, 54, 54, 65, 64, 61, 57, 50, 52, 62, 69, 80, 70, 80, 72, 73, 71,
			60, 83, 84, 10, 6, 87, 88, 88, 89, 91, 92, 53, 93, 6, 56, 35, 80, 47, 92, 26, 72, 40, 85, 94, 95, 96, 97, 98, 99);
		"PASTE YOUR CAR HERE - Original Gamemode Creator: GraczCourier (now known as RaidVentador_Courier_13)"
		Global.VAR_PLAYER_RACER.VAR_VEH_COLOR_DEFAULT = Color(Blue);
		Call Subroutine(SUB_VEH_VSL_GET_COLORS);
	}
}

rule("#5 McLaren Senna 2018 (Mesh Array Tables)")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		"FOR INDEXES REFER TO: MENU \\ ARRAY TABLE - INTERNAL STORAGE VARIABLE \n [1] - CURRENT CAR \n Rule Elements Count: 2629"
		Global.VAR_GBL_INTRNL_STORED_VALUES[1] == 4;
		Entity Exists(Global.VAR_PLAYER_RACER) == True;
	}

	actions
	{
		"VERTICES COUNT: 250 \n EDGE COUNT: 210 \n Car models ported with Deltin's OSTW for Visual Studio Code"
		Global.VAR_VEH_MESH_VRTCS_FRONT_BUMPER = Array(Vector(1.167, 0.364, 2.766), Vector(1.313, 0.815, 1.978), Vector(1.251, 0.695,
			1.133), Vector(0.631, 0.280, 3.075), Vector(0.985, 1.034, 2.196), Vector(1.034, 1.082, 1.230), Vector(1.316, 1.055, 1.308),
			Vector(1.227, 0.866, 2.386), Vector(0.604, 0.605, 3.119), Vector(1.319, 0.958, 1.587), Vector(0.604, 0.605, 3.146), Vector(
			1.300, 1.071, 0.977), Vector(0.001, 0.605, 3.206), Vector(1.302, 0.768, 2.179), Vector(1.137, 0.926, 2.468), Vector(1.281,
			1.026, 1.972), Vector(-1.166, 0.364, 2.766), Vector(-1.311, 0.815, 1.978), Vector(-1.249, 0.695, 1.133), Vector(-0.630, 0.280,
			3.075), Vector(-0.984, 1.034, 2.196), Vector(-1.032, 1.082, 1.230), Vector(-1.314, 1.055, 1.308), Vector(-1.226, 0.866, 2.386),
			Vector(-0.602, 0.605, 3.119), Vector(-1.317, 0.958, 1.587), Vector(-0.602, 0.605, 3.146), Vector(-1.298, 1.071, 0.977), Vector(
			-1.168, 0.284, 2.741), Vector(-1.277, 0.276, 2.382), Vector(-1.284, 0.383, 2.414), Vector(-1.300, 0.768, 2.179), Vector(-1.136,
			0.926, 2.468), Vector(-1.280, 1.026, 1.972), Vector(1.170, 0.284, 2.741), Vector(1.278, 0.276, 2.382), Vector(1.286, 0.383,
			2.414));
		Global.VAR_VEH_MESH_VRTCS_FRONT_HOOD = Empty Array;
		Global.VAR_VEH_MESH_VRTCS_BODY = Array(Vector(1.251, 0.695, 1.133), Vector(1.163, 0.450, 0.553), Vector(1.130, 0.956, -0.451),
			Vector(1.150, 0.555, -0.142), Vector(1.034, 1.082, 1.230), Vector(1.314, 1.039, -0.951), Vector(1.320, 0.293, -0.986), Vector(
			1.151, 0.953, -2.777), Vector(1.232, 0.235, 0.395), Vector(1.358, 0.533, -1.558), Vector(1.300, 1.071, 0.977), Vector(1.174,
			1.193, -0.836), Vector(0.961, 1.163, -0.583), Vector(1.130, 0.241, 1.097), Vector(1.089, 1.053, -0.634), Vector(1.181, 0.920,
			0.907), Vector(-1.296, 0.482, -0.472), Vector(-1.249, 0.695, 1.133), Vector(-1.161, 0.450, 0.553), Vector(-1.129, 0.956,
			-0.451), Vector(-1.149, 0.555, -0.142), Vector(-1.032, 1.082, 1.230), Vector(-1.312, 1.039, -0.951), Vector(-1.319, 0.293,
			-0.986), Vector(-1.149, 0.953, -2.777), Vector(-1.230, 0.235, 0.395), Vector(-1.356, 0.533, -1.558), Vector(-1.298, 1.071,
			0.977), Vector(-1.173, 1.193, -0.836), Vector(-1.129, 0.241, 1.097), Vector(-1.088, 1.053, -0.634), Vector(-1.179, 0.920,
			0.907), Vector(1.297, 0.482, -0.472), Vector(1.336, 0.181, -1.540), Vector(1.344, 0.755, -1.666), Vector(1.344, 0.990, -2.175),
			Vector(1.146, 0.905, -3.071), Vector(1.133, 1.013, -3.014), Vector(0.727, 1.219, -1.398), Vector(1.150, 1.252, -1.960), Vector(
			1.248, 0.656, -2.821), Vector(-1.334, 0.181, -1.540), Vector(-1.343, 0.755, -1.666), Vector(-1.343, 0.990, -2.175), Vector(
			-1.132, 1.013, -3.014), Vector(-0.725, 1.219, -1.398), Vector(-1.148, 1.252, -1.960), Vector(-1.145, 0.905, -3.071), Vector(
			-1.247, 0.656, -2.821), Vector(-0.960, 1.163, -0.583));
		Global.VAR_VEH_MESH_VRTCS_ENGINE_HOOD = Array(Vector(0.231, 1.092, -2.622), Vector(0.727, 1.219, -1.398), Vector(0.120, 0.908,
			-3.223), Vector(0.300, 0.969, -2.991), Vector(1.119, 0.885, -2.978), Vector(-0.229, 1.092, -2.622), Vector(-0.725, 1.219,
			-1.398), Vector(-0.118, 0.908, -3.223), Vector(-0.298, 0.969, -2.991), Vector(-1.118, 0.885, -2.978), Vector(1.061, 0.924,
			-2.843), Vector(-1.059, 0.924, -2.843));
		Global.VAR_VEH_MESH_VRTCS_REAR_BUMPER = Array(Vector(1.254, 1.525, -2.406), Vector(1.249, 1.312, -2.231), Vector(1.259, 1.543,
			-2.997), Vector(1.259, 1.205, -2.849), Vector(-1.252, 1.525, -2.406), Vector(-1.247, 1.312, -2.231), Vector(-1.258, 1.543,
			-2.997), Vector(-1.258, 1.205, -2.849));
		Global.VAR_VEH_MESH_VRTCS_HEADLIGHTS = Array(Vector(1.218, 0.637, 2.536), Vector(1.207, 0.856, 2.361), Vector(0.906, 0.800, 2.651),
			Vector(0.778, 0.599, 3.022), Vector(-1.217, 0.637, 2.536), Vector(-1.205, 0.856, 2.361), Vector(-0.904, 0.800, 2.651), Vector(
			-0.776, 0.599, 3.022));
		Global.VAR_VEH_MESH_VRTCS_L_R_LIGHTS = Array(Vector(1.051, 0.832, -2.937), Vector(0.463, 0.832, -3.115));
		Global.VAR_VEH_MESH_VRTCS_R_R_LIGHTS = Array(Vector(-1.050, 0.832, -2.937), Vector(-0.461, 0.832, -3.115));
		Global.VAR_VEH_MESH_VRTCS_NITROUS = Array(Vector(0.077, 1.004, -2.897), Vector(0.001, 0.936, -3.070), Vector(-0.075, 1.004,
			-2.897));
		Global.VAR_VEH_MESH_VRTCS_CARBON_PARTS = Array(Vector(0.592, 0.223, 3.249), Vector(1.228, 0.223, 2.833), Vector(1.333, 0.204,
			2.094), Vector(1.277, 0.225, -2.591), Vector(1.005, 0.350, -3.060), Vector(1.125, 0.598, -3.128), Vector(0.478, 0.627, -3.066),
			Vector(0.902, 0.516, -2.970), Vector(0.186, 0.922, 2.608), Vector(0.001, 1.644, -0.146), Vector(0.709, 0.989, 2.226), Vector(
			0.001, 1.067, 1.901), Vector(0.814, 1.482, 0.428), Vector(0.638, 1.539, -0.600), Vector(0.451, 1.214, -1.765), Vector(0.001,
			1.594, 0.376), Vector(0.478, 0.148, -3.075), Vector(0.902, 0.148, -2.964), Vector(0.198, 0.584, -3.164), Vector(0.198, 0.343,
			-3.130), Vector(0.690, 0.341, -3.059), Vector(0.690, 0.148, -3.014), Vector(0.084, 0.835, 2.808), Vector(0.001, 1.594, -0.616),
			Vector(1.486, 1.165, 0.782), Vector(1.313, 0.815, 1.978), Vector(1.336, 0.181, -1.540), Vector(1.344, 0.990, -2.175), Vector(
			1.034, 1.082, 1.230), Vector(1.300, 1.071, 0.977), Vector(0.167, 0.985, 2.336), Vector(0.708, 1.067, 1.679), Vector(0.205,
			1.624, -0.651), Vector(0.119, 1.429, -1.288), Vector(1.318, 0.180, 1.141), Vector(1.329, 0.564, -2.601), Vector(1.236, 0.338,
			-2.914), Vector(1.223, 0.302, -2.770), Vector(1.248, 0.656, -2.821), Vector(0.961, 1.163, -0.583), Vector(0.708, 1.565,
			-0.094), Vector(0.484, 1.223, -1.694), Vector(-0.591, 0.223, 3.249), Vector(-1.226, 0.223, 2.833), Vector(-1.332, 0.204,
			2.094), Vector(-1.276, 0.225, -2.591), Vector(-1.003, 0.350, -3.060), Vector(-1.123, 0.598, -3.128), Vector(-0.476, 0.627,
			-3.066), Vector(-0.900, 0.516, -2.970), Vector(-0.185, 0.922, 2.608), Vector(-0.707, 0.989, 2.226), Vector(-0.812, 1.482,
			0.428), Vector(-0.636, 1.539, -0.600), Vector(-0.476, 0.148, -3.075), Vector(-0.900, 0.148, -2.964), Vector(-0.196, 0.584,
			-3.164), Vector(-0.196, 0.343, -3.130), Vector(-0.688, 0.341, -3.059), Vector(-0.688, 0.148, -3.014), Vector(0.001, 0.618,
			-3.234), Vector(0.001, 0.342, -3.207), Vector(-0.082, 0.835, 2.808), Vector(-1.485, 1.165, 0.782), Vector(-1.311, 0.815,
			1.978), Vector(-1.334, 0.181, -1.540), Vector(-1.343, 0.990, -2.175), Vector(-1.032, 1.082, 1.230), Vector(-1.298, 1.071,
			0.977), Vector(-0.165, 0.985, 2.336), Vector(-0.203, 1.624, -0.651), Vector(-0.117, 1.429, -1.288), Vector(-1.317, 0.180,
			1.141), Vector(-1.327, 0.564, -2.601), Vector(-1.235, 0.338, -2.914), Vector(-1.222, 0.302, -2.770), Vector(-1.247, 0.656,
			-2.821), Vector(-0.960, 1.163, -0.583), Vector(-0.706, 1.565, -0.094), Vector(-0.482, 1.223, -1.694), Vector(0.120, 0.908,
			-3.223), Vector(0.198, 0.999, -2.920), Vector(0.121, 1.062, -2.733), Vector(-0.118, 0.908, -3.223), Vector(-0.120, 1.062,
			-2.733), Vector(-0.196, 0.999, -2.920), Vector(0.578, 0.693, -2.229), Vector(0.593, 1.593, -2.610), Vector(0.602, 1.451,
			-2.860), Vector(0.688, 1.513, -3.143), Vector(0.453, 1.423, -3.153), Vector(0.584, 1.448, -2.808), Vector(1.237, 1.451,
			-2.615), Vector(1.208, 1.525, -2.831), Vector(0.453, 1.423, -2.860), Vector(-0.576, 0.693, -2.229), Vector(-0.591, 1.593,
			-2.610), Vector(-0.600, 1.451, -2.860), Vector(-0.686, 1.513, -3.143), Vector(-0.451, 1.423, -3.153), Vector(-0.583, 1.448,
			-2.808), Vector(-1.236, 1.451, -2.615), Vector(-1.206, 1.525, -2.831), Vector(-0.451, 1.423, -2.860), Vector(1.130, 0.241,
			1.097), Vector(-1.129, 0.241, 1.097), Vector(0.140, 1.067, 1.864), Vector(-0.707, 1.067, 1.679), Vector(-0.139, 1.067, 1.864),
			Vector(0.282, 1.183, -2.052), Vector(-0.281, 1.183, -2.052), Vector(-0.449, 1.214, -1.765), Vector(0.097, 1.143, -2.368),
			Vector(-0.095, 1.143, -2.368), Vector(-0.587, 1.566, -2.743), Vector(0.589, 1.566, -2.743), Vector(0.566, 1.020, -2.417),
			Vector(-0.565, 1.020, -2.417), Vector(1.065, 1.092, -2.284), Vector(-1.064, 1.092, -2.284), Vector(0.603, 1.037, -2.145),
			Vector(-0.628, 1.037, -2.145), Vector(1.070, 1.126, -1.982), Vector(-1.069, 1.126, -1.982), Vector(0.498, 0.994, -2.697),
			Vector(-0.497, 0.994, -2.697), Vector(1.044, 1.023, -2.608), Vector(-1.043, 1.023, -2.608));
		Global.VAR_VEH_MESH_EDGES_FRONT_BUMPER = Array(9, 2, 8, 12, 1, 9, 3, 10, 7, 0, 4, 11, 11, 6, 2, 6, 15, 7, 6, 15, 1, 13, 10, 14, 5,
			6, 25, 18, 24, 12, 17, 25, 19, 26, 23, 16, 20, 27, 27, 22, 18, 22, 33, 23, 16, 28, 22, 33, 29, 30, 30, 31, 17, 31, 26, 32, 21,
			22, 10, 4, 26, 20, 7, 14, 23, 32, 35, 36, 36, 13, 0, 34);
		Global.VAR_VEH_MESH_EDGES_FRONT_HOOD = Empty Array;
		Global.VAR_VEH_MESH_EDGES_BODY = Array(32, 14, 11, 12, 0, 13, 11, 5, 15, 2, 1, 9, 8, 13, 2, 3, 4, 12, 16, 23, 3, 1, 17, 29, 25, 27,
			28, 22, 31, 19, 18, 26, 22, 16, 19, 20, 12, 14, 20, 18, 4, 15, 21, 31, 32, 6, 5, 32, 16, 30, 8, 10, 25, 29, 33, 34, 39, 37, 34,
			35, 47, 43, 40, 36, 41, 42, 46, 44, 42, 43, 47, 44, 45, 49, 49, 30, 28, 49, 21, 49, 36, 37, 11, 39, 43, 22, 38, 12, 48, 47, 28,
			46, 35, 5, 36, 35);
		Global.VAR_VEH_MESH_EDGES_ENGINE_HOOD = Array(3, 0, 0, 1, 2, 4, 8, 5, 5, 6, 7, 9, 8, 11, 3, 10);
		Global.VAR_VEH_MESH_EDGES_REAR_BUMPER = Array(0, 2, 1, 0, 2, 3, 1, 3, 4, 6, 5, 4, 6, 7, 5, 7);
		Global.VAR_VEH_MESH_EDGES_HEADLIGHTS = Array(3, 0, 1, 2, 7, 4, 5, 6);
		Global.VAR_VEH_MESH_EDGES_L_R_LIGHTS = Array(0, 1);
		Global.VAR_VEH_MESH_EDGES_R_R_LIGHTS = Array(0, 1);
		Global.VAR_VEH_MESH_EDGES_NITROUS = Array(0, 1, 2, 1);
		Global.VAR_VEH_MESH_EDGES_CARBON_PARTS = Array(0, 1, 3, 36, 10, 8, 40, 13, 13, 41, 30, 22, 15, 9, 9, 23, 6, 16, 17, 7, 18, 19, 20,
			21, 15, 12, 2, 25, 35, 3, 34, 26, 29, 24, 106, 30, 32, 33, 27, 35, 36, 5, 37, 4, 12, 40, 5, 38, 28, 12, 28, 31, 1, 2, 13, 39,
			42, 43, 45, 74, 51, 50, 78, 53, 53, 79, 69, 62, 48, 54, 55, 49, 56, 57, 58, 59, 47, 60, 46, 61, 15, 52, 107, 11, 44, 64, 73,
			45, 72, 65, 68, 63, 108, 69, 70, 71, 66, 73, 74, 47, 75, 46, 52, 78, 47, 76, 67, 52, 43, 44, 53, 77, 33, 71, 0, 42, 22, 62, 28,
			10, 67, 51, 32, 70, 81, 82, 85, 84, 80, 83, 82, 84, 80, 81, 83, 85, 92, 88, 93, 89, 89, 90, 115, 91, 88, 94, 101, 97, 102, 98,
			98, 99, 114, 100, 97, 103, 90, 99, 94, 103, 86, 87, 95, 96, 35, 38, 73, 76, 34, 104, 72, 105, 67, 107, 31, 11, 109, 110, 112,
			113, 111, 113, 14, 112, 5, 60, 4, 61, 96, 114, 87, 115, 121, 123, 120, 122, 116, 118, 117, 119, 124, 126, 125, 127);
		"PASTE YOUR CAR HERE - Original Gamemode Creator: GraczCourier (now known as RaidVentador_Courier_13)"
		Global.VAR_PLAYER_RACER.VAR_VEH_COLOR_DEFAULT = Color(Blue);
		Call Subroutine(SUB_VEH_VSL_GET_COLORS);
	}
}

rule("#6 Ferrari LaFerrari 2013 (Mesh Array Tables)")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		"FOR INDEXES REFER TO: MENU \\ ARRAY TABLE - INTERNAL STORAGE VARIABLE \n [1] - CURRENT CAR \n Rule Elements Count: 2441"
		Global.VAR_GBL_INTRNL_STORED_VALUES[1] == 5;
		Entity Exists(Global.VAR_PLAYER_RACER) == True;
	}

	actions
	{
		"VERTICES COUNT: 224 \n EDGE COUNT: 210 \n Car models ported with Deltin's OSTW for Visual Studio Code"
		Global.VAR_VEH_MESH_VRTCS_FRONT_BUMPER = Array(Vector(1.353, 0.900, 1.757), Vector(1.342, 0.707, 2.076), Vector(1.031, 0.215,
			2.651), Vector(0.867, 0.589, 2.930), Vector(1.105, 0.623, 2.705), Vector(1.305, 0.213, 2.150), Vector(0.864, 0.227, 2.872),
			Vector(0.220, 0.217, 3.231), Vector(Empty Array, 0.224, 3.188), Vector(1.260, 0.970, 1.913), Vector(Empty Array, 0.530, 3.203),
			Vector(0.168, 0.640, 3.001), Vector(-1.353, 0.900, 1.757), Vector(-1.342, 0.707, 2.076), Vector(-1.031, 0.215, 2.651), Vector(
			-0.867, 0.589, 2.930), Vector(-1.105, 0.623, 2.705), Vector(-1.305, 0.213, 2.150), Vector(-0.864, 0.227, 2.872), Vector(-0.220,
			0.217, 3.231), Vector(-0.090, 0.546, 3.267), Vector(-1.260, 0.970, 1.913), Vector(-0.168, 0.640, 3.001), Vector(0.090, 0.546,
			3.267), Vector(0.861, 0.716, 2.706), Vector(-0.861, 0.716, 2.706));
		Global.VAR_VEH_MESH_VRTCS_FRONT_HOOD = Array(Vector(0.659, 0.997, 1.540), Vector(0.441, 0.968, 1.849), Vector(0.168, 0.640, 3.001),
			Vector(0.406, 0.680, 2.918), Vector(0.298, 0.797, 2.558), Vector(-0.659, 0.997, 1.540), Vector(-0.441, 0.968, 1.849), Vector(
			-0.168, 0.640, 3.001), Vector(-0.406, 0.680, 2.918), Vector(-0.298, 0.797, 2.558), Vector(-0.736, 0.923, 1.778), Vector(0.736,
			0.923, 1.778));
		Global.VAR_VEH_MESH_VRTCS_BODY = Array(Vector(1.353, 0.922, 1.597), Vector(1.293, 0.158, 1.112), Vector(1.354, 0.700, 1.206),
			Vector(1.312, 0.149, -1.486), Vector(1.353, 0.900, 1.757), Vector(1.344, 0.656, -1.525), Vector(1.325, 0.153, -0.984), Vector(
			1.260, 0.970, 1.913), Vector(1.251, 1.014, 1.525), Vector(1.250, 0.894, 1.174), Vector(1.284, 0.388, 0.428), Vector(1.332,
			0.553, -0.962), Vector(1.255, 0.978, -0.506), Vector(1.320, 0.438, -0.352), Vector(0.947, 0.907, 1.340), Vector(0.897, 0.988,
			1.040), Vector(0.912, 0.988, 0.982), Vector(0.861, 0.716, 2.706), Vector(0.966, 0.981, 1.904), Vector(0.948, 1.111, -0.233),
			Vector(0.822, 1.228, -0.575), Vector(1.284, 0.156, -0.287), Vector(1.144, 0.646, -0.426), Vector(-1.353, 0.922, 1.597), Vector(
			-1.293, 0.158, 1.112), Vector(-1.354, 0.700, 1.206), Vector(-1.312, 0.149, -1.486), Vector(-1.353, 0.900, 1.757), Vector(
			-1.344, 0.656, -1.525), Vector(-1.325, 0.153, -0.984), Vector(-1.260, 0.970, 1.913), Vector(-1.251, 1.014, 1.525), Vector(
			-1.250, 0.894, 1.174), Vector(-1.284, 0.388, 0.428), Vector(-1.308, 0.797, -0.458), Vector(-1.320, 0.438, -0.352), Vector(
			-0.947, 0.907, 1.340), Vector(-0.897, 0.988, 1.040), Vector(-0.736, 0.923, 1.778), Vector(-0.912, 0.988, 0.982), Vector(-0.861,
			0.716, 2.706), Vector(-0.966, 0.981, 1.904), Vector(-0.948, 1.111, -0.233), Vector(-0.822, 1.228, -0.575), Vector(-1.144,
			0.646, -0.426), Vector(0.736, 0.923, 1.778), Vector(-1.284, 0.156, -0.287), Vector(1.193, 0.921, 0.129), Vector(1.055, 0.830,
			1.196), Vector(-1.193, 0.921, 0.129), Vector(-1.255, 0.978, -0.506), Vector(-1.055, 0.830, 1.196), Vector(1.308, 0.797,
			-0.458), Vector(-1.332, 0.553, -0.962));
		Global.VAR_VEH_MESH_VRTCS_ENGINE_HOOD = Array(Vector(1.344, 0.656, -1.525), Vector(1.363, 0.976, -2.029), Vector(1.362, 0.846,
			-2.368), Vector(1.332, 0.553, -0.962), Vector(1.255, 0.978, -0.506), Vector(1.247, 1.030, -1.035), Vector(0.926, 1.114,
			-1.354), Vector(0.290, 1.031, -2.780), Vector(0.622, 1.098, -1.838), Vector(0.898, 1.133, -2.298), Vector(1.254, 1.166,
			-1.968), Vector(1.130, 1.073, -2.800), Vector(1.186, 0.961, -2.823), Vector(0.943, 1.070, -2.838), Vector(0.853, 1.032,
			-2.928), Vector(-1.344, 0.656, -1.525), Vector(-1.363, 0.976, -2.029), Vector(-1.362, 0.846, -2.368), Vector(-1.332, 0.553,
			-0.962), Vector(-0.290, 1.031, -2.780), Vector(-1.247, 1.030, -1.035), Vector(-0.926, 1.114, -1.354), Vector(-0.622, 1.098,
			-1.838), Vector(-0.898, 1.133, -2.298), Vector(-1.254, 1.166, -1.968), Vector(-1.130, 1.073, -2.800), Vector(-1.186, 0.961,
			-2.823), Vector(Empty Array, 1.083, -3.123), Vector(-0.943, 1.070, -2.838), Vector(-0.853, 1.032, -2.928), Vector(-1.255,
			0.978, -0.506), Vector(0.822, 1.228, -0.575), Vector(-0.822, 1.228, -0.575));
		Global.VAR_VEH_MESH_VRTCS_REAR_BUMPER = Array(Vector(1.362, 0.846, -2.368), Vector(1.280, 0.214, -2.595), Vector(0.079, 0.972,
			-3.127), Vector(1.077, 0.798, -2.974), Vector(1.186, 0.961, -2.823), Vector(1.173, 0.865, -2.885), Vector(0.894, 0.905,
			-2.913), Vector(0.069, 0.717, -3.186), Vector(1.141, 0.311, -2.917), Vector(0.075, 0.551, -3.182), Vector(0.054, 0.244,
			-3.194), Vector(0.901, 0.941, -2.926), Vector(-1.362, 0.846, -2.368), Vector(-1.280, 0.214, -2.595), Vector(-1.077, 0.798,
			-2.974), Vector(-1.186, 0.961, -2.823), Vector(-1.173, 0.865, -2.885), Vector(-0.894, 0.905, -2.913), Vector(-0.069, 0.717,
			-3.186), Vector(-1.141, 0.311, -2.917), Vector(-0.075, 0.551, -3.182), Vector(-0.054, 0.244, -3.194), Vector(-0.901, 0.941,
			-2.926), Vector(-0.079, 0.972, -3.127), Vector(Empty Array, 0.972, -3.127));
		Global.VAR_VEH_MESH_VRTCS_HEADLIGHTS = Array(Vector(0.982, 0.739, 2.592), Vector(1.215, 0.963, 2), Vector(-0.982, 0.739, 2.592),
			Vector(-1.215, 0.963, 2));
		Global.VAR_VEH_MESH_VRTCS_L_R_LIGHTS = Array(Vector(0.976, 0.870, -2.938), Vector(1.115, 1.009, -2.938), Vector(1.115, 0.870,
			-2.938), Vector(0.976, 1.009, -2.938));
		Global.VAR_VEH_MESH_VRTCS_R_R_LIGHTS = Array(Vector(-0.976, 0.870, -2.938), Vector(-1.115, 1.009, -2.938), Vector(-1.115, 0.870,
			-2.938), Vector(-0.976, 1.009, -2.938));
		Global.VAR_VEH_MESH_VRTCS_NITROUS = Array(Vector(-1.031, 0.400, -2.980), Vector(0.872, 0.400, -3.060), Vector(-0.872, 0.400,
			-3.060), Vector(1.031, 0.400, -2.980));
		Global.VAR_VEH_MESH_VRTCS_CARBON_PARTS = Array(Vector(0.680, 1.352, -0.739), Vector(0.159, 1.068, -2.643), Vector(-0.680, 1.352,
			-0.739), Vector(-0.159, 1.068, -2.643), Vector(1.293, 0.158, 1.112), Vector(1.324, 0.188, 2.149), Vector(1.325, 0.153, -0.984),
			Vector(1.071, 0.166, 2.794), Vector(0.328, 0.164, 3.162), Vector(-0.218, 0.754, 2.737), Vector(0.897, 0.988, 1.040), Vector(
			0.659, 0.997, 1.540), Vector(0.218, 0.754, 2.737), Vector(0.912, 0.988, 0.982), Vector(0.916, 1.055, 0.799), Vector(1.446,
			1.188, 0.683), Vector(0.687, 1.425, -0.103), Vector(0.765, 1.347, 0.401), Vector(0.062, 0.705, -3.128), Vector(1.008, 0.706,
			-2.969), Vector(1.097, 0.537, -2.932), Vector(0.821, 0.261, -3.039), Vector(0.707, 0.522, -3.140), Vector(0.248, 0.509,
			-3.191), Vector(0.236, 0.220, -3.133), Vector(0.233, 0.431, -3.148), Vector(0.085, 0.364, -3.176), Vector(0.747, 0.477,
			-3.060), Vector(-1.293, 0.158, 1.112), Vector(-1.324, 0.188, 2.149), Vector(-1.325, 0.153, -0.984), Vector(-1.071, 0.166,
			2.794), Vector(-0.328, 0.164, 3.162), Vector(-0.897, 0.988, 1.040), Vector(-0.659, 0.997, 1.540), Vector(-0.912, 0.988, 0.982),
			Vector(-0.916, 1.055, 0.799), Vector(-1.446, 1.188, 0.683), Vector(-0.687, 1.425, -0.103), Vector(-0.765, 1.347, 0.401),
			Vector(-0.062, 0.705, -3.128), Vector(-1.008, 0.706, -2.969), Vector(-1.097, 0.537, -2.932), Vector(-0.821, 0.261, -3.039),
			Vector(-0.707, 0.522, -3.140), Vector(-0.248, 0.509, -3.191), Vector(-0.236, 0.220, -3.133), Vector(-0.233, 0.431, -3.148),
			Vector(-0.085, 0.364, -3.176), Vector(-0.747, 0.477, -3.060), Vector(Empty Array, 1.454, -0.745), Vector(Empty Array, 1.460,
			0.457), Vector(Empty Array, 1.525, -0.072), Vector(0.822, 1.228, -0.575), Vector(0.598, 1.311, -1.015), Vector(-0.822, 1.228,
			-0.575), Vector(-0.598, 1.311, -1.015), Vector(Empty Array, 1.007, 1.725));
		Global.VAR_VEH_MESH_EDGES_FRONT_BUMPER = Array(1, 0, 5, 1, 3, 2, 4, 3, 1, 4, 6, 7, 8, 10, 4, 9, 2, 5, 13, 12, 17, 13, 15, 14, 16,
			15, 13, 16, 18, 19, 15, 20, 16, 21, 14, 17, 20, 23, 3, 23, 22, 20, 11, 23, 3, 24, 15, 25, 11, 22, 22, 25, 11, 24, 7, 19);
		Global.VAR_VEH_MESH_EDGES_FRONT_HOOD = Array(0, 1, 1, 4, 3, 11, 5, 6, 6, 9, 0, 11, 5, 10, 1, 6, 4, 9, 8, 10, 9, 7, 4, 2);
		Global.VAR_VEH_MESH_EDGES_BODY = Array(4, 0, 0, 2, 6, 3, 2, 1, 3, 5, 7, 8, 8, 9, 13, 11, 10, 13, 48, 14, 14, 15, 45, 16, 16, 19,
			19, 20, 13, 22, 35, 46, 17, 18, 27, 23, 23, 25, 29, 26, 25, 24, 26, 28, 30, 31, 32, 33, 34, 49, 33, 35, 51, 36, 36, 37, 39, 42,
			42, 43, 35, 44, 9, 48, 38, 39, 40, 41, 13, 21, 12, 48, 48, 18, 20, 12, 50, 51, 51, 41, 34, 50, 43, 50, 34, 44, 9, 10, 31, 32,
			32, 51, 0, 8, 23, 31, 52, 47, 35, 53, 52, 12, 52, 22, 11, 52, 53, 34);
		Global.VAR_VEH_MESH_EDGES_ENGINE_HOOD = Array(0, 1, 1, 2, 15, 18, 0, 3, 13, 14, 9, 13, 0, 5, 5, 6, 8, 7, 6, 8, 6, 9, 5, 10, 10, 11,
			13, 11, 11, 12, 2, 12, 9, 10, 15, 16, 16, 17, 28, 29, 23, 28, 15, 20, 20, 21, 21, 22, 21, 23, 20, 24, 24, 25, 28, 25, 25, 26,
			17, 26, 29, 27, 23, 24, 14, 27, 5, 4, 20, 30, 19, 32, 7, 31, 22, 19, 1, 10, 16, 24);
		Global.VAR_VEH_MESH_EDGES_REAR_BUMPER = Array(0, 1, 8, 3, 14, 17, 5, 4, 3, 5, 2, 7, 1, 8, 9, 10, 12, 13, 19, 14, 3, 6, 16, 15, 14,
			16, 22, 24, 23, 18, 13, 19, 20, 21, 11, 24, 10, 21, 7, 18, 9, 20);
		Global.VAR_VEH_MESH_EDGES_HEADLIGHTS = Array(0, 1, 2, 3);
		Global.VAR_VEH_MESH_EDGES_L_R_LIGHTS = Array(2, 3, 1, 0);
		Global.VAR_VEH_MESH_EDGES_R_R_LIGHTS = Array(2, 3, 1, 0);
		Global.VAR_VEH_MESH_EDGES_NITROUS = Array(0, 2, 3, 1);
		Global.VAR_VEH_MESH_EDGES_CARBON_PARTS = Array(0, 1, 2, 3, 1, 3, 4, 6, 5, 7, 10, 11, 14, 15, 16, 17, 13, 17, 40, 41, 19, 20, 21,
			22, 22, 23, 23, 24, 25, 26, 20, 27, 7, 8, 28, 30, 29, 31, 33, 34, 8, 32, 12, 9, 38, 39, 35, 39, 36, 37, 41, 42, 43, 44, 44, 45,
			45, 46, 47, 48, 42, 49, 31, 32, 18, 19, 0, 16, 2, 38, 52, 51, 50, 52, 17, 51, 39, 51, 0, 50, 2, 50, 57, 34, 53, 54, 55, 56, 53,
			0, 55, 2, 11, 57);
		"PASTE YOUR CAR HERE - Original Gamemode Creator: GraczCourier (now known as RaidVentador_Courier_13)"
		Global.VAR_PLAYER_RACER.VAR_VEH_COLOR_DEFAULT = Color(Red);
		Call Subroutine(SUB_VEH_VSL_GET_COLORS);
	}
}

rule("#7 McLaren P1 2013 (Mesh Array Tables)")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		"FOR INDEXES REFER TO: MENU \\ ARRAY TABLE - INTERNAL STORAGE VARIABLE \n [1] - CURRENT CAR \n Rule Elements Count: 2721"
		Global.VAR_GBL_INTRNL_STORED_VALUES[1] == 6;
		Entity Exists(Global.VAR_PLAYER_RACER) == True;
	}

	actions
	{
		"VERTICES COUNT: 263 \n EDGE COUNT: 212 \n Car models ported with Deltin's OSTW for Visual Studio Code"
		Global.VAR_VEH_MESH_VRTCS_FRONT_BUMPER = Array(Vector(1.200, 1.085, 1.475), Vector(1.042, 1.027, 2.126), Vector(0.696, 0.693,
			2.911), Vector(1.302, 0.660, 1.242), Vector(1.327, 0.849, 1.468), Vector(1.014, 0.714, 2.582), Vector(1.169, 0.735, 2.408),
			Vector(0.917, 0.387, 2.807), Vector(0.898, 0.265, 2.758), Vector(1.327, 0.974, 1.683), Vector(1.207, 0.424, 2.384), Vector(
			1.306, 0.733, 2.140), Vector(0.338, 0.587, 3.100), Vector(0.736, 0.654, 2.919), Vector(0.951, 1.072, 1.327), Vector(1.207,
			0.281, 2.297), Vector(-1.200, 1.085, 1.475), Vector(-1.042, 1.027, 2.126), Vector(-0.696, 0.693, 2.911), Vector(-1.327, 0.849,
			1.468), Vector(-1.014, 0.714, 2.582), Vector(-1.169, 0.735, 2.408), Vector(-0.917, 0.387, 2.807), Vector(-0.898, 0.265, 2.758),
			Vector(-1.327, 0.974, 1.683), Vector(-1.207, 0.424, 2.384), Vector(-1.306, 0.733, 2.140), Vector(-0.338, 0.587, 3.100), Vector(
			-0.736, 0.654, 2.919), Vector(-0.951, 1.072, 1.327), Vector(-1.302, 0.660, 1.242), Vector(-1.207, 0.281, 2.297));
		Global.VAR_VEH_MESH_VRTCS_FRONT_HOOD = Array(Vector(Empty Array, 0.582, 3.136), Vector(0.661, 1.005, 2.056), Vector(0.320, 0.814,
			2.780), Vector(0.079, 0.785, 2.881), Vector(0.150, 1.047, 1.965), Vector(0.865, 1.047, 1.480), Vector(0.818, 1, 1.981), Vector(
			0.338, 0.587, 3.100), Vector(0.555, 0.829, 2.688), Vector(-0.661, 1.005, 2.056), Vector(-0.320, 0.814, 2.780), Vector(-0.079,
			0.785, 2.881), Vector(-0.150, 1.047, 1.965), Vector(-0.865, 1.047, 1.480), Vector(-0.818, 1, 1.981), Vector(-0.338, 0.587,
			3.100), Vector(-0.555, 0.829, 2.688));
		Global.VAR_VEH_MESH_VRTCS_BODY = Array(Vector(1.189, 0.206, 1.152), Vector(1.275, 0.608, 1.216), Vector(1.248, 0.627, 1.087),
			Vector(1.248, 0.344, 0.827), Vector(1.283, 0.489, -0.451), Vector(1.268, 0.993, -1.021), Vector(1.316, 0.846, -1.559), Vector(
			1.188, 1.127, -0.665), Vector(1.200, 1.085, 1.475), Vector(1.302, 0.660, 1.242), Vector(0.987, 1.065, 1.250), Vector(0.729,
			1.464, 0.484), Vector(0.677, 1.539, -0.010), Vector(0.620, 1.515, -0.433), Vector(1.042, 1.029, 0.247), Vector(1.264, 0.914,
			0.835), Vector(1.271, 0.990, -0.641), Vector(0.952, 1.107, -0.564), Vector(-1.189, 0.206, 1.152), Vector(-1.275, 0.608, 1.216),
			Vector(-1.248, 0.627, 1.087), Vector(-1.248, 0.344, 0.827), Vector(-1.283, 0.489, -0.451), Vector(-1.268, 0.993, -1.021),
			Vector(-1.188, 1.127, -0.665), Vector(-1.200, 1.085, 1.475), Vector(-0.987, 1.065, 1.250), Vector(-0.729, 1.464, 0.484),
			Vector(-0.677, 1.539, -0.010), Vector(-0.620, 1.515, -0.433), Vector(-1.042, 1.029, 0.247), Vector(-1.264, 0.914, 0.835),
			Vector(-1.271, 0.990, -0.641), Vector(-0.952, 1.107, -0.564), Vector(-1.302, 0.660, 1.242), Vector(1.239, 0.288, -1.439),
			Vector(-1.239, 0.288, -1.439), Vector(-1.316, 0.846, -1.559));
		Global.VAR_VEH_MESH_VRTCS_ENGINE_HOOD = Array(Vector(1.316, 0.846, -1.559), Vector(1.330, 1.007, -1.952), Vector(1.309, 0.794,
			-2.397), Vector(1.264, 0.491, -2.488), Vector(1.157, 0.302, -2.504), Vector(1.146, 0.957, -2.536), Vector(1.005, 1.192,
			-2.344), Vector(1.125, 1.229, -1.898), Vector(1.188, 1.127, -0.665), Vector(0.620, 1.515, -0.433), Vector(0.468, 1.187,
			-1.749), Vector(0.171, 1.020, -2.420), Vector(0.467, 0.978, -2.510), Vector(0.930, 1.153, -2.376), Vector(0.657, 1.258,
			-1.223), Vector(0.883, 1.033, -2.779), Vector(1.056, 1.116, -0.617), Vector(-1.316, 0.846, -1.559), Vector(-1.330, 1.007,
			-1.952), Vector(-1.309, 0.794, -2.397), Vector(-1.264, 0.491, -2.488), Vector(-1.157, 0.302, -2.504), Vector(-1.146, 0.957,
			-2.536), Vector(-1.005, 1.192, -2.344), Vector(-1.125, 1.229, -1.898), Vector(-1.188, 1.127, -0.665), Vector(-0.620, 1.515,
			-0.433), Vector(-0.468, 1.187, -1.749), Vector(-0.171, 1.020, -2.420), Vector(-0.467, 0.978, -2.510), Vector(-0.930, 1.153,
			-2.376), Vector(-0.657, 1.258, -1.223), Vector(-0.883, 1.033, -2.779), Vector(-1.056, 1.116, -0.617), Vector(Empty Array,
			0.978, -2.560), Vector(0.952, 1.107, -0.564), Vector(-0.952, 1.107, -0.564), Vector(0.573, 0.917, -2.946), Vector(-0.573,
			0.917, -2.946), Vector(0.332, 0.908, -2.978), Vector(-0.332, 0.908, -2.978), Vector(1.065, 0.324, -2.641), Vector(0.915, 0.702,
			-2.887), Vector(-1.065, 0.324, -2.641), Vector(-0.915, 0.702, -2.887));
		Global.VAR_VEH_MESH_VRTCS_REAR_BUMPER = Array(Vector(Empty Array, 1.355, -3.245), Vector(0.896, 1.490, -2.779), Vector(Empty Array,
			1.332, -3.033), Vector(0.595, 1.336, -3.166), Vector(0.914, 1.484, -2.718), Vector(0.583, 1.310, -2.964), Vector(-0.896, 1.490,
			-2.779), Vector(-0.595, 1.336, -3.166), Vector(-0.914, 1.484, -2.718), Vector(-0.583, 1.310, -2.964));
		Global.VAR_VEH_MESH_VRTCS_HEADLIGHTS = Array(Vector(0.902, 0.830, 2.595), Vector(1.169, 0.756, 2.403), Vector(1.088, 0.816, 2.393),
			Vector(0.859, 0.781, 2.557), Vector(1.146, 0.873, 2.321), Vector(-0.902, 0.830, 2.595), Vector(-1.169, 0.756, 2.403), Vector(
			-1.088, 0.816, 2.393), Vector(-0.859, 0.781, 2.557), Vector(-1.146, 0.873, 2.321));
		Global.VAR_VEH_MESH_VRTCS_L_R_LIGHTS = Array(Vector(1.146, 0.957, -2.536), Vector(0.883, 1.033, -2.779), Vector(0.573, 0.917,
			-2.946), Vector(0.915, 0.702, -2.887));
		Global.VAR_VEH_MESH_VRTCS_R_R_LIGHTS = Array(Vector(-1.146, 0.957, -2.536), Vector(-0.883, 1.033, -2.779), Vector(-0.573, 0.917,
			-2.946), Vector(-0.915, 0.702, -2.887));
		Global.VAR_VEH_MESH_VRTCS_NITROUS = Array(Vector(0.171, 0.791, -2.938), Vector(-0.171, 0.791, -2.938));
		Global.VAR_VEH_MESH_VRTCS_CARBON_PARTS = Array(Vector(0.555, 0.489, 3.008), Vector(0.987, 1.065, 1.250), Vector(0.729, 1.464,
			0.484), Vector(0.620, 1.515, -0.433), Vector(1.014, 0.659, 2.545), Vector(0.645, 1.045, 1.712), Vector(Empty Array, 1.041,
			1.874), Vector(-0.365, 0.640, -2.991), Vector(1.238, 0.204, 1.203), Vector(1.248, 0.204, -1.426), Vector(1.306, 0.733, 2.140),
			Vector(1.307, 0.243, 2.199), Vector(0.595, 0.764, -2.414), Vector(0.595, 1.226, -2.842), Vector(0.595, 0.702, -2.527), Vector(
			0.595, 1.163, -2.956), Vector(0.176, 1.587, -0.498), Vector(0.560, 1.520, -0.538), Vector(0.361, 0.368, -2.932), Vector(0.419,
			0.162, -2.861), Vector(0.689, 0.476, -2.961), Vector(0.857, 0.181, -2.705), Vector(0.599, 0.286, 2.934), Vector(0.098, 1.466,
			-0.920), Vector(1.228, 0.899, 0.797), Vector(1.312, 1.128, 0.889), Vector(0.143, 1.556, 0.473), Vector(Empty Array, 1.571,
			0.467), Vector(1.253, 0.583, -0.633), Vector(1.271, 0.990, -0.641), Vector(1.221, 0.781, 0.739), Vector(0.952, 1.107, -0.564),
			Vector(Empty Array, 0.489, 3.131), Vector(1.029, 0.243, 2.780), Vector(0.044, 1.417, 0.913), Vector(0.583, 1.304, -2.975),
			Vector(1.455, 1.116, 0.769), Vector(0.579, 0.474, -2.965), Vector(0.626, 0.178, -2.736), Vector(0.629, 0.243, 3.045), Vector(
			0.396, 1.228, -1.655), Vector(0.072, 1.030, -2.294), Vector(1.173, 0.430, -0.197), Vector(-0.555, 0.489, 3.008), Vector(-0.987,
			1.065, 1.250), Vector(-0.729, 1.464, 0.484), Vector(-0.620, 1.515, -0.433), Vector(-1.014, 0.659, 2.545), Vector(-0.645, 1.045,
			1.712), Vector(-0.204, 0.657, -3.083), Vector(-1.238, 0.204, 1.203), Vector(-1.248, 0.204, -1.426), Vector(-1.306, 0.733,
			2.140), Vector(-1.307, 0.243, 2.199), Vector(-0.595, 0.764, -2.414), Vector(-0.595, 1.226, -2.842), Vector(-0.595, 0.702,
			-2.527), Vector(-0.595, 1.163, -2.956), Vector(-0.560, 1.520, -0.538), Vector(-0.391, 0.368, -2.932), Vector(-0.419, 0.162,
			-2.861), Vector(-0.689, 0.476, -2.961), Vector(-0.857, 0.181, -2.705), Vector(-0.599, 0.286, 2.934), Vector(-0.098, 1.466,
			-0.920), Vector(-1.228, 0.899, 0.797), Vector(-1.312, 1.128, 0.889), Vector(-0.143, 1.556, 0.473), Vector(-1.253, 0.583,
			-0.633), Vector(-1.271, 0.990, -0.641), Vector(-1.221, 0.781, 0.739), Vector(-0.952, 1.107, -0.564), Vector(-1.029, 0.243,
			2.780), Vector(-0.044, 1.417, 0.913), Vector(-0.583, 1.304, -2.975), Vector(-1.455, 1.116, 0.769), Vector(-0.579, 0.474,
			-2.965), Vector(-0.626, 0.178, -2.736), Vector(Empty Array, 0.285, -2.932), Vector(-0.629, 0.243, 3.045), Vector(-0.396, 1.228,
			-1.655), Vector(-0.072, 1.030, -2.294), Vector(-1.173, 0.430, -0.197), Vector(-0.927, 0.646, -2.809), Vector(0.375, 0.476,
			-3.044), Vector(-0.375, 0.476, -3.044), Vector(0.365, 0.640, -2.991), Vector(0.159, 1.630, -0.114), Vector(0.176, 1.581,
			-0.364), Vector(-0.159, 1.630, -0.114), Vector(-0.176, 1.581, -0.364), Vector(-0.176, 1.587, -0.498), Vector(0.204, 0.657,
			-3.083), Vector(0.927, 0.646, -2.809), Vector(0.518, 1.446, -0.873), Vector(-0.518, 1.446, -0.873), Vector(0.152, 1.520,
			-0.689), Vector(-0.152, 1.520, -0.689), Vector(0.391, 0.368, -2.932), Vector(-0.361, 0.368, -2.932), Vector(Empty Array, 0.243,
			3.195));
		Global.VAR_VEH_MESH_EDGES_FRONT_BUMPER = Array(0, 1, 3, 9, 6, 7, 0, 4, 9, 11, 7, 8, 10, 11, 15, 10, 5, 13, 0, 14, 13, 12, 8, 15, 1,
			2, 30, 24, 21, 22, 16, 19, 24, 26, 22, 23, 25, 26, 31, 25, 20, 28, 16, 29, 28, 27, 23, 31, 17, 18, 16, 17);
		Global.VAR_VEH_MESH_EDGES_FRONT_HOOD = Array(1, 2, 3, 4, 5, 6, 8, 7, 6, 8, 7, 0, 2, 3, 9, 10, 11, 12, 13, 14, 16, 15, 14, 16, 15,
			0, 10, 11);
		Global.VAR_VEH_MESH_EDGES_BODY = Array(0, 1, 1, 2, 2, 3, 3, 4, 5, 6, 11, 12, 10, 14, 12, 13, 7, 16, 7, 15, 15, 8, 5, 16, 10, 11,
			18, 19, 19, 20, 20, 21, 21, 22, 27, 28, 26, 30, 7, 17, 28, 29, 24, 32, 24, 31, 31, 25, 23, 32, 34, 32, 26, 27, 9, 16, 14, 17,
			30, 33, 24, 33, 4, 5, 22, 23, 36, 37, 23, 37, 35, 6);
		Global.VAR_VEH_MESH_EDGES_ENGINE_HOOD = Array(0, 1, 1, 2, 2, 3, 3, 4, 6, 7, 7, 8, 1, 7, 10, 11, 2, 5, 12, 13, 15, 6, 26, 27, 9, 14,
			35, 14, 17, 18, 18, 19, 19, 20, 20, 21, 23, 24, 24, 25, 18, 24, 27, 28, 19, 22, 29, 30, 32, 23, 26, 31, 36, 31, 16, 12, 11, 28,
			33, 29, 34, 29, 9, 10, 12, 14, 29, 31, 12, 34, 38, 40, 37, 39, 39, 40, 44, 43, 42, 41, 4, 41, 21, 43);
		Global.VAR_VEH_MESH_EDGES_REAR_BUMPER = Array(3, 0, 5, 2, 3, 1, 5, 4, 7, 0, 9, 2, 7, 6, 9, 8);
		Global.VAR_VEH_MESH_EDGES_HEADLIGHTS = Array(2, 3, 4, 1, 0, 4, 7, 8, 9, 6, 5, 9);
		Global.VAR_VEH_MESH_EDGES_L_R_LIGHTS = Array(1, 2, 3, 0, 0, 1);
		Global.VAR_VEH_MESH_EDGES_R_R_LIGHTS = Array(3, 0, 1, 2, 0, 1);
		Global.VAR_VEH_MESH_EDGES_NITROUS = Array(0, 1);
		Global.VAR_VEH_MESH_EDGES_CARBON_PARTS = Array(5, 6, 9, 8, 10, 11, 12, 13, 14, 15, 13, 15, 88, 17, 13, 35, 84, 19, 21, 20, 16, 23,
			24, 25, 26, 34, 2, 27, 0, 22, 28, 30, 32, 0, 0, 4, 33, 39, 25, 36, 11, 33, 37, 38, 7, 99, 40, 41, 1, 5, 42, 29, 48, 6, 3, 31,
			51, 50, 52, 53, 54, 55, 56, 57, 55, 57, 90, 58, 89, 91, 55, 74, 61, 85, 62, 61, 65, 66, 67, 73, 45, 27, 93, 92, 83, 49, 43, 63,
			68, 70, 32, 43, 43, 47, 72, 79, 66, 75, 53, 72, 76, 77, 80, 81, 44, 48, 82, 69, 100, 79, 34, 73, 23, 64, 20, 84, 85, 60, 98,
			78, 46, 71, 41, 81, 87, 16, 91, 64, 87, 89, 67, 89, 26, 87, 49, 92, 78, 59, 86, 18, 96, 94, 97, 95, 39, 100);
		"PASTE YOUR CAR HERE - Original Gamemode Creator: GraczCourier (now known as RaidVentador_Courier_13)"
		Global.VAR_PLAYER_RACER.VAR_VEH_COLOR_DEFAULT = Color(Orange);
		Call Subroutine(SUB_VEH_VSL_GET_COLORS);
	}
}

rule("#8 Porsche 918 2013 (Mesh Array Tables)")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		"FOR INDEXES REFER TO: MENU \\ ARRAY TABLE - INTERNAL STORAGE VARIABLE \n [1] - CURRENT CAR \n Rule Elements Count: 2747"
		Global.VAR_GBL_INTRNL_STORED_VALUES[1] == 7;
		Entity Exists(Global.VAR_PLAYER_RACER) == True;
	}

	actions
	{
		"VERTICES COUNT: 262 \n EDGE COUNT: 220 \n Car models ported with Deltin's OSTW for Visual Studio Code"
		Global.VAR_VEH_MESH_VRTCS_FRONT_BUMPER = Array(Vector(1.351, 0.829, 2.259), Vector(1.164, 0.824, 2.638), Vector(1.073, 0.248,
			2.852), Vector(0.650, 0.252, 3.087), Vector(0.457, 0.406, 3.184), Vector(-0.457, 0.406, 3.184), Vector(1.342, 0.246, 2.348),
			Vector(1.348, 0.629, 2.367), Vector(1.153, 0.592, 2.849), Vector(0.467, 0.572, 3.202), Vector(-0.761, 0.698, 2.989), Vector(
			-1.351, 0.829, 2.259), Vector(-1.105, 0.767, 2.745), Vector(-1.073, 0.248, 2.852), Vector(-0.650, 0.252, 3.087), Vector(-1.342,
			0.246, 2.348), Vector(-1.348, 0.629, 2.367), Vector(-1.153, 0.592, 2.849), Vector(-0.467, 0.572, 3.202), Vector(0.677, 0.292,
			3.016), Vector(-0.677, 0.292, 3.016), Vector(0.522, 0.528, 3.108), Vector(-0.522, 0.528, 3.108), Vector(Empty Array, 0.572,
			3.281), Vector(Empty Array, 0.749, 3.022), Vector(1.105, 0.767, 2.745), Vector(0.761, 0.698, 2.989), Vector(-1.164, 0.824,
			2.638));
		Global.VAR_VEH_MESH_VRTCS_FRONT_HOOD = Array(Vector(1.005, 1.107, 0.945), Vector(1.242, 1.138, 1.843), Vector(0.787, 0.810, 2.820),
			Vector(1.291, 0.850, 1.049), Vector(1.342, 0.837, 1.391), Vector(1.342, 1.038, 1.837), Vector(1.351, 0.829, 2.259), Vector(
			1.164, 0.824, 2.638), Vector(0.574, 0.784, 2.895), Vector(-1.128, 1.001, 2.420), Vector(1.192, 1.012, 0.986), Vector(1.009,
			1.112, 0.850), Vector(-1.242, 1.138, 1.843), Vector(0.960, 1.139, 1.814), Vector(-1.291, 0.850, 1.049), Vector(-1.342, 0.837,
			1.391), Vector(-1.342, 1.038, 1.837), Vector(-1.351, 0.829, 2.259), Vector(-0.574, 0.784, 2.895), Vector(-1.005, 1.107, 0.945),
			Vector(-1.192, 1.012, 0.986), Vector(-1.009, 1.112, 0.850), Vector(-0.960, 1.139, 1.814), Vector(Empty Array, 0.749, 3.022),
			Vector(-0.893, 0.952, 2.538), Vector(-0.787, 0.810, 2.820), Vector(-1.164, 0.824, 2.638), Vector(1.128, 1.001, 2.420), Vector(
			0.893, 0.952, 2.538), Vector(0.804, 1.068, 1.889), Vector(-0.804, 1.068, 1.889), Vector(0.825, 1.145, 1.268), Vector(-0.825,
			1.145, 1.268));
		Global.VAR_VEH_MESH_VRTCS_BODY = Array(Vector(1.281, 0.160, 1.281), Vector(1.281, 0.160, -1.514), Vector(1.361, 0.791, -1.525),
			Vector(1.358, 0.635, -1.468), Vector(0.079, 1.326, -0.741), Vector(0.222, 1.554, -0.603), Vector(0.730, 1.509, -0.597), Vector(
			1.273, 0.592, -0.648), Vector(1.252, 0.364, -0.309), Vector(1.156, 0.253, 1.170), Vector(1.281, 0.160, 1.216), Vector(1.255,
			0.373, 0.989), Vector(1.255, 0.516, 0.672), Vector(1.201, 0.583, -0.460), Vector(1.127, 1.069, -0.865), Vector(1.005, 1.107,
			0.945), Vector(1.183, 0.583, -0.672), Vector(1.291, 0.850, 1.049), Vector(1.342, 0.837, 1.391), Vector(1.192, 1.012, 0.986),
			Vector(0.677, 1.131, 1.380), Vector(-1.281, 0.160, 1.281), Vector(-1.281, 0.160, -1.514), Vector(-1.361, 0.791, -1.525),
			Vector(-1.373, 1.096, -2.027), Vector(-1.373, 0.967, -2.376), Vector(-1.358, 0.635, -1.468), Vector(-0.079, 1.326, -0.741),
			Vector(-0.222, 1.554, -0.603), Vector(-0.730, 1.509, -0.597), Vector(-0.979, 1.178, -0.811), Vector(-1.273, 0.592, -0.648),
			Vector(-1.252, 0.364, -0.309), Vector(-1.156, 0.253, 1.170), Vector(-1.281, 0.160, 1.216), Vector(-1.255, 0.373, 0.989),
			Vector(-1.255, 0.516, 0.672), Vector(-1.201, 0.583, -0.460), Vector(-1.127, 1.069, -0.865), Vector(-1.183, 0.583, -0.672),
			Vector(-1.291, 0.850, 1.049), Vector(-1.342, 0.837, 1.391), Vector(Empty Array, 1.147, 1.591), Vector(-1.005, 1.107, 0.945),
			Vector(-1.192, 1.012, 0.986), Vector(-0.677, 1.131, 1.380), Vector(1.149, 1.050, -0.667), Vector(0.987, 1.142, -0.592), Vector(
			-1.149, 1.050, -0.667), Vector(-0.987, 1.142, -0.592), Vector(1.209, 1.103, -0.835), Vector(0.959, 1.239, -1.119), Vector(
			0.454, 1.570, -0.830), Vector(-0.959, 1.239, -1.119), Vector(0.979, 1.178, -0.811), Vector(-1.229, 1.153, -1.216), Vector(
			1.229, 1.153, -1.216), Vector(-1.209, 1.103, -0.835), Vector(0.460, 1.610, -0.566), Vector(-0.454, 1.570, -0.830), Vector(
			-0.460, 1.610, -0.566));
		Global.VAR_VEH_MESH_VRTCS_ENGINE_HOOD = Array(Vector(1.361, 0.791, -1.525), Vector(1.373, 1.096, -2.027), Vector(1.373, 0.967,
			-2.376), Vector(1.208, 1.061, -2.699), Vector(0.959, 1.239, -1.119), Vector(0.454, 1.570, -0.830), Vector(0.246, 1.540,
			-0.853), Vector(0.079, 1.322, -1.052), Vector(0.885, 1.279, -1.897), Vector(0.756, 1.159, -2.680), Vector(0.674, 1.505,
			-0.873), Vector(0.572, 1.114, -2.734), Vector(-1.373, 1.096, -2.027), Vector(-1.208, 1.061, -2.699), Vector(-1.236, 1.256,
			-1.916), Vector(-0.246, 1.540, -0.853), Vector(-0.079, 1.322, -1.052), Vector(-0.959, 1.239, -1.119), Vector(-0.885, 1.279,
			-1.897), Vector(-0.756, 1.159, -2.680), Vector(-0.674, 1.505, -0.873), Vector(-0.572, 1.114, -2.734), Vector(-1.361, 0.885,
			-1.605), Vector(1.361, 0.885, -1.605), Vector(1.236, 1.256, -1.916), Vector(-1.229, 1.153, -1.216), Vector(1.229, 1.153,
			-1.216), Vector(-0.454, 1.570, -0.830));
		Global.VAR_VEH_MESH_VRTCS_REAR_BUMPER = Array(Vector(1.373, 0.967, -2.376), Vector(1.208, 1.061, -2.699), Vector(1.211, 0.902,
			-2.783), Vector(0.379, 0.839, -3.235), Vector(0.522, 0.598, -3.158), Vector(0.801, 0.302, -3.055), Vector(-0.679, 0.871,
			-3.111), Vector(1.199, 0.315, -2.639), Vector(0.557, 1.058, -2.951), Vector(1.201, 0.926, -2.753), Vector(0.564, 0.929,
			-3.184), Vector(0.572, 1.114, -2.734), Vector(-1.373, 0.967, -2.376), Vector(-1.199, 0.315, -2.639), Vector(-1.208, 1.061,
			-2.699), Vector(-1.211, 0.902, -2.783), Vector(-0.782, 0.560, -3.133), Vector(0.782, 0.560, -3.133), Vector(-1.100, 0.631,
			-2.977), Vector(-0.379, 0.839, -3.235), Vector(-0.522, 0.598, -3.158), Vector(-0.801, 0.302, -3.055), Vector(0.552, 1, -3.065),
			Vector(-0.557, 1.058, -2.951), Vector(-1.201, 0.926, -2.753), Vector(-0.564, 0.929, -3.184), Vector(-0.572, 1.114, -2.734),
			Vector(-0.552, 1, -3.065), Vector(0.679, 0.871, -3.111), Vector(-0.906, 0.599, -2.939), Vector(0.906, 0.599, -2.939), Vector(
			1.100, 0.631, -2.977), Vector(-1.365, 0.677, -2.574), Vector(1.365, 0.677, -2.574));
		Global.VAR_VEH_MESH_VRTCS_HEADLIGHTS = Array(Vector(1.027, 0.954, 2.470), Vector(-0.968, 0.724, 2.711), Vector(-1.027, 0.954,
			2.470), Vector(0.968, 0.724, 2.711));
		Global.VAR_VEH_MESH_VRTCS_L_R_LIGHTS = Array(Vector(0.646, 1.034, -2.911), Vector(1.180, 1.007, -2.685));
		Global.VAR_VEH_MESH_VRTCS_R_R_LIGHTS = Array(Vector(-0.646, 1.034, -2.911), Vector(-1.180, 1.007, -2.685));
		Global.VAR_VEH_MESH_VRTCS_NITROUS = Array(Vector(0.449, 1.411, -1.432), Vector(0.449, 1.349, -1.521), Vector(-0.449, 1.411,
			-1.432), Vector(-0.449, 1.349, -1.521));
		Global.VAR_VEH_MESH_VRTCS_CARBON_PARTS = Array(Vector(1.257, 0.390, -2.934), Vector(1.358, 0.797, -2.768), Vector(0.823, 0.281,
			-2.999), Vector(0.778, 0.259, -3.100), Vector(0.530, 0.363, -3.133), Vector(1.208, 1.061, -2.699), Vector(1.369, 0.827,
			-2.556), Vector(0.222, 1.554, -0.603), Vector(0.730, 1.509, -0.597), Vector(0.756, 1.159, -2.680), Vector(0.464, 1.162,
			-3.094), Vector(1.199, 0.315, -2.639), Vector(0.444, 1.298, -1.564), Vector(0.429, 1.275, -1.977), Vector(0.765, 1.522, 0.427),
			Vector(Empty Array, 1.608, 0.511), Vector(Empty Array, 1.652, -0.048), Vector(-0.576, 0.210, 3.134), Vector(1.342, 0.202,
			2.348), Vector(1.126, 0.203, 2.857), Vector(0.650, 0.209, 3.129), Vector(0.457, 0.363, 3.215), Vector(0.576, 0.210, 3.134),
			Vector(0.734, 1.551, -0.055), Vector(0.103, 1.289, -1.301), Vector(0.166, 1.315, -1.470), Vector(0.136, 1.152, -2.236), Vector(
			1.009, 1.112, 0.850), Vector(1.141, 1.030, 0.854), Vector(1.343, 1.163, 0.692), Vector(-1.257, 0.390, -2.934), Vector(-1.358,
			0.797, -2.768), Vector(-1.199, 0.315, -2.639), Vector(-0.823, 0.281, -2.999), Vector(-0.778, 0.259, -3.100), Vector(-0.711,
			0.470, -3.180), Vector(0.711, 0.470, -3.180), Vector(-0.530, 0.487, -3.212), Vector(-0.530, 0.259, -3.129), Vector(-0.530,
			0.363, -3.133), Vector(-1.208, 1.061, -2.699), Vector(-1.369, 0.827, -2.556), Vector(-0.222, 1.554, -0.603), Vector(-0.730,
			1.509, -0.597), Vector(-1.343, 1.163, 0.692), Vector(-0.756, 1.159, -2.680), Vector(-0.464, 1.162, -3.094), Vector(Empty Array,
			1.157, -2.767), Vector(-0.444, 1.298, -1.564), Vector(-0.429, 1.275, -1.977), Vector(-0.765, 1.522, 0.427), Vector(-1.342,
			0.202, 2.348), Vector(-1.126, 0.203, 2.857), Vector(-0.650, 0.209, 3.129), Vector(-0.457, 0.363, 3.215), Vector(-0.734, 1.551,
			-0.055), Vector(-0.103, 1.289, -1.301), Vector(-0.166, 1.315, -1.470), Vector(-0.136, 1.152, -2.236), Vector(-1.009, 1.112,
			0.850), Vector(-1.141, 1.030, 0.854), Vector(Empty Array, 1.554, -0.603), Vector(0.987, 1.142, -0.592), Vector(-0.987, 1.142,
			-0.592), Vector(0.530, 0.487, -3.212), Vector(0.530, 0.259, -3.129));
		Global.VAR_VEH_MESH_EDGES_FRONT_BUMPER = Array(6, 2, 2, 3, 3, 4, 8, 9, 7, 8, 0, 6, 15, 13, 13, 14, 17, 18, 16, 17, 11, 15, 23, 18,
			2, 8, 13, 17, 19, 21, 20, 22, 9, 23, 14, 5, 23, 24, 27, 17, 1, 8, 10, 12, 26, 25, 4, 5);
		Global.VAR_VEH_MESH_EDGES_FRONT_HOOD = Array(28, 13, 3, 4, 4, 5, 5, 6, 10, 3, 6, 7, 11, 10, 1, 10, 24, 22, 14, 15, 15, 16, 16, 17,
			20, 14, 17, 26, 21, 20, 12, 20, 18, 23, 2, 8, 8, 23, 25, 18, 0, 13, 19, 22, 1, 27, 12, 9, 8, 29, 18, 30, 29, 31, 30, 32, 2, 28,
			24, 25, 1, 5, 12, 16);
		Global.VAR_VEH_MESH_EDGES_BODY = Array(0, 1, 22, 23, 1, 2, 7, 3, 4, 5, 50, 7, 7, 8, 8, 9, 10, 11, 11, 12, 16, 12, 13, 46, 20, 42,
			11, 17, 18, 0, 14, 19, 21, 22, 23, 24, 24, 25, 31, 26, 27, 28, 29, 30, 31, 32, 32, 33, 34, 35, 35, 36, 39, 36, 37, 48, 48, 49,
			35, 40, 41, 21, 43, 45, 38, 44, 45, 42, 15, 20, 4, 27, 46, 47, 30, 43, 51, 54, 55, 57, 59, 60, 52, 58, 30, 57, 5, 58, 58, 6, 6,
			54, 57, 31, 54, 50, 28, 60, 60, 29, 54, 15, 53, 30, 56, 50);
		Global.VAR_VEH_MESH_EDGES_ENGINE_HOOD = Array(1, 2, 3, 24, 5, 6, 6, 7, 11, 10, 10, 5, 4, 10, 13, 14, 15, 16, 8, 9, 21, 20, 7, 16,
			18, 19, 17, 20, 17, 18, 0, 1, 12, 14, 1, 24, 4, 8, 26, 4, 23, 26, 14, 25, 24, 26, 22, 25, 25, 17, 27, 15, 20, 27);
		Global.VAR_VEH_MESH_EDGES_REAR_BUMPER = Array(0, 1, 1, 2, 3, 4, 24, 25, 22, 11, 28, 30, 32, 13, 12, 14, 14, 15, 18, 16, 16, 17, 15,
			18, 19, 20, 16, 21, 27, 26, 6, 29, 8, 23, 33, 7, 9, 10, 3, 19, 17, 5, 10, 25, 2, 31, 31, 17, 12, 32, 0, 33);
		Global.VAR_VEH_MESH_EDGES_HEADLIGHTS = Array(2, 1, 0, 3);
		Global.VAR_VEH_MESH_EDGES_L_R_LIGHTS = Array(1, 0);
		Global.VAR_VEH_MESH_EDGES_R_R_LIGHTS = Array(1, 0);
		Global.VAR_VEH_MESH_EDGES_NITROUS = Array(1, 0, 3, 2);
		Global.VAR_VEH_MESH_EDGES_CARBON_PARTS = Array(14, 15, 0, 2, 28, 29, 11, 6, 6, 1, 62, 8, 5, 10, 48, 49, 15, 16, 16, 61, 19, 20, 20,
			21, 22, 17, 18, 19, 23, 14, 8, 23, 1, 0, 59, 50, 24, 25, 25, 26, 35, 36, 50, 15, 30, 33, 34, 35, 37, 38, 41, 31, 63, 43, 46,
			10, 40, 46, 47, 9, 12, 13, 7, 42, 32, 41, 52, 53, 21, 54, 51, 52, 55, 50, 43, 55, 31, 30, 56, 57, 57, 58, 60, 44, 27, 14, 24,
			56, 26, 58, 4, 39, 5, 9, 45, 47, 40, 45, 3, 36, 53, 54, 64, 65);
		"PASTE YOUR CAR HERE - Original Gamemode Creator: GraczCourier (now known as RaidVentador_Courier_13)"
		Global.VAR_PLAYER_RACER.VAR_VEH_COLOR_DEFAULT = Color(Gray);
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
			"SELECT CAR BODY"), 0, Array(Custom String("2016's Lamborghini Aventador SuperVeloce"), Custom String(
			"2021's Koenigsegg Jesko"), Custom String("2020's Lamborghini Sián FKP 37"), Custom String("2020's Pininfarina Battista"),
			Custom String("2018's McLaren Senna"), Custom String("2013's Ferrari LaFerrari"), Custom String("2013's McLaren P1"),
			Custom String("2013's Porsche 918")), 0), 1, False, 2, 50, 2, Workshop Setting Combo(Custom String(
			"A - START UP SETTINGS (GAME MODES)"), Custom String("SELECT GAME MODE"), 0, Array(Custom String("FREE DRIVE"), Custom String(
			"RACE"), Custom String("DYNAMITE TRIAL")), 0), Workshop Setting Integer(Custom String("A - START UP SETTINGS (GAME MODES)"),
			Custom String("NUMBER OF LAPS"), 3, 1, 30, 1), Workshop Setting Toggle(Custom String("A - START UP SETTINGS (GAME MODES)"),
			Custom String("REVERSE VARIANT"), False, 2), Workshop Setting Combo(Custom String("A - START UP SETTINGS (GAME MODES)"),
			Custom String("SCORE CONDITION"), 0, Array(Custom String("OFF"), Custom String("ON")), 3), Workshop Setting Integer(
			Custom String("A - START UP SETTINGS (GAME MODES)"), Custom String("SCORE THRESHOLD"), 100000, 1000, 1000000, 4),
			Workshop Setting Integer(Custom String("A - START UP SETTINGS (GAME MODES)"), Custom String("CHECKPOINT RADIUS"), 5, 1, 10, 5),
			Workshop Setting Integer(Custom String("A - START UP SETTINGS (GAME MODES)"), Custom String(
			"DYNAMITE TRIAL - START WITH REMAINING TIME"), 10, 10, 120, 6), Workshop Setting Integer(Custom String(
			"A - START UP SETTINGS (GAME MODES)"), Custom String("DYNAMITE TRIAL - TIME EARNED VIA CHECKPOINT"), 5, 0, 20, 7));
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
		If(Array Contains(Array(Map(Circuit royal), Map(King's Row), Map(Blizzard World), Map(Busan), Map(New Queen Street), Map(Paris),
			Map(Black Forest)), Current Map) == True);
			Global.VAR_GLB_RACE_HAS_TRACK = True;
			Global.VAR_GLB_RACE_HAS_REV_VARIANT = True;
		Else If(Array Contains(Array(Map(Colosseo)), Current Map) == True);
			Global.VAR_GLB_RACE_HAS_TRACK = True;
			Global.VAR_GLB_RACE_HAS_REV_VARIANT = False;
		Else;
			Global.VAR_GLB_RACE_HAS_TRACK = False;
			Global.VAR_GLB_RACE_HAS_REV_VARIANT = False;
		End;
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
		If(Current Map == Map(Circuit royal));
			"STARTING POSITIONS FOR: CIRCUIT ROYAL"
			Global.VAR_GLB_VEH_REG_START_POS = Vector(-18.161, 7.017, 3.987);
			Global.VAR_GLB_VEH_REG_START_FACE = 90;
			Global.VAR_GLB_VEH_REV_START_POS = Vector(1.067, 7.016, 3.982);
			Global.VAR_GLB_VEH_REV_START_FACE = -90;
		Else If(Current Map == Map(Paris));
			"STARTING POSITIONS FOR: PARIS"
			Global.VAR_GLB_VEH_REG_START_POS = Vector(16.254, 11.174, -54.481);
			Global.VAR_GLB_VEH_REG_START_FACE = -52.500;
			Global.VAR_GLB_VEH_REV_START_POS = Vector(5.469, 11.174, -44.427);
			Global.VAR_GLB_VEH_REV_START_FACE = 135;
		Else If(Current Map == Map(New Queen Street));
			"STARTING POSITIONS FOR: NEW QUEEN STREET"
			Global.VAR_GLB_VEH_REG_START_POS = Vector(-10.457, 2.637, -30.817);
			Global.VAR_GLB_VEH_REG_START_FACE = -4;
			Global.VAR_GLB_VEH_REV_START_POS = Vector(-10.866, 2.596, -4.568);
			Global.VAR_GLB_VEH_REV_START_FACE = -179.500;
		Else If(Current Map == Map(Colosseo));
			"STARTING POSITIONS FOR: COLOSSEO"
			Global.VAR_GLB_VEH_REG_START_POS = Vector(36.800, 3.050, 1.424);
			Global.VAR_GLB_VEH_REG_START_FACE = 179.500;
		Else If(Current Map == Map(King's Row));
			"STARTING POSITIONS FOR: KING'S ROW"
			Global.VAR_GLB_VEH_REG_START_POS = Vector(-27.368, 1.188, 16.012);
			Global.VAR_GLB_VEH_REG_START_FACE = 100;
			Global.VAR_GLB_VEH_REV_START_POS = Vector(-4.213, 1.586, 11.852);
			Global.VAR_GLB_VEH_REV_START_FACE = -80;
		Else If(Current Map == Map(Blizzard World));
			"STARTING POSITIONS FOR: BLIZZARD WORLD"
			Global.VAR_GLB_VEH_REG_START_POS = Vector(-38.270, 0.856, 75.801);
			Global.VAR_GLB_VEH_REG_START_FACE = -75;
			Global.VAR_GLB_VEH_REV_START_POS = Vector(-57.942, 0.855, 81.003);
			Global.VAR_GLB_VEH_REV_START_FACE = 105;
		Else If(Current Map == Map(Busan));
			"STARTING POSITIONS FOR: BUSAN"
			Global.VAR_GLB_VEH_REG_START_POS = Vector(108.191, 17.185, -111.474);
			Global.VAR_GLB_VEH_REG_START_FACE = -179;
			Global.VAR_GLB_VEH_REV_START_POS = Vector(108.188, 17.185, -132.011);
			Global.VAR_GLB_VEH_REV_START_FACE = 0;
		Else If(Current Map == Map(Black Forest));
			"STARTING POSITIONS FOR: BLACK FOREST"
			Global.VAR_GLB_VEH_REG_START_POS = Vector(-23.024, 14.218, 18.716);
			Global.VAR_GLB_VEH_REG_START_FACE = 177.500;
			Global.VAR_GLB_VEH_REV_START_POS = Vector(-22.824, 13.488, -2.604);
			Global.VAR_GLB_VEH_REV_START_FACE = -6;
		Else;
			If(Array Contains(Array(Game Mode(Deathmatch), Game Mode(Team Deathmatch), Game Mode(Bounty Hunter)), Current Game Mode) == True);
				Global.VAR_GLB_VEH_REG_START_POS = Spawn Points(All Teams);
				Global.VAR_GLB_VEH_REG_START_FACE = Spawn Points(All Teams);
			Else;
				Global.VAR_GLB_VEH_REG_START_POS = First Of(Spawn Points(Team Of(Global.VAR_PLAYER_RACER)));
				Global.VAR_GLB_VEH_REG_START_FACE = First Of(Spawn Points(Team Of(Global.VAR_PLAYER_RACER)));
			End;
		End;
	}
}

rule("INITIAL MECHANICS: GET CHECKPOINT TABLES")
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
		If(Current Map == Map(Circuit royal));
			"CHECKPOINT POSITIONS FOR: CIRCUIT ROYAL"
			Global.VAR_GLB_ARRAY_CHECKPOINT_TABLE = Array(Vector(-7.726, 7.017, 4.409), Vector(10.271, 11.074, -36.937), Vector(22.224, 16.032,
				-16.350), Vector(59.872, 16.209, -25.084), Vector(44.329, 16.255, -20.952), Vector(-4.645, 7.017, 4.237), Vector(-30.609,
				7.047, -42.150), Vector(-53.025, 5.403, -24.093), Vector(-22.489, 7.027, -27.145));
		Else If(Current Map == Map(Paris));
			"CHECKPOINT POSITIONS FOR: PARIS"
			Global.VAR_GLB_ARRAY_CHECKPOINT_TABLE = Array(Vector(11.979, 11.171, -50.056), Vector(-28.579, 11.174, -23.800), Vector(-45.897,
				11.174, 0.270), Vector(-66.491, 13.115, -24.307), Vector(-78.414, 11.105, -48.054), Vector(-82.830, 13.200, -16.052), Vector(
				-57.836, 13.140, -12.061), Vector(-28.484, 11.174, -23.930), Vector(-11.132, 11.174, -52.970), Vector(11.899, 11.174,
				-60.423));
		Else If(Current Map == Map(New Queen Street));
			"CHECKPOINT POSITIONS FOR: NEW QUEEN STREET"
			Global.VAR_GLB_ARRAY_CHECKPOINT_TABLE = Array(Vector(-9, 2.109, -18.010), Vector(0.016, 1.550, 12.186), Vector(9.925, 2.155,
				-11.056), Vector(20.465, 3.082, -36.721), Vector(27.549, 5.250, 2.193), Vector(15.914, 5.250, 25.313), Vector(-16.135, 5.250,
				24.906), Vector(-26.954, 5.250, -0.132), Vector(-24.238, 3.095, -36.543));
		Else If(Current Map == Map(Colosseo));
			"CHECKPOINT POSITIONS FOR: COLOSSEO"
			Global.VAR_GLB_ARRAY_CHECKPOINT_TABLE = Array(Vector(36.447, 3.050, -9.724), Vector(31.888, 5.050, -35.563), Vector(26.156, 8.700,
				-7.337), Vector(-0.034, 1.951, 12.180), Vector(-32.790, 3.233, 11.930), Vector(-31.699, 5.050, -35.882), Vector(-26.201, 8.700,
				-6.967), Vector(-0.021, 1.960, 12.234), Vector(33.077, 3.233, 12.498));
		Else If(Current Map == Map(King's Row));
			"CHECKPOINT POSITIONS FOR: KING'S ROW"
			Global.VAR_GLB_ARRAY_CHECKPOINT_TABLE = Array(Vector(-15.788, 1.184, 14.145), Vector(3.356, 1.105, -24.036), Vector(-36.722, 1.159,
				-25.112), Vector(-80.050, 1.525, -22.910), Vector(-90.422, 2.191, -0.662), Vector(-72.238, 1.109, -14.149), Vector(-36.722,
				1.159, -25.112), Vector(3.356, 1.105, -24.036), Vector(-26.864, 1.170, -2.941));
		Else If(Current Map == Map(Blizzard World));
			"CHECKPOINT POSITIONS FOR: BLIZZARD WORLD"
			Global.VAR_GLB_ARRAY_CHECKPOINT_TABLE = Array(Vector(-49.177, 0.856, 78.530), Vector(-61.145, 0.855, 100.201), Vector(-41.246,
				1.198, 86.826), Vector(-12.571, 3.176, 89.055), Vector(13.546, 3.088, 66.801), Vector(7.505, 1.150, 10.971), Vector(2.987,
				-2.850, -12.546), Vector(-2.895, 1.150, 10.156), Vector(-7.251, 3.090, 65.809));
		Else If(Current Map == Map(Busan));
			"CHECKPOINT POSITIONS FOR: BUSAN"
			Global.VAR_GLB_ARRAY_CHECKPOINT_TABLE = Array(Vector(108.089, 17.485, -121.004), Vector(77.591, 14.484, -117.054), Vector(51.910,
				7.257, -94.019), Vector(26.465, 14.485, -117.185), Vector(-4.332, 17.185, -120.854), Vector(26.465, 14.485, -117.185), Vector(
				51.892, 7.557, -93.985), Vector(77.871, 14.485, -116.979));
		Else If(Current Map == Map(Black Forest));
			"CHECKPOINT POSITIONS FOR: BLACK FOREST"
			Global.VAR_GLB_ARRAY_CHECKPOINT_TABLE = Array(Vector(-23.716, 13.342, 7.002), Vector(-9.664, 14.361, -8.876), Vector(20.915,
				12.603, -15.076), Vector(20.779, 12.575, 24.406), Vector(-8.668, 14.260, 17.957));
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

rule("RACE MODE MECHANICS: PREPARE RACE (GLOBALS)")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		"FOR INDEXES REFER TO: MENU \\ ARRAY TABLE - INTERNAL STORAGE VARIABLE \n [7] - CURRENT MODE:"
		Global.VAR_GBL_INTRNL_STORED_VALUES[7] != 0;
		Global.VAR_GLB_VEHICLE_DEPLOY_STATUS == Custom String("DEPLOYED");
		Global.VAR_GLB_RACE_STATUS == Custom String("RACE_READY");
	}

	actions
	{
		Global.VAR_DRIVEABLE_VEHICLE_HUD = Null;
		Global.VAR_GPL_RACE_START_CLOCKS = False;
		Global.VAR_GPL_RACE_CURR_COUNTDOWN = 3;
	}
}

rule("RACE MODE MECHANICS: PREPARE RACE (PLAYERS)")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		"FOR INDEXES REFER TO: MENU \\ ARRAY TABLE - INTERNAL STORAGE VARIABLE \n [7] - CURRENT MODE:"
		Global.VAR_GBL_INTRNL_STORED_VALUES[7] != 0;
		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == True;
		Global.VAR_GLB_VEHICLE_DEPLOY_STATUS == Custom String("DEPLOYED");
		Global.VAR_GLB_RACE_STATUS == Custom String("RACE_READY");
	}

	actions
	{
		Event Player.VAR_RACER_INPUT_ENABLED = False;
		"FOR INDEXES REFER TO: MENU \\ ARRAY TABLE - INTERNAL STORAGE VARIABLE \n [5] - STARTING NITROUS PERCENT: 50"
		Event Player.VAR_NITROUS_CURR_VAL_TANK = Global.VAR_GBL_INTRNL_STORED_VALUES[5];
		Event Player.VAR_GPL_MODE_CURRENT_LAP = 0;
		Event Player.VAR_GPL_MODE_CP_CURRENT = 0;
		Event Player.VAR_VSL_TXT_CLK_CLK_MINUTES = Custom String("--");
		Event Player.VAR_VSL_TXT_CLK_CLK_SECONDS = Custom String("--");
		Event Player.VAR_VSL_TXT_CLK_LAP_MINUTES = Custom String("--");
		Event Player.VAR_VSL_TXT_CLK_LAP_SECONDS = Custom String("--");
		Event Player.VAR_VSL_TXT_CLK_LST_MINUTES = Custom String("--");
		Event Player.VAR_VSL_TXT_CLK_LST_SECONDS = Custom String("--");
		Event Player.VAR_VSL_TXT_CLK_BST_MINUTES = Custom String("--");
		Event Player.VAR_VSL_TXT_CLK_BST_SECONDS = Custom String("--");
		Event Player.VAR_VSL_HUD_TGT_SCORE_TRIGGER = False;
		Event Player.VAR_STUNTS_SCORE = 0;
		Event Player.VAR_GPL_MODE_CP_TYPE = Custom String("CHECKPOINT_RACE_LINE");
		Event Player.VAR_GPL_MODE_CP_CURR_COLOR = Color(Green);
		"FOR INDEXES REFER TO: MENU \\ ARRAY TABLE - INTERNAL STORAGE VARIABLE \n [13] - REMAINING TIME AT THE START:"
		Event Player.VAR_VAL_DT_MODE_CHASE_TIME = Global.VAR_GBL_INTRNL_STORED_VALUES[13];
		Wait(1, Ignore Condition);
		Global.VAR_GLB_RACE_STATUS = Custom String("RACE_STARTING");
	}
}

rule("RACE MODE MECHANICS: START THE RACE (COUNTDOWN)")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		"FOR INDEXES REFER TO: MENU \\ ARRAY TABLE - INTERNAL STORAGE VARIABLE \n [7] - CURRENT MODE:"
		Global.VAR_GBL_INTRNL_STORED_VALUES[7] != 0;
		Global.VAR_GLB_RACE_STATUS == Custom String("RACE_STARTING");
	}

	actions
	{
		Global.VAR_GPL_RACE_VSL_COUNTDOWN_A = 255;
		If(Global.VAR_GPL_RACE_CURR_COUNTDOWN != 0);
			Play Effect(All Players(All Teams), Echo Sticky Bomb Explosion Sound, Color(White), All Players(All Teams), 200);
			Wait(1, Ignore Condition);
			Global.VAR_GPL_RACE_CURR_COUNTDOWN -= 1;
			Loop;
		End;
		Play Effect(All Players(All Teams), Pharah Concussive Blast Sound, Color(White), All Players(All Teams), 200);
		Global.VAR_GLB_RACE_STATUS = Custom String("RACE_ON");
	}
}

rule("RACE MODE MECHANICS: START THE RACE (PLAYERS)")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		"FOR INDEXES REFER TO: MENU \\ ARRAY TABLE - INTERNAL STORAGE VARIABLE \n [7] - CURRENT MODE:"
		Global.VAR_GBL_INTRNL_STORED_VALUES[7] != 0;
		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == True;
		Global.VAR_GLB_RACE_STATUS == Custom String("RACE_ON");
	}

	actions
	{
		"FOR INDEXES REFER TO: MENU \\ ARRAY TABLE - INTERNAL STORAGE VARIABLE \n [7] - CURRENT MODE:"
		If(Global.VAR_GBL_INTRNL_STORED_VALUES[7] == 2);
			Event Player.VAR_VSL_TXT_DT_TMR_DEST = 5;
			"FOR INDEXES REFER TO: MENU \\ ARRAY TABLE - INTERNAL STORAGE VARIABLE \n [5] - STARTING NITROUS PERCENT: 50"
			Event Player.VAR_NITROUS_CURR_VAL_TANK = Global.VAR_GBL_INTRNL_STORED_VALUES[5];
		End;
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [6] - ENGINE STATUS - ENABLED WHEN RACE STARTS"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[6] = 1;
		Event Player.VAR_RACER_INPUT_ENABLED = True;
		Event Player.VAR_VSL_TXT_CLK_CLK_MINUTES = 0;
	}
}

rule("RACE MODE MECHANICS: CREATE CHECKPOINT SPHERE AND ICON FOR RACER")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		"FOR INDEXES REFER TO: MENU \\ ARRAY TABLE - INTERNAL STORAGE VARIABLE \n [7] - CURRENT MODE:"
		Global.VAR_GBL_INTRNL_STORED_VALUES[7] != 0;
		Global.VAR_GLB_VEHICLE_DEPLOY_STATUS == Custom String("DEPLOY_CAR");
	}

	actions
	{
		"FOR INDEXES REFER TO: MENU \\ ARRAY TABLE - INTERNAL STORAGE VARIABLE \n [12] - CHECKPOINT RADIUS: "
		Create Effect(Global.VAR_PLAYER_RACER.VAR_RACER_HUD, Sphere, Global.VAR_PLAYER_RACER.VAR_GPL_MODE_CP_CURR_COLOR,
			Global.VAR_GLB_ARRAY_CHECKPOINT_TABLE[Global.VAR_PLAYER_RACER.VAR_GPL_MODE_CP_CURRENT],
			Global.VAR_GBL_INTRNL_STORED_VALUES[12], Visible To Position Radius and Color);
		Create Icon(Global.VAR_PLAYER_RACER.VAR_RACER_HUD,
			Global.VAR_GLB_ARRAY_CHECKPOINT_TABLE[Global.VAR_PLAYER_RACER.VAR_GPL_MODE_CP_CURRENT], Flag, Visible To Position and Color,
			Global.VAR_PLAYER_RACER.VAR_GPL_MODE_CP_CURR_COLOR, True);
	}
}

rule("RACE MODE MECHANICS: RACER REACHED CHECKPOINT")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Global.VAR_GLB_RACE_STATUS == Custom String("RACE_ON");
		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == True;
		"FOR INDEXES REFER TO: MENU \\ ARRAY TABLE - INTERNAL STORAGE VARIABLE \n [12] - CHECKPOINT RADIUS: "
		Distance Between(Event Player.VAR_RACER_VEHICLE, Global.VAR_GLB_ARRAY_CHECKPOINT_TABLE[Event Player.VAR_GPL_MODE_CP_CURRENT])
			<= Global.VAR_GBL_INTRNL_STORED_VALUES[12];
	}

	actions
	{
		If(Event Player.VAR_GPL_MODE_CP_TYPE == Custom String("CHECKPOINT_RACE_LINE"));
			Event Player.VAR_GPL_MODE_CURRENT_LAP += 1;
			"FOR INDEXES REFER TO: MENU \\ ARRAY TABLE - INTERNAL STORAGE VARIABLE \n [7] - CURRENT MODE:"
			If(Global.VAR_GBL_INTRNL_STORED_VALUES[7] == 2);
				If(Event Player.VAR_GPL_MODE_CURRENT_LAP == 1);
					Chase Player Variable At Rate(Event Player, VAR_VAL_DT_MODE_CHASE_TIME, Event Player.VAR_VSL_TXT_DT_TMR_DEST, 1,
						Destination and Rate);
				End;
			End;
			If(Event Player.VAR_GPL_MODE_CURRENT_LAP > 1);
				Event Player.VAR_VSL_TXT_CLK_LST_MINUTES = Event Player.VAR_VSL_TXT_CLK_LAP_MINUTES;
				Event Player.VAR_VSL_TXT_CLK_LST_SECONDS = Event Player.VAR_VSL_TXT_CLK_LAP_SECONDS;
				Event Player.VAR_VSL_TXT_CLK_TIME_TRIGGER = True;
			End;
			If(Event Player.VAR_GPL_MODE_CURRENT_LAP == 1);
				Global.VAR_GPL_RACE_START_CLOCKS = True;
			End;
			Event Player.VAR_VSL_TXT_CLK_LAP_MINUTES = 0;
			Event Player.VAR_VSL_TXT_CLK_LAP_SECONDS = 0;
			Event Player.VAR_GPL_MODE_CP_TYPE = Custom String("CHECKPOINT_REGULAR");
			Event Player.VAR_GPL_MODE_CP_CURR_COLOR = Color(Orange);
		End;
		Call Subroutine(SUB_GPL_MODE_CHECKPOINT_REACHED);
		Call Subroutine(SUB_GPL_MODE_CHECKPOINT_RESPAWN);
	}
}

rule("RACE MODE MECHANICS SUBROUTINE: CHECKPOINT REACHED")
{
	event
	{
		Subroutine;
		SUB_GPL_MODE_CHECKPOINT_REACHED;
	}

	actions
	{
		"FOR INDEXES REFER TO: MENU \\ ARRAY TABLE - INTERNAL STORAGE VARIABLE \n [9] - IS REVERSED?: (NORMAL DIRECTION)"
		If(Global.VAR_GBL_INTRNL_STORED_VALUES[9] == False);
			Event Player.VAR_GPL_MODE_CP_CURRENT += 1;
			"FINAL REGULAR CHECKPOINT REACHED"
			If(Event Player.VAR_GPL_MODE_CP_CURRENT == Count Of(Global.VAR_GLB_ARRAY_CHECKPOINT_TABLE));
				Call Subroutine(SUB_GPL_MODE_CHECKPOINT_RESET);
			End;
		"FOR INDEXES REFER TO: MENU \\ ARRAY TABLE - INTERNAL STORAGE VARIABLE \n [9] - IS REVERSED?: (REVERSED DIRECTION)"
		Else;
			Event Player.VAR_GPL_MODE_CP_CURRENT -= 1;
			If(Event Player.VAR_GPL_MODE_CP_CURRENT == -1);
				Event Player.VAR_GPL_MODE_CP_CURRENT = Count Of(Global.VAR_GLB_ARRAY_CHECKPOINT_TABLE);
				Event Player.VAR_GPL_MODE_CP_CURRENT -= 1;
			"FINAL REGULAR CHECKPOINT REACHED"
			Else If(Event Player.VAR_GPL_MODE_CP_CURRENT == 0);
				Call Subroutine(SUB_GPL_MODE_CHECKPOINT_RESET);
			End;
		End;
	}
}

rule("RACE MODE MECHANICS SUBROUTINE: RESPAWN SAVED")
{
	event
	{
		Subroutine;
		SUB_GPL_MODE_CHECKPOINT_RESPAWN;
	}

	actions
	{
		Play Effect(Global.VAR_PLAYER_RACER, Brigitte Repair Pack Impact Sound, Color(White), Position Of(Global.VAR_PLAYER_RACER), 200);
		"FOR INDEXES REFER TO: MENU \\ ARRAY TABLE - INTERNAL STORAGE VARIABLE \n [7] - CURRENT MODE:"
		If(Global.VAR_GBL_INTRNL_STORED_VALUES[7] != 2);
			Global.VAR_PLAYER_RACER.VAR_RACER_VEHICLE_RES_POS = Position Of(Global.VAR_PLAYER_RACER);
			Global.VAR_PLAYER_RACER.VAR_RACER_VEHICLE_RES_FACE = Horizontal Facing Angle Of(Global.VAR_PLAYER_RACER);
			Global.VAR_PLAYER_RACER.VAR_RACER_VEHICLE_RES_NITROUS = Global.VAR_PLAYER_RACER.VAR_NITROUS_CURR_VAL_TANK;
		Else;
			If(Event Player.VAR_GPL_MODE_CURRENT_LAP != 0);
				"FOR INDEXES REFER TO: MENU \\ ARRAY TABLE - INTERNAL STORAGE VARIABLE \n [14] - TIME EARNED VIA CHECKPOINT:"
				Event Player.VAR_VAL_DT_MODE_CHASE_TIME += Global.VAR_GBL_INTRNL_STORED_VALUES[14];
				Event Player.VAR_VSL_TXT_DT_TMR_CHASED_R = 0;
				Event Player.VAR_VSL_TXT_DT_TMR_CHASED_B = 0;
			End;
		End;
	}
}

rule("RACE MODE MECHANICS SUBROUTINE: RESET FINAL CHECKPOINT TO START")
{
	event
	{
		Subroutine;
		SUB_GPL_MODE_CHECKPOINT_RESET;
	}

	actions
	{
		Event Player.VAR_GPL_MODE_CP_TYPE = Custom String("CHECKPOINT_RACE_LINE");
		Event Player.VAR_GPL_MODE_CP_CURR_COLOR = Color(Green);
		Event Player.VAR_GPL_MODE_CP_CURRENT = 0;
	}
}

rule("RACE MODE MECHANICS: NOTIFY PLAYER OF LAST LAP")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		"FOR INDEXES REFER TO: MENU \\ ARRAY TABLE - INTERNAL STORAGE VARIABLE \n [7] - CURRENT MODE:"
		Global.VAR_GBL_INTRNL_STORED_VALUES[7] > 0;
		Global.VAR_GLB_RACE_STATUS == Custom String("RACE_ON");
		"FOR INDEXES REFER TO: MENU \\ ARRAY TABLE - INTERNAL STORAGE VARIABLE \n [8] - NUMBER OF LAPS:"
		Event Player.VAR_GPL_MODE_CURRENT_LAP == Global.VAR_GBL_INTRNL_STORED_VALUES[8];
	}

	actions
	{
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ GLOBAL \\ ARRAY TABLE - IN-GAME STRINGS \n [16] - FINAL LAP!"
		Big Message(Event Player, Global.VAR_GLB_ARRAY_STRING_IN_GAME[16]);
	}
}

rule("RACE MODE MECHANICS: PLAYER FINISHED THE RACE")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		"FOR INDEXES REFER TO: MENU \\ ARRAY TABLE - INTERNAL STORAGE VARIABLE \n [7] - CURRENT MODE:"
		Global.VAR_GBL_INTRNL_STORED_VALUES[7] > 0;
		Global.VAR_GLB_RACE_STATUS == Custom String("RACE_ON");
		"FOR INDEXES REFER TO: MENU \\ ARRAY TABLE - INTERNAL STORAGE VARIABLE \n [8] - NUMBER OF LAPS:"
		Event Player.VAR_GPL_MODE_CURRENT_LAP > Global.VAR_GBL_INTRNL_STORED_VALUES[8];
	}

	actions
	{
		Global.VAR_GLB_RACE_STATUS = Custom String("RACE_FINISHED");
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [6] - ENGINE STATUS"
		Global.VAR_PLAYER_RACER.VAR_ARRAY_CAR_NAVIGATION[6] = 0;
		Call Subroutine(SUB_VEH_ENGINE_OFF);
		Global.VAR_PLAYER_RACER.VAR_VSL_STUNT_DRIFT_TRIGGER = False;
		Global.VAR_PLAYER_RACER.VAR_VSL_STUNT_AIR_TRIGGER = False;
		"FOR INDEXES REFER TO: MENU \\ ARRAY TABLE - INTERNAL STORAGE VARIABLE \n [10] - SCORE CONDITION: ON"
		If(Global.VAR_GBL_INTRNL_STORED_VALUES[10] == 1);
			If(Event Player.VAR_VSL_HUD_TGT_SCORE_TRIGGER != True);
				"FOR INDEXES REFER TO: GAME IN PROGRESS \\ GLOBAL \\ ARRAY TABLE - IN-GAME STRINGS \n [23] - TARGET SCORE NOT REACHED!"
				Small Message(Event Player, Custom String("  {0} {1}", Icon String(X), Global.VAR_GLB_ARRAY_STRING_IN_GAME[23]));
			End;
		End;
		Stop Chasing Player Variable(Event Player, VAR_VSL_TXT_CLK_CLK_SECONDS);
		Stop Chasing Player Variable(Event Player, VAR_VSL_TXT_CLK_LAP_SECONDS);
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ GLOBAL \\ ARRAY TABLE - IN-GAME STRINGS \n [17] - FINISH!"
		Big Message(Event Player, Global.VAR_GLB_ARRAY_STRING_IN_GAME[17]);
		"FOR INDEXES REFER TO: MENU \\ ARRAY TABLE - INTERNAL STORAGE VARIABLE \n [8] - NUMBER OF LAPS:"
		Event Player.VAR_GPL_MODE_CURRENT_LAP = Global.VAR_GBL_INTRNL_STORED_VALUES[8];
		Stop Chasing Player Variable(Event Player, VAR_VAL_DT_MODE_CHASE_TIME);
		Wait(2, Ignore Condition);
		Declare Player Victory(Event Player);
		Declare Team Victory(Team Of(Event Player));
	}
}

disabled rule("DYNAMITE MODE MECHANICS")
{
	event
	{
		Ongoing - Global;
	}
}

rule("DYNAMITE MODE MECHANICS: START CUEING PLAYER THEIR TIME IS RUNNING OUT")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		"FOR INDEXES REFER TO: MENU \\ ARRAY TABLE - INTERNAL STORAGE VARIABLE \n [7] - CURRENT MODE:"
		Global.VAR_GBL_INTRNL_STORED_VALUES[7] == 2;
		Event Player.VAR_VSL_TXT_DT_TMR_TRIGGER == False;
		Event Player.VAR_VAL_DT_MODE_CHASE_TIME == 5;
	}

	actions
	{
		Event Player.VAR_VSL_TXT_DT_TMR_TRIGGER = True;
		Event Player.VAR_VSL_TXT_DT_TMR_DEST = 0;
		Event Player.VAR_VSL_TXT_DT_TMR_WAIT_VALUE = 1;
	}
}

rule("DYNAMITE MODE MECHANICS: CUE PLAYER THEIR TIME IS RUNNING OUT")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		"FOR INDEXES REFER TO: MENU \\ ARRAY TABLE - INTERNAL STORAGE VARIABLE \n [7] - CURRENT MODE:"
		Global.VAR_GBL_INTRNL_STORED_VALUES[7] == 2;
		"CURRENTLY CAUSES CRASH WHEN ENTIRELY ENABLED - OCCURS WHEN RESPAWNING"
		Event Player.VAR_VSL_TXT_DT_TMR_TRIGGER == True;
	}

	actions
	{
		Event Player.VAR_VSL_TXT_DT_TMR_CHASED_Z = Event Player.VAR_VSL_TXT_ALL_BOUNCE_Z;
		Play Effect(Event Player, Debuff Impact Sound, Color(White), Event Player, 200);
		Event Player.VAR_VSL_TXT_DT_TMR_CHASED_R = 255;
		Event Player.VAR_VSL_TXT_DT_TMR_CHASED_G = 0;
		Event Player.VAR_VSL_TXT_DT_TMR_CHASED_B = 0;
		Wait(Event Player.VAR_VSL_TXT_DT_TMR_WAIT_VALUE, Abort When False);
		Loop If Condition Is True;
	}
}

rule("DYNAMITE MODE MECHANICS: STOP CUEING PLAYER THEIR TIME IS RUNNING OUT")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		"FOR INDEXES REFER TO: MENU \\ ARRAY TABLE - INTERNAL STORAGE VARIABLE \n [7] - CURRENT MODE:"
		Global.VAR_GBL_INTRNL_STORED_VALUES[7] == 2;
		Event Player.VAR_VSL_TXT_DT_TMR_TRIGGER == True;
		Event Player.VAR_VAL_DT_MODE_CHASE_TIME > 5;
	}

	actions
	{
		Event Player.VAR_VSL_TXT_DT_TMR_TRIGGER = False;
		Event Player.VAR_VSL_TXT_DT_TMR_DEST = 5;
	}
}

rule("DYNAMITE MODE MECHANICS: DESTROY PLAYER VEHICLE WHEN THEIR TIME RUNS OUT")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		"FOR INDEXES REFER TO: MENU \\ ARRAY TABLE - INTERNAL STORAGE VARIABLE \n [7] - CURRENT MODE:"
		Global.VAR_GBL_INTRNL_STORED_VALUES[7] == 2;
		Event Player.VAR_VSL_TXT_DT_TMR_TRIGGER == True;
		Event Player.VAR_VAL_DT_MODE_CHASE_TIME == 0;
	}

	actions
	{
		Stop Chasing Player Variable(Event Player, VAR_VSL_TXT_CLK_CLK_SECONDS);
		Stop Chasing Player Variable(Event Player, VAR_VSL_TXT_CLK_LAP_SECONDS);
		Event Player.VAR_VSL_TXT_DT_TMR_TRIGGER = False;
		Play Effect(All Players(All Teams), Good Explosion, Color(Orange), Event Player.VAR_RACER_VEHICLE, 10);
		Play Effect(Event Player, Junkrat RIP Tire Explosion Sound, Color(White), Event Player, 200);
		Kill(Event Player.VAR_RACER_VEHICLE, Null);
	}
}

disabled rule("CLOCK VISUALS MECHANICS")
{
	event
	{
		Ongoing - Global;
	}
}

rule("CLOCK VISUALS MECHANICS: START CLK AND LAP CLOCKS")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Global.VAR_GPL_RACE_START_CLOCKS == True;
	}

	actions
	{
		Chase Player Variable At Rate(Event Player, VAR_VSL_TXT_CLK_CLK_SECONDS, 60, 1, Destination and Rate);
		Chase Player Variable At Rate(Event Player, VAR_VSL_TXT_CLK_LAP_SECONDS, 60, 1, Destination and Rate);
	}
}

rule("CLOCK VISUALS MECHANICS: CLK - ADD 1 MINUTE AND RESET THE SECONDS TO 0")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Global.VAR_GPL_RACE_START_CLOCKS == True;
		Event Player.VAR_VSL_TXT_CLK_CLK_SECONDS == 60;
	}

	actions
	{
		Event Player.VAR_VSL_TXT_CLK_CLK_SECONDS = 0;
		Event Player.VAR_VSL_TXT_CLK_CLK_MINUTES += 1;
	}
}

rule("CLOCK VISUALS MECHANICS: LAP - ADD 1 MINUTE AND RESET THE SECONDS TO 0")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Global.VAR_GPL_RACE_START_CLOCKS == True;
		Event Player.VAR_VSL_TXT_CLK_LAP_SECONDS == 60;
	}

	actions
	{
		Event Player.VAR_VSL_TXT_CLK_LAP_SECONDS = 0;
		Event Player.VAR_VSL_TXT_CLK_LAP_MINUTES += 1;
	}
}

rule("CLOCK VISUALS MECHANICS: BST - SET NEW BEST RECORD")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Global.VAR_GPL_RACE_START_CLOCKS == True;
		Event Player.VAR_VSL_TXT_CLK_TIME_TRIGGER == True;
		Event Player.VAR_GPL_MODE_CURRENT_LAP > 1;
	}

	actions
	{
		If(Event Player.VAR_VSL_TXT_CLK_LST_MINUTES <= Event Player.VAR_VSL_TXT_CLK_BST_MINUTES);
			If(Event Player.VAR_VSL_TXT_CLK_LST_SECONDS <= Event Player.VAR_VSL_TXT_CLK_BST_SECONDS);
				Event Player.VAR_VSL_TXT_CLK_BST_SECONDS = Event Player.VAR_VSL_TXT_CLK_LST_SECONDS;
				Event Player.VAR_VSL_TXT_CLK_BST_MINUTES = Event Player.VAR_VSL_TXT_CLK_LST_MINUTES;
				Event Player.VAR_VSL_HUD_CLK_BST_COLOR_BLINK = 3;
				Call Subroutine(SUB_GPL_VSL_BST_CLOCK_BLINK);
			End;
		End;
		Event Player.VAR_VSL_TXT_CLK_TIME_TRIGGER = False;
	}
}

rule("CLOCK VISUALS MECHANICS SUBROUTINE: BLINK BST CLOCK WHEN NEW LAP RECORD IS SET")
{
	event
	{
		Subroutine;
		SUB_GPL_VSL_BST_CLOCK_BLINK;
	}

	actions
	{
		Event Player.VAR_VSL_HUD_CLK_BST_COLOR_BLINK -= 1;
		Wait(0.500, Ignore Condition);
		Event Player.VAR_VSL_HUD_CLK_BST_COLOR = Color(Black);
		Wait(0.500, Ignore Condition);
		Event Player.VAR_VSL_HUD_CLK_BST_COLOR = Color(White);
		Loop If(Event Player.VAR_VSL_HUD_CLK_BST_COLOR_BLINK != 0);
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

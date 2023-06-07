settings
{
	main
	{
		Description: "Project: Streetwatch by GraczCourier (now known as RaidVentador_Courier_13) \n OPEN HORIZONS UPDATE \n (B9P3A - SPORTS CARS PACK) \n \n Gamemode Homepage: \n https://workshop.codes/4XQP4 \n Support the Creator via Ko-Fi:\n https://ko-fi.com/raidventador_courier_13 \n \n Special Thanks to:\n Deltin and Lotto for help and contribution"
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
		Kinetic Explosion Effects
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
		50: VAR_VEH_MESH_VRTCS_DRIFT_POINTS
		51: VAR_VEH_MESH_EDGES_FRONT_BUMPER
		52: VAR_VEH_MESH_EDGES_FRONT_HOOD
		53: VAR_VEH_MESH_EDGES_BODY
		54: VAR_VEH_MESH_EDGES_ENGINE_HOOD
		55: VAR_VEH_MESH_EDGES_REAR_BUMPER
		56: VAR_VEH_MESH_EDGES_HEADLIGHTS
		57: VAR_VEH_MESH_EDGES_L_R_LIGHTS
		58: VAR_VEH_MESH_EDGES_R_R_LIGHTS
		59: VAR_VEH_MESH_EDGES_NITROUS
		60: VAR_VEH_MESH_EDGES_CARBON_PARTS
		61: VAR_VEH_MESH_Effects
		62: VAR_VEH_MESH_Scale
		63: VAR_VEH_MESH_i
		64: VAR_VEH_MESH_ActualLine
		65: A_PIECE_OF_ASPHALT_THAT_I_FOUND
		66: VAR_VEH_CUSTOM_CAR_BODY_COLORS
		67: VAR_VEH_CUSTOM_CAR_LIGHT_COLORS
		68: VAR_VEH_CAR_BODY
		69: VAR_GLB_RACE_HAS_REV_VARIANT
		70: VAR_GLB_RACE_HAS_TRACK
		71: VAR_GLB_PLAYER_IS_IN_MAIN_MENU
		72: VAR_GLB_VEHICLE_DEPLOY_STATUS
		73: VAR_GLB_ARRAY_STRING_IN_GAME
		74: VAR_GLB_ARRAY_STRING_AWARD_LVL
		75: VAR_GLB_ARRAY_STRING_STUNT
		76: VAR_GLB_ARRAY_STRING_CAMERA
		77: VAR_GLB_ARRAY_VAL_DRIFT_AWARD
		78: VAR_GLB_ARRAY_VAL_AIR_AWARD
		79: VAR_GLB_ARRAY_STUNT_MECHANICS
		80: VAR_GLB_ARRAY_CHECKPOINT_TABLE
		81: VAR_GLB_VEH_REG_START_POS
		82: VAR_GLB_VEH_REG_START_FACE
		83: VAR_GLB_VEH_REV_START_POS
		84: VAR_GLB_VEH_REV_START_FACE
		85: VAR_GLB_RACE_STATUS
		86: VAR_GPL_RACE_COUNTERS_STRINGS
		87: VAR_GPL_RACE_CURR_COUNTDOWN
		88: VAR_GPL_RACE_VSL_COUNTDOWN_A
		89: VAR_GPL_RACE_START_CLOCKS
		90: THE_RAVEN_CAN_ONLY_WATCH_OMENS
		91: VAR_TIP_TRIVIAS_HERE
		92: VAR_CRIT_ARRAY_CORE

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
		94: VAR_VEH_VSL_SMOKE_CURRENT
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
	41: SUB_VEH_VSL_DRIFT_SMOKE
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
			"BY RAIDVENTADOR_COURIER_13 AND DELTIN"), Custom String("B9P3A - SPORTS CARS PACK"), Custom String("VEHICLE CONTROLS"),
			Custom String("PLAY"), Custom String("SELECT CAR:"), Custom String("TUNE CAR"), Custom String("MODE SETTINGS"), Custom String(
			"EXIT TO LOBBY"), Custom String("EXIT TO MAIN MENU"), Custom String(
			">                                                                                 <"), Custom String("SETTINGS SAVED"),
			Custom String("SETTING REVERTED"), Custom String("THE CURRENT MAP HAS NO TRACK"), Custom String(
			"THE TRACK DOESN'T HAVE A REVERSE VARIANT"));
		Global.VAR_MENU_ARRAY_STRING_CONTROL = Array(Custom String("(HOLD)"), Custom String("(TAP)"), Custom String("(PRESS)"),
			Custom String("(HOLD/TAP)"), Custom String("- ENTER/EXIT THE VEHICLE"), Custom String("- NITROUS"), Custom String(
			"- HANDBRAKE"), Custom String("- SWITCH RADIO"), Custom String("- TOGGLE BLINKERS"), Custom String("- TURN ON/OFF CAR ENGINE"),
			Custom String("- SWITCH CAMERA"), Custom String("- RESPAWN (WHEN CRASHED)"), Custom String("PRESS"), Custom String("OR"),
			Custom String("TO EXIT TO MAIN MENU"), Custom String("MOVE LEFT"), Custom String("MOVE RIGHT"));
		"REFER TO \"VARIABLE_STRING_TABLES.TXT\" FILE"
		Global.VAR_MENU_ARRAY_STRING_CAR = Array(Custom String("2018 Porsche 911 GT3 RS"), Custom String("2017 HONDA CIVIC TYPE-R FK8"),
			Custom String("2013 Nissan GT-R NISMO"), Custom String("2002 Nissan Skyline GT-R (R34)"), Custom String(
			"1983 Toyota AE86 Trueno"));
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
		"Ready - Press \"Anything\" to Deploy"), Custom String("TIP/TRIVIA:"), Custom String("for next random Tip/Trivia"), Custom String(
		"Motorsports are dangerous. In real world, hoon responsibly,\n obey the laws of the road, and always wear your seatbelt."),
		Custom String("Don't be afraid to use the brakes if you're approaching a curve too fast."), Custom String(
		"The handbrake can help you initiate the drift."), Custom String(
		"You can initiate the Drift by quickly braking and then \n accelerating while turning simultaneously."), Custom String(
		"E-Drift is initiated by simply using the handbrake while turning."), Custom String(
		"When drifting, counter-steer or brake to recover grip."), Custom String(
		"Having trouble controlling the car?\n Go easy on the accelerator and remember to counter-steer."),
		Custom String("PROJECT: Streetwatch originally came to life on 21st January of 2021. \n A month later it was showcased on 2021 BlizzConline."),
		Custom String("The creator of the \"PROJECT: Streetwatch\" is from Poland. \n However, they prefer not to represent their country.")
			);
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

disabled rule("Cars / Sports Cars Pack")
{
	event
	{
		Ongoing - Global;
	}
}

rule("#1 2018 Porsche 911 GT3 RS (Mesh Array Tables)")
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
		"VERTICES COUNT: 300 \n EDGE COUNT: 245 \n Car models ported with Deltin's OSTW for Visual Studio Code"
		Global.VAR_VEH_MESH_VRTCS_FRONT_BUMPER = Array(Vector(0.641, 0.827, 2.575), Vector(1.103, 0.812, 2.347), Vector(1.240, 0.804,
			2.015), Vector(1.227, 0.673, 2.147), Vector(1.022, 0.614, 2.696), Vector(0.513, 0.587, 2.981), Vector(Empty Array, 0.578,
			3.056), Vector(1.097, 0.301, 2.574), Vector(1.084, 0.458, 2.605), Vector(0.785, 0.279, 2.763), Vector(0.918, 0.233, 2.759),
			Vector(0.501, 0.203, 3.011), Vector(0.540, 0.463, 2.969), Vector(0.644, 0.282, 2.885), Vector(Empty Array, 0.469, 3.047),
			Vector(0.642, 0.519, 2.867), Vector(0.596, 0.844, 2.555), Vector(0.758, 0.840, 2.481), Vector(-0.641, 0.827, 2.575), Vector(
			-1.103, 0.812, 2.347), Vector(-1.240, 0.804, 2.015), Vector(-1.227, 0.673, 2.147), Vector(-1.022, 0.614, 2.696), Vector(-0.513,
			0.587, 2.981), Vector(-1.097, 0.301, 2.574), Vector(-1.084, 0.458, 2.605), Vector(-0.918, 0.233, 2.759), Vector(-0.501, 0.203,
			3.011), Vector(-0.540, 0.463, 2.969), Vector(-0.644, 0.282, 2.885), Vector(-0.758, 0.840, 2.481), Vector(-0.596, 0.844, 2.555),
			Vector(0.416, 0.456, 2.981), Vector(0.489, 0.257, 2.912), Vector(-0.785, 0.279, 2.763), Vector(-0.416, 0.456, 2.981), Vector(
			-0.489, 0.257, 2.912), Vector(-0.642, 0.519, 2.867));
		Global.VAR_VEH_MESH_VRTCS_FRONT_HOOD = Array(Vector(Empty Array, 0.770, 2.793), Vector(0.231, 1.177, 1.378), Vector(0.218, 1.054,
			2.055), Vector(0.202, 0.899, 2.535), Vector(0.663, 1.073, 1.855), Vector(0.516, 0.895, 2.476), Vector(0.470, 1.073, 1.899),
			Vector(0.357, 0.828, 2.661), Vector(0.830, 1.107, 1.708), Vector(0.957, 1.139, 0.916), Vector(0.552, 0.812, 2.639), Vector(
			-0.231, 1.177, 1.378), Vector(-0.218, 1.054, 2.055), Vector(-0.202, 0.899, 2.535), Vector(-0.663, 1.073, 1.855), Vector(-0.516,
			0.895, 2.476), Vector(-0.357, 0.828, 2.661), Vector(-0.830, 1.107, 1.708), Vector(-0.552, 0.812, 2.639), Vector(-0.957, 1.139,
			0.916), Vector(-0.355, 0.781, 2.757), Vector(0.355, 0.781, 2.757), Vector(-0.470, 1.073, 1.899));
		Global.VAR_VEH_MESH_VRTCS_BODY = Array(Vector(1.269, 0.938, -1.439), Vector(1.269, 0.700, -1.171), Vector(1.213, 0.186, -1.145),
			Vector(1.269, 0.938, -1.642), Vector(0.724, 1.062, -2.740), Vector(0.932, 1.043, -2.588), Vector(0.770, 1.143, -2.472), Vector(
			1.151, 1.139, -1.249), Vector(1.166, 1.184, -1.624), Vector(1.098, 1.167, -2.067), Vector(1.130, 1.052, -0.757), Vector(0.977,
			1.194, -0.690), Vector(1.010, 1.139, 0.848), Vector(1.159, 0.995, 0.963), Vector(1.130, 0.343, 0.937), Vector(1.165, 0.271,
			1.113), Vector(1.148, 0.321, -0.509), Vector(1.255, 0.354, -1.107), Vector(1.169, 0.392, -0.349), Vector(1.159, 1.018, 1.458),
			Vector(0.853, 1.283, -1.588), Vector(0.768, 1.207, -2.294), Vector(0.624, 1.337, -2.097), Vector(0.694, 1.588, -1.172), Vector(
			0.736, 1.669, -0.478), Vector(0.806, 1.575, 0.207), Vector(1, 1.125, 1.715), Vector(0.949, 1.077, 2.072), Vector(1.227, 0.673,
			2.147), Vector(1.238, 0.963, 1.697), Vector(1.238, 0.685, 1.179), Vector(1.269, 0.938, -1.823), Vector(-1.269, 0.938, -1.439),
			Vector(-1.269, 0.700, -1.171), Vector(-1.213, 0.186, -1.145), Vector(-1.269, 0.938, -1.642), Vector(-0.724, 1.062, -2.740),
			Vector(-0.932, 1.043, -2.588), Vector(-0.770, 1.143, -2.472), Vector(-1.151, 1.139, -1.249), Vector(-1.166, 1.184, -1.624),
			Vector(-1.098, 1.167, -2.067), Vector(-1.130, 1.052, -0.757), Vector(-0.977, 1.194, -0.690), Vector(-1.010, 1.139, 0.848),
			Vector(-1.159, 0.995, 0.963), Vector(-1.130, 0.343, 0.937), Vector(-1.165, 0.271, 1.113), Vector(-1.148, 0.321, -0.509),
			Vector(-1.255, 0.354, -1.107), Vector(-1.169, 0.392, -0.349), Vector(-1.159, 1.018, 1.458), Vector(-0.853, 1.283, -1.588),
			Vector(-0.768, 1.207, -2.294), Vector(-0.624, 1.337, -2.097), Vector(-0.694, 1.588, -1.172), Vector(-0.736, 1.669, -0.478),
			Vector(-0.806, 1.575, 0.207), Vector(-1, 1.125, 1.715), Vector(-0.949, 1.077, 2.072), Vector(-1.227, 0.673, 2.147), Vector(
			-1.238, 0.963, 1.697), Vector(-1.238, 0.685, 1.179), Vector(-1.269, 0.938, -1.823), Vector(1.152, 0.186, 1.109), Vector(-1.152,
			0.186, 1.109));
		Global.VAR_VEH_MESH_VRTCS_ENGINE_HOOD = Array(Vector(-0.559, 1.203, -2.520), Vector(Empty Array, 1.074, -2.851), Vector(0.724,
			1.062, -2.740), Vector(0.730, 1.207, -2.812), Vector(Empty Array, 1.229, -2.912), Vector(0.770, 1.143, -2.472), Vector(0.559,
			1.203, -2.520), Vector(0.768, 1.207, -2.294), Vector(0.624, 1.337, -2.097), Vector(-0.724, 1.062, -2.740), Vector(-0.730,
			1.207, -2.812), Vector(-0.770, 1.143, -2.472), Vector(-0.768, 1.207, -2.294), Vector(-0.624, 1.337, -2.097), Vector(
			Empty Array, 1.230, -2.608), Vector(1.076, 1.516, -2.421), Vector(0.763, 1.574, -2.506), Vector(Empty Array, 1.585, -2.544),
			Vector(1.053, 1.572, -2.848), Vector(0.762, 1.573, -2.915), Vector(Empty Array, 1.576, -2.956), Vector(-1.076, 1.516, -2.421),
			Vector(-0.763, 1.574, -2.506), Vector(-1.053, 1.572, -2.848), Vector(-0.762, 1.573, -2.915));
		Global.VAR_VEH_MESH_VRTCS_REAR_BUMPER = Array(Vector(1.257, 0.700, -2.103), Vector(1.223, 0.301, -2.204), Vector(1.127, 0.431,
			-2.495), Vector(0.951, 0.415, -2.804), Vector(0.848, 0.502, -2.891), Vector(0.322, 0.517, -3.017), Vector(0.312, 0.565,
			-2.996), Vector(0.233, 0.787, -3.032), Vector(1.056, 0.730, -2.682), Vector(0.678, 0.746, -2.963), Vector(1.133, 0.999,
			-2.272), Vector(0.572, 1.065, -2.797), Vector(0.724, 1.062, -2.740), Vector(0.612, 0.962, -2.902), Vector(0.932, 1.043,
			-2.588), Vector(0.544, 0.869, -2.996), Vector(0.940, 0.860, -2.810), Vector(1.094, 0.846, -2.569), Vector(0.928, 0.935,
			-2.736), Vector(1.120, 0.943, -2.395), Vector(1.269, 0.938, -1.823), Vector(-1.257, 0.700, -2.103), Vector(-1.223, 0.301,
			-2.204), Vector(-1.127, 0.431, -2.495), Vector(-0.951, 0.415, -2.804), Vector(-0.848, 0.502, -2.891), Vector(-0.322, 0.517,
			-3.017), Vector(-0.312, 0.565, -2.996), Vector(-0.233, 0.787, -3.032), Vector(-1.056, 0.730, -2.682), Vector(-0.678, 0.746,
			-2.963), Vector(-1.133, 0.999, -2.272), Vector(-0.572, 1.065, -2.797), Vector(-0.724, 1.062, -2.740), Vector(-0.612, 0.962,
			-2.902), Vector(-0.932, 1.043, -2.588), Vector(-0.544, 0.869, -2.996), Vector(-0.940, 0.860, -2.810), Vector(-1.094, 0.846,
			-2.569), Vector(-0.928, 0.935, -2.736), Vector(-1.120, 0.943, -2.395), Vector(-1.269, 0.938, -1.823), Vector(1.185, 0.715,
			-2.340), Vector(-1.185, 0.715, -2.340));
		Global.VAR_VEH_MESH_VRTCS_HEADLIGHTS = Array(Vector(0.934, 1.053, 2.201), Vector(0.889, 0.782, 2.543), Vector(-0.934, 1.053,
			2.201), Vector(-0.889, 0.782, 2.543));
		Global.VAR_VEH_MESH_VRTCS_L_R_LIGHTS = Array(Vector(1.099, 0.978, -2.427), Vector(0.628, 1.016, -2.871));
		Global.VAR_VEH_MESH_VRTCS_R_R_LIGHTS = Array(Vector(-1.099, 0.978, -2.427), Vector(-0.628, 1.016, -2.871));
		Global.VAR_VEH_MESH_VRTCS_NITROUS = Array(Vector(0.081, 0.377, -3.035), Vector(-0.081, 0.377, -3.035));
		Global.VAR_VEH_MESH_VRTCS_CARBON_PARTS = Array(Vector(1.152, 0.186, 1.109), Vector(1.213, 0.186, -1.145), Vector(-1.152, 0.186,
			1.109), Vector(-1.213, 0.186, -1.145), Vector(1.223, 0.301, -2.204), Vector(1.018, 0.354, -2.772), Vector(0.876, 0.356,
			-2.895), Vector(0.245, 0.364, -3.035), Vector(0.164, 0.490, -3.035), Vector(0.724, 1.062, -2.740), Vector(0.730, 1.207,
			-2.812), Vector(0.770, 1.143, -2.472), Vector(0.762, 1.432, -2.648), Vector(0.755, 1.472, -2.828), Vector(0.762, 1.513,
			-2.610), Vector(0.755, 1.534, -2.799), Vector(1.038, 1.653, -2.881), Vector(1.064, 1.442, -2.759), Vector(1.090, 1.516,
			-2.387), Vector(1.075, 1.582, -2.460), Vector(1.010, 1.139, 0.848), Vector(0.624, 1.337, -2.097), Vector(0.806, 1.575, 0.207),
			Vector(0.226, 1.664, 0.253), Vector(0.213, 1.727, -0.476), Vector(0.212, 1.633, -1.175), Vector(0.619, 1.588, -1.188), Vector(
			1.227, 0.673, 2.147), Vector(0.627, 0.511, 2.906), Vector(0.983, 0.515, 2.727), Vector(1.035, 0.268, 2.656), Vector(0.479,
			0.167, 3.050), Vector(0.547, 0.140, 3.031), Vector(1.060, 0.150, 2.723), Vector(1.222, 0.152, 2.164), Vector(0.691, 1.139,
			1.153), Vector(0.231, 1.177, 1.378), Vector(0.359, 1.337, -2.180), Vector(1.090, 1.103, 0.568), Vector(1.334, 1.212, 0.322),
			Vector(-1.223, 0.301, -2.204), Vector(-1.018, 0.354, -2.772), Vector(-0.876, 0.356, -2.895), Vector(-0.245, 0.364, -3.035),
			Vector(-0.164, 0.490, -3.035), Vector(-0.724, 1.062, -2.740), Vector(-0.730, 1.207, -2.812), Vector(-0.770, 1.143, -2.472),
			Vector(-0.762, 1.432, -2.648), Vector(-0.755, 1.472, -2.828), Vector(-0.762, 1.513, -2.610), Vector(-0.755, 1.534, -2.799),
			Vector(-1.038, 1.653, -2.881), Vector(-1.064, 1.442, -2.759), Vector(-1.090, 1.516, -2.387), Vector(-1.075, 1.582, -2.460),
			Vector(-1.010, 1.139, 0.848), Vector(-0.624, 1.337, -2.097), Vector(-0.806, 1.575, 0.207), Vector(-0.226, 1.664, 0.253),
			Vector(-0.213, 1.727, -0.476), Vector(-0.212, 1.633, -1.175), Vector(-0.619, 1.588, -1.188), Vector(-1.227, 0.673, 2.147),
			Vector(-0.627, 0.511, 2.906), Vector(-0.983, 0.515, 2.727), Vector(-1.035, 0.268, 2.656), Vector(-0.479, 0.167, 3.050), Vector(
			-0.547, 0.140, 3.031), Vector(-1.060, 0.150, 2.723), Vector(-1.222, 0.152, 2.164), Vector(-0.691, 1.139, 1.153), Vector(-0.231,
			1.177, 1.378), Vector(-0.359, 1.337, -2.180), Vector(-1.090, 1.103, 0.568), Vector(-1.334, 1.212, 0.322), Vector(1.193, 1.018,
			1.539), Vector(-1.193, 0.707, 1.117), Vector(1.193, 0.707, 1.117), Vector(-1.193, 1.018, 1.539), Vector(1.124, 1.075, -1.198),
			Vector(1.160, 0.765, -0.856), Vector(-1.124, 1.075, -1.198), Vector(-1.160, 0.765, -0.856), Vector(0.977, 1.194, -0.690),
			Vector(0.853, 1.283, -1.588), Vector(0.783, 1.572, -0.826), Vector(-0.977, 1.194, -0.690), Vector(-0.853, 1.283, -1.588),
			Vector(-0.783, 1.572, -0.826));
		Global.VAR_VEH_MESH_VRTCS_DRIFT_POINTS = Array(Vector(1.269, 0.425, -1.642), Vector(1.238, 0.450, 1.697), Vector(-1.269, 0.425,
			-1.642), Vector(-1.238, 0.450, 1.697));
		Global.VAR_VEH_MESH_EDGES_FRONT_BUMPER = Array(1, 2, 9, 15, 4, 5, 5, 6, 3, 4, 7, 10, 10, 11, 12, 13, 4, 8, 8, 7, 5, 0, 16, 17, 14,
			12, 19, 20, 22, 23, 23, 6, 21, 22, 24, 26, 26, 27, 28, 29, 22, 25, 25, 24, 23, 18, 31, 30, 14, 28, 11, 27, 32, 33, 34, 37, 35,
			36);
		Global.VAR_VEH_MESH_EDGES_FRONT_HOOD = Array(1, 2, 2, 3, 4, 5, 6, 4, 7, 6, 9, 8, 21, 0, 11, 12, 12, 13, 14, 15, 19, 17, 17, 18, 8,
			10, 20, 0, 18, 20, 10, 21, 16, 22, 22, 14);
		Global.VAR_VEH_MESH_EDGES_BODY = Array(1, 0, 2, 1, 4, 6, 7, 8, 8, 9, 3, 8, 14, 18, 0, 31, 10, 11, 11, 12, 12, 13, 13, 14, 26, 29,
			15, 16, 16, 17, 10, 18, 13, 19, 10, 13, 11, 20, 20, 21, 22, 23, 24, 25, 12, 25, 23, 24, 12, 26, 26, 27, 28, 29, 29, 30, 5, 9,
			7, 10, 33, 32, 34, 33, 36, 38, 39, 40, 40, 41, 35, 40, 46, 50, 32, 63, 42, 43, 43, 44, 44, 45, 45, 46, 58, 61, 47, 48, 48, 49,
			42, 50, 45, 51, 42, 45, 43, 52, 52, 53, 54, 55, 56, 57, 44, 57, 55, 56, 44, 58, 58, 59, 60, 61, 61, 62, 37, 41, 39, 42, 15, 30,
			47, 62, 15, 64, 47, 65);
		Global.VAR_VEH_MESH_EDGES_ENGINE_HOOD = Array(2, 1, 3, 4, 5, 7, 7, 8, 9, 1, 10, 4, 11, 12, 12, 13, 6, 14, 8, 6, 13, 0, 14, 0, 15,
			16, 16, 17, 18, 19, 19, 20, 21, 22, 22, 17, 23, 24, 24, 20);
		Global.VAR_VEH_MESH_EDGES_REAR_BUMPER = Array(0, 1, 42, 2, 2, 3, 3, 4, 4, 5, 6, 7, 8, 9, 20, 10, 14, 12, 11, 13, 15, 16, 10, 14,
			16, 17, 34, 39, 19, 18, 20, 0, 21, 22, 43, 23, 23, 24, 24, 25, 25, 26, 27, 28, 29, 30, 41, 31, 35, 33, 32, 34, 36, 37, 31, 35,
			37, 38, 40, 39, 41, 21, 15, 36, 5, 26, 7, 28, 13, 18, 0, 8, 21, 29);
		Global.VAR_VEH_MESH_EDGES_HEADLIGHTS = Array(0, 1, 2, 3);
		Global.VAR_VEH_MESH_EDGES_L_R_LIGHTS = Array(0, 1);
		Global.VAR_VEH_MESH_EDGES_R_R_LIGHTS = Array(0, 1);
		Global.VAR_VEH_MESH_EDGES_NITROUS = Array(0, 1);
		Global.VAR_VEH_MESH_EDGES_CARBON_PARTS = Array(0, 1, 2, 3, 4, 5, 5, 6, 6, 7, 7, 8, 9, 10, 13, 12, 12, 14, 10, 13, 16, 17, 18, 19,
			16, 19, 35, 36, 22, 23, 23, 24, 25, 26, 28, 29, 29, 30, 31, 32, 32, 33, 27, 34, 24, 25, 12, 11, 13, 15, 21, 37, 17, 18, 38, 39,
			20, 35, 40, 41, 41, 42, 42, 43, 43, 44, 45, 46, 49, 48, 48, 50, 46, 49, 52, 53, 54, 55, 52, 55, 69, 70, 71, 72, 58, 59, 59, 60,
			61, 62, 64, 65, 65, 66, 67, 68, 68, 69, 63, 70, 33, 34, 60, 61, 48, 47, 49, 51, 57, 73, 53, 54, 74, 75, 56, 71, 8, 44, 25, 61,
			37, 73, 23, 59, 36, 72, 31, 67, 76, 78, 79, 77, 80, 81, 82, 83, 86, 85, 84, 86, 87, 89, 89, 88);
		"PASTE YOUR CAR HERE - Original Gamemode Creator: GraczCourier (now known as RaidVentador_Courier_13)"
		Global.VAR_PLAYER_RACER.VAR_VEH_COLOR_DEFAULT = Color(Green);
		Call Subroutine(SUB_VEH_VSL_GET_COLORS);
	}
}

rule("#2 2017 HONDA CIVIC TYPE-R FK8  (Mesh Array Tables)")
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
		"VERTICES COUNT: 289 \n EDGE COUNT: 240 \n Car models ported with Deltin's OSTW for Visual Studio Code"
		Global.VAR_VEH_MESH_VRTCS_FRONT_BUMPER = Array(Vector(0.387, 0.427, 2.684), Vector(1.123, 0.670, 2.039), Vector(1.094, 0.353,
			2.126), Vector(0.522, 0.294, 2.702), Vector(0.990, 0.810, 2.188), Vector(1.006, 0.307, 2.399), Vector(1.051, 0.383, 2.299),
			Vector(0.977, 0.668, 2.409), Vector(0.383, 0.500, 2.700), Vector(Empty Array, 0.871, 2.559), Vector(-0.393, 0.556, 2.699),
			Vector(0.556, 0.872, 2.484), Vector(-0.387, 0.427, 2.684), Vector(-1.123, 0.670, 2.039), Vector(-1.094, 0.353, 2.126), Vector(
			-0.522, 0.294, 2.702), Vector(-0.990, 0.810, 2.188), Vector(0.393, 0.556, 2.699), Vector(-1.006, 0.307, 2.399), Vector(-1.051,
			0.383, 2.299), Vector(-0.977, 0.668, 2.409), Vector(-0.383, 0.500, 2.700), Vector(-0.556, 0.872, 2.484));
		Global.VAR_VEH_MESH_VRTCS_FRONT_HOOD = Array(Vector(0.536, 0.927, 2.393), Vector(0.860, 1.057, 1.941), Vector(0.907, 1.138, 1.304),
			Vector(-0.837, 1.141, 1.211), Vector(0.600, 1.126, 1.415), Vector(0.661, 1.092, 1.651), Vector(0.578, 1.008, 2.137), Vector(
			-0.475, 1.128, 1.436), Vector(-0.991, 1.033, 1.438), Vector(-0.527, 0.899, 2.437), Vector(-0.860, 1.057, 1.941), Vector(
			Empty Array, 1.128, 1.494), Vector(-0.600, 1.126, 1.415), Vector(-0.661, 1.092, 1.651), Vector(-0.578, 1.008, 2.137), Vector(
			0.991, 1.033, 1.438), Vector(0.527, 0.899, 2.437), Vector(-0.536, 0.927, 2.393), Vector(0.475, 1.128, 1.436), Vector(-0.907,
			1.138, 1.304), Vector(-1.003, 0.925, 2.012), Vector(1.003, 0.925, 2.012), Vector(0.837, 1.141, 1.211));
		Global.VAR_VEH_MESH_VRTCS_BODY = Array(Vector(1.090, 0.418, -1.152), Vector(1.033, 0.374, -0.946), Vector(1.125, 0.867, -1.631),
			Vector(1.116, 0.766, -1.931), Vector(1.109, 0.754, -1.310), Vector(0.989, 1.130, -1.946), Vector(1.028, 1.132, -1.515), Vector(
			1.057, 1.012, -0.287), Vector(1.049, 0.905, 1.086), Vector(1.017, 0.987, 1.073), Vector(1.083, 0.712, 1.166), Vector(1.056,
			0.348, 1.053), Vector(1.018, 0.333, -0.297), Vector(0.694, 1.646, -0.419), Vector(0.964, 1.153, -0.311), Vector(0.907, 1.253,
			-1.420), Vector(1.094, 0.198, 1.135), Vector(1.127, 0.709, 1.257), Vector(1.124, 0.862, 1.638), Vector(1.123, 0.670, 2.039),
			Vector(1.052, 0.309, 0.990), Vector(0.961, 1.070, 1.031), Vector(0.915, 1.164, 0.999), Vector(0.695, 1.566, 0.284), Vector(
			1.041, 0.938, 1.130), Vector(0.716, 1.578, -1.231), Vector(0.885, 1.213, -2.074), Vector(-0.347, 1.573, 0.401), Vector(1.016,
			1.129, -1.654), Vector(0.837, 1.141, 1.211), Vector(-0.837, 1.141, 1.211), Vector(-1.090, 0.418, -1.152), Vector(-1.033, 0.374,
			-0.946), Vector(-1.125, 0.867, -1.631), Vector(-1.116, 0.766, -1.931), Vector(-1.109, 0.754, -1.310), Vector(-0.989, 1.130,
			-1.946), Vector(-1.028, 1.132, -1.515), Vector(-1.057, 1.012, -0.287), Vector(-1.049, 0.905, 1.086), Vector(-1.017, 0.987,
			1.073), Vector(-1.083, 0.712, 1.166), Vector(-1.056, 0.348, 1.053), Vector(-1.018, 0.333, -0.297), Vector(-0.694, 1.646,
			-0.419), Vector(-0.964, 1.153, -0.311), Vector(-0.907, 1.253, -1.420), Vector(-1.094, 0.198, 1.135), Vector(-1.127, 0.709,
			1.257), Vector(-1.124, 0.862, 1.638), Vector(-1.123, 0.670, 2.039), Vector(-1.052, 0.309, 0.990), Vector(-0.961, 1.070, 1.031),
			Vector(-0.915, 1.164, 0.999), Vector(-0.695, 1.566, 0.284), Vector(-1.041, 0.938, 1.130), Vector(-0.716, 1.578, -1.231),
			Vector(-0.885, 1.213, -2.074), Vector(-1.016, 1.129, -1.654), Vector(0.347, 1.573, 0.401), Vector(Empty Array, 1.695, -0.419),
			Vector(-1.035, 0.953, 1.648), Vector(1.035, 0.953, 1.648), Vector(-0.907, 1.138, 1.304), Vector(0.907, 1.138, 1.304), Vector(
			0.636, 1.662, -0.427), Vector(-0.636, 1.662, -0.427), Vector(0.511, 1.616, -1.447), Vector(-0.511, 1.616, -1.447), Vector(
			-0.996, 0.993, 1.653), Vector(0.996, 0.993, 1.653));
		Global.VAR_VEH_MESH_VRTCS_ENGINE_HOOD = Array(Vector(0.676, 1.511, -1.659), Vector(0.676, 0.962, -2.483), Vector(0.558, 0.927,
			-2.541), Vector(0.363, 1.035, -2.560), Vector(0.632, 1.255, -2.419), Vector(0.490, 1.152, -2.511), Vector(0.621, 1.545,
			-1.556), Vector(0.479, 1.594, -1.706), Vector(0.702, 1.384, -2.029), Vector(0.765, 1.432, -2.172), Vector(0.746, 1.421,
			-2.384), Vector(0.690, 1.305, -2.261), Vector(0.726, 1.515, -2.220), Vector(0.689, 1.554, -2.539), Vector(0.843, 1.325,
			-1.968), Vector(0.892, 1.285, -2.080), Vector(0.878, 1.287, -2.388), Vector(0.811, 1.338, -2.374), Vector(0.447, 0.804,
			-2.560), Vector(-0.676, 1.511, -1.659), Vector(-0.676, 0.962, -2.483), Vector(-0.558, 0.927, -2.541), Vector(-0.363, 1.035,
			-2.560), Vector(-0.632, 1.255, -2.419), Vector(-0.490, 1.152, -2.511), Vector(-0.621, 1.545, -1.556), Vector(-0.479, 1.594,
			-1.706), Vector(-0.702, 1.384, -2.029), Vector(-0.765, 1.432, -2.172), Vector(-0.746, 1.421, -2.384), Vector(-0.690, 1.305,
			-2.261), Vector(-0.726, 1.515, -2.220), Vector(-0.689, 1.554, -2.539), Vector(-0.843, 1.325, -1.968), Vector(-0.892, 1.285,
			-2.080), Vector(-0.878, 1.287, -2.388), Vector(-0.811, 1.338, -2.374), Vector(-0.447, 0.804, -2.560), Vector(0.511, 1.616,
			-1.447), Vector(-0.511, 1.616, -1.447), Vector(-0.686, 0.900, -2.496), Vector(0.686, 0.900, -2.496));
		Global.VAR_VEH_MESH_VRTCS_REAR_BUMPER = Array(Vector(1.116, 0.766, -1.931), Vector(1.083, 0.384, -2.140), Vector(0.998, 0.414,
			-2.434), Vector(0.971, 0.963, -2.204), Vector(0.686, 0.900, -2.496), Vector(0.645, 0.818, -2.581), Vector(0.532, 0.729,
			-2.631), Vector(0.594, 0.432, -2.687), Vector(0.439, 0.561, -2.667), Vector(0.937, 0.798, -2.424), Vector(1.012, 0.496,
			-2.321), Vector(-1.116, 0.766, -1.931), Vector(-1.083, 0.384, -2.140), Vector(-0.998, 0.414, -2.434), Vector(-0.971, 0.963,
			-2.204), Vector(-0.686, 0.900, -2.496), Vector(-0.645, 0.818, -2.581), Vector(-0.532, 0.729, -2.631), Vector(-0.594, 0.432,
			-2.687), Vector(-0.439, 0.561, -2.667), Vector(-0.937, 0.798, -2.424), Vector(-1.012, 0.496, -2.321));
		Global.VAR_VEH_MESH_VRTCS_HEADLIGHTS = Array(Vector(0.552, 0.733, 2.489), Vector(1.002, 0.874, 2.090), Vector(-0.552, 0.733,
			2.489), Vector(-1.002, 0.874, 2.090));
		Global.VAR_VEH_MESH_VRTCS_L_R_LIGHTS = Array(Vector(0.989, 1.130, -1.946), Vector(0.686, 0.900, -2.496), Vector(0.895, 0.985,
			-2.340), Vector(0.939, 1.132, -2.250), Vector(0.632, 1.255, -2.419));
		Global.VAR_VEH_MESH_VRTCS_R_R_LIGHTS = Array(Vector(-0.989, 1.130, -1.946), Vector(-0.686, 0.900, -2.496), Vector(-0.895, 0.985,
			-2.340), Vector(-0.939, 1.132, -2.250), Vector(-0.632, 1.255, -2.419));
		Global.VAR_VEH_MESH_VRTCS_NITROUS = Array(Vector(0.131, 0.321, -2.706), Vector(-0.131, 0.321, -2.706));
		Global.VAR_VEH_MESH_VRTCS_CARBON_PARTS = Array(Vector(1.094, 0.198, -1.144), Vector(1.094, 0.229, -0.836), Vector(1.094, 0.431,
			-1.158), Vector(0.694, 1.646, -0.419), Vector(0.964, 1.153, -0.311), Vector(0.907, 1.253, -1.420), Vector(0.780, 1.495,
			-1.286), Vector(1.094, 0.198, 1.135), Vector(0.445, 0.225, 2.721), Vector(0.532, 0.208, 2.733), Vector(1.077, 0.212, 2.363),
			Vector(1.115, 0.216, 2.107), Vector(1.109, 0.358, 2.099), Vector(1.043, 0.228, 2.389), Vector(1.098, 0.330, -2.097), Vector(
			1.038, 0.348, -2.399), Vector(0.597, 0.367, -2.699), Vector(0.409, 0.478, -2.699), Vector(0.387, 0.530, -2.688), Vector(0.389,
			0.342, -2.688), Vector(0.254, 0.456, -2.707), Vector(0.255, 0.346, -2.703), Vector(0.255, 0.538, -2.712), Vector(0.960, 0.505,
			-2.422), Vector(0.704, 1.492, -2.296), Vector(0.459, 1.564, -2.381), Vector(0.693, 1.503, -2.480), Vector(0.443, 1.564,
			-2.560), Vector(0.620, 1.279, -2.427), Vector(0.320, 0.586, -2.676), Vector(0.550, 0.594, -2.648), Vector(0.710, 0.777,
			-2.563), Vector(0.920, 0.753, -2.445), Vector(0.669, 0.500, -2.612), Vector(0.361, 0.597, 2.676), Vector(0.431, 0.784, 2.628),
			Vector(0.955, 1.082, 0.751), Vector(0.875, 1.295, 0.691), Vector(0.719, 0.712, 2.445), Vector(1.003, 0.925, 2.012), Vector(
			0.941, 1.124, 0.825), Vector(1.256, 1.124, 0.629), Vector(-1.094, 0.198, -1.144), Vector(-1.094, 0.229, -0.836), Vector(-1.094,
			0.431, -1.158), Vector(-0.694, 1.646, -0.419), Vector(-0.964, 1.153, -0.311), Vector(-0.907, 1.253, -1.420), Vector(-0.780,
			1.495, -1.286), Vector(-1.094, 0.198, 1.135), Vector(-0.445, 0.225, 2.721), Vector(-0.532, 0.208, 2.733), Vector(-1.077, 0.212,
			2.363), Vector(-1.109, 0.358, 2.099), Vector(-1.043, 0.228, 2.389), Vector(-1.098, 0.330, -2.097), Vector(-1.038, 0.348,
			-2.399), Vector(-0.597, 0.367, -2.699), Vector(-0.409, 0.478, -2.699), Vector(-0.387, 0.530, -2.688), Vector(-0.389, 0.342,
			-2.688), Vector(-0.254, 0.456, -2.707), Vector(-0.255, 0.346, -2.703), Vector(-0.255, 0.538, -2.712), Vector(-0.960, 0.505,
			-2.422), Vector(-0.704, 1.492, -2.296), Vector(-0.459, 1.564, -2.381), Vector(-0.693, 1.503, -2.480), Vector(-0.443, 1.564,
			-2.560), Vector(-0.620, 1.279, -2.427), Vector(-0.320, 0.586, -2.676), Vector(-0.550, 0.594, -2.648), Vector(-0.710, 0.777,
			-2.563), Vector(-0.920, 0.753, -2.445), Vector(-0.669, 0.500, -2.612), Vector(-0.361, 0.597, 2.676), Vector(-0.431, 0.784,
			2.628), Vector(-0.955, 1.082, 0.751), Vector(-0.875, 1.295, 0.691), Vector(-0.719, 0.712, 2.445), Vector(-1.003, 0.925, 2.012),
			Vector(-0.941, 1.124, 0.825), Vector(-1.256, 1.124, 0.629), Vector(0.620, 1.300, -2.319), Vector(-0.620, 1.300, -2.319),
			Vector(Empty Array, 1.300, -2.556), Vector(Empty Array, 1.590, -2.428), Vector(Empty Array, 1.590, -2.607), Vector(Empty Array,
			1.323, -2.363), Vector(-1.115, 0.216, 2.107), Vector(0.216, 1.097, 1.718), Vector(-0.216, 1.097, 1.718));
		Global.VAR_VEH_MESH_VRTCS_DRIFT_POINTS = Array(Vector(1.125, 0.367, -1.631), Vector(1.124, 0.362, 1.638), Vector(-1.125, 0.367,
			-1.631), Vector(-1.124, 0.362, 1.638));
		Global.VAR_VEH_MESH_EDGES_FRONT_BUMPER = Array(3, 5, 2, 1, 0, 3, 5, 6, 6, 7, 7, 17, 4, 7, 9, 11, 15, 18, 14, 13, 12, 15, 18, 19,
			19, 20, 20, 10, 16, 20, 8, 21, 9, 22);
		Global.VAR_VEH_MESH_EDGES_FRONT_HOOD = Array(6, 16, 0, 1, 4, 5, 5, 6, 22, 18, 10, 19, 18, 11, 11, 7, 12, 13, 13, 14, 17, 10, 2, 15,
			14, 9, 7, 3, 20, 8, 15, 21, 8, 19, 1, 2, 2, 22, 3, 19);
		Global.VAR_VEH_MESH_EDGES_BODY = Array(70, 18, 4, 0, 3, 2, 2, 4, 5, 6, 14, 7, 10, 11, 7, 12, 6, 8, 6, 15, 32, 51, 17, 16, 18, 17,
			19, 18, 8, 20, 14, 21, 14, 15, 63, 53, 69, 49, 59, 27, 24, 10, 2, 28, 64, 22, 23, 59, 25, 26, 13, 25, 23, 13, 13, 60, 53, 54,
			37, 32, 35, 31, 34, 33, 33, 35, 36, 37, 45, 38, 41, 42, 38, 43, 37, 39, 37, 46, 39, 53, 48, 47, 49, 48, 50, 49, 39, 51, 8, 22,
			1, 20, 45, 52, 45, 46, 22, 23, 61, 40, 55, 41, 62, 9, 33, 58, 6, 1, 54, 27, 60, 44, 56, 57, 44, 56, 54, 44, 22, 29, 53, 30, 67,
			65, 68, 66);
		Global.VAR_VEH_MESH_EDGES_ENGINE_HOOD = Array(0, 4, 2, 1, 2, 3, 8, 9, 10, 11, 12, 13, 14, 12, 15, 14, 16, 15, 17, 16, 13, 17, 5,
			24, 18, 2, 19, 23, 21, 20, 21, 22, 6, 25, 27, 28, 29, 30, 31, 32, 33, 31, 34, 33, 35, 34, 36, 35, 32, 36, 18, 37, 3, 22, 37,
			21, 7, 38, 26, 39, 4, 5, 23, 24, 40, 23, 41, 4, 0, 6, 19, 25);
		Global.VAR_VEH_MESH_EDGES_REAR_BUMPER = Array(1, 0, 2, 1, 0, 3, 5, 6, 4, 5, 7, 2, 8, 7, 5, 9, 9, 10, 3, 9, 2, 10, 12, 11, 13, 12,
			11, 14, 16, 17, 15, 16, 6, 17, 18, 13, 19, 18, 16, 20, 20, 21, 14, 20, 13, 21);
		Global.VAR_VEH_MESH_EDGES_HEADLIGHTS = Array(0, 1, 2, 3);
		Global.VAR_VEH_MESH_EDGES_L_R_LIGHTS = Array(0, 3, 1, 2, 2, 3, 3, 4);
		Global.VAR_VEH_MESH_EDGES_R_R_LIGHTS = Array(0, 3, 1, 2, 2, 3, 3, 4);
		Global.VAR_VEH_MESH_EDGES_NITROUS = Array(0, 1);
		Global.VAR_VEH_MESH_EDGES_CARBON_PARTS = Array(2, 1, 85, 28, 3, 4, 5, 6, 65, 66, 26, 27, 12, 11, 0, 2, 10, 9, 11, 10, 13, 12, 14,
			15, 15, 16, 16, 17, 18, 19, 20, 21, 86, 66, 22, 29, 29, 30, 30, 31, 31, 32, 32, 23, 23, 33, 30, 33, 9, 8, 34, 38, 35, 39, 36,
			37, 40, 41, 7, 0, 44, 43, 45, 46, 47, 48, 24, 25, 42, 44, 52, 51, 54, 53, 55, 56, 56, 57, 57, 58, 59, 60, 61, 62, 87, 68, 63,
			70, 70, 71, 71, 72, 72, 73, 73, 64, 64, 74, 71, 74, 51, 50, 75, 79, 76, 80, 77, 78, 81, 82, 49, 42, 67, 68, 34, 75, 35, 76, 8,
			50, 17, 58, 22, 63, 27, 87, 84, 88, 25, 86, 69, 85, 88, 83, 89, 52, 53, 89, 90, 91);
		"PASTE YOUR CAR HERE - Original Gamemode Creator: GraczCourier (now known as RaidVentador_Courier_13)"
		Global.VAR_PLAYER_RACER.VAR_VEH_COLOR_DEFAULT = Color(Gray);
		Call Subroutine(SUB_VEH_VSL_GET_COLORS);
	}
}

rule("#3 2013 Nissan GT-R NISMO (Mesh Array Tables)")
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
		"VERTICES COUNT: 294 \n EDGE COUNT: 240 \n Car models ported with Deltin's OSTW for Visual Studio Code"
		Global.VAR_VEH_MESH_VRTCS_FRONT_BUMPER = Array(Vector(1.183, 0.765, 2.215), Vector(1.160, 0.343, 2.343), Vector(0.684, 0.279,
			2.903), Vector(0.636, 0.652, 2.903), Vector(0.457, 0.804, 2.858), Vector(1.082, 0.711, 2.635), Vector(1.180, 0.737, 2.295),
			Vector(0.671, 0.513, 2.909), Vector(0.629, 0.650, 2.892), Vector(0.549, 0.896, 2.691), Vector(1.076, 0.543, 2.647), Vector(
			1.106, 0.232, 2.620), Vector(0.734, 0.856, 2.645), Vector(1.024, 0.766, 2.580), Vector(0.747, 0.720, 2.768), Vector(-1.183,
			0.765, 2.215), Vector(-1.160, 0.343, 2.343), Vector(-0.684, 0.279, 2.903), Vector(-0.636, 0.652, 2.903), Vector(-0.457, 0.804,
			2.858), Vector(-1.082, 0.711, 2.635), Vector(-1.180, 0.737, 2.295), Vector(-0.671, 0.513, 2.909), Vector(-0.629, 0.650, 2.892),
			Vector(-0.549, 0.896, 2.691), Vector(-1.076, 0.543, 2.647), Vector(-1.106, 0.232, 2.620), Vector(-0.734, 0.856, 2.645), Vector(
			-1.024, 0.766, 2.580), Vector(-0.747, 0.720, 2.768));
		Global.VAR_VEH_MESH_VRTCS_FRONT_HOOD = Array(Vector(0.919, 1.190, 1.002), Vector(0.549, 0.896, 2.691), Vector(0.816, 1.104, 1.942),
			Vector(-0.919, 1.190, 1.002), Vector(0.997, 1.136, 1.170), Vector(0.952, 1.029, 2.025), Vector(0.734, 0.856, 2.645), Vector(
			0.760, 1.219, 1.119), Vector(-0.549, 0.896, 2.691), Vector(-0.816, 1.104, 1.942), Vector(-0.969, 1.171, 1.096), Vector(
			Empty Array, 1.219, 1.274), Vector(-0.997, 1.136, 1.170), Vector(-0.952, 1.029, 2.025), Vector(-0.734, 0.856, 2.645), Vector(
			-0.760, 1.219, 1.119), Vector(0.969, 1.171, 1.096));
		Global.VAR_VEH_MESH_VRTCS_BODY = Array(Vector(1.204, 0.271, -1.231), Vector(1.183, 0.283, 1.266), Vector(1.212, 0.693, -1.300),
			Vector(1.218, 0.910, -1.770), Vector(1.212, 0.756, -2.163), Vector(0.704, 1.241, -2.561), Vector(1.145, 0.390, 0.797), Vector(
			0.737, 1.314, -2.041), Vector(1.051, 1.148, -2.448), Vector(1.138, 1.102, -0.836), Vector(1.111, 0.974, 0.862), Vector(0.996,
			1.176, 0.893), Vector(0.991, 1.225, -0.732), Vector(0.839, 1.549, -0.811), Vector(1.161, 0.289, -0.483), Vector(1.161, 0.390,
			-0.661), Vector(1.136, 0.941, 1.176), Vector(1.183, 0.765, 1.374), Vector(1.183, 0.941, 1.790), Vector(1.183, 0.765, 2.215),
			Vector(0.645, 1.592, -1.121), Vector(0.638, 1.641, -0.836), Vector(0.752, 1.622, 0.101), Vector(0.659, 1.672, -0.373), Vector(
			Empty Array, 1.645, 0.259), Vector(0.815, 1.624, -0.127), Vector(0.933, 1.257, -1.717), Vector(0.952, 1.029, 2.025), Vector(
			1.046, 0.821, 2.509), Vector(1.100, 1.045, 1.878), Vector(1.114, 1.062, 1.350), Vector(0.877, 1.455, -1.224), Vector(0.966,
			1.250, -1.392), Vector(1.078, 1.127, -1.721), Vector(-1.204, 0.271, -1.231), Vector(-1.183, 0.283, 1.266), Vector(-1.212,
			0.693, -1.300), Vector(-1.218, 0.910, -1.770), Vector(-1.212, 0.756, -2.163), Vector(-0.659, 1.672, -0.373), Vector(-0.704,
			1.241, -2.561), Vector(-1.145, 0.390, 0.797), Vector(-0.737, 1.314, -2.041), Vector(-1.051, 1.148, -2.448), Vector(-1.138,
			1.102, -0.836), Vector(-1.111, 0.974, 0.862), Vector(-0.996, 1.176, 0.893), Vector(-0.991, 1.225, -0.732), Vector(-0.839,
			1.549, -0.811), Vector(-1.161, 0.289, -0.483), Vector(-1.161, 0.390, -0.661), Vector(-1.136, 0.941, 1.176), Vector(-1.183,
			0.765, 1.374), Vector(-1.183, 0.941, 1.790), Vector(-1.183, 0.765, 2.215), Vector(-0.645, 1.592, -1.121), Vector(-0.638, 1.641,
			-0.836), Vector(-0.752, 1.622, 0.101), Vector(-0.815, 1.624, -0.127), Vector(-0.933, 1.257, -1.717), Vector(-0.952, 1.029,
			2.025), Vector(-1.046, 0.821, 2.509), Vector(-1.100, 1.045, 1.878), Vector(-1.114, 1.062, 1.350), Vector(-0.877, 1.455,
			-1.224), Vector(-0.966, 1.250, -1.392), Vector(-1.078, 1.127, -1.721));
		Global.VAR_VEH_MESH_VRTCS_ENGINE_HOOD = Array(Vector(0.681, 1.227, -2.709), Vector(0.737, 1.314, -2.041), Vector(0.631, 1.130,
			-2.768), Vector(0.503, 1.068, -2.824), Vector(-0.681, 1.227, -2.709), Vector(-0.737, 1.314, -2.041), Vector(-0.631, 1.130,
			-2.768), Vector(-0.503, 1.068, -2.824));
		Global.VAR_VEH_MESH_VRTCS_REAR_BUMPER = Array(Vector(1.212, 0.756, -2.163), Vector(1.204, 0.482, -2.280), Vector(1.084, 0.542,
			-2.795), Vector(1.143, 0.827, -2.543), Vector(1.060, 1.148, -2.449), Vector(0.967, 1.223, -2.455), Vector(0.700, 1.244,
			-2.573), Vector(0.681, 1.227, -2.709), Vector(1.084, 0.848, -2.755), Vector(1.018, 1.153, -2.607), Vector(0.909, 1.221,
			-2.609), Vector(0.488, 0.845, -2.927), Vector(0.434, 0.608, -2.962), Vector(-1.212, 0.756, -2.163), Vector(-1.204, 0.482,
			-2.280), Vector(-1.084, 0.542, -2.795), Vector(-1.143, 0.827, -2.543), Vector(-1.060, 1.148, -2.449), Vector(-0.967, 1.223,
			-2.455), Vector(-0.700, 1.244, -2.573), Vector(-0.681, 1.227, -2.709), Vector(-1.084, 0.848, -2.755), Vector(-1.018, 1.153,
			-2.607), Vector(-0.909, 1.221, -2.609), Vector(-0.488, 0.845, -2.927), Vector(-0.434, 0.608, -2.962));
		Global.VAR_VEH_MESH_VRTCS_HEADLIGHTS = Array(Vector(1.027, 1.029, 2.035), Vector(0.815, 0.817, 2.669), Vector(1.053, 0.472, 2.657),
			Vector(0.832, 0.456, 2.796), Vector(-1.027, 1.029, 2.035), Vector(-0.815, 0.817, 2.669), Vector(-1.053, 0.472, 2.657), Vector(
			-0.832, 0.456, 2.796));
		Global.VAR_VEH_MESH_VRTCS_L_R_LIGHTS = Array(Vector(0.966, 0.971, -2.724), Vector(0.800, 0.977, -2.785), Vector(0.799, 1.148,
			-2.716), Vector(0.962, 1.140, -2.657), Vector(0.682, 1.097, -2.793), Vector(0.552, 1.103, -2.828), Vector(0.550, 0.967,
			-2.878), Vector(0.681, 0.959, -2.848));
		Global.VAR_VEH_MESH_VRTCS_R_R_LIGHTS = Array(Vector(-0.966, 0.971, -2.724), Vector(-0.800, 0.977, -2.785), Vector(-0.799, 1.148,
			-2.716), Vector(-0.962, 1.140, -2.657), Vector(-0.682, 1.097, -2.793), Vector(-0.552, 1.103, -2.828), Vector(-0.550, 0.967,
			-2.878), Vector(-0.681, 0.959, -2.848));
		Global.VAR_VEH_MESH_VRTCS_NITROUS = Array(Vector(0.731, 0.378, -2.848), Vector(0.901, 0.386, -2.769), Vector(-0.731, 0.378,
			-2.848), Vector(-0.901, 0.386, -2.769));
		Global.VAR_VEH_MESH_VRTCS_CARBON_PARTS = Array(Vector(1.204, 0.271, -1.231), Vector(1.183, 0.283, 1.266), Vector(1.204, 0.482,
			-2.280), Vector(1.204, 0.146, -2.240), Vector(1.224, 0.143, -1.246), Vector(1.173, 0.154, 1.286), Vector(1.163, 0.234, -2.744),
			Vector(1.084, 0.542, -2.795), Vector(1.024, 0.263, -2.776), Vector(0.688, 0.259, -2.892), Vector(0.473, 0.494, -2.973), Vector(
			1.060, 0.712, -2.769), Vector(0.484, 0.567, -2.961), Vector(-1.261, 1.225, 0.279), Vector(0.485, 0.309, -2.912), Vector(0.996,
			1.176, 0.893), Vector(0.991, 1.225, -0.732), Vector(0.839, 1.549, -0.811), Vector(1.145, 0.433, 0.823), Vector(1.136, 0.941,
			1.176), Vector(0.752, 1.622, 0.101), Vector(1.195, 0.337, 2.330), Vector(1.155, 0.179, 2.664), Vector(1.195, 0.176, 2.291),
			Vector(0.640, 0.173, 2.989), Vector(0.474, 0.493, 2.944), Vector(0.563, 0.254, 2.954), Vector(0.703, 0.254, 2.921), Vector(
			1.072, 0.271, 2.687), Vector(0.469, 0.499, 2.951), Vector(0.629, 0.650, 2.892), Vector(0.440, 0.629, 2.952), Vector(0.658,
			0.508, 2.896), Vector(0.451, 0.793, 2.826), Vector(0.301, 0.657, 2.941), Vector(0.348, 1.287, -2.580), Vector(0.348, 1.419,
			-2.596), Vector(0.348, 1.216, -2.817), Vector(0.348, 1.434, -2.873), Vector(0.353, 1.444, -2.496), Vector(0.952, 1.436,
			-2.375), Vector(0.958, 1.437, -2.772), Vector(0.349, 1.443, -2.884), Vector(0.970, 1.473, -2.776), Vector(0.968, 1.460,
			-2.325), Vector(0.970, 1.354, -2.404), Vector(0.968, 1.284, -2.628), Vector(0.970, 1.281, -2.755), Vector(0.465, 1.118, 2.075),
			Vector(0.431, 1.160, 1.809), Vector(0.539, 1.154, 1.813), Vector(0.337, 1.289, -2.829), Vector(-1.204, 0.271, -1.231), Vector(
			-1.183, 0.283, 1.266), Vector(-1.204, 0.482, -2.280), Vector(-1.204, 0.146, -2.240), Vector(-1.224, 0.143, -1.246), Vector(
			-1.173, 0.154, 1.286), Vector(-1.163, 0.234, -2.744), Vector(-1.084, 0.542, -2.795), Vector(-1.024, 0.263, -2.776), Vector(
			-0.688, 0.259, -2.892), Vector(-0.473, 0.494, -2.973), Vector(-1.060, 0.712, -2.769), Vector(-0.484, 0.567, -2.961), Vector(
			-0.485, 0.309, -2.912), Vector(-0.996, 1.176, 0.893), Vector(-0.991, 1.225, -0.732), Vector(-0.839, 1.549, -0.811), Vector(
			-1.145, 0.433, 0.823), Vector(-1.136, 0.941, 1.176), Vector(1.059, 1.094, 0.491), Vector(-0.752, 1.622, 0.101), Vector(1.261,
			1.225, 0.279), Vector(-1.059, 1.094, 0.491), Vector(-1.195, 0.337, 2.330), Vector(-1.155, 0.179, 2.664), Vector(-1.195, 0.176,
			2.291), Vector(-0.640, 0.173, 2.989), Vector(-0.474, 0.493, 2.944), Vector(-0.563, 0.254, 2.954), Vector(-0.703, 0.254, 2.921),
			Vector(-1.072, 0.271, 2.687), Vector(-0.469, 0.499, 2.951), Vector(-0.629, 0.650, 2.892), Vector(-0.440, 0.629, 2.952), Vector(
			-0.658, 0.508, 2.896), Vector(-0.451, 0.793, 2.826), Vector(-0.300, 0.657, 2.941), Vector(-0.348, 1.287, -2.580), Vector(
			-0.348, 1.419, -2.596), Vector(-0.348, 1.216, -2.817), Vector(-0.348, 1.434, -2.873), Vector(-0.353, 1.444, -2.496), Vector(
			-0.952, 1.436, -2.375), Vector(-0.958, 1.437, -2.772), Vector(-0.349, 1.443, -2.884), Vector(-0.970, 1.473, -2.776), Vector(
			-0.968, 1.460, -2.325), Vector(-0.970, 1.354, -2.404), Vector(-0.968, 1.284, -2.628), Vector(-0.970, 1.281, -2.755), Vector(
			-0.465, 1.118, 2.075), Vector(-0.431, 1.160, 1.809), Vector(-0.539, 1.154, 1.813), Vector(-0.337, 1.289, -2.829), Vector(1.099,
			0.293, -2.789), Vector(-1.099, 0.293, -2.789), Vector(0, 1.330, -2.176), Vector(0.737, 1.314, -2.041), Vector(-0.737, 1.314,
			-2.041), Vector(0.645, 1.592, -1.121), Vector(Empty Array, 1.625, -1.215), Vector(-0.645, 1.592, -1.121));
		Global.VAR_VEH_MESH_VRTCS_DRIFT_POINTS = Array(Vector(1.218, 0.467, -1.770), Vector(1.183, 0.498, 1.790), Vector(-1.218, 0.467,
			-1.770), Vector(-1.183, 0.498, 1.790));
		Global.VAR_VEH_MESH_EDGES_FRONT_BUMPER = Array(0, 1, 2, 3, 3, 4, 3, 5, 5, 6, 4, 9, 10, 7, 11, 10, 8, 12, 13, 14, 15, 16, 17, 18,
			18, 19, 18, 20, 20, 21, 19, 24, 25, 22, 26, 25, 23, 27, 28, 29, 4, 19, 5, 10, 20, 25);
		Global.VAR_VEH_MESH_EDGES_FRONT_HOOD = Array(1, 2, 2, 16, 3, 15, 4, 5, 1, 6, 5, 6, 8, 9, 9, 10, 3, 12, 12, 13, 8, 14, 7, 11, 13,
			14, 11, 15, 1, 8, 0, 4, 0, 7);
		Global.VAR_VEH_MESH_EDGES_BODY = Array(0, 2, 2, 3, 3, 4, 6, 10, 9, 10, 10, 11, 11, 12, 9, 12, 9, 14, 15, 6, 1, 17, 17, 18, 18, 19,
			20, 21, 23, 22, 21, 23, 22, 24, 22, 25, 13, 25, 12, 26, 5, 26, 7, 20, 27, 29, 28, 29, 18, 29, 29, 30, 32, 31, 13, 31, 11, 30,
			3, 33, 8, 9, 16, 30, 21, 13, 34, 36, 36, 37, 37, 38, 41, 45, 44, 45, 45, 46, 46, 47, 44, 47, 44, 49, 50, 41, 35, 52, 52, 53,
			53, 54, 23, 39, 55, 56, 57, 24, 57, 58, 48, 58, 47, 59, 40, 59, 42, 55, 60, 62, 61, 62, 53, 62, 62, 63, 65, 64, 48, 64, 46, 63,
			37, 66, 43, 44, 51, 63, 56, 48, 39, 57, 56, 39);
		Global.VAR_VEH_MESH_EDGES_ENGINE_HOOD = Array(0, 1, 2, 0, 3, 2, 4, 5, 6, 4, 7, 6, 3, 7, 0, 4);
		Global.VAR_VEH_MESH_EDGES_REAR_BUMPER = Array(0, 1, 0, 3, 3, 4, 4, 5, 5, 6, 2, 8, 8, 9, 9, 10, 7, 10, 13, 14, 13, 16, 16, 17, 17,
			18, 18, 19, 15, 21, 21, 22, 22, 23, 20, 23, 11, 24, 12, 25);
		Global.VAR_VEH_MESH_EDGES_HEADLIGHTS = Array(0, 1, 2, 3, 4, 5, 6, 7);
		Global.VAR_VEH_MESH_EDGES_L_R_LIGHTS = Array(1, 3, 0, 2, 4, 6, 5, 7);
		Global.VAR_VEH_MESH_EDGES_R_R_LIGHTS = Array(1, 3, 0, 2, 4, 6, 5, 7);
		Global.VAR_VEH_MESH_EDGES_NITROUS = Array(0, 1, 2, 3);
		Global.VAR_VEH_MESH_EDGES_CARBON_PARTS = Array(1, 0, 2, 3, 5, 4, 0, 4, 1, 5, 3, 6, 106, 7, 2, 7, 8, 9, 9, 10, 89, 105, 23, 21, 16,
			17, 18, 19, 21, 22, 20, 15, 22, 23, 25, 26, 26, 27, 27, 28, 32, 29, 30, 31, 33, 34, 39, 40, 41, 42, 43, 44, 44, 45, 46, 47, 43,
			47, 48, 49, 48, 50, 35, 36, 37, 38, 45, 46, 53, 52, 54, 55, 57, 56, 52, 56, 53, 57, 55, 58, 107, 59, 54, 59, 60, 61, 61, 62,
			35, 51, 63, 64, 12, 64, 77, 75, 67, 68, 69, 70, 75, 76, 72, 66, 76, 77, 76, 78, 79, 80, 80, 81, 81, 82, 86, 83, 84, 85, 87, 88,
			93, 94, 95, 96, 97, 98, 98, 99, 100, 101, 97, 101, 102, 103, 11, 12, 102, 104, 89, 90, 91, 92, 99, 100, 51, 105, 35, 89, 42,
			96, 39, 93, 74, 13, 34, 88, 31, 85, 29, 83, 10, 62, 14, 65, 71, 73, 22, 24, 24, 78, 6, 106, 58, 107, 109, 108, 110, 108, 111,
			112, 113, 112);
		"PASTE YOUR CAR HERE - Original Gamemode Creator: GraczCourier (now known as RaidVentador_Courier_13)"
		Global.VAR_PLAYER_RACER.VAR_VEH_COLOR_DEFAULT = Color(Gray);
		Call Subroutine(SUB_VEH_VSL_GET_COLORS);
	}
}

rule("#4 2002 Nissan Skyline GT-R (R34) (Mesh Array Tables)")
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
		Global.VAR_VEH_MESH_VRTCS_FRONT_BUMPER = Array(Vector(1.192, 0.730, 2.143), Vector(1.192, 0.286, 2.291), Vector(1.022, 0.730,
			2.494), Vector(-0.461, 0.647, 2.950), Vector(1.006, 0.305, 2.622), Vector(0.461, 0.305, 2.914), Vector(0.461, 0.647, 2.950),
			Vector(0.514, 0.663, 2.907), Vector(1.020, 0.681, 2.630), Vector(1.177, 0.680, 2.273), Vector(0.442, 0.824, 2.889), Vector(
			0.507, 0.862, 2.811), Vector(-0.507, 0.862, 2.811), Vector(1.163, 0.557, 2.302), Vector(1.133, 0.555, 2.401), Vector(1.066,
			0.355, 2.447), Vector(0.909, 0.350, 2.648), Vector(0.901, 0.475, 2.711), Vector(0.508, 0.468, 2.901), Vector(-1.192, 0.730,
			2.143), Vector(-1.192, 0.286, 2.291), Vector(-1.022, 0.730, 2.494), Vector(-1.006, 0.305, 2.622), Vector(-0.461, 0.305, 2.914),
			Vector(-0.514, 0.663, 2.907), Vector(-1.020, 0.681, 2.630), Vector(-1.177, 0.680, 2.273), Vector(0.461, 0.671, 2.912), Vector(
			-0.442, 0.824, 2.889), Vector(-1.163, 0.557, 2.302), Vector(-1.133, 0.555, 2.401), Vector(-0.461, 0.671, 2.912), Vector(-1.066,
			0.355, 2.447), Vector(-0.909, 0.350, 2.648), Vector(-0.901, 0.475, 2.711), Vector(-0.508, 0.468, 2.901));
		Global.VAR_VEH_MESH_VRTCS_FRONT_HOOD = Array(Vector(0.795, 1.177, 1.171), Vector(0.507, 0.862, 2.811), Vector(-0.507, 0.862,
			2.811), Vector(0.938, 1.148, 1.070), Vector(0.657, 1.072, 2.005), Vector(0.956, 1.036, 1.856), Vector(0.905, 0.901, 2.540),
			Vector(-0.795, 1.177, 1.171), Vector(-0.938, 1.148, 1.070), Vector(-0.657, 1.072, 2.005), Vector(-0.956, 1.036, 1.856), Vector(
			-0.905, 0.901, 2.540));
		Global.VAR_VEH_MESH_VRTCS_BODY = Array(Vector(1.166, 0.261, 1.293), Vector(1.164, 0.261, -1.177), Vector(1.112, 0.369, 0.952),
			Vector(1.084, 0.350, -0.421), Vector(1.081, 0.462, -0.580), Vector(1.175, 0.656, -1.240), Vector(1.155, 0.942, -1.672), Vector(
			1.141, 0.761, -1.981), Vector(1.123, 0.614, 1.028), Vector(1.166, 0.424, 1.309), Vector(1.182, 0.846, 1.775), Vector(1.192,
			0.730, 2.143), Vector(-1.166, 0.424, 1.309), Vector(1.022, 0.730, 2.494), Vector(1.002, 0.852, 2.457), Vector(0.938, 1.148,
			1.070), Vector(0.905, 0.901, 2.540), Vector(1.115, 0.423, 0.972), Vector(1.095, 1.030, 0.989), Vector(1.021, 1.138, 0.887),
			Vector(1.110, 0.949, 1.807), Vector(1.020, 0.793, 2.469), Vector(0.978, 1.149, 0.978), Vector(0.691, 1.599, 0.262), Vector(
			Empty Array, 1.660, 0.347), Vector(1.078, 0.899, -0.733), Vector(1.160, 0.885, -1.633), Vector(0.639, 1.631, -1.128), Vector(
			1.041, 1.086, -0.726), Vector(1.019, 1.128, 0.602), Vector(0.634, 1.682, -0.330), Vector(0.940, 1.236, -1.452), Vector(0.834,
			1.241, -2.718), Vector(0.960, 1.193, -2.684), Vector(1.035, 0.838, -2.681), Vector(1.177, 0.462, -1.202), Vector(0.814, 1.322,
			-1.749), Vector(0.295, 1.266, -2.120), Vector(Empty Array, 1.727, -0.330), Vector(Empty Array, 1.663, -1.117), Vector(1.086,
			0.672, -0.691), Vector(1.031, 1.161, -1.712), Vector(1.001, 1.154, -0.702), Vector(0.874, 1.245, -1.963), Vector(0.796, 1.280,
			-1.911), Vector(0.636, 1.664, -0.729), Vector(0.807, 1.076, -2.786), Vector(1.017, 1.011, -2.685), Vector(-1.166, 0.261,
			1.293), Vector(-1.164, 0.261, -1.177), Vector(-1.112, 0.369, 0.952), Vector(-1.084, 0.350, -0.421), Vector(-1.081, 0.462,
			-0.580), Vector(-1.175, 0.656, -1.240), Vector(-1.155, 0.942, -1.672), Vector(-1.141, 0.761, -1.981), Vector(-1.123, 0.614,
			1.028), Vector(-1.174, 0.729, 1.449), Vector(-1.182, 0.846, 1.775), Vector(-1.192, 0.730, 2.143), Vector(1.174, 0.729, 1.449),
			Vector(-1.022, 0.730, 2.494), Vector(-1.002, 0.852, 2.457), Vector(-0.938, 1.148, 1.070), Vector(-0.905, 0.901, 2.540), Vector(
			-1.115, 0.423, 0.972), Vector(-1.095, 1.030, 0.989), Vector(-1.021, 1.138, 0.887), Vector(-1.110, 0.949, 1.807), Vector(-1.020,
			0.793, 2.469), Vector(-0.978, 1.149, 0.978), Vector(-0.691, 1.599, 0.262), Vector(-1.078, 0.899, -0.733), Vector(-1.160, 0.885,
			-1.633), Vector(-0.639, 1.631, -1.128), Vector(-1.041, 1.086, -0.726), Vector(-1.019, 1.128, 0.602), Vector(-0.634, 1.682,
			-0.330), Vector(-0.940, 1.236, -1.452), Vector(-0.834, 1.241, -2.718), Vector(-0.960, 1.193, -2.684), Vector(-1.035, 0.838,
			-2.681), Vector(-1.177, 0.462, -1.202), Vector(-0.814, 1.322, -1.749), Vector(-0.295, 1.266, -2.120), Vector(-1.086, 0.672,
			-0.691), Vector(-1.031, 1.161, -1.712), Vector(-1.001, 1.154, -0.702), Vector(-0.874, 1.245, -1.963), Vector(-0.796, 1.280,
			-1.911), Vector(-0.636, 1.664, -0.729), Vector(-0.807, 1.076, -2.786), Vector(-1.017, 1.011, -2.685));
		Global.VAR_VEH_MESH_VRTCS_ENGINE_HOOD = Array(Vector(0.661, 1.240, -2.774), Vector(0.834, 1.241, -2.718), Vector(0.430, 0.895,
			-2.870), Vector(0.467, 1.129, -2.836), Vector(0.547, 1.249, -2.722), Vector(0.544, 1.452, -2.716), Vector(0.825, 1.468,
			-2.724), Vector(0.848, 1.508, -2.423), Vector(0.848, 1.555, -2.815), Vector(0.543, 1.455, -2.526), Vector(0.547, 1.267,
			-2.481), Vector(0.874, 1.245, -1.963), Vector(0.829, 1.272, -1.933), Vector(0.825, 1.476, -2.447), Vector(0.848, 1.433,
			-2.524), Vector(0.848, 1.435, -2.772), Vector(-0.661, 1.240, -2.774), Vector(-0.834, 1.241, -2.718), Vector(-0.430, 0.895,
			-2.870), Vector(-0.467, 1.129, -2.836), Vector(-0.547, 1.249, -2.722), Vector(-0.544, 1.452, -2.716), Vector(-0.825, 1.468,
			-2.724), Vector(-0.848, 1.508, -2.423), Vector(-0.848, 1.555, -2.815), Vector(-0.543, 1.455, -2.526), Vector(-0.547, 1.267,
			-2.481), Vector(-0.874, 1.245, -1.963), Vector(-0.829, 1.272, -1.933), Vector(-0.825, 1.476, -2.447), Vector(-0.848, 1.433,
			-2.524), Vector(-0.848, 1.435, -2.772), Vector(Empty Array, 1.476, -2.470));
		Global.VAR_VEH_MESH_VRTCS_REAR_BUMPER = Array(Vector(1.141, 0.761, -1.981), Vector(1.079, 0.363, -2.140), Vector(1.035, 0.838,
			-2.681), Vector(0.430, 0.926, -2.870), Vector(1.009, 0.838, -2.759), Vector(1.006, 0.782, -2.806), Vector(0.948, 0.427,
			-2.783), Vector(0.655, 0.427, -2.862), Vector(0.817, 0.404, -2.871), Vector(0.817, 0.529, -2.885), Vector(0.248, 0.529,
			-2.962), Vector(0.301, 0.511, -2.962), Vector(0.301, 0.401, -2.951), Vector(0.605, 0.782, -2.927), Vector(-0.430, 0.895,
			-2.870), Vector(0.222, 0.487, -2.931), Vector(0.254, 0.740, -2.931), Vector(-1.141, 0.761, -1.981), Vector(-1.079, 0.363,
			-2.140), Vector(-1.035, 0.838, -2.681), Vector(-0.430, 0.926, -2.870), Vector(-1.009, 0.838, -2.759), Vector(-1.006, 0.782,
			-2.806), Vector(-0.948, 0.427, -2.783), Vector(-0.655, 0.427, -2.862), Vector(-0.817, 0.404, -2.871), Vector(-0.817, 0.529,
			-2.885), Vector(-0.248, 0.529, -2.962), Vector(-0.301, 0.511, -2.962), Vector(-0.301, 0.401, -2.951), Vector(-0.605, 0.782,
			-2.927), Vector(0.430, 0.895, -2.870), Vector(-0.222, 0.487, -2.931), Vector(-0.254, 0.740, -2.931), Vector(1.012, 0.895,
			-2.748), Vector(-1.012, 0.895, -2.748), Vector(1.066, 0.316, -2.156), Vector(0.985, 0.493, -2.794), Vector(-1.066, 0.316,
			-2.156), Vector(-0.985, 0.493, -2.794));
		Global.VAR_VEH_MESH_VRTCS_HEADLIGHTS = Array(Vector(0.511, 0.769, 2.797), Vector(0.974, 0.786, 2.532), Vector(-0.511, 0.769,
			2.797), Vector(-0.974, 0.786, 2.532));
		Global.VAR_VEH_MESH_VRTCS_L_R_LIGHTS = Array(Vector(0.714, 1.160, -2.791), Vector(0.729, 0.989, -2.823), Vector(0.501, 1.106,
			-2.832), Vector(0.889, 1.168, -2.749), Vector(0.904, 0.997, -2.781), Vector(0.501, 0.991, -2.857), Vector(0.622, 1.103,
			-2.819), Vector(0.622, 0.988, -2.844));
		Global.VAR_VEH_MESH_VRTCS_R_R_LIGHTS = Array(Vector(-0.714, 1.160, -2.791), Vector(-0.729, 0.989, -2.823), Vector(-0.501, 1.106,
			-2.832), Vector(-0.889, 1.168, -2.749), Vector(-0.904, 0.997, -2.781), Vector(-0.501, 0.991, -2.857), Vector(-0.622, 1.103,
			-2.819), Vector(-0.622, 0.988, -2.844));
		Global.VAR_VEH_MESH_VRTCS_NITROUS = Array(Vector(0.521, 0.424, -2.732), Vector(0.521, 0.424, -2.943));
		Global.VAR_VEH_MESH_VRTCS_CARBON_PARTS = Array(Vector(0.938, 1.148, 1.070), Vector(-0.938, 1.148, 1.070), Vector(-0.448, 1.198,
			1.262), Vector(0.448, 1.198, 1.262), Vector(0.981, 1.187, -0.670), Vector(1.012, 0.208, 2.627), Vector(0.440, 0.208, 2.918),
			Vector(1.192, 0.208, 2.291), Vector(0.704, 1.647, -0.524), Vector(1.019, 1.128, 0.602), Vector(0.911, 1.334, 0.608), Vector(
			0.998, 1.175, 0.715), Vector(1.254, 1.210, 0.463), Vector(0.825, 1.508, -2.711), Vector(-0.825, 1.531, -2.794), Vector(-0.981,
			1.187, -0.670), Vector(-1.012, 0.208, 2.627), Vector(-0.440, 0.208, 2.918), Vector(-1.192, 0.208, 2.291), Vector(-0.704, 1.647,
			-0.524), Vector(-1.019, 1.128, 0.602), Vector(-0.911, 1.334, 0.608), Vector(-0.998, 1.175, 0.715), Vector(-1.254, 1.210,
			0.463), Vector(-0.825, 1.508, -2.711), Vector(0.825, 1.531, -2.794));
		Global.VAR_VEH_MESH_VRTCS_DRIFT_POINTS = Array(Vector(1.182, 0.396, 1.775), Vector(1.160, 0.435, -1.633), Vector(-1.182, 0.396,
			1.775), Vector(-1.160, 0.435, -1.633));
		Global.VAR_VEH_MESH_EDGES_FRONT_BUMPER = Array(0, 2, 20, 22, 4, 5, 7, 18, 7, 8, 8, 9, 13, 14, 15, 16, 14, 15, 10, 11, 6, 7, 1, 0,
			23, 3, 16, 17, 17, 18, 19, 21, 31, 28, 22, 23, 24, 35, 24, 25, 25, 26, 27, 10, 29, 30, 32, 33, 30, 32, 20, 19, 33, 34, 5, 6, 1,
			4, 34, 35, 10, 28, 5, 23, 3, 24, 6, 3, 28, 12);
		Global.VAR_VEH_MESH_EDGES_FRONT_HOOD = Array(5, 3, 1, 2, 4, 1, 0, 4, 6, 5, 10, 8, 7, 9, 11, 10, 1, 6, 9, 2, 2, 11);
		Global.VAR_VEH_MESH_EDGES_BODY = Array(3, 4, 15, 19, 4, 35, 66, 75, 5, 26, 25, 42, 40, 8, 11, 10, 12, 65, 8, 2, 3, 2, 6, 41, 8, 18,
			18, 19, 18, 20, 10, 20, 9, 17, 13, 14, 22, 23, 23, 24, 14, 16, 29, 19, 32, 33, 47, 33, 25, 6, 26, 7, 20, 21, 23, 30, 30, 27,
			27, 36, 30, 38, 27, 39, 36, 44, 45, 31, 33, 41, 28, 41, 42, 29, 44, 37, 4, 25, 6, 47, 47, 34, 42, 43, 0, 1, 51, 52, 63, 67, 52,
			82, 12, 48, 53, 73, 35, 5, 72, 87, 85, 56, 59, 58, 58, 57, 56, 50, 51, 50, 54, 86, 56, 66, 66, 67, 66, 68, 58, 68, 57, 12, 61,
			62, 70, 71, 71, 24, 62, 64, 76, 67, 79, 80, 92, 80, 72, 54, 73, 55, 68, 69, 71, 77, 77, 74, 74, 83, 77, 38, 74, 39, 83, 89, 90,
			78, 80, 86, 75, 86, 87, 76, 37, 84, 89, 84, 52, 72, 54, 92, 92, 81, 87, 88, 48, 49, 60, 9, 9, 0, 10, 60, 18, 28, 82, 53, 49,
			82, 1, 35, 43, 44, 88, 89);
		Global.VAR_VEH_MESH_EDGES_ENGINE_HOOD = Array(11, 1, 9, 10, 4, 5, 0, 16, 8, 7, 30, 31, 14, 15, 8, 15, 13, 32, 3, 0, 1, 0, 12, 0,
			27, 17, 25, 26, 23, 30, 2, 3, 20, 21, 24, 23, 24, 31, 19, 16, 17, 16, 28, 16, 6, 22, 32, 29, 18, 19, 7, 14, 3, 19);
		Global.VAR_VEH_MESH_EDGES_REAR_BUMPER = Array(0, 36, 19, 21, 34, 31, 0, 2, 15, 16, 35, 21, 6, 7, 8, 9, 9, 10, 11, 12, 5, 13, 21,
			22, 17, 38, 35, 14, 17, 19, 32, 33, 2, 4, 23, 24, 25, 26, 26, 27, 28, 29, 22, 30, 3, 20, 13, 30, 15, 32, 5, 37, 22, 39, 4, 5,
			34, 4, 37, 6, 36, 6, 39, 23, 38, 23, 1, 37, 18, 39);
		Global.VAR_VEH_MESH_EDGES_HEADLIGHTS = Array(0, 1, 2, 3);
		Global.VAR_VEH_MESH_EDGES_L_R_LIGHTS = Array(2, 7, 5, 6, 1, 3, 0, 4);
		Global.VAR_VEH_MESH_EDGES_R_R_LIGHTS = Array(2, 7, 5, 6, 1, 3, 0, 4);
		Global.VAR_VEH_MESH_EDGES_NITROUS = Array(0, 1);
		Global.VAR_VEH_MESH_EDGES_CARBON_PARTS = Array(0, 3, 1, 2, 2, 3, 4, 8, 9, 10, 11, 12, 5, 6, 7, 5, 15, 19, 20, 21, 22, 23, 16, 17,
			25, 14, 18, 16, 13, 24, 6, 17);
		"PASTE YOUR CAR HERE - Original Gamemode Creator: GraczCourier (now known as RaidVentador_Courier_13)"
		Global.VAR_PLAYER_RACER.VAR_VEH_COLOR_DEFAULT = Color(Blue);
		Call Subroutine(SUB_VEH_VSL_GET_COLORS);
	}
}

rule("#5 1983 Toyota AE86 Trueno (Mesh Array Tables)")
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
		"VERTICES COUNT: 295 \n EDGE COUNT: 243 \n Car models ported with Deltin's OSTW for Visual Studio Code"
		Global.VAR_VEH_MESH_VRTCS_FRONT_BUMPER = Array(Vector(1.087, 0.599, 2.163), Vector(0.955, 0.597, 2.793), Vector(1.110, 0.622,
			1.269), Vector(1.028, 1.171, 0.934), Vector(1.123, 0.810, 0.986), Vector(1.123, 0.795, 1.426), Vector(0.997, 1.072, 1.851),
			Vector(0.951, 0.922, 2.494), Vector(0.939, 0.817, 2.682), Vector(1.011, 0.766, 2.431), Vector(1.070, 0.768, 2.049), Vector(
			1.087, 0.862, 1.727), Vector(1.121, 0.622, 0.986), Vector(-1.087, 0.599, 2.163), Vector(-0.955, 0.597, 2.793), Vector(-1.110,
			0.622, 1.269), Vector(-1.028, 1.171, 0.934), Vector(-1.123, 0.810, 0.986), Vector(-0.997, 1.072, 1.851), Vector(-0.951, 0.922,
			2.494), Vector(-0.939, 0.817, 2.682), Vector(-1.011, 0.766, 2.431), Vector(-1.070, 0.768, 2.049), Vector(-1.121, 0.622, 0.986),
			Vector(0.859, 0.594, 2.850), Vector(-0.859, 0.594, 2.850), Vector(-1.123, 0.795, 1.426), Vector(-1.087, 0.862, 1.727));
		Global.VAR_VEH_MESH_VRTCS_FRONT_HOOD = Array(Vector(0.911, 0.941, 2.484), Vector(0.895, 1.076, 2.709), Vector(0.511, 1.113, 2.720),
			Vector(0.895, 0.946, 2.502), Vector(0.511, 0.954, 2.492), Vector(0.931, 1.086, 1.840), Vector(0.943, 1.176, 1.052), Vector(
			0.668, 1.174, 1.247), Vector(0.516, 1.174, 1.268), Vector(0.512, 1.091, 1.842), Vector(0.507, 0.823, 2.731), Vector(-0.911,
			0.941, 2.484), Vector(-0.895, 1.076, 2.709), Vector(-0.511, 1.113, 2.720), Vector(-0.895, 0.946, 2.502), Vector(-0.511, 0.954,
			2.492), Vector(-0.931, 1.086, 1.840), Vector(-0.943, 1.176, 1.052), Vector(-0.668, 1.174, 1.247), Vector(-0.516, 1.174, 1.268),
			Vector(-0.512, 1.091, 1.842), Vector(-0.507, 0.823, 2.731));
		Global.VAR_VEH_MESH_VRTCS_BODY = Array(Vector(1.121, 0.622, -0.831), Vector(1.121, 0.816, -0.831), Vector(1.028, 1.171, 0.934),
			Vector(1.123, 0.810, 0.986), Vector(0.741, 1.622, 0.199), Vector(Empty Array, 1.635, 0.253), Vector(0.709, 1.671, -0.633),
			Vector(1.067, 1.104, 0.960), Vector(1.107, 0.570, 0.981), Vector(1.121, 0.622, 0.986), Vector(-0.943, 1.176, 1.052), Vector(
			-1.028, 1.171, 0.934), Vector(-1.123, 0.810, 0.986), Vector(-0.741, 1.622, 0.199), Vector(-0.709, 1.671, -0.633), Vector(
			-1.067, 1.104, 0.960), Vector(-1.107, 0.570, 0.981), Vector(-1.121, 0.622, 0.986), Vector(-1.121, 0.622, -0.831), Vector(0.943,
			1.176, 1.052), Vector(1.048, 1.104, -0.770), Vector(1.121, 0.559, -0.822), Vector(-1.121, 0.559, -0.822), Vector(-1.121, 0.816,
			-0.831), Vector(-1.048, 1.104, -0.770), Vector(0.715, 1.643, -1.244), Vector(-0.715, 1.643, -1.244));
		Global.VAR_VEH_MESH_VRTCS_ENGINE_HOOD = Array(Vector(0.715, 1.643, -1.244), Vector(0.940, 1.232, -2.368), Vector(0.940, 1.219,
			-2.510), Vector(0.869, 1.220, -2.576), Vector(1.002, 1.041, -2.586), Vector(0.905, 1.219, -2.543), Vector(0.944, 1.042,
			-2.632), Vector(0.886, 1.044, -2.678), Vector(-0.715, 1.643, -1.244), Vector(-0.940, 1.232, -2.368), Vector(-0.940, 1.219,
			-2.510), Vector(-0.869, 1.220, -2.576), Vector(-1.002, 1.041, -2.586), Vector(-0.905, 1.219, -2.543), Vector(-0.886, 1.044,
			-2.678), Vector(-0.944, 1.042, -2.632));
		Global.VAR_VEH_MESH_VRTCS_REAR_BUMPER = Array(Vector(1.048, 1.104, -0.770), Vector(1.116, 0.622, -1.111), Vector(1.121, 0.622,
			-0.831), Vector(1.121, 0.816, -0.831), Vector(1.121, 0.816, -1.311), Vector(1.023, 1.128, -2.146), Vector(0.980, 1.219,
			-2.205), Vector(0.999, 1.079, -2.561), Vector(1.023, 0.781, -2.650), Vector(1.101, 0.788, -1.847), Vector(1.121, 0.855,
			-1.578), Vector(-1.048, 1.104, -0.770), Vector(-1.116, 0.622, -1.111), Vector(-1.121, 0.816, -0.831), Vector(-1.121, 0.816,
			-1.311), Vector(-1.023, 1.128, -2.146), Vector(-0.980, 1.219, -2.205), Vector(-0.999, 1.079, -2.561), Vector(-1.023, 0.781,
			-2.650), Vector(-1.101, 0.788, -1.847), Vector(-1.121, 0.855, -1.578), Vector(-1.121, 0.622, -0.831), Vector(1.022, 0.644,
			-2.779), Vector(1.125, 0.645, -1.876), Vector(0.875, 0.646, -2.830), Vector(-1.022, 0.644, -2.779), Vector(-1.125, 0.645,
			-1.876), Vector(-0.875, 0.646, -2.830));
		Global.VAR_VEH_MESH_VRTCS_HEADLIGHTS = Array(Vector(0.584, 0.818, 2.749), Vector(0.828, 0.818, 2.724), Vector(0.828, 1.007, 2.724),
			Vector(0.584, 1.007, 2.749), Vector(-0.584, 0.818, 2.749), Vector(-0.828, 0.818, 2.724), Vector(-0.828, 1.007, 2.724), Vector(
			-0.584, 1.007, 2.749));
		Global.VAR_VEH_MESH_VRTCS_L_R_LIGHTS = Array(Vector(0.587, 0.600, 2.866), Vector(0.920, 0.760, 2.705), Vector(1.003, 0.766, 2.459),
			Vector(0.428, 0.935, -2.730), Vector(0.971, 0.935, -2.697), Vector(0.428, 0.860, -2.748), Vector(0.971, 0.860, -2.714), Vector(
			1.001, 0.930, -2.626), Vector(1.001, 0.854, -2.643), Vector(0.845, 0.600, 2.851));
		Global.VAR_VEH_MESH_VRTCS_R_R_LIGHTS = Array(Vector(-0.587, 0.600, 2.866), Vector(-0.920, 0.760, 2.705), Vector(-1.003, 0.766,
			2.459), Vector(-0.428, 0.935, -2.730), Vector(-0.971, 0.935, -2.697), Vector(-0.428, 0.860, -2.748), Vector(-0.971, 0.860,
			-2.714), Vector(-1.001, 0.930, -2.626), Vector(-1.001, 0.854, -2.643), Vector(-0.845, 0.600, 2.851));
		Global.VAR_VEH_MESH_VRTCS_NITROUS = Array(Vector(0.642, 0.295, -1.915), Vector(0.642, 0.295, -2.750));
		Global.VAR_VEH_MESH_VRTCS_CARBON_PARTS = Array(Vector(1.151, 0.712, 1.449), Vector(1.115, 0.425, 1.257), Vector(1.090, 0.182,
			-1.052), Vector(0.826, 0.253, 2.685), Vector(1.124, 0.722, 1.986), Vector(1.139, 0.793, 1.714), Vector(1.091, 0.481, 2.169),
			Vector(1.025, 0.260, 2.202), Vector(0.937, 0.487, 2.760), Vector(1.087, 0.690, 2.104), Vector(0.952, 0.679, 2.813), Vector(
			1.028, 0.278, 1.031), Vector(1.028, 0.278, -0.811), Vector(1.124, 0.428, -1.085), Vector(1.151, 0.701, -1.292), Vector(1.151,
			0.777, -1.553), Vector(1.119, 0.678, -1.866), Vector(1.105, 0.569, -1.964), Vector(1.065, 0.147, -2.030), Vector(0.906, 0.315,
			-2.059), Vector(0.782, 0.338, -2.629), Vector(0.879, 0.512, -2.815), Vector(0.988, 0.506, -2.727), Vector(1.071, 0.484,
			-2.050), Vector(1.113, 0.698, -1.165), Vector(1.022, 0.290, -0.753), Vector(1.121, 0.559, -0.822), Vector(0.503, 0.774, 2.767),
			Vector(-1.121, 0.701, 1.337), Vector(1.121, 0.701, 1.337), Vector(1.113, 0.568, -1.073), Vector(0.526, 0.770, 2.772), Vector(
			0.884, 0.770, 2.736), Vector(0.884, 1.055, 2.736), Vector(0.884, 1.068, 2.800), Vector(0.512, 1.103, 2.815), Vector(0.895,
			1.076, 2.709), Vector(0.511, 1.113, 2.720), Vector(0.943, 1.176, 1.052), Vector(0.526, 1.054, 2.772), Vector(0.816, 1.232,
			-2.360), Vector(0.669, 1.598, -1.389), Vector(1.095, 1.000, -0.665), Vector(1.095, 1.000, -0.450), Vector(1.090, 0.719,
			-1.946), Vector(0.822, 0.147, -2.030), Vector(1.013, 0.719, -2.643), Vector(0.939, 0.719, -2.729), Vector(0.418, 0.719,
			-2.754), Vector(0.823, 0.395, -2.042), Vector(0.837, 0.336, -2.595), Vector(1.028, 0.285, 0.934), Vector(-0.344, 1.186, 1.164),
			Vector(1.067, 0.487, 2.211), Vector(1.107, 0.570, 0.981), Vector(1.309, 1.182, 0.586), Vector(0.983, 1.148, 0.714), Vector(
			0.960, 1.290, 0.605), Vector(1.033, 1.112, 0.598), Vector(0.633, 0.253, 2.770), Vector(0.783, 0.487, 2.854), Vector(-1.151,
			0.712, 1.449), Vector(-1.090, 0.193, 1.210), Vector(-1.115, 0.425, 1.257), Vector(-1.090, 0.182, -1.052), Vector(-0.826, 0.253,
			2.685), Vector(-1.124, 0.722, 1.986), Vector(-1.139, 0.793, 1.714), Vector(-1.091, 0.481, 2.169), Vector(-1.025, 0.260, 2.202),
			Vector(-0.937, 0.487, 2.760), Vector(-1.087, 0.690, 2.104), Vector(-1.028, 0.278, 1.031), Vector(-1.028, 0.278, -0.811),
			Vector(-1.124, 0.428, -1.085), Vector(-1.151, 0.701, -1.292), Vector(-1.151, 0.777, -1.553), Vector(-1.119, 0.678, -1.866),
			Vector(-1.105, 0.569, -1.964), Vector(-1.065, 0.147, -2.030), Vector(-0.906, 0.315, -2.059), Vector(-0.782, 0.338, -2.629),
			Vector(-0.879, 0.512, -2.815), Vector(-0.988, 0.506, -2.727), Vector(-1.071, 0.484, -2.050), Vector(-1.113, 0.698, -1.165),
			Vector(-1.022, 0.290, -0.753), Vector(-1.121, 0.559, -0.822), Vector(-0.503, 0.774, 2.767), Vector(1.121, 0.570, 1.245),
			Vector(-1.113, 0.568, -1.073), Vector(-1.121, 0.570, 1.245), Vector(-0.526, 0.770, 2.772), Vector(-0.884, 0.770, 2.736),
			Vector(-0.884, 1.055, 2.736), Vector(-0.884, 1.068, 2.800), Vector(-0.512, 1.103, 2.815), Vector(-0.895, 1.076, 2.709), Vector(
			-0.511, 1.113, 2.720), Vector(-0.943, 1.176, 1.052), Vector(-0.526, 1.054, 2.772), Vector(-0.816, 1.232, -2.360), Vector(
			-0.669, 1.598, -1.389), Vector(-1.095, 1.000, -0.665), Vector(-1.095, 1.000, -0.450), Vector(-1.090, 0.719, -1.946), Vector(
			-0.822, 0.147, -2.030), Vector(-1.013, 0.719, -2.643), Vector(-0.939, 0.719, -2.729), Vector(-0.418, 0.719, -2.754), Vector(
			-0.823, 0.395, -2.042), Vector(-0.837, 0.336, -2.595), Vector(-1.028, 0.285, 0.934), Vector(-1.067, 0.487, 2.211), Vector(
			-1.107, 0.570, 0.981), Vector(-1.309, 1.182, 0.586), Vector(-0.983, 1.148, 0.714), Vector(-0.960, 1.290, 0.605), Vector(-1.033,
			1.112, 0.598), Vector(-0.633, 0.253, 2.770), Vector(-0.783, 0.487, 2.854), Vector(0.572, 0.606, 2.867), Vector(-0.572, 0.606,
			2.867), Vector(0.344, 1.186, 1.164), Vector(0.856, 0.679, 2.851), Vector(-0.856, 0.679, 2.851), Vector(1.090, 0.193, 1.210),
			Vector(0.422, 1.004, -2.715), Vector(0.933, 1.004, -2.675), Vector(1.008, 1.004, -2.601), Vector(-0.422, 1.004, -2.715),
			Vector(-0.933, 1.004, -2.675), Vector(-1.008, 1.004, -2.601), Vector(0.418, 0.882, -2.682), Vector(0.418, 0.719, -2.717),
			Vector(0.371, 0.697, -2.717), Vector(-0.418, 0.882, -2.682), Vector(-0.418, 0.719, -2.717), Vector(-0.371, 0.697, -2.717),
			Vector(-0.952, 0.679, 2.813));
		Global.VAR_VEH_MESH_VRTCS_DRIFT_POINTS = Array(Vector(1.139, 0.383, 1.723), Vector(1.151, 0.383, -1.538), Vector(-1.139, 0.383,
			1.723), Vector(-1.151, 0.383, -1.538));
		Global.VAR_VEH_MESH_EDGES_FRONT_BUMPER = Array(0, 1, 4, 5, 6, 7, 7, 8, 9, 10, 10, 11, 5, 11, 12, 2, 3, 6, 1, 24, 13, 14, 18, 19,
			19, 20, 21, 22, 23, 15, 16, 18, 14, 25, 26, 27, 17, 26, 22, 27);
		Global.VAR_VEH_MESH_EDGES_FRONT_HOOD = Array(1, 3, 2, 4, 0, 5, 5, 6, 7, 8, 8, 9, 9, 4, 4, 10, 12, 14, 13, 15, 11, 16, 16, 17, 18,
			19, 19, 20, 20, 15, 15, 21, 10, 21, 14, 15, 3, 4);
		Global.VAR_VEH_MESH_EDGES_BODY = Array(8, 3, 1, 3, 2, 4, 4, 5, 4, 6, 0, 9, 7, 3, 2, 7, 16, 12, 10, 11, 11, 13, 13, 5, 13, 14, 18,
			17, 15, 12, 11, 15, 6, 14, 19, 2, 22, 23, 20, 6, 20, 7, 23, 12, 20, 1, 21, 1, 24, 23, 24, 14, 24, 15, 14, 26, 6, 25);
		Global.VAR_VEH_MESH_EDGES_ENGINE_HOOD = Array(1, 2, 5, 6, 7, 4, 8, 9, 9, 10, 13, 15, 3, 11, 0, 1, 2, 3, 10, 11, 14, 12, 7, 14, 8,
			0);
		Global.VAR_VEH_MESH_EDGES_REAR_BUMPER = Array(3, 4, 0, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10, 4, 10, 1, 2, 13, 14, 11, 15, 15, 16, 16,
			17, 17, 18, 18, 19, 19, 20, 14, 20, 12, 21, 22, 23, 24, 22, 25, 26, 27, 25, 24, 27);
		Global.VAR_VEH_MESH_EDGES_HEADLIGHTS = Array(0, 1, 1, 2, 3, 0, 2, 3, 4, 5, 5, 6, 7, 4, 6, 7);
		Global.VAR_VEH_MESH_EDGES_L_R_LIGHTS = Array(3, 4, 1, 2, 5, 6, 4, 7, 6, 8, 0, 9);
		Global.VAR_VEH_MESH_EDGES_R_R_LIGHTS = Array(3, 4, 1, 2, 5, 6, 4, 7, 6, 8, 0, 9);
		Global.VAR_VEH_MESH_EDGES_NITROUS = Array(0, 1);
		Global.VAR_VEH_MESH_EDGES_CARBON_PARTS = Array(7, 3, 0, 1, 5, 4, 6, 7, 5, 0, 8, 53, 9, 10, 1, 11, 11, 12, 2, 12, 12, 13, 2, 13, 13,
			14, 14, 15, 15, 16, 17, 18, 50, 20, 21, 22, 22, 23, 124, 125, 32, 33, 31, 32, 10, 124, 90, 91, 26, 25, 34, 35, 36, 34, 35, 37,
			36, 37, 39, 31, 33, 39, 57, 58, 40, 41, 42, 43, 44, 46, 46, 47, 47, 48, 18, 45, 45, 49, 55, 56, 54, 51, 38, 123, 4, 6, 19, 50,
			3, 59, 60, 8, 69, 65, 61, 63, 62, 64, 63, 62, 67, 66, 68, 69, 67, 61, 70, 113, 63, 72, 62, 72, 72, 73, 64, 73, 73, 74, 64, 74,
			74, 75, 75, 76, 76, 77, 78, 79, 111, 81, 82, 83, 83, 84, 85, 28, 93, 94, 92, 93, 20, 81, 30, 89, 87, 86, 95, 96, 97, 95, 96,
			98, 97, 98, 100, 92, 94, 100, 117, 118, 101, 102, 103, 104, 105, 107, 107, 108, 108, 109, 79, 106, 106, 110, 115, 116, 114,
			112, 99, 52, 66, 68, 80, 111, 65, 119, 120, 70, 21, 82, 27, 88, 121, 122, 59, 119, 60, 120, 41, 102, 40, 101, 52, 123, 24, 29,
			1, 126, 126, 11, 126, 2, 127, 128, 128, 129, 130, 131, 131, 132, 127, 130, 134, 133, 134, 135, 137, 136, 137, 138, 135, 138,
			71, 139, 125, 139);
		"PASTE YOUR CAR HERE - Original Gamemode Creator: GraczCourier (now known as RaidVentador_Courier_13)"
		Global.VAR_PLAYER_RACER.VAR_VEH_COLOR_DEFAULT = Color(Gray);
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
		"CARBONATED BEVERAGE WITH COLA FLAVOUR.\nContains cement. Contains traces of debris. \n CODE: B9P3A"
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
		Wait(0.250, Ignore Condition);
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
			"SELECT CAR BODY"), 0, Array(Custom String("2018 Porsche 911 GT3 RS"), Custom String("2017 HONDA CIVIC TYPE-R FK8"),
			Custom String("2013 Nissan GT-R NISMO"), Custom String("2002 Nissan Skyline GT-R (R34)"), Custom String(
			"1983 Toyota AE86 Trueno")), 0), 1, False, 2, 50, 2, Workshop Setting Combo(Custom String(
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

	conditions
	{
		Entity Exists(Global.VAR_PLAYER_RACER) == True;
		Global.VAR_GLB_VEHICLE_DEPLOY_STATUS != 3;
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
				Global.VAR_GLB_VEH_REG_START_POS = First Of(Spawn Points(All Teams));
				Global.VAR_GLB_VEH_REG_START_FACE = First Of(Spawn Points(All Teams));
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
		Global.VAR_GLB_VEHICLE_DEPLOY_STATUS == 1;
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
	Global.VAR_GLB_VEHICLE_DEPLOY_STATUS = 1;
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
	Global.VAR_TIP_TRIVIAS_HERE = Global.VAR_MENU_ARRAY_STRING_DEPLOY[Random Integer(4, 12)];
		Global.VAR_GLB_VEHICLE_DEPLOY_STATUS = 2;
		Global.VAR_MENU_WAITING_FOR_CAR_STRING = Global.VAR_MENU_ARRAY_STRING_DEPLOY[1];
		Create In-World Text(Global.VAR_PLAYER_RACER, Custom String("{0} \"{1}\" {2}", Global.VAR_MENU_ARRAY_STRING_CONTROL[12],
			Input Binding String(Button(Crouch)), Global.VAR_MENU_ARRAY_STRING_DEPLOY[3]), Vector(0, 150,
			Global.VAR_MENU_ARRAY_BTN_Z_VECTOR[6]), 2, Clip Against Surfaces, Visible To Position and String, Color(White),
			Default Visibility);
	Create In-World Text(Global.VAR_PLAYER_RACER, Custom String("{0} {1}", Global.VAR_MENU_ARRAY_STRING_DEPLOY[2],
		Global.VAR_TIP_TRIVIAS_HERE), Vector(0, 150, Global.VAR_MENU_ARRAY_BTN_Z_VECTOR[8]), 2, Clip Against Surfaces,
		Visible To Position and String, Color(White), Default Visibility);
		Wait Until(Array Contains(Array(Is Button Held(Global.VAR_PLAYER_RACER, Button(Primary Fire)), Is Button Held(
			Global.VAR_PLAYER_RACER, Button(Secondary Fire)), Is Button Held(Global.VAR_PLAYER_RACER, Button(Ability 1)), Is Button Held(
			Global.VAR_PLAYER_RACER, Button(Ability 2)), Is Button Held(Global.VAR_PLAYER_RACER, Button(Reload)), Is Button Held(
			Global.VAR_PLAYER_RACER, Button(Melee)), Is Button Held(Global.VAR_PLAYER_RACER, Button(Jump)), Is Button Held(
			Global.VAR_PLAYER_RACER, Button(Interact)), Is Button Held(Global.VAR_PLAYER_RACER, Button(Ultimate))), True)
			|| Array Contains(Array(X Component Of(Throttle Of(Global.VAR_PLAYER_RACER)), Z Component Of(Throttle Of(
			Global.VAR_PLAYER_RACER))), Array(1, -1)), 99999);
		Wait(0.100, Ignore Condition);
		Stop Camera(All Players(All Teams));
		Destroy All In-World Text;
		Global.VAR_GLB_VEHICLE_DEPLOY_STATUS = 3;
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
		Global.VAR_GLB_VEHICLE_DEPLOY_STATUS == 1;
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
		Global.VAR_GLB_VEHICLE_DEPLOY_STATUS == 3;
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
			Custom String("\"{0}\" {1}", Input Binding String(Button(Interact)), Global.VAR_GLB_ARRAY_STRING_IN_GAME[7])));
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
		Event Player.VAR_RACER_VEHICLE_VISIBLE_TO = All Players(All Teams);
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
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - VEHICLE MECHANICS \n [1] - ACCELERATION - RATE (RECEIVER)"
		Event Player.VAR_ARRAY_CAR_MECHANICS[1] = 1;
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
		Event Player.VAR_ARRAY_CAR_NAVIGATION[1] == Left;
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
		Event Player.VAR_ARRAY_CAR_NAVIGATION[1] == Left;
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
		Event Player.VAR_ARRAY_CAR_NAVIGATION[1] == Right;
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
		Event Player.VAR_ARRAY_CAR_NAVIGATION[1] == Right;
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

rule("CAR DRIFTING MECHANICS: Drift Trigger")
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
		(Event Player.VAR_ARRAY_CAR_NAVIGATION[1] == Left || Event Player.VAR_ARRAY_CAR_NAVIGATION[1] == Right) == True;
		Event Player.VAR_VEH_DRIFT_TRIGGER == True;
		Is In Air(Event Player.VAR_RACER_VEHICLE) == False;
	}

	actions
	{
		If(Event Player.VAR_ARRAY_CAR_NAVIGATION[1] == Left);
			Event Player.VAR_VEH_GRIP_DEST = -1;
		Else If(Event Player.VAR_ARRAY_CAR_NAVIGATION[1] == Right);
			Event Player.VAR_VEH_GRIP_DEST = 1;
		End;
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
		Event Player.VAR_ARRAY_CAR_NAVIGATION[1] == Left;
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
		Event Player.VAR_ARRAY_CAR_NAVIGATION[1] == Right;
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
		Event Player.VAR_ARRAY_CAR_NAVIGATION[1] == Left;
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
		Event Player.VAR_ARRAY_CAR_NAVIGATION[1] == Right;
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
		Speed Of In Direction(Event Player.VAR_RACER_VEHICLE, World Vector Of(Forward, Event Player.VAR_RACER_VEHICLE, Rotation)) >= 4;
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
		Speed Of In Direction(Event Player.VAR_RACER_VEHICLE, World Vector Of(Forward, Event Player.VAR_RACER_VEHICLE, Rotation)) <= 4;
		Is In Air(Event Player) == False;
	}

	actions
	{
		Wait(0.100, Abort When False);
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
		Global.VAR_GLB_VEHICLE_DEPLOY_STATUS == 2;
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
		Global.VAR_GLB_VEHICLE_DEPLOY_STATUS == 2;
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
		Event Player.VAR_ARRAY_CAR_NAVIGATION[0] == Custom String("NAV_ACC_ACCELERATING");
	}

	actions
	{
		"FOR INDEXES REFER TO: GAME IN PROGRESS \\ VEHICLE \\ ARRAY TABLE - CAR NAVIGATION \n [8] - BLINKERS ENABLED"
		Event Player.VAR_ARRAY_CAR_NAVIGATION[8] = False;
	}
}

rule("VISUAL CAR MECHANICS: SHOW DRIFT SMOKE")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_VEH_DRIFT_TRIGGER == True;
		Speed Of In Direction(Event Player.VAR_RACER_VEHICLE, World Vector Of(Forward, Event Player.VAR_RACER_VEHICLE, Rotation)) >= 6;
		Is In Air(Event Player.VAR_RACER_VEHICLE) == False;
	}

	actions
	{
		Call Subroutine(SUB_VEH_VSL_DRIFT_SMOKE);
		Wait(0.100, Ignore Condition);
		Loop If Condition Is True;
	}
}

rule("VISUAL CAR MECHANICS SUBROUTINE: SHOW DRIFT SMOKE")
{
	event
	{
		Subroutine;
		SUB_VEH_VSL_DRIFT_SMOKE;
	}

	actions
	{
		Play Effect(Event Player, Doomfist Rising Uppercut Leap Effect, Color(White), Update Every Frame(Position Of(
			Event Player.VAR_RACER_VEHICLE) + World Vector Of(
			Global.VAR_VEH_MESH_VRTCS_DRIFT_POINTS[Event Player.VAR_VEH_VSL_SMOKE_CURRENT], Event Player.VAR_RACER_VEHICLE, Rotation)
			* Global.VAR_VEH_MESH_Scale), 10 * Event Player.VAR_VEH_ACCELER_THROTTLE);
		If(Event Player.VAR_VEH_VSL_SMOKE_CURRENT != 3);
			Event Player.VAR_VEH_VSL_SMOKE_CURRENT += 1;
			Loop If Condition Is True;
		Else;
			Event Player.VAR_VEH_VSL_SMOKE_CURRENT = 0;
		End;
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
			Small Message(Event Player, Custom String("  {0} {1} {2}", Global.VAR_GLB_ARRAY_STRING_IN_GAME[6], Input Binding String(Button(
				Reload)), Global.VAR_GLB_ARRAY_STRING_IN_GAME[8]));
		Else;
			"FOR INDEXES REFER TO: GAME IN PROGRESS \\ GLOBAL \\ ARRAY TABLE - IN-GAME STRINGS \n [6] - PRESS / [9] - TO RESTART"
			Small Message(Event Player, Custom String("  {0} {1} {2}", Global.VAR_GLB_ARRAY_STRING_IN_GAME[6], Input Binding String(Button(
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
		Global.VAR_GLB_VEHICLE_DEPLOY_STATUS == 2;
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
		Global.VAR_GLB_VEHICLE_DEPLOY_STATUS == 3;
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
		Global.VAR_GLB_VEHICLE_DEPLOY_STATUS == 3;
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
		Global.VAR_GLB_VEHICLE_DEPLOY_STATUS == 3;
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
		Global.VAR_GLB_VEHICLE_DEPLOY_STATUS == 1;
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

rule("VEHICLE MECHANICS: PLAYER JUMPS OFF THE RAMP")
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

rule("VEHICLE MECHANICS: CANCEL JUMPING OFF THE RAMP IF LOST TOO MUCH SPEED")
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
			* 20, Event Player.VAR_RACER_VEHICLE, Event Player.VAR_RACER_VEHICLE, True)) > 3;
		Distance Between(Eye Position(Event Player.VAR_RACER_VEHICLE), Ray Cast Hit Position(Eye Position(Event Player.VAR_RACER_VEHICLE),
			Eye Position(Event Player.VAR_RACER_VEHICLE) + World Vector Of(Vector(0, -0.250, -1), Event Player.VAR_RACER_VEHICLE, Rotation) * 20,
			Event Player.VAR_RACER_VEHICLE, Event Player.VAR_RACER_VEHICLE, True)) >= 7;
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
		Event Player.VAR_ARRAY_CAR_NAVIGATION[6] == 1;
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
		Event Player.VAR_ARRAY_CAR_NAVIGATION[1] = Left;
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
		Event Player.VAR_ARRAY_CAR_NAVIGATION[1] = Right;
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

rule("INPUT NAVIGATION MECHANICS: NEXT TIP/TRIVIA")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Global.VAR_GLB_VEHICLE_DEPLOY_STATUS == 2;
		Is Button Held(Event Player, Button(Crouch)) == True;
	}

	actions
	{
	Global.VAR_TIP_TRIVIAS_HERE = Global.VAR_MENU_ARRAY_STRING_DEPLOY[Random Integer(4, 12)];
	}
}

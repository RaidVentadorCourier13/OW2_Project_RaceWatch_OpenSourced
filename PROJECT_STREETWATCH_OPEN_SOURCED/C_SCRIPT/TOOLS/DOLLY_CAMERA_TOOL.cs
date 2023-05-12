variables
{
	global:
		35: VAR_PLAYER_RACER
		71: VAR_GLB_VEHICLE_DEPLOY_STATUS
		100: VAR_DOLLY_CAM_TOOLS
		101: VAR_DOLLY_CAM_TOOLS_STRING
		102: VAR_DOLLY_CAM_OPTION_STRING
		103: VAR_DOLLY_CAM_ARRAY_HUD
		104: VAR_DOLLY_CAM_ARRAY_POS
		105: VAR_DOLLY_CAM_ARRAY_FACE
		106: VAR_DOLLY_CAM_ARRAY_STRING
		107: VAR_DOLLY_CAM_BLEND_SPEED
		108: VAR_DOLLY_CAM_VALUE_CHANGE_SPEED
		109: VAR_DOLLY_CAM_VALUE_CHANGE_RATE
		110: VAR_DOLLY_CAM_AUTOSWITCH_CHASED
		111: VAR_DOLLY_CAM_CURRENT_POS
		112: VAR_DOLLY_CAM_CURRENT_FACE
		113: VAR_DOLLY_CAM_CURRENT
		114: VAR_DOLLY_CAM_IS_ACTIVATED
		115: VAR_DOLLY_CAM_AUTOSWITCH_ENABLED
		116: VAR_DOLLY_CAM_AUTOSWITCH_DEST

	player:
		11: VAR_RACER_VEHICLE_IS_READY
		14: VAR_PLAYER_RACER_INSIDE_VEHICLE
		37: VAR_VEH_FUNCTION_COOLDOWN
}

subroutines
{
	21: SUB_VEH_CAMERA_START
	27: SUB_VEH_INPUT_FUNC_COOLDOWN
	41: SUB_DOLLY_CAM_TOOL_STRINGS
	42: SUB_DOLLY_CAM_NEXT
	43: SUB_DOLLY_CAM_PREV
	44: SUB_DOLLY_CAM_TRIGGERED
	45: SUB_DOLLY_CAM_DEACTIVATED
}

disabled rule("DOLLY CAMERA TOOL")
{
	event
	{
		Ongoing - Global;
	}
}

rule("DOLLY CAMERA TOOL: Create Dolly Camera HUD")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		Global.VAR_GLB_VEHICLE_DEPLOY_STATUS == Custom String("DEPLOYED");
	}

	actions
	{
		Call Subroutine(SUB_DOLLY_CAM_TOOL_STRINGS);
		"[0] - DOLLY CAMERA SETUP HUD (MAIN)"
		Create HUD Text(Global.VAR_DOLLY_CAM_ARRAY_HUD[0], Custom String("CURRENT TOOL: {0}", Global.VAR_DOLLY_CAM_TOOLS_STRING), Null,
			Null, Top, 0, Color(White), Color(White), Color(White), Visible To and String, Default Visibility);
		Create HUD Text(Global.VAR_DOLLY_CAM_ARRAY_HUD[0], Null, Null, Custom String("{0} + {1} / {2} - Cycle Between Tools",
			Input Binding String(Button(Reload)), Input Binding String(Button(Secondary Fire)), Input Binding String(Button(
			Primary Fire))), Top, 1, Color(White), Color(White), Color(White), Visible To and String, Default Visibility);
		Create HUD Text(Global.VAR_DOLLY_CAM_ARRAY_HUD[0], Null, Null, Custom String("\n \n \n \n \n \n \n \n",
			Global.VAR_DOLLY_CAM_OPTION_STRING), Top, 3, Color(White), Color(White), Color(White), Visible To and String,
			Default Visibility);
		"[1] - DOLLY CAMERA SETUP HUD (PLACEMENT TOOL) (SELECTED)"
		Create HUD Text(Global.VAR_DOLLY_CAM_ARRAY_HUD[1], Null, Null, Custom String(
			"{0} / {1} - Cycle Between Dolly Cameras  \n{2} - Place Dolly Camera", Input Binding String(Button(Secondary Fire)),
			Input Binding String(Button(Primary Fire)), Input Binding String(Button(Ultimate))), Left, 0, Color(White), Color(White),
			Color(White), Visible To and String, Default Visibility);
		Create HUD Text(Global.VAR_DOLLY_CAM_ARRAY_HUD[1], Null, Null, Custom String("CURRENT DOLLY CAMERA: #{0} ({1})",
			Global.VAR_DOLLY_CAM_CURRENT, Global.VAR_DOLLY_CAM_ARRAY_STRING[Global.VAR_DOLLY_CAM_CURRENT]), Top, 4, Color(White), Color(
			White), Color(White), Visible To and String, Default Visibility);
		"[2] - DOLLY CAMERA SETUP HUD (BLEND SPEED TOOL) (SELECTED)"
		Create HUD Text(Global.VAR_DOLLY_CAM_ARRAY_HUD[2], Null, Null, Custom String(
			"{0} - Increase Blend Speed \n{1} - Decrease Blend Speed ", Input Binding String(Button(Secondary Fire)), Input Binding String(
			Button(Primary Fire))), Left, 0, Color(White), Color(White), Color(White), Visible To and String, Default Visibility);
		Create HUD Text(Global.VAR_DOLLY_CAM_ARRAY_HUD[2], Null, Null, Custom String("{0} (Hold) - Speed Up Change Rate",
			Input Binding String(Button(Melee))), Left, 1, Color(White), Color(White), Color(White), Visible To and String,
			Default Visibility);
		Create HUD Text(Global.VAR_DOLLY_CAM_ARRAY_HUD[2], Null, Null, Custom String("Blend Speed: {0}", Global.VAR_DOLLY_CAM_BLEND_SPEED),
			Top, 4, Color(White), Color(White), Color(White), Visible To and String, Default Visibility);
		"[3] - DOLLY CAMERA SETUP HUD (AUTO-SWITCH TOOL) (SELECTED)"
		Create HUD Text(Global.VAR_DOLLY_CAM_ARRAY_HUD[3], Null, Null, Custom String("{0} - Extend Time \n{1} - Shorten Time",
			Input Binding String(Button(Secondary Fire)), Input Binding String(Button(Primary Fire))), Left, 0, Color(White), Color(White),
			Color(White), Visible To and String, Default Visibility);
		Create HUD Text(Global.VAR_DOLLY_CAM_ARRAY_HUD[3], Null, Null, Custom String("{0} (Hold) - Speed Up Change Rate",
			Input Binding String(Button(Melee))), Left, 1, Color(White), Color(White), Color(White), Visible To and String,
			Default Visibility);
		Create HUD Text(Global.VAR_DOLLY_CAM_ARRAY_HUD[3], Null, Null, Custom String("Auto-Switch Wait Time: {0}",
			Global.VAR_DOLLY_CAM_AUTOSWITCH_DEST), Top, 4, Color(White), Color(White), Color(White), Visible To and String,
			Default Visibility);
		"[4] - ACTIVATED DOLLY CAMERA HUD (MAIN)"
		Create HUD Text(Global.VAR_DOLLY_CAM_ARRAY_HUD[4], Null, Null, Custom String(
			"\n\n\n\n                                        ¯¯\\\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        _/"),
			Left, 0, Color(White), Color(White), Color(White), Visible To and String, Default Visibility);
		Create HUD Text(Global.VAR_DOLLY_CAM_ARRAY_HUD[4], Null, Null, Custom String(
			"\n\n\n\n/¯¯                                        \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\\_                                        "),
			Right, 0, Color(White), Color(White), Color(White), Visible To and String, Default Visibility);
		Create HUD Text(Global.VAR_DOLLY_CAM_ARRAY_HUD[4], Null, Null, Custom String("CURRENT DOLLY CAMERA: #{0}",
			Global.VAR_DOLLY_CAM_CURRENT), Top, 2, Color(White), Color(White), Color(White), Visible To and String, Default Visibility);
		"[5] - ACTIVATED DOLLY CAMERA HUD (INSTRUCTIONS - ALWAYS VISIBLE)"
		Create HUD Text(Global.VAR_DOLLY_CAM_ARRAY_HUD[5], Null, Null, Custom String("{0} + {1} - Toggle Dolly Camera",
			Input Binding String(Button(Melee)), Input Binding String(Button(Ultimate))), Top, 2, Color(White), Color(White), Color(White),
			Visible To and String, Default Visibility);
		"[6] - ACTIVATED DOLLY CAMERA HUD (AUTO-SWITCH ENABLED)"
		Create HUD Text(Global.VAR_DOLLY_CAM_ARRAY_HUD[6], Null, Null, Custom String("NEXT CAMERA IN: #{0}",
			Global.VAR_DOLLY_CAM_AUTOSWITCH_CHASED), Top, 4, Color(White), Color(White), Color(White), Visible To and String,
			Default Visibility);
	}
}

rule("DOLLY CAMERA TOOL: SHOW HUD")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == False;
		Event Player.VAR_RACER_VEHICLE_IS_READY == True;
	}

	actions
	{
		"[0] - DOLLY CAMERA SETUP HUD (MAIN)"
		Global.VAR_DOLLY_CAM_ARRAY_HUD[0] = Event Player;
		"[5] - ACTIVATED DOLLY CAMERA HUD (INSTRUCTIONS - ALWAYS VISIBLE)"
		Global.VAR_DOLLY_CAM_ARRAY_HUD[5] = Event Player;
		Call Subroutine(SUB_DOLLY_CAM_TOOL_STRINGS);
	}
}

rule("DOLLY CAMERA TOOL: HIDE HUD")
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
		Event Player.VAR_RACER_VEHICLE_IS_READY == True;
	}

	actions
	{
		"[0] - DOLLY CAMERA SETUP HUD (MAIN)"
		Global.VAR_DOLLY_CAM_ARRAY_HUD[0] = Null;
		"[1] - DOLLY CAMERA SETUP HUD (PLACEMENT TOOL) (DESELECTED)"
		Global.VAR_DOLLY_CAM_ARRAY_HUD[1] = Null;
		"[2] - DOLLY CAMERA SETUP HUD (BLEND SPEED TOOL) (DESELECTED)"
		Global.VAR_DOLLY_CAM_ARRAY_HUD[2] = Null;
		"[3] - DOLLY CAMERA SETUP HUD (AUTO-SWITCH TOOL) (DESELECTED)"
		Global.VAR_DOLLY_CAM_ARRAY_HUD[3] = Null;
		"[4] - ACTIVATED DOLLY CAMERA HUD (MAIN)"
		Global.VAR_DOLLY_CAM_ARRAY_HUD[4] = Null;
		"[5] - ACTIVATED DOLLY CAMERA HUD (INSTRUCTIONS - ALWAYS VISIBLE)"
		Global.VAR_DOLLY_CAM_ARRAY_HUD[5] = Null;
	}
}

rule("DOLLY CAMERA TOOL SUBROUTINE: CURRENT TOOL STRINGS")
{
	event
	{
		Subroutine;
		SUB_DOLLY_CAM_TOOL_STRINGS;
	}

	actions
	{
		If(Global.VAR_DOLLY_CAM_TOOLS == 0);
			Global.VAR_DOLLY_CAM_TOOLS_STRING = Custom String("No Tools Selected");
			"[1] - DOLLY CAMERA SETUP HUD (PLACEMENT TOOL) (DESELECTED)"
			Global.VAR_DOLLY_CAM_ARRAY_HUD[1] = Null;
			"[2] - DOLLY CAMERA SETUP HUD (BLEND SPEED TOOL) (DESELECTED)"
			Global.VAR_DOLLY_CAM_ARRAY_HUD[2] = Null;
			"[3] - DOLLY CAMERA SETUP HUD (AUTO-SWITCH TOOL) (DESELECTED)"
			Global.VAR_DOLLY_CAM_ARRAY_HUD[3] = Null;
		Else If(Global.VAR_DOLLY_CAM_TOOLS == 1);
			Global.VAR_DOLLY_CAM_TOOLS_STRING = Custom String("Placing and Selection Tool");
			"[1] - DOLLY CAMERA SETUP HUD (PLACEMENT TOOL) (SELECTED)"
			Global.VAR_DOLLY_CAM_ARRAY_HUD[1] = Event Player;
			"[2] - DOLLY CAMERA SETUP HUD (BLEND SPEED TOOL) (DESELECTED)"
			Global.VAR_DOLLY_CAM_ARRAY_HUD[2] = Null;
			"[3] - DOLLY CAMERA SETUP HUD (AUTO-SWITCH TOOL) (DESELECTED)"
			Global.VAR_DOLLY_CAM_ARRAY_HUD[3] = Null;
		Else If(Global.VAR_DOLLY_CAM_TOOLS == 2);
			Global.VAR_DOLLY_CAM_TOOLS_STRING = Custom String("Blend Speed Tool");
			"[1] - DOLLY CAMERA SETUP HUD (PLACEMENT TOOL) (DESELECTED)"
			Global.VAR_DOLLY_CAM_ARRAY_HUD[1] = Null;
			"[2] - DOLLY CAMERA SETUP HUD (BLEND SPEED TOOL) (SELECTED)"
			Global.VAR_DOLLY_CAM_ARRAY_HUD[2] = Event Player;
			"[3] - DOLLY CAMERA SETUP HUD (AUTO-SWITCH TOOL) (DESELECTED)"
			Global.VAR_DOLLY_CAM_ARRAY_HUD[3] = Null;
		Else If(Global.VAR_DOLLY_CAM_TOOLS == 3);
			Global.VAR_DOLLY_CAM_TOOLS_STRING = Custom String("Auto-Next Camera Tool");
			"[1] - DOLLY CAMERA SETUP HUD (PLACEMENT TOOL) (DESELECTED)"
			Global.VAR_DOLLY_CAM_ARRAY_HUD[1] = Null;
			"[2] - DOLLY CAMERA SETUP HUD (BLEND SPEED TOOL) (DESELECTED)"
			Global.VAR_DOLLY_CAM_ARRAY_HUD[2] = Null;
			"[3] - DOLLY CAMERA SETUP HUD (AUTO-SWITCH TOOL) (SELECTED)"
			Global.VAR_DOLLY_CAM_ARRAY_HUD[3] = Event Player;
		End;
	}
}

rule("DOLLY CAMERA TOOL: Cycle Between Tools")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Global.VAR_PLAYER_RACER.VAR_PLAYER_RACER_INSIDE_VEHICLE == False;
		Global.VAR_DOLLY_CAM_IS_ACTIVATED != True;
		Is Button Held(Event Player, Button(Reload)) == True;
		(Is Button Held(Event Player, Button(Primary Fire)) || Is Button Held(Event Player, Button(Secondary Fire))) == True;
	}

	actions
	{
		"NEXT DOLLY CAMERA TOOLS"
		If(Is Button Held(Event Player, Button(Secondary Fire)));
			If(Global.VAR_DOLLY_CAM_TOOLS != 3);
				Global.VAR_DOLLY_CAM_TOOLS += 1;
			End;
		"PREV DOLLY CAMERA TOOLS"
		Else If(Is Button Held(Event Player, Button(Primary Fire)));
			If(Global.VAR_DOLLY_CAM_TOOLS != 0);
				Global.VAR_DOLLY_CAM_TOOLS -= 1;
			End;
		End;
		Call Subroutine(SUB_DOLLY_CAM_TOOL_STRINGS);
		If(Global.VAR_DOLLY_CAM_ARRAY_STRING[Global.VAR_DOLLY_CAM_CURRENT] == 0);
			Global.VAR_DOLLY_CAM_ARRAY_STRING[Global.VAR_DOLLY_CAM_CURRENT] = Custom String("NOT PLACED");
		End;
	}
}

rule("DOLLY CAMERA TOOL: Cycle Between Values")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Global.VAR_PLAYER_RACER.VAR_PLAYER_RACER_INSIDE_VEHICLE == False;
		Global.VAR_DOLLY_CAM_IS_ACTIVATED != True;
		Is Button Held(Event Player, Button(Reload)) == False;
		(Is Button Held(Event Player, Button(Primary Fire)) || Is Button Held(Event Player, Button(Secondary Fire))) == True;
	}

	actions
	{
		If(Is Button Held(Event Player, Button(Secondary Fire)));
			"NEXT DOLLY CAMERA"
			If(Global.VAR_DOLLY_CAM_TOOLS == 1);
				Call Subroutine(SUB_DOLLY_CAM_NEXT);
			"INCREASE DOLLY CAMERA BLEND SPEED"
			Else If(Global.VAR_DOLLY_CAM_TOOLS == 2);
				Chase Global Variable At Rate(VAR_DOLLY_CAM_BLEND_SPEED, 100, Global.VAR_DOLLY_CAM_VALUE_CHANGE_SPEED, Destination and Rate);
			"INCREASE WAIT TIME BEFORE SWITCHING TO NEXT DOLLY CAMERA"
			Else If(Global.VAR_DOLLY_CAM_TOOLS == 3);
				Chase Global Variable At Rate(VAR_DOLLY_CAM_AUTOSWITCH_DEST, 10, Global.VAR_DOLLY_CAM_VALUE_CHANGE_SPEED, Destination and Rate);
			End;
		Else If(Is Button Held(Event Player, Button(Primary Fire)));
			"PREV DOLLY CAMERA"
			If(Global.VAR_DOLLY_CAM_TOOLS == 1);
				Call Subroutine(SUB_DOLLY_CAM_PREV);
			"DECREASE DOLLY CAMERA BLEND SPEED"
			Else If(Global.VAR_DOLLY_CAM_TOOLS == 2);
				Chase Global Variable At Rate(VAR_DOLLY_CAM_BLEND_SPEED, 0, Global.VAR_DOLLY_CAM_VALUE_CHANGE_SPEED, Destination and Rate);
			"DECREASE WAIT TIME BEFORE SWITCHING TO NEXT DOLLY CAMERA"
			Else If(Global.VAR_DOLLY_CAM_TOOLS == 3);
				Chase Global Variable At Rate(VAR_DOLLY_CAM_AUTOSWITCH_DEST, 0, Global.VAR_DOLLY_CAM_VALUE_CHANGE_SPEED, Destination and Rate);
			End;
		End;
		If(Global.VAR_DOLLY_CAM_TOOLS > 1);
			Global.VAR_DOLLY_CAM_VALUE_CHANGE_RATE = 0.250;
			Chase Global Variable At Rate(VAR_DOLLY_CAM_VALUE_CHANGE_SPEED, 20, Global.VAR_DOLLY_CAM_VALUE_CHANGE_RATE, Destination and Rate);
		End;
		If(Global.VAR_DOLLY_CAM_ARRAY_STRING[Global.VAR_DOLLY_CAM_CURRENT] == 0);
			Global.VAR_DOLLY_CAM_ARRAY_STRING[Global.VAR_DOLLY_CAM_CURRENT] = Custom String("NOT PLACED");
		End;
	}
}

rule("DOLLY CAMERA TOOL: Double Value Change Speed")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Global.VAR_PLAYER_RACER.VAR_PLAYER_RACER_INSIDE_VEHICLE == False;
		Global.VAR_DOLLY_CAM_IS_ACTIVATED != True;
		Global.VAR_DOLLY_CAM_TOOLS > 1;
		(Is Button Held(Event Player, Button(Primary Fire)) || Is Button Held(Event Player, Button(Secondary Fire))) == True;
		Is Button Held(Event Player, Button(Melee)) == True;
	}

	actions
	{
		Global.VAR_DOLLY_CAM_VALUE_CHANGE_RATE = 5;
		Wait Until(!Is Button Held(Event Player, Button(Melee)), 99999);
		Global.VAR_DOLLY_CAM_VALUE_CHANGE_RATE = 0.250;
	}
}

rule("DOLLY CAMERA TOOL: Halt Dolly Camera Setting Speed")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Global.VAR_PLAYER_RACER.VAR_PLAYER_RACER_INSIDE_VEHICLE == False;
		Global.VAR_DOLLY_CAM_IS_ACTIVATED != True;
		(Is Button Held(Event Player, Button(Primary Fire)) || Is Button Held(Event Player, Button(Secondary Fire))) == False;
	}

	actions
	{
		Stop Chasing Global Variable(VAR_DOLLY_CAM_VALUE_CHANGE_SPEED);
		Stop Chasing Global Variable(VAR_DOLLY_CAM_BLEND_SPEED);
		Stop Chasing Global Variable(VAR_DOLLY_CAM_AUTOSWITCH_CHASED);
		Global.VAR_DOLLY_CAM_VALUE_CHANGE_SPEED = 0;
	}
}

rule("DOLLY CAMERA TOOL SUBROUTINE: Next Dolly Camera")
{
	event
	{
		Subroutine;
		SUB_DOLLY_CAM_NEXT;
	}

	actions
	{
		If(Global.VAR_DOLLY_CAM_ARRAY_STRING[Global.VAR_DOLLY_CAM_CURRENT] == Custom String("PLACED"));
			Global.VAR_DOLLY_CAM_CURRENT += 1;
		End;
	}
}

rule("DOLLY CAMERA TOOL SUBROUTINE: Prev Dolly Camera")
{
	event
	{
		Subroutine;
		SUB_DOLLY_CAM_PREV;
	}

	actions
	{
		If(Global.VAR_DOLLY_CAM_CURRENT != 0);
			Global.VAR_DOLLY_CAM_CURRENT -= 1;
		End;
	}
}

rule("DOLLY CAMERA TOOL: Place Dolly Camera (On Foot)")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == False;
		Global.VAR_DOLLY_CAM_IS_ACTIVATED != True;
		Global.VAR_DOLLY_CAM_TOOLS == 1;
		Is Button Held(Event Player, Button(Melee)) == False;
		Is Button Held(Event Player, Button(Ultimate)) == True;
	}

	actions
	{
		Small Message(Global.VAR_PLAYER_RACER, Custom String("  {0} DOLLY CAM #{1} PLACED  ", Icon String(Checkmark),
			Global.VAR_DOLLY_CAM_CURRENT));
		Play Effect(Global.VAR_PLAYER_RACER, Brigitte Repair Pack Armor Sound, Color(White), Eye Position(Global.VAR_PLAYER_RACER), 200);
		Global.VAR_DOLLY_CAM_CURRENT_POS = Eye Position(Global.VAR_PLAYER_RACER);
		Global.VAR_DOLLY_CAM_CURRENT_FACE = Ray Cast Hit Position(Eye Position(Global.VAR_PLAYER_RACER), Eye Position(
			Global.VAR_PLAYER_RACER) + Facing Direction Of(Global.VAR_PLAYER_RACER) * 2, Global.VAR_PLAYER_RACER, All Players(All Teams),
			True);
		Global.VAR_DOLLY_CAM_ARRAY_POS[Global.VAR_DOLLY_CAM_CURRENT] = Global.VAR_DOLLY_CAM_CURRENT_POS;
		Global.VAR_DOLLY_CAM_ARRAY_FACE[Global.VAR_DOLLY_CAM_CURRENT] = Global.VAR_DOLLY_CAM_CURRENT_FACE;
		Global.VAR_DOLLY_CAM_ARRAY_STRING[Global.VAR_DOLLY_CAM_CURRENT] = Custom String("PLACED");
	}
}

rule("DOLLY CAMERA TOOL: Trigger Dolly Camera")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Event Player.VAR_VEH_FUNCTION_COOLDOWN == False;
		Is Button Held(Event Player, Button(Melee)) == True;
		Is Button Held(Event Player, Button(Ultimate)) == True;
	}

	actions
	{
		If(Global.VAR_DOLLY_CAM_AUTOSWITCH_DEST != 0);
			Global.VAR_DOLLY_CAM_AUTOSWITCH_CHASED = Global.VAR_DOLLY_CAM_AUTOSWITCH_DEST;
			Global.VAR_DOLLY_CAM_AUTOSWITCH_ENABLED = True;
			Chase Global Variable At Rate(VAR_DOLLY_CAM_AUTOSWITCH_CHASED, 0, 1, Destination and Rate);
		Else;
			Global.VAR_DOLLY_CAM_AUTOSWITCH_ENABLED = False;
		End;
		If(Global.VAR_DOLLY_CAM_ARRAY_POS != 0);
			"TURN OFF DOLLY CAM"
			If(Global.VAR_DOLLY_CAM_IS_ACTIVATED);
				Call Subroutine(SUB_DOLLY_CAM_DEACTIVATED);
				If(Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == True);
					Call Subroutine(SUB_VEH_CAMERA_START);
				Else;
					Stop Camera(Global.VAR_PLAYER_RACER);
				End;
			"TURN ON DOLLY CAM"
			Else;
				Small Message(Event Player, Custom String("  {0} Dolly Camera: ON  ", Icon String(Checkmark)));
				Global.VAR_DOLLY_CAM_IS_ACTIVATED = True;
			End;
			Call Subroutine(SUB_DOLLY_CAM_TRIGGERED);
			Call Subroutine(SUB_VEH_INPUT_FUNC_COOLDOWN);
		Else;
			Small Message(Event Player, Custom String("   {0} NO DOLLY CAMERAS WERE PLACED!  ", Icon String(Warning)));
		End;
	}
}

rule("DOLLY CAMERA TOOL SUBROUTINE: DOLLY CAMERA TRIGGERED")
{
	event
	{
		Subroutine;
		SUB_DOLLY_CAM_TRIGGERED;
	}

	actions
	{
		If(Global.VAR_DOLLY_CAM_IS_ACTIVATED == True);
			"[0] - DOLLY CAMERA SETUP HUD (MAIN)"
			Global.VAR_DOLLY_CAM_ARRAY_HUD[0] = Null;
			"[1] - DOLLY CAMERA SETUP HUD (PLACEMENT TOOL) (DESELECTED)"
			Global.VAR_DOLLY_CAM_ARRAY_HUD[1] = Null;
			"[2] - DOLLY CAMERA SETUP HUD (BLEND SPEED TOOL) (DESELECTED)"
			Global.VAR_DOLLY_CAM_ARRAY_HUD[2] = Null;
			"[3] - DOLLY CAMERA SETUP HUD (AUTO-SWITCH TOOL) (DESELECTED)"
			Global.VAR_DOLLY_CAM_ARRAY_HUD[3] = Null;
			"[4] - ACTIVATED DOLLY CAMERA HUD (MAIN)"
			Global.VAR_DOLLY_CAM_ARRAY_HUD[4] = Event Player;
			If(Global.VAR_DOLLY_CAM_AUTOSWITCH_ENABLED == True);
				"[6] - ACTIVATED DOLLY CAMERA HUD (AUTO-SWITCH) (ENABLED)"
				Global.VAR_DOLLY_CAM_ARRAY_HUD[6] = Event Player;
			End;
		Else;
			If(Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == False);
				Global.VAR_DOLLY_CAM_ARRAY_HUD[0] = Event Player;
				Call Subroutine(SUB_DOLLY_CAM_TOOL_STRINGS);
			End;
			Global.VAR_DOLLY_CAM_ARRAY_HUD[4] = Null;
			"[6] - ACTIVATED DOLLY CAMERA HUD (AUTO-SWITCH) (DISABLED)"
			Global.VAR_DOLLY_CAM_ARRAY_HUD[6] = Null;
		End;
	}
}

rule("DOLLY CAMERA TOOL SUBROUTINE: DOLLY CAMERA DEACTIVATED")
{
	event
	{
		Subroutine;
		SUB_DOLLY_CAM_DEACTIVATED;
	}

	actions
	{
		Small Message(Event Player, Custom String("  {0} Dolly Camera: OFF  ", Icon String(Warning)));
		Stop Chasing Global Variable(VAR_DOLLY_CAM_AUTOSWITCH_CHASED);
		Global.VAR_DOLLY_CAM_IS_ACTIVATED = False;
	}
}

rule("DOLLY CAMERA TOOL: Activate Dolly Camera")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		Global.VAR_DOLLY_CAM_IS_ACTIVATED == True;
	}

	actions
	{
		Stop Camera(Global.VAR_PLAYER_RACER);
		Global.VAR_DOLLY_CAM_CURRENT = 0;
		Global.VAR_DOLLY_CAM_CURRENT_POS = Global.VAR_DOLLY_CAM_ARRAY_POS[Global.VAR_DOLLY_CAM_CURRENT];
		Global.VAR_DOLLY_CAM_CURRENT_FACE = Global.VAR_DOLLY_CAM_ARRAY_FACE[Global.VAR_DOLLY_CAM_CURRENT];
		Wait(0.016, Ignore Condition);
		Start Camera(Global.VAR_PLAYER_RACER, Global.VAR_DOLLY_CAM_CURRENT_POS, Global.VAR_DOLLY_CAM_CURRENT_FACE, 0);
		Stop Camera(Global.VAR_PLAYER_RACER);
		Wait(0.016, Ignore Condition);
		Start Camera(Global.VAR_PLAYER_RACER, Global.VAR_DOLLY_CAM_CURRENT_POS, Global.VAR_DOLLY_CAM_CURRENT_FACE,
			Global.VAR_DOLLY_CAM_BLEND_SPEED);
	}
}

rule("DOLLY CAMERA TOOL: Deactivate Dolly Camera if Player Entered the vehicle")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Global.VAR_PLAYER_RACER.VAR_PLAYER_RACER_INSIDE_VEHICLE == True;
	}

	actions
	{
		Call Subroutine(SUB_DOLLY_CAM_DEACTIVATED);
	}
}

rule("DOLLY CAMERA TOOL: Deactivate Dolly Camera if Player Switched Camera Type inside the vehicle")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Global.VAR_PLAYER_RACER.VAR_PLAYER_RACER_INSIDE_VEHICLE == True;
		Global.VAR_DOLLY_CAM_IS_ACTIVATED == True;
		Is Button Held(Event Player, Button(Melee)) == False;
		Is Button Held(Event Player, Button(Ultimate)) == True;
	}

	actions
	{
		Call Subroutine(SUB_DOLLY_CAM_DEACTIVATED);
		Call Subroutine(SUB_VEH_CAMERA_START);
	}
}

rule("DOLLY CAMERA TOOL: Dolly Camera Activated - Cycle Between Dolly Cameras")
{
	event
	{
		Ongoing - Each Player;
		All;
		Slot 0;
	}

	conditions
	{
		Global.VAR_DOLLY_CAM_IS_ACTIVATED == True;
		Is Button Held(Event Player, Button(Melee)) == False;
		(Is Button Held(Event Player, Button(Primary Fire)) || Is Button Held(Event Player, Button(Secondary Fire))) == True;
	}

	actions
	{
		Global.VAR_DOLLY_CAM_AUTOSWITCH_CHASED = Global.VAR_DOLLY_CAM_AUTOSWITCH_DEST;
		If(Is Button Held(Event Player, Button(Secondary Fire)));
			Call Subroutine(SUB_DOLLY_CAM_NEXT);
		Else If(Is Button Held(Event Player, Button(Primary Fire)));
			Call Subroutine(SUB_DOLLY_CAM_PREV);
		End;
		Global.VAR_DOLLY_CAM_CURRENT_POS = Global.VAR_DOLLY_CAM_ARRAY_POS[Global.VAR_DOLLY_CAM_CURRENT];
		Global.VAR_DOLLY_CAM_CURRENT_FACE = Global.VAR_DOLLY_CAM_ARRAY_FACE[Global.VAR_DOLLY_CAM_CURRENT];
	}
}

rule("DOLLY CAMERA TOOL: Dolly Camera Activated - Auto Switch to Next Camera")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		Global.VAR_DOLLY_CAM_IS_ACTIVATED == True;
		Global.VAR_DOLLY_CAM_AUTOSWITCH_ENABLED == True;
		Global.VAR_DOLLY_CAM_AUTOSWITCH_CHASED == 0;
		Global.VAR_DOLLY_CAM_CURRENT != Count Of(Global.VAR_DOLLY_CAM_ARRAY_STRING);
	}

	actions
	{
		Global.VAR_DOLLY_CAM_AUTOSWITCH_CHASED = Global.VAR_DOLLY_CAM_AUTOSWITCH_DEST;
		Global.VAR_DOLLY_CAM_CURRENT += 1;
		Global.VAR_DOLLY_CAM_CURRENT_POS = Global.VAR_DOLLY_CAM_ARRAY_POS[Global.VAR_DOLLY_CAM_CURRENT];
		Global.VAR_DOLLY_CAM_CURRENT_FACE = Global.VAR_DOLLY_CAM_ARRAY_FACE[Global.VAR_DOLLY_CAM_CURRENT];
	}
}

variables
{
	global:
		35: VAR_PLAYER_RACER
		71: VAR_GLB_VEHICLE_DEPLOY_STATUS
		100: VAR_DOLLY_CAM_TOOLS
		101: VAR_DOLLY_CAM_TOOLS_STRING
		102: VAR_DOLLY_CAM_OPTION_STRING
		103: VAR_DOLLY_CAM_HUD_ARRAY
		104: VAR_DOLLY_CAM_POS_ARRAY
		105: VAR_DOLLY_CAM_FACE_ARRAY
		106: VAR_DOLLY_CAM_BLEND_SPEED
		107: VAR_DOLLY_CAM_VALUE_CHANGE_SPEED
		108: VAR_DOLLY_CAM_VALUE_CHANGE_RATE
		109: VAR_DOLLY_CAM_AUTOSWITCH_WAIT
		110: VAR_DOLLY_CAM_CURRENT_POS
		111: VAR_DOLLY_CAM_CURRENT_FACE
		112: VAR_DOLLY_CAM_CURRENT
		113: VAR_DOLLY_CAM_IS_ACTIVATED

	player:
		11: VAR_RACER_VEHICLE_IS_READY
		14: VAR_PLAYER_RACER_INSIDE_VEHICLE
		37: VAR_VEH_FUNCTION_COOLDOWN
}

subroutines
{
	21: SUB_VEH_CAMERA_START
	27: SUB_VEH_INPUT_FUNC_COOLDOWN
	40: SUB_DOLLY_CAM_TOOL_STRINGS
	41: SUB_DOLLY_CAM_ACTIVATED
	42: SUB_DOLLY_CAM_DEACTIVATED
}

disabled rule("DOLLY CAM TOOL")
{
	event
	{
		Ongoing - Global;
	}
}

rule("DOLLY CAM TOOL: Create Dolly Cam HUD")
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
		"[0] - DOLLY CAMERA SETUP HUD"
		Create HUD Text(Global.VAR_DOLLY_CAM_HUD_ARRAY[0], Custom String("CURRENT TOOL: {0}", Global.VAR_DOLLY_CAM_TOOLS_STRING), Null,
			Null, Top, 0, Color(White), Color(White), Color(White), Visible To and String, Default Visibility);
		Create HUD Text(Global.VAR_DOLLY_CAM_HUD_ARRAY[0], Null, Null, Custom String("{0} + {1} / {2} - Cycle Between Tools",
			Input Binding String(Button(Reload)), Input Binding String(Button(Secondary Fire)), Input Binding String(Button(
			Primary Fire))), Top, 1, Color(White), Color(White), Color(White), Visible To and String, Default Visibility);
		"[0] - DOLLY CAMERA SETUP HUD"
		Create HUD Text(Global.VAR_DOLLY_CAM_HUD_ARRAY[0], Null, Null, Custom String("\n \n \n \n \n \n \n \n",
			Global.VAR_DOLLY_CAM_OPTION_STRING), Top, 3, Color(White), Color(White), Color(White), Visible To and String,
			Default Visibility);
		"[1] - DOLLY CAMERA PLACEMENT TOOL"
		Create HUD Text(Global.VAR_DOLLY_CAM_HUD_ARRAY[1], Null, Null, Custom String(
			"{0} / {1} - Cycle Between Dolly Cameras  \n{2} - Place Dolly Camera", Input Binding String(Button(Secondary Fire)),
			Input Binding String(Button(Primary Fire)), Input Binding String(Button(Ultimate))), Left, 0, Color(White), Color(White),
			Color(White), Visible To and String, Default Visibility);
		Create HUD Text(Global.VAR_DOLLY_CAM_HUD_ARRAY[1], Null, Null, Custom String("CURRENT DOLLY CAMERA: #{0}",
			Global.VAR_DOLLY_CAM_CURRENT), Top, 4, Color(White), Color(White), Color(White), Visible To and String, Default Visibility);
		"[2] - BLEND SPEED TOOL"
		Create HUD Text(Global.VAR_DOLLY_CAM_HUD_ARRAY[2], Null, Null, Custom String(
			"{0} - Increase Blend Speed \n{1} - Decrease Blend Speed ", Input Binding String(Button(Secondary Fire)), Input Binding String(
			Button(Primary Fire))), Left, 0, Color(White), Color(White), Color(White), Visible To and String, Default Visibility);
		Create HUD Text(Global.VAR_DOLLY_CAM_HUD_ARRAY[2], Null, Null, Custom String("Blend Speed: {0}", Global.VAR_DOLLY_CAM_BLEND_SPEED),
			Top, 4, Color(White), Color(White), Color(White), Visible To and String, Default Visibility);
		"[3] - AUTO-SWITCH CAMERA TOOL"
		Create HUD Text(Global.VAR_DOLLY_CAM_HUD_ARRAY[3], Null, Null, Custom String("{0} - Extend Time \n{1} - Shorten Time",
			Input Binding String(Button(Secondary Fire)), Input Binding String(Button(Primary Fire))), Left, 0, Color(White), Color(White),
			Color(White), Visible To and String, Default Visibility);
		Create HUD Text(Global.VAR_DOLLY_CAM_HUD_ARRAY[3], Null, Null, Custom String("Auto-Switch Wait Time: {0}",
			Global.VAR_DOLLY_CAM_AUTOSWITCH_WAIT), Top, 4, Color(White), Color(White), Color(White), Visible To and String,
			Default Visibility);
		"[5] - DOLLY CAMERA GLOBAL HUD"
		Create HUD Text(Global.VAR_DOLLY_CAM_HUD_ARRAY[5], Null, Null, Custom String("{0} + {1} - Toggle Dolly Camera",
			Input Binding String(Button(Melee)), Input Binding String(Button(Ultimate))), Top, 2, Color(White), Color(White), Color(White),
			Visible To and String, Default Visibility);
		"[4] - DOLLY CAMERA HUD"
		Create HUD Text(Global.VAR_DOLLY_CAM_HUD_ARRAY[4], Null, Null, Custom String(
			"\n\n\n\n                                        ¯¯\\\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        _/"),
			Left, 0, Color(White), Color(White), Color(White), Visible To and String, Default Visibility);
		Create HUD Text(Global.VAR_DOLLY_CAM_HUD_ARRAY[4], Null, Null, Custom String("CURRENT DOLLY CAMERA: #{0}",
			Global.VAR_DOLLY_CAM_CURRENT), Top, 2, Color(White), Color(White), Color(White), Visible To and String, Default Visibility);
		Create HUD Text(Global.VAR_DOLLY_CAM_HUD_ARRAY[4], Null, Null, Custom String(
			"\n\n\n\n/¯¯                                        \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\\_                                        "),
			Right, 0, Color(White), Color(White), Color(White), Visible To and String, Default Visibility);
	}
}

rule("DOLLY CAM TOOL: SHOW HUD")
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
		Global.VAR_DOLLY_CAM_HUD_ARRAY[0] = Event Player;
		Global.VAR_DOLLY_CAM_HUD_ARRAY[5] = Event Player;
		Call Subroutine(SUB_DOLLY_CAM_TOOL_STRINGS);
	}
}

rule("DOLLY CAM TOOL: HIDE HUD")
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
		Global.VAR_DOLLY_CAM_HUD_ARRAY[0] = Null;
		Global.VAR_DOLLY_CAM_HUD_ARRAY[1] = Null;
		Global.VAR_DOLLY_CAM_HUD_ARRAY[2] = Null;
		Global.VAR_DOLLY_CAM_HUD_ARRAY[3] = Null;
		Global.VAR_DOLLY_CAM_HUD_ARRAY[4] = Null;
		Global.VAR_DOLLY_CAM_HUD_ARRAY[5] = Null;
	}
}

rule("DOLLY CAM TOOL SUBROUTINE: CURRENT TOOL STRINGS")
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
			Global.VAR_DOLLY_CAM_HUD_ARRAY[1] = Null;
			Global.VAR_DOLLY_CAM_HUD_ARRAY[2] = Null;
			Global.VAR_DOLLY_CAM_HUD_ARRAY[3] = Null;
		Else If(Global.VAR_DOLLY_CAM_TOOLS == 1);
			Global.VAR_DOLLY_CAM_TOOLS_STRING = Custom String("Placing and Selection Tool");
			Global.VAR_DOLLY_CAM_HUD_ARRAY[1] = Event Player;
			Global.VAR_DOLLY_CAM_HUD_ARRAY[2] = Null;
			Global.VAR_DOLLY_CAM_HUD_ARRAY[3] = Null;
		Else If(Global.VAR_DOLLY_CAM_TOOLS == 2);
			Global.VAR_DOLLY_CAM_TOOLS_STRING = Custom String("Blend Speed Tool");
			Global.VAR_DOLLY_CAM_HUD_ARRAY[1] = Null;
			Global.VAR_DOLLY_CAM_HUD_ARRAY[2] = Event Player;
			Global.VAR_DOLLY_CAM_HUD_ARRAY[3] = Null;
		Else If(Global.VAR_DOLLY_CAM_TOOLS == 3);
			Global.VAR_DOLLY_CAM_TOOLS_STRING = Custom String("Auto-Next Camera Tool");
			Global.VAR_DOLLY_CAM_HUD_ARRAY[1] = Null;
			Global.VAR_DOLLY_CAM_HUD_ARRAY[2] = Null;
			Global.VAR_DOLLY_CAM_HUD_ARRAY[3] = Event Player;
		End;
	}
}

rule("DOLLY CAM TOOL: Cycle Between Tools")
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
	}
}

rule("DOLLY CAM TOOL: Cycle Between Values")
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
				Global.VAR_DOLLY_CAM_CURRENT += 1;
			"INCREASE DOLLY CAMERA BLEND SPEED"
			Else If(Global.VAR_DOLLY_CAM_TOOLS == 2);
				Chase Global Variable At Rate(VAR_DOLLY_CAM_BLEND_SPEED, 100, Global.VAR_DOLLY_CAM_VALUE_CHANGE_SPEED, Destination and Rate);
			"INCREASE WAIT TIME BEFORE SWITCHING TO NEXT DOLLY CAMERA"
			Else If(Global.VAR_DOLLY_CAM_TOOLS == 3);
				Chase Global Variable At Rate(VAR_DOLLY_CAM_AUTOSWITCH_WAIT, 20, Global.VAR_DOLLY_CAM_VALUE_CHANGE_SPEED, Destination and Rate);
			End;
		Else If(Is Button Held(Event Player, Button(Primary Fire)));
			"PREV DOLLY CAMERA"
			If(Global.VAR_DOLLY_CAM_TOOLS == 1);
				If(Global.VAR_DOLLY_CAM_CURRENT != 0);
					Global.VAR_DOLLY_CAM_CURRENT -= 1;
				End;
			"DECREASE DOLLY CAMERA BLEND SPEED"
			Else If(Global.VAR_DOLLY_CAM_TOOLS == 2);
				Chase Global Variable At Rate(VAR_DOLLY_CAM_BLEND_SPEED, 0, Global.VAR_DOLLY_CAM_VALUE_CHANGE_SPEED, Destination and Rate);
			"DECREASE WAIT TIME BEFORE SWITCHING TO NEXT DOLLY CAMERA"
			Else If(Global.VAR_DOLLY_CAM_TOOLS == 3);
				Chase Global Variable At Rate(VAR_DOLLY_CAM_AUTOSWITCH_WAIT, 0, Global.VAR_DOLLY_CAM_VALUE_CHANGE_SPEED, Destination and Rate);
			End;
		End;
		If(Global.VAR_DOLLY_CAM_TOOLS > 1);
			Global.VAR_DOLLY_CAM_VALUE_CHANGE_RATE = 0.250;
			Chase Global Variable At Rate(VAR_DOLLY_CAM_VALUE_CHANGE_SPEED, 20, Global.VAR_DOLLY_CAM_VALUE_CHANGE_RATE, Destination and Rate);
		End;
	}
}

rule("DOLLY CAM TOOL: Double Value Change Speed")
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

rule("DOLLY CAM TOOL: Halt Dolly Cam Setting Speed")
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
		Stop Chasing Global Variable(VAR_DOLLY_CAM_AUTOSWITCH_WAIT);
		Global.VAR_DOLLY_CAM_VALUE_CHANGE_SPEED = 0;
	}
}

rule("DOLLY CAM TOOL: Place Dolly Cam (On Foot)")
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
		Global.VAR_DOLLY_CAM_CURRENT_POS = Eye Position(Global.VAR_PLAYER_RACER);
		Global.VAR_DOLLY_CAM_CURRENT_FACE = Ray Cast Hit Position(Eye Position(Global.VAR_PLAYER_RACER), Eye Position(
			Global.VAR_PLAYER_RACER) + Facing Direction Of(Global.VAR_PLAYER_RACER) * 2, Global.VAR_PLAYER_RACER, All Players(All Teams),
			True);
		Global.VAR_DOLLY_CAM_POS_ARRAY[Global.VAR_DOLLY_CAM_CURRENT] = Global.VAR_DOLLY_CAM_CURRENT_POS;
		Global.VAR_DOLLY_CAM_FACE_ARRAY[Global.VAR_DOLLY_CAM_CURRENT] = Global.VAR_DOLLY_CAM_CURRENT_FACE;
		Play Effect(Global.VAR_PLAYER_RACER, Brigitte Repair Pack Armor Sound, Color(White), Eye Position(Global.VAR_PLAYER_RACER), 200);
	}
}

rule("DOLLY CAM TOOL: Trigger Dolly Cam")
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
		If(Global.VAR_DOLLY_CAM_POS_ARRAY != 0);
			"TURN OFF DOLLY CAM"
			If(Global.VAR_DOLLY_CAM_IS_ACTIVATED);
				Call Subroutine(SUB_DOLLY_CAM_DEACTIVATED);
				If(Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == True);
					Call Subroutine(SUB_VEH_CAMERA_START);
				Else;
					Stop Camera(All Players(All Teams));
				End;
			"TURN ON DOLLY CAM"
			Else;
				Small Message(Event Player, Custom String("  {0} Dolly Camera: ON  ", Icon String(Checkmark)));
				Global.VAR_DOLLY_CAM_IS_ACTIVATED = True;
			End;
			Call Subroutine(SUB_DOLLY_CAM_ACTIVATED);
			Call Subroutine(SUB_VEH_INPUT_FUNC_COOLDOWN);
		Else;
			Small Message(Event Player, Custom String("   {0} NO DOLLY CAMERAS WERE PLACED!  ", Icon String(Warning)));
		End;
	}
}

rule("DOLLY CAM TOOL SUBROUTINE: DOLLY CAMERA ACTIVATED")
{
	event
	{
		Subroutine;
		SUB_DOLLY_CAM_ACTIVATED;
	}

	actions
	{
		If(Global.VAR_DOLLY_CAM_IS_ACTIVATED == True);
			Global.VAR_DOLLY_CAM_HUD_ARRAY[0] = Null;
			Global.VAR_DOLLY_CAM_HUD_ARRAY[1] = Null;
			Global.VAR_DOLLY_CAM_HUD_ARRAY[2] = Null;
			Global.VAR_DOLLY_CAM_HUD_ARRAY[3] = Null;
			Global.VAR_DOLLY_CAM_HUD_ARRAY[4] = Event Player;
		Else;
			If(Event Player.VAR_PLAYER_RACER_INSIDE_VEHICLE == False);
				Global.VAR_DOLLY_CAM_HUD_ARRAY[0] = Event Player;
				Call Subroutine(SUB_DOLLY_CAM_TOOL_STRINGS);
			End;
			Global.VAR_DOLLY_CAM_HUD_ARRAY[4] = Null;
		End;
	}
}

rule("DOLLY CAM TOOL SUBROUTINE: DOLLY CAMERA DEACTIVATED")
{
	event
	{
		Subroutine;
		SUB_DOLLY_CAM_DEACTIVATED;
	}

	actions
	{
		Small Message(Event Player, Custom String("  {0} Dolly Camera: OFF  ", Icon String(Warning)));
		Global.VAR_DOLLY_CAM_IS_ACTIVATED = False;
	}
}

rule("DOLLY CAM TOOL: Activate Dolly Cam")
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
		Global.VAR_DOLLY_CAM_CURRENT_POS = Global.VAR_DOLLY_CAM_POS_ARRAY[Global.VAR_DOLLY_CAM_CURRENT];
		Global.VAR_DOLLY_CAM_CURRENT_FACE = Global.VAR_DOLLY_CAM_FACE_ARRAY[Global.VAR_DOLLY_CAM_CURRENT];
		Global.VAR_DOLLY_CAM_CURRENT = 0;
		Wait(0.016, Ignore Condition);
		Start Camera(All Players(All Teams), Global.VAR_DOLLY_CAM_CURRENT_POS, Global.VAR_DOLLY_CAM_CURRENT_FACE, 0);
		Start Camera(All Players(All Teams), Global.VAR_DOLLY_CAM_CURRENT_POS, Global.VAR_DOLLY_CAM_CURRENT_FACE,
			Global.VAR_DOLLY_CAM_BLEND_SPEED);
	}
}

rule("DOLLY CAM TOOL: Deactivate Dolly Camera if Player Entered the vehicle")
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

rule("DOLLY CAM TOOL: Deactivate Dolly Camera if Player Switched Camera Type inside the vehicle")
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

rule("DOLLY CAM TOOL: Dolly Cam Activated - Cycle Between Dolly Cameras")
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
		Global.VAR_DOLLY_CAM_AUTOSWITCH_WAIT <= 0.500;
		Global.VAR_DOLLY_CAM_CURRENT != Last Of(Global.VAR_DOLLY_CAM_POS_ARRAY);
		Is Button Held(Event Player, Button(Melee)) == False;
		(Is Button Held(Event Player, Button(Primary Fire)) || Is Button Held(Event Player, Button(Secondary Fire))) == True;
	}

	actions
	{
		If(Is Button Held(Event Player, Button(Secondary Fire)));
			Global.VAR_DOLLY_CAM_CURRENT += 1;
		Else If(Is Button Held(Event Player, Button(Primary Fire)));
			Global.VAR_DOLLY_CAM_CURRENT -= 1;
		End;
		Global.VAR_DOLLY_CAM_CURRENT_POS = Global.VAR_DOLLY_CAM_POS_ARRAY[Global.VAR_DOLLY_CAM_CURRENT];
		Global.VAR_DOLLY_CAM_CURRENT_FACE = Global.VAR_DOLLY_CAM_FACE_ARRAY[Global.VAR_DOLLY_CAM_CURRENT];
	}
}

rule("DOLLY CAM TOOL: Dolly Cam Activated - Auto Switch to Next Camera")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		Global.VAR_DOLLY_CAM_IS_ACTIVATED == True;
		Global.VAR_DOLLY_CAM_AUTOSWITCH_WAIT >= 0.500;
		Global.VAR_DOLLY_CAM_CURRENT != Last Of(Global.VAR_DOLLY_CAM_POS_ARRAY);
	}

	actions
	{
		Global.VAR_DOLLY_CAM_CURRENT += 1;
		Global.VAR_DOLLY_CAM_CURRENT_POS = Global.VAR_DOLLY_CAM_POS_ARRAY[Global.VAR_DOLLY_CAM_CURRENT];
		Global.VAR_DOLLY_CAM_CURRENT_FACE = Global.VAR_DOLLY_CAM_FACE_ARRAY[Global.VAR_DOLLY_CAM_CURRENT];
		Wait(Global.VAR_DOLLY_CAM_AUTOSWITCH_WAIT, Abort When False);
		Loop If Condition Is True;
	}
}
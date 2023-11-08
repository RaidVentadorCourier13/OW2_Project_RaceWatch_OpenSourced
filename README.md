# INTRODUCTION

The future of street racing re-starts here.

NOTE: Open-Sourced Build of the Project: RaceWatch workshop script was stripped from car models.

# Guide to Building Your Own Car for the "Project: RaceWatch" Workshop Script

First things first, download the following apps:

Visual Studio Code:
https://code.visualstudio.com

Blender: https://www.blender.org


# Once you downloaded and launched Blender:
1. Go to Edit and then Preferences
![image](https://user-images.githubusercontent.com/52705052/236925809-aed3c120-33b7-4996-b729-5df754615b9f.png)
2. Click on Add-ons section
3. Search for "Wavefront (Legacy)" add-on.
![image](https://user-images.githubusercontent.com/52705052/236926158-94972597-49d0-436c-9b92-19b8f3affde5.png)


# Once you downloaded and launched Visual Studio Code:
1. Click on Extensions Tab
2. Search for: "Overwatch Script To Workshop" by Deltin
3. Download the extension
![image](https://user-images.githubusercontent.com/52705052/236926500-6a312902-0af2-4d99-a58c-7ecab84d6778.png)

# Install the Deltinteger Server

For the import script I recommend using the: v2.0-beta. 13

1. Download the Deltinteger Server v2.0-beta. 13 from here: https://drive.google.com/file/d/1FznZU1QgQDYVIIuTbrqRNhqmuZUy-cIC/view?usp=sharing
2. Unpack the zip file contents.
3. Press CTRL + SHIFT and P and search for Locate the server installation.
4. Navigate to the location where you unpacked the Deltinteger Server, and search for the Deltinteger app.

It will take a while for the server to ping with OSTW.

If you'll notice the "Failed to Ping OSTW", try repeating Step 3.
![image](https://github.com/RaidVentadorCourier13/Project_Streetwatch_Open_Sourced/assets/52705052/534b1ab4-6f94-4738-8461-94858165d862)



# Part 1 - Building the car

In order to build your own car/the car you want, you need to get a 3D model reference.

Try searching Sketchfab for ex. for downloadable car model. I recommend searching for one that looks promising.

Download the car model in glTF format.
Make sure you have an account on Sketchfab, otherwise you won't be able to download the model.
Unzip the contents of downloaded file into another folder.

1. In Blender, click on File > Import > Select glTF
2. Navigate to the folder where you unpacked the contents of the car's zip file.

You can now start building the car's body.

Note: Overwatch Workshop has an effect cap of 128 effects.

And with the extension on, 256, which is enough for the model of your car that has over 128 edges.

Treat Edges as how much Beams the car model has.

Most of the cars that were created for the Master Build of the script contain from 200 to 230+ of beam effects.

You can display the Statistics of the car's model via Viewport Overlays.
![image](https://user-images.githubusercontent.com/52705052/236936270-99860281-1624-4026-98d6-6a03824671eb.png)

Use the Mirror modifier to save yourself a time building the car's body.

Make sure not to cross the cap of 230 of edges.

# Once you're done building your car:

PART the car into parts and NAME them into their respective names:

For ex. "SKYLINE_A", and on and on.

A - Front Bumper

B - Hood

C - Body

D - Trunk/Engine Hood

E - Rear Bumper

F - Headlighs

GL - Left Rear Light

GR - Right Rear Light

H - Nitrous

I - Carbon

ID - Drift Points

1. Make sure that ALL PARTS of your car's origin (Orange Dot) remains the same.

2. Copy ALL PARTS.

Blender has it's own separate clipboard for the models.

You can also, just in case, SAVE the model of your car.

PASTE your car into the PS_CAR_LEVELER_PLANE.blend file

Or if you saved your car, do the vice versa:

PASTE the Leveler Plane from PS_CAR_LEVELER_PLANE.blend file into the blend. file of your car model.

3. Select ALL PARTS of your car.
4. Resize your entire car to match the Leveler Plane's bounds (and height).

![image](https://user-images.githubusercontent.com/52705052/236936672-93f5379f-c54c-4d2f-acce-a935c20ff223.png)

# Part 2 - Porting the Cars

Inside the "A_YOUR_CAR_TEMPLATE" folder you should see various files with OBJ. and MTL. file extensions.

Lettered down from A to I:

1. A_FRONT_BUMPER
2. B_HOOD
3. C_BODY
4. D_ENGINE_HOOD
5. E_REAR_BUMPER
6. F_HEADLIGHTS
7. GL_REAR_LIGHT
8. GR_REAR_LIGHT
9. H_NITROUS
10. I_CARBON
11. ID_DRIFT

![image](https://user-images.githubusercontent.com/52705052/236927418-169230c1-810c-41b1-a913-6df501b63156.png)

Those are the parts of your car's model, which you're gonna need to port into the game.

Below all them, there's a del. file called: "Parted Car Import Script".

This del. file is crucial to be inside folder with car parts.

Otherwise OSTW won't be able to receive the points from the OBJ. models of the car's parts.

Open the del. file: Parted Car Import Script

In order to see and get the Script's Output:
Click on Terminal > New Terminal, and then for the Output select Workshop Code.
![image](https://user-images.githubusercontent.com/52705052/236928114-e1f8fa92-047f-4933-be22-8e81f90426cd.png)

You can see in the Output, that this Import Script has Empty Arrays. That's because the OBJ. models of the car's parts inside the A_YOUR_CAR_TEMPLATE folder are empty.
![image](https://github.com/RaidVentadorCourier13/Project_Streetwatch_Open_Sourced/assets/52705052/d217bb47-6e03-459b-8c3c-79c719f9374d)



# Example on a completed car template

You can use the completed car model inside the "B_COMPLETE_CAR_TEMPLATE" folder, as an example on how to build your car:

Inside the "B_COMPLETE_CAR_TEMPLATE" folder, there are two folders: Blend, and Wavefront (Legacy).
Blend folder contains the blend. file of a complete car model of Skyline R34 made for the script.
The Wavefront (Legacy) folder contains the parts of the car's model.

1. Open the 1_Skyline_R34 blend. file with Blender.
2. Switch the workspace to Layout.

If you take a look at the Statistics of the car's model, you can see, that the car has 262 Vertices, and 232 Edges.

3. Open and take a look at the del. file (Parted Car Import Script (Skyline R34)) inside the Visual Studio Code.

Notice that the Output of this Import Script is different. The folder where the Car Importing Script is contains OBJ. files that contain the data of your car's parts.
![image](https://github.com/RaidVentadorCourier13/Project_Streetwatch_Open_Sourced/assets/52705052/b145bb03-9a86-4dd5-9cc9-d8dfb4fdd30e)


4: Go back to Blender and Export the first part of the car model.

5: Select Front Bumper part of your car model and then Export the part as Wavefront (Legacy) OBJ. file.
![image](https://user-images.githubusercontent.com/52705052/236937095-bb23b00e-0bc5-4939-b2ce-4c7f5d7239a5.png)

6: Navigate the folder: A_YOUR_CAR_TEMPLATE

7: Make sure that Selection Only is checked when exporting the part as OBJ file.

8: Select/Highlight the respective car part's OBJ. file, and click on Export OBJ to replace it.

![image](https://user-images.githubusercontent.com/52705052/236937281-b4575d33-e2c1-49a7-a475-57359d5aaf61.png)

9: Go back to Visual Studio Code and check the output.

Notice, that the output has changed in Visual Studio Code for the Import Script inside the A_YOUR_CAR_TEMPLATE. Both VAR_VEH_MESH_VRTCS_FRONT_BUMPER, and VAR_VEH_MESH_EDGES_FRONT_BUMPER now contains the model's data, which OSTW has picked off.
![image](https://github.com/RaidVentadorCourier13/Project_Streetwatch_Open_Sourced/assets/52705052/a1c3db75-8136-40fe-89d0-2c79620ad457)

10: Go back to Blender and export the rest of the respective car parts.

When building your car you can optionally add Drift Points (ID_DRIFT)
![image](https://github.com/RaidVentadorCourier13/Project_Streetwatch_Open_Sourced/assets/52705052/93761f2e-75fe-4b1a-a147-a1397fa30a32)

# How do I port the cars into the game?

1. Open the "PROJECT_RACEWATCH_OPEN_SOURCED_BUILD.cs" file, placed in C_SCRIPT folder, in Visual Studio Code
2. Search for the rule named - #1 <CAR_01_NAME_HERE> (Mesh Array Tables)

3. Replace these Actions...

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

...by pasting the Workshop Code Output from Visual Studio Code

3a: Optionally, you can change the color value in the following (and highlighted) action to determine the car's default color:

Global.VAR_PLAYER_RACER.VAR_VEH_COLOR_DEFAULT = Color(Blue);
![ScreenShot_23-05-11_19-33-54-000](https://github.com/RaidVentadorCourier13/Project_Streetwatch_Open_Sourced/assets/52705052/5cf567c2-0264-44d8-abf6-7fd1dc0eb860)

4: Copy the entire script and paste it to Overwatch.

![ScreenShot_23-05-08_21-56-21-000](https://github.com/RaidVentadorCourier13/Project_Streetwatch_Open_Sourced/assets/52705052/d3de7109-f138-4e4a-9f0f-22917d84399d)

5: Launch the game.

![ScreenShot_23-05-08_22-00-58-000](https://github.com/RaidVentadorCourier13/Project_Streetwatch_Open_Sourced/assets/52705052/56d0a3bf-84ed-451f-8433-10a0b67be2a9)

You can now drive your own car which you created. Enjoy.

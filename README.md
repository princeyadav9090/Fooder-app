# Fooder-app
An AR based food ordering app

📦 Vuforia Installation Guide
This project uses the Vuforia Engine (v10.27.3) via Unity's Package Manager.

🔧 How to Install Vuforia
    1. Open the Unity project.
    2. Go to Edit > Project Settings > Package Manager.
    3. Under Scoped Registries, click the "+" button and enter:

       Name: Vuforia
       URL: https://registry.packages.vuforia.com/
       Scope(s): com.ptc.vuforia.engine

    4. Save the changes.
    5. Open Packages/manifest.json and add the Vuforia dependency:

       "dependencies": {
         "com.ptc.vuforia.engine": "10.27.3",
         // other dependencies...
       }

    6.Unity will automatically fetch and install the Vuforia package.
# Fooder-app
An AR based food ordering app

📦 Vuforia Installation Guide
This project uses the Vuforia Engine (v10.27.3) via Unity's Package Manager.

🔧 How to Install Vuforia
Open the Unity project.

Go to Edit > Project Settings > Package Manager.

Under Scoped Registries, click the "+" button and enter:

makefile -

Name: Vuforia
URL: https://registry.packages.vuforia.com/
Scope(s): com.ptc.vuforia.engine
Save the changes.

Open Packages/manifest.json and add the Vuforia dependency:

json -

"dependencies": {
  "com.ptc.vuforia.engine": "10.27.3",
  // other dependencies...
}
Unity will automatically fetch and install the Vuforia package.
# IHM Unity Server :

This repository contains the Unity server of the [IHM project](https://github.com/Manon-Arc/projetDev_IHM).

## 📌 Table of Contents :
   
I. [Badges](#🎯-badges)

II. [Prerequisites](#🔧-prerequisites-)

III. [Installation](#💻-how-to-install-the-project-)

## 🎯 Badges :

[![Csharp logo](https://img.shields.io/badge/Language-CSharp-green)](https://learn.microsoft.com/fr-fr/dotnet/csharp/)
[![Unity logo](https://img.shields.io/badge/Software-Unity-black)](https://unity.com/fr/)


## 🔧 Prerequisites :

- [Unity](https://unity.com/fr/download) installed on your system.

## 💻 How to Install the Project :

### 1. Installation :

- Clone the repo with the following command :
  ```bash
  git clone https://github.com/Manon-Arc/IHM_Unity.git
  ```

- Open the projet from [Unity](https://unity.com/fr/download)

- Desactivate your firewall with the following command :
```bash
netsh advfirewall set allprofiles state off
```
Or add a rule to autorized the TCP trafic on the port 50051 of your computer : <br>
[Check documentation here !](https://www.malekal.com/comment-ouvrir-port-pare-feu-windows-defender/)

### 2. Lauch :

- Press the following button :
    
![button](./Img/button.png)

➜ You will see : "Server listening on 0.0.0.0:50051"

😉 Enjoy !

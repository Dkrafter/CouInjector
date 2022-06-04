# CouInjector

[![CI](https://github.com/ByMynix/CouInjector/actions/workflows/main.yml/badge.svg)](https://github.com/ByMynix/CouInjector/actions/workflows/main.yml)
<a href="https://github.com/ByMynix/CouInjector/stargazers"><img alt="GitHub Stars" src="https://img.shields.io/github/stars/ByMynix/CouInjector"></a>
<a href="https://dsc.gg/bymynixde"><img alt="ByMynixDE Discord Server" src="https://img.shields.io/discord/908055039258550305?label=Discord&logo=Discord"></a> 
<a href="https://github.com/ByMynix/CouInjector/commits/master"><img alt="GitHub commit activity" src="https://img.shields.io/github/commit-activity/w/ByMynix/CouInjector"></a>
<img alt="Platform Windows" src="https://img.shields.io/badge/platform-Windows-0078d7.svg?style=plastic"></a>
<img alt="Game CS:GO" src="https://img.shields.io/badge/game-CS%3AGO-yellow.svg?style=plastic"></a>
<a href="https://www.paypal.com/paypalme/bymynix"><img alt="PayPal" src="https://img.shields.io/badge/donate-PayPal-104098.svg?style=plastic&logo=PayPal"></a>



![CouInjector-Picture](https://bymynix.de/couinjector/assets/images/couinjector-picture-412x242.png)
 
[https://bymynix.de/couinjector/]
CouInjector (formerly MadInjector) is an injector for CS:GO. It's an open-source project since 11.09.2021 and no longer closed-source. From the 29.05.2022 it's a real Git project, as the previous versions consisted of a file structure and I was too lazy to make the effort.




# Compile
In this project "CouInjector" resources were embedded:

The resource "Injection", i.e. the injection file ([Branch-Injection](https://github.com/ByMynix/CouInjector/tree/CouInjector-Injection)).

The resource "Updater", a console application as auto-updater ([Branch-Auto-Updater](https://github.com/ByMynix/CouInjector/tree/CouInjector-Auto-Updater)), which takes care of automatic updates.

The resource "VAC-ByPass", i.e. the VAC-ByPass file ([Branch-VAC-ByPass](https://github.com/ByMynix/CouInjector/tree/CouInjector-VAC-ByPass)).

These three resources, which are already embedded in "CouInjector" can of course be replaced by compiling the three applications mentioned and then embedding them as resources.


Compile it in Release / x86









# Previous versions
Please note that up to version 1.9 there is a file structure and it is not a single, let alone one Visual Studio project, which cannot be compiled in a simple way to use. From version 2.0 onwards, it is without a Setup Compiler and "CouInjector" can be easily compiled.

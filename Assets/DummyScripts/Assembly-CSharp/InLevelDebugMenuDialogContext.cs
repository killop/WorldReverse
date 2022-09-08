﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using Newtonsoft.Json.Linq;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class InLevelDebugMenuDialogContext : BaseDialogContext // TypeDefIndex: 28620
{
	// Fields
	private bool _mihoyoBuildConsoleShow; // 0x178
	private MonoInLevelDebugMenuDialog _dialogMono; // 0x180
	private PostProcessLayer _postProcessLayer; // 0x188
	private bool _inLoginShow; // 0x190
	private List<string> _candSkillDepotIds; // 0x198
	private string _preStr; // 0x1A0
	private bool _isHoldCamera; // 0x1A8
	private GameObject _hierarchyPrefab; // 0x1B0
	private int _commandIndex; // 0x1B8
	private int _categoryIndex; // 0x1BC
	private List<string> _commandCategory; // 0x1C0
	private List<string> _commandList; // 0x1C8
	private JObject _jCommands; // 0x1D0
	private static int _backupTargetFrameRate; // 0x00
	private GameObject HDRTestDialog; // 0x1D8
	private const string HDR_PATH = "ART/UI/UIScene/HDRUIManager"; // Metadata: 0x00B0DA38
	private static int _testCount; // 0x04
	public static bool musicLayoutTest; // 0x08
	private static List<string> _sceneNameList; // 0x10
	private static List<uint> _sceneIdLsit; // 0x18

	// Constructors
	public InLevelDebugMenuDialogContext() {} // Dummy constructor
	public InLevelDebugMenuDialogContext(bool inLoginShow = false /* Metadata: 0x00B0DA37 */) {} // 0x000000018128BFB0-0x000000018128C0D0
	static InLevelDebugMenuDialogContext() {} // 0x000000018128BE50-0x000000018128BFB0

	// Methods
	// [XID] // 0x0000000189A4C7A0-0x0000000189A4C7C0
	public override void SetupView() {} // 0x000000018128BC70-0x000000018128BE50
	// [XID] // 0x0000000189A53F80-0x0000000189A53FA0
	private void InitControl() {} // 0x000000018127E510-0x0000000181281EA0
	// [XID] // 0x0000000189A5B990-0x0000000189A5B9B0
	private void ShowGraphicsSetting() {} // 0x0000000181289090-0x0000000181289D30
	// [XID] // 0x0000000189A63080-0x0000000189A630A0
	private void ShowPlayerInfo() {} // 0x0000000181285590-0x00000001812858E0
	// [XID] // 0x0000000189A6ABE0-0x0000000189A6AC00
	private void InitSkillDepotId() {} // 0x000000018127DF10-0x000000018127E440
	// [XID] // 0x0000000189A722A0-0x0000000189A722C0
	private void OnSkillDepotId(int index) {} // 0x0000000181284FF0-0x00000001812853A0
	// [XID] // 0x0000000189A79F00-0x0000000189A79F20
	private void UpdateOpinionText() {} // 0x0000000181288F30-0x0000000181289090
	// [XID] // 0x0000000189A81380-0x0000000189A813A0
	public override void ClearView() {} // 0x000000018127B810-0x000000018127CC00
	// [XID] // 0x0000000189A88D80-0x0000000189A88DA0
	private void MoveInfo() {} // 0x0000000181285D30-0x0000000181285EC0
	// [XID] // 0x0000000189A90530-0x0000000189A90550
	private void Combat() {} // 0x000000018127CC00-0x000000018127CD90
	// [XID] // 0x0000000189A97DC0-0x0000000189A97DE0
	private void DumpLocalSetting() {} // 0x000000018127A380-0x000000018127A580
	// [XID] // 0x0000000189A9F150-0x0000000189A9F170
	private void ClearAll() {} // 0x000000018127AF90-0x000000018127B1F0
	// [XID] // 0x0000000189AA6A10-0x0000000189AA6A30
	private void ClearLocalSetting() {} // 0x000000018127DA70-0x000000018127DB10
	// [XID] // 0x0000000189AAE100-0x0000000189AAE120
	private void OnGotoRenderingDebug() {} // 0x000000018128B970-0x000000018128BB00
	// [XID] // 0x0000000189AB59D0-0x0000000189AB59F0
	private void OnGrassViewRangeSetting() {} // 0x000000018127A8A0-0x000000018127AA30
	// [XID] // 0x0000000189ABD3D0-0x0000000189ABD3F0
	private void OnGraphicsSetting() {} // 0x00000001812858E0-0x0000000181285A70
	// [XID] // 0x0000000189AC4E00-0x0000000189AC4E20
	private void OnHideShowObj() {} // 0x000000018128A6A0-0x000000018128A830
	// [XID] // 0x0000000189ACC460-0x0000000189ACC480
	private void OnShowBudget() {} // 0x000000018128A9C0-0x000000018128AB50
	// [XID] // 0x0000000189AD40A0-0x0000000189AD40C0
	private void ToggleEnableHoldCamera() {} // 0x0000000181284600-0x00000001812847C0
	// [XID] // 0x0000000189ADBAA0-0x0000000189ADBAC0
	private void ToggleEnableFrameCapture() {} // 0x00000001812873B0-0x0000000181287560
	// [XID] // 0x0000000189AE3400-0x0000000189AE3420
	private void AndroidSwitchVulkan() {} // 0x0000000181284820-0x00000001812849D0
	// [XID] // 0x0000000189AEAD90-0x0000000189AEADB0
	private void OpenHierarchyPanel() {} // 0x000000018128AF20-0x000000018128B110
	// [XID] // 0x0000000189AF2660-0x0000000189AF2680
	private void OnResetPos() {} // 0x000000018128A360-0x000000018128A540
	// [XID] // 0x0000000189AFA020-0x0000000189AFA040
	private void InitAllCommands() {} // 0x00000001812828D0-0x0000000181282CB0
	// [XID] // 0x0000000189B01550-0x0000000189B01570
	private void OnSelectCommand(int index) {} // 0x0000000181282050-0x0000000181282100
	// [XID] // 0x0000000189B08AA0-0x0000000189B08AC0
	private void OnSelectCategory(int index) {} // 0x0000000181287890-0x0000000181287C30
	// [XID] // 0x0000000189B10460-0x0000000189B10480
	private void SendCommand() {} // 0x0000000181285A70-0x0000000181285CD0
	// [XID] // 0x0000000189B17560-0x0000000189B17580
	private void OnGrassTest(int mode) {} // 0x0000000181288930-0x0000000181288AB0
	// [XID] // 0x0000000189B1EE80-0x0000000189B1EEA0
	private void OnDevLevel() {} // 0x000000018127B2B0-0x000000018127B440
	// [XID] // 0x0000000189B267F0-0x0000000189B26810
	private void OnAITool() {} // 0x0000000181284410-0x00000001812845A0
	// [XID] // 0x0000000189B2DA00-0x0000000189B2DA20
	private void OnGMTalk() {} // 0x00000001812849D0-0x0000000181284AA0
	// [XID] // 0x0000000189B34E20-0x0000000189B34E40
	private void OnDeviceMemory() {} // 0x000000018127B5D0-0x000000018127B750
	// [XID] // 0x0000000189B3C6F0-0x0000000189B3C710
	private void OnCloseFps() {} // 0x0000000181289FD0-0x000000018128A1B0
	// [XID] // 0x0000000189B443F0-0x0000000189B44410
	private void OnLowFPSTest() {} // 0x000000018128A540-0x000000018128A6A0
	// [XID] // 0x0000000189B4BA80-0x0000000189B4BAA0
	private void OnOptimizeConsole() {} // 0x00000001812868C0-0x00000001812869B0
	// [XID] // 0x0000000189B53030-0x0000000189B53050
	private void ToggleEnablePhysxLog() {} // 0x000000018127DB10-0x000000018127DCD0
	// [XID] // 0x0000000189B5A9E0-0x0000000189B5AA00
	private void OnLODControl() {} // 0x0000000181286C00-0x0000000181286D90
	// [XID] // 0x0000000189B61E70-0x0000000189B61E90
	private void OnMemInfo() {} // 0x0000000181281EA0-0x0000000181281F90
	// [XID] // 0x0000000189B69B20-0x0000000189B69B40
	private void OnWeather() {} // 0x00000001812869B0-0x0000000181286B40
	// [XID] // 0x0000000189B710C0-0x0000000189B710E0
	private void OnCameraDebug() {} // 0x000000018127B440-0x000000018127B5D0
	// [XID] // 0x0000000189B78690-0x0000000189B786B0
	private void OnAvatarSetting() {} // 0x0000000181283170-0x0000000181283300
	// [XID] // 0x0000000189B7FC50-0x0000000189B7FC70
	private void OnTeamSetting() {} // 0x0000000181288480-0x00000001812885B0
	// [XID] // 0x0000000189B876C0-0x0000000189B876E0
	private void OnNpcTest() {} // 0x000000018128AC70-0x000000018128AE00
	// [XID] // 0x0000000189B8E830-0x0000000189B8E850
	private void OnThreadEnableToggle() {} // 0x0000000181285F20-0x0000000181286050
	// [XID] // 0x0000000189B95D10-0x0000000189B95D30
	private void OnThreadDebugToggle() {} // 0x000000018127D1F0-0x000000018127D2A0
	// [XID] // 0x0000000189B9D250-0x0000000189B9D270
	private void OnThreadTestToggle() {} // 0x000000018127D560-0x000000018127D610
	// [XID] // 0x0000000189BA4C10-0x0000000189BA4C30
	private void OnAudioDebug() {} // 0x00000001812853A0-0x0000000181285530
	// [XID] // 0x0000000189BABF30-0x0000000189BABF50
	private void OnToggleTextureStreaming() {} // 0x000000018127AA30-0x000000018127ABC0
	// [XID] // 0x0000000189BB35E0-0x0000000189BB3600
	private void ToggleMiHoYoBuildConsole() {} // 0x000000018127DCD0-0x000000018127DD80
	// [XID] // 0x0000000189BBAC00-0x0000000189BBAC20
	private void ToggleFocusMode() {} // 0x0000000181287630-0x00000001812877C0
	// [XID] // 0x0000000189BC2BD0-0x0000000189BC2BF0
	private void TogglePutawayWeapon() {} // 0x000000018127AC20-0x000000018127AE00
	// [XID] // 0x0000000189BCA2E0-0x0000000189BCA300
	private void ToggleShowHideWeapon() {} // 0x0000000181286460-0x0000000181286640
	// [XID] // 0x0000000189BD1970-0x0000000189BD1990
	private void ToggleOpinion() {} // 0x0000000181282F90-0x0000000181283170
	// [XID] // 0x0000000189BD8F60-0x0000000189BD8F80
	private void ToggleOpinionSwitch() {} // 0x000000018128A210-0x000000018128A360
	// [XID] // 0x00000001895E5AE0-0x00000001895E5B00
	private void ToggleUSpider() {} // 0x000000018127D3D0-0x000000018127D560
	// [XID] // 0x00000001895ED450-0x00000001895ED470
	private void ToggleCrashTest() {} // 0x000000018127CF60-0x000000018127D000
	// [XID] // 0x00000001895F4B50-0x00000001895F4B70
	private void ToggleExtAssets() {} // 0x0000000181284AA0-0x0000000181284C30
	// [XID] // 0x00000001895FC260-0x00000001895FC280
	private void OnPlusSpeed(bool plus) {} // 0x0000000181286ED0-0x0000000181287150
	// [XID] // 0x0000000189603C60-0x0000000189603C80
	private void OnResetAvatarSpeed() {} // 0x0000000181284DA0-0x0000000181284FF0
	// [XID] // 0x000000018960B5A0-0x000000018960B5C0
	private void OnUISetting() {} // 0x00000001812827B0-0x00000001812828D0
	// [XID] // 0x00000001896129D0-0x00000001896129F0
	private void OnCook() {} // 0x000000018128BB00-0x000000018128BC10
	// [XID] // 0x000000018961A300-0x000000018961A320
	private void OnHDR() {} // 0x00000001812823B0-0x0000000181282550
	[DebuggerHidden] // 0x0000000189621850-0x0000000189621890
	// [XID] // 0x0000000189621850-0x0000000189621890
	private IEnumerator CloseHDRDialog() => default; // 0x0000000181286640-0x0000000181286710
	// [XID] // 0x000000018962BE30-0x000000018962BE50
	private void OnCombine() {} // 0x000000018128B1D0-0x000000018128B2E0
	// [XID] // 0x0000000189633970-0x0000000189633990
	private void OnForge() {} // 0x0000000181288730-0x0000000181288840
	// [XID] // 0x000000018963B290-0x000000018963B2B0
	private void OnExplore() {} // 0x0000000181289D30-0x0000000181289E40
	// [XID] // 0x00000001896429C0-0x00000001896429E0
	private void OnNpcHead() {} // 0x000000018128B2E0-0x000000018128B660
	// [XID] // 0x000000018964A0D0-0x000000018964A0F0
	private void OnChat() {} // 0x000000018127A580-0x000000018127A690
	// [XID] // 0x0000000189651790-0x00000001896517B0
	private void OnMonthlyCard() {} // 0x0000000181289E40-0x0000000181289FD0
	// [XID] // 0x0000000189658FB0-0x0000000189658FD0
	private void OnCodex() {} // 0x0000000181287C30-0x0000000181287D20
	// [XID] // 0x0000000189660680-0x00000001896606A0
	private void OnAntiAddict() {} // 0x0000000181282100-0x00000001812822F0
	// [XID] // 0x0000000189667FE0-0x0000000189668000
	private void OnReputation() {} // 0x0000000181286DF0-0x0000000181286ED0
	// [XID] // 0x000000018966FA80-0x000000018966FAA0
	private void OnHomeworld() {} // 0x0000000181283300-0x0000000181283450
	// [XID] // 0x00000001896773A0-0x00000001896773C0
	private void OnMusicGame() {} // 0x000000018127A690-0x000000018127A760
	// [XID] // 0x000000018967E910-0x000000018967E930
	private void OnVideoTest() {} // 0x000000018127CDF0-0x000000018127CF60
	// [XID] // 0x00000001896861C0-0x00000001896861E0
	private void ToggleInputMonitor() {} // 0x000000018127D8F0-0x000000018127DA70
	// [XID] // 0x000000018968DFD0-0x000000018968DFF0
	private void OnReturn() {} // 0x0000000181283450-0x00000001812835C0
	// [XID] // 0x0000000189695920-0x0000000189695940
	private void OnLeave() {} // 0x0000000181286710-0x00000001812867F0
	// [XID] // 0x000000018969CFB0-0x000000018969CFD0
	private void SelectAvatarInHierarchy() {} // 0x000000018127D610-0x000000018127D6B0
	// [XID] // 0x00000001896A4280-0x00000001896A42A0
	private void OnPaimonTest() {} // 0x000000018128A830-0x000000018128A9C0
	// [XID] // 0x00000001896AB840-0x00000001896AB860
	private void OnStreamTest() {} // 0x000000018127DD80-0x000000018127DF10
	// [XID] // 0x00000001896B2A70-0x00000001896B2A90
	private void OnCloudGamePara() {} // 0x000000018127A030-0x000000018127A380
	// [XID] // 0x00000001896BA220-0x00000001896BA240
	public void UpdateServerSwitch() {} // 0x0000000181284250-0x00000001812843B0
	// [XID] // 0x00000001896C1490-0x00000001896C14B0
	private void SetupServerSwitchDrop() {} // 0x00000001812860B0-0x0000000181286460
	// [XID] // 0x00000001896C8B50-0x00000001896C8B70
	private void OnServerSwitchSelect(int index) {} // 0x0000000181283C20-0x0000000181283FD0
	// [XID] // 0x00000001896D0580-0x00000001896D05A0
	private void EnableFly(bool enable) {} // 0x00000001812885B0-0x00000001812886D0
	// [XID] // 0x00000001896D7A40-0x00000001896D7A60
	private void EnableLimitRegion(bool enable) {} // 0x00000001812825C0-0x00000001812826D0
	// [XID] // 0x00000001896DF2E0-0x00000001896DF300
	private void EnableTransport(bool enable) {} // 0x0000000181288270-0x0000000181288360
	// [XID] // 0x00000001896E6710-0x00000001896E6730
	private void EnableTime(bool enable) {} // 0x0000000181288360-0x0000000181288480
	// [XID] // 0x00000001896EDC40-0x00000001896EDC60
	private void EnableWeather(bool enable) {} // 0x0000000181288AB0-0x0000000181288BD0
	// [XID] // 0x00000001896F5470-0x00000001896F5490
	private void EnableSkill(bool enable) {} // 0x00000001812826D0-0x00000001812827B0
	// [XID] // 0x00000001896FCC70-0x00000001896FCC90
	private void EnableForbidTransmit(bool enable) {} // 0x0000000181283FD0-0x00000001812840B0
	// [XID] // 0x0000000189704150-0x0000000189704170
	private void OnServerSwitch() {} // 0x00000001812835C0-0x0000000181283C20
	// [XID] // 0x000000018970BA00-0x000000018970BA20
	private void ToggleShowHideSafeArea() {} // 0x0000000181282DF0-0x0000000181282ED0
	// [XID] // 0x00000001897132D0-0x00000001897132F0
	private void ScanCode() {} // 0x000000018128AB50-0x000000018128AC70
	// [XID] // 0x000000018971AB10-0x000000018971AB30
	private void RefreshTestScene() {} // 0x0000000181287D20-0x0000000181288200
	// [XID] // 0x0000000189721E10-0x0000000189721E30
	private void JumpCurSelectScene() {} // 0x0000000181287150-0x0000000181287350
	// [XID] // 0x0000000189729520-0x0000000189729540
	private void JumpScene(uint sceneID) {} // 0x0000000181288CA0-0x0000000181288E10
}


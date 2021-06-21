using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Define;
using Il2CppDummyDll;
using Loader;
using RF5SHOP;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x0200040F RID: 1039
[Token(Token = "0x200032C")]
public class AdvMain : MonoBehaviour
{
	// Token: 0x17000430 RID: 1072
	// (get) Token: 0x0600180F RID: 6159 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001810 RID: 6160 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170003C6")]
	public static AdvMain Instance
	{
		[Token(Token = "0x600156C")]
		[Address(RVA = "0x1D5D800", Offset = "0x1D5D901", VA = "0x1D5D800")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D6C0", Offset = "0x19D7C1")]
		get
		{
			return null;
		}
		[Token(Token = "0x600156D")]
		[Address(RVA = "0x1D5D850", Offset = "0x1D5D951", VA = "0x1D5D850")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D6D0", Offset = "0x19D7D1")]
		private set
		{
		}
	}

	// Token: 0x17000431 RID: 1073
	// (get) Token: 0x06001811 RID: 6161 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001812 RID: 6162 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170003C7")]
	public AdvDialogControl advDialogControl
	{
		[Token(Token = "0x600156E")]
		[Address(RVA = "0x1D5D8B0", Offset = "0x1D5D9B1", VA = "0x1D5D8B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D6E0", Offset = "0x19D7E1")]
		get
		{
			return null;
		}
		[Token(Token = "0x600156F")]
		[Address(RVA = "0x1D5D8C0", Offset = "0x1D5D9C1", VA = "0x1D5D8C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D6F0", Offset = "0x19D7F1")]
		private set
		{
		}
	}

	// Token: 0x06001813 RID: 6163 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001570")]
	[Address(RVA = "0x1D5D8D0", Offset = "0x1D5D9D1", VA = "0x1D5D8D0")]
	public List<int> DontDestoryNpcList()
	{
		return null;
	}

	// Token: 0x06001814 RID: 6164 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001571")]
	[Address(RVA = "0x1D5D8F0", Offset = "0x1D5D9F1", VA = "0x1D5D8F0")]
	public void TimelineMsgListClear()
	{
	}

	// Token: 0x06001815 RID: 6165 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001572")]
	[Address(RVA = "0x1D5D950", Offset = "0x1D5DA51", VA = "0x1D5D950")]
	public void AddTimelineMsg(TimelineMsg tmsg)
	{
	}

	// Token: 0x06001816 RID: 6166 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001573")]
	[Address(RVA = "0x1D5D9C0", Offset = "0x1D5DAC1", VA = "0x1D5D9C0")]
	public void ShowTimelineMsg(TimelineMsgID msgId)
	{
	}

	// Token: 0x06001817 RID: 6167 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001574")]
	[Address(RVA = "0x1D5DB60", Offset = "0x1D5DC61", VA = "0x1D5DB60")]
	private void Awake()
	{
	}

	// Token: 0x06001818 RID: 6168 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001575")]
	[Address(RVA = "0x1D5DDD0", Offset = "0x1D5DED1", VA = "0x1D5DDD0")]
	private void Start()
	{
	}

	// Token: 0x06001819 RID: 6169 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001576")]
	[Address(RVA = "0x1D5DE80", Offset = "0x1D5DF81", VA = "0x1D5DE80")]
	public string GetCurrentScriptName()
	{
		return null;
	}

	// Token: 0x0600181A RID: 6170 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001577")]
	[Address(RVA = "0x1D5DEA0", Offset = "0x1D5DFA1", VA = "0x1D5DEA0")]
	private void ReSearch(bool research)
	{
	}

	// Token: 0x0600181B RID: 6171 RVA: 0x0000A650 File Offset: 0x00008850
	[Token(Token = "0x6001578")]
	[Address(RVA = "0x1D5E0D0", Offset = "0x1D5E1D1", VA = "0x1D5E0D0")]
	public bool AdvStart(string filePath, NpcController npc, bool research = false)
	{
		return default(bool);
	}

	// Token: 0x0600181C RID: 6172 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001579")]
	[Address(RVA = "0x1D5EEF0", Offset = "0x1D5EFF1", VA = "0x1D5EEF0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19D700", Offset = "0x19D801")]
	private IEnumerator AdvStartWaitResult(string filePath, NpcController npc, bool research = false)
	{
		return null;
	}

	// Token: 0x0600181D RID: 6173 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600157A")]
	[Address(RVA = "0x1D5E440", Offset = "0x1D5E541", VA = "0x1D5E440")]
	public void AdvPreLoadStart(TextAsset textobj, string filePath, bool research = false)
	{
	}

	// Token: 0x0600181E RID: 6174 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600157B")]
	[Address(RVA = "0x1D5F7D0", Offset = "0x1D5F8D1", VA = "0x1D5F7D0")]
	public void AddPreLoadCount()
	{
	}

	// Token: 0x0600181F RID: 6175 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600157C")]
	[Address(RVA = "0x1D5F7E0", Offset = "0x1D5F8E1", VA = "0x1D5F7E0")]
	public void PreloadWait()
	{
	}

	// Token: 0x06001820 RID: 6176 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600157D")]
	[Address(RVA = "0x1D5F650", Offset = "0x1D5F751", VA = "0x1D5F650")]
	public void AdvPreLoadEnd()
	{
	}

	// Token: 0x06001821 RID: 6177 RVA: 0x0000A668 File Offset: 0x00008868
	[Token(Token = "0x600157E")]
	[Address(RVA = "0x1D5E060", Offset = "0x1D5E161", VA = "0x1D5E060")]
	public bool AdvEnd()
	{
		return default(bool);
	}

	// Token: 0x06001822 RID: 6178 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600157F")]
	[Address(RVA = "0x1D5DB50", Offset = "0x1D5DC51", VA = "0x1D5DB50")]
	public void SetForceText(string nametext, string chattext, bool timelineMsg)
	{
	}

	// Token: 0x06001823 RID: 6179 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001580")]
	[Address(RVA = "0x1D5FA60", Offset = "0x1D5FB61", VA = "0x1D5FA60")]
	public void SetForceText(string nametext, string chattext, bool timelineMsg, UnityAction callBackAction)
	{
	}

	// Token: 0x06001824 RID: 6180 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001581")]
	[Address(RVA = "0x1D5FB20", Offset = "0x1D5FC21", VA = "0x1D5FB20")]
	public void SetEndAction(UnityAction callBackAction)
	{
	}

	// Token: 0x06001825 RID: 6181 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001582")]
	[Address(RVA = "0x1D5FB30", Offset = "0x1D5FC31", VA = "0x1D5FB30")]
	public void SetForceTextAddSpeakerNpcId(string nametext, string chattext, bool timelineMsg, int speakerNpcId)
	{
	}

	// Token: 0x06001826 RID: 6182 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001583")]
	[Address(RVA = "0x1D5F940", Offset = "0x1D5FA41", VA = "0x1D5F940")]
	public void SetForceTextBase(string nametext, string chattext, bool timelineMsg, int speakerNpcId = -1)
	{
	}

	// Token: 0x06001827 RID: 6183 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001584")]
	[Address(RVA = "0x1D5FB40", Offset = "0x1D5FC41", VA = "0x1D5FB40")]
	public void AdvUpdate(NpcController npc)
	{
	}

	// Token: 0x06001828 RID: 6184 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001585")]
	[Address(RVA = "0x1D6E9D0", Offset = "0x1D6EAD1", VA = "0x1D6E9D0")]
	public void EventAdvFinish()
	{
	}

	// Token: 0x06001829 RID: 6185 RVA: 0x0000A680 File Offset: 0x00008880
	[Token(Token = "0x6001586")]
	[Address(RVA = "0x1D6EB10", Offset = "0x1D6EC11", VA = "0x1D6EB10")]
	public int GetAdvCostumeId(int charaId, int variationId)
	{
		return 0;
	}

	// Token: 0x0600182A RID: 6186 RVA: 0x0000A698 File Offset: 0x00008898
	[Token(Token = "0x6001587")]
	[Address(RVA = "0x1D60520", Offset = "0x1D60621", VA = "0x1D60520")]
	private AdvMain.WorkList ReadCommand(NpcController npc)
	{
		return AdvMain.WorkList.WORK_NONE;
	}

	// Token: 0x0600182B RID: 6187 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001588")]
	[Address(RVA = "0x1D6F0A0", Offset = "0x1D6F1A1", VA = "0x1D6F0A0")]
	public void onPauseEnd()
	{
	}

	// Token: 0x0600182C RID: 6188 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001589")]
	[Address(RVA = "0x1D6F0C0", Offset = "0x1D6F1C1", VA = "0x1D6F0C0")]
	public void TimelineEnd()
	{
	}

	// Token: 0x0600182D RID: 6189 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600158A")]
	[Address(RVA = "0x1D6F160", Offset = "0x1D6F261", VA = "0x1D6F160")]
	public void onReadText()
	{
	}

	// Token: 0x0600182E RID: 6190 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600158B")]
	[Address(RVA = "0x1D6F190", Offset = "0x1D6F291", VA = "0x1D6F190")]
	public void disableForceText()
	{
	}

	// Token: 0x0600182F RID: 6191 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600158C")]
	[Address(RVA = "0x1D60390", Offset = "0x1D60491", VA = "0x1D60390")]
	public void onTextWindowClick()
	{
	}

	// Token: 0x06001830 RID: 6192 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600158D")]
	[Address(RVA = "0x1D6F270", Offset = "0x1D6F371", VA = "0x1D6F270")]
	public void AdvSkip()
	{
	}

	// Token: 0x06001831 RID: 6193 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600158E")]
	[Address(RVA = "0x1D6F1A0", Offset = "0x1D6F2A1", VA = "0x1D6F1A0")]
	public void DisableForceText()
	{
	}

	// Token: 0x06001832 RID: 6194 RVA: 0x0000A6B0 File Offset: 0x000088B0
	[Token(Token = "0x600158F")]
	[Address(RVA = "0x1D6F310", Offset = "0x1D6F411", VA = "0x1D6F310")]
	public int OnSkip([Optional] bool? flag)
	{
		return 0;
	}

	// Token: 0x06001833 RID: 6195 RVA: 0x0000A6C8 File Offset: 0x000088C8
	[Token(Token = "0x6001590")]
	[Address(RVA = "0x1D6F3E0", Offset = "0x1D6F4E1", VA = "0x1D6F3E0")]
	public int GetSkipState()
	{
		return 0;
	}

	// Token: 0x06001834 RID: 6196 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001591")]
	[Address(RVA = "0x1D6F3F0", Offset = "0x1D6F4F1", VA = "0x1D6F3F0")]
	public void AdvStartByCmd(stCommand_t[] _cmdList, bool resetStep = true)
	{
	}

	// Token: 0x06001835 RID: 6197 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001592")]
	[Address(RVA = "0x1D6F650", Offset = "0x1D6F751", VA = "0x1D6F650")]
	public void SubMoveCharaCount()
	{
	}

	// Token: 0x06001836 RID: 6198 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001593")]
	[Address(RVA = "0x1D6ED60", Offset = "0x1D6EE61", VA = "0x1D6ED60")]
	public void UiHide()
	{
	}

	// Token: 0x06001837 RID: 6199 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001594")]
	[Address(RVA = "0x1D6F670", Offset = "0x1D6F771", VA = "0x1D6F670")]
	public void SetNamePlate(string nametext, bool moreThanLover = false)
	{
	}

	// Token: 0x06001838 RID: 6200 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001595")]
	[Address(RVA = "0x1D6EB40", Offset = "0x1D6EC41", VA = "0x1D6EB40")]
	private void SystemFadeIn(CommandList cmdId, int[] cmdArg)
	{
	}

	// Token: 0x06001839 RID: 6201 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001596")]
	[Address(RVA = "0x1D5EFA0", Offset = "0x1D5F0A1", VA = "0x1D5EFA0")]
	private void PlayerUnEquipForAdv()
	{
	}

	// Token: 0x0600183A RID: 6202 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001597")]
	[Address(RVA = "0x1D6F690", Offset = "0x1D6F791", VA = "0x1D6F690")]
	public void ForceEndWork()
	{
	}

	// Token: 0x0600183B RID: 6203 RVA: 0x0000A6E0 File Offset: 0x000088E0
	[Token(Token = "0x6001598")]
	[Address(RVA = "0x1D5F160", Offset = "0x1D5F261", VA = "0x1D5F160")]
	public int GetFesNpcId(int fesNpcId)
	{
		return 0;
	}

	// Token: 0x0600183C RID: 6204 RVA: 0x0000A6F8 File Offset: 0x000088F8
	[Token(Token = "0x6001599")]
	[Address(RVA = "0x1D5F560", Offset = "0x1D5F661", VA = "0x1D5F560")]
	public bool CanBathPartnerNpcId(int charCmdId, int npcId)
	{
		return default(bool);
	}

	// Token: 0x0600183D RID: 6205 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600159A")]
	[Address(RVA = "0x1D6EFB0", Offset = "0x1D6F0B1", VA = "0x1D6EFB0")]
	private void DoorClose(string door_name)
	{
	}

	// Token: 0x0600183E RID: 6206 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600159B")]
	[Address(RVA = "0x1D6F6B0", Offset = "0x1D6F7B1", VA = "0x1D6F6B0")]
	private void JudgeSeriousScripts(string scriptsName)
	{
	}

	// Token: 0x0600183F RID: 6207 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600159C")]
	[Address(RVA = "0x1D6FAC0", Offset = "0x1D6FBC1", VA = "0x1D6FAC0")]
	private void ChangeIsBedSkip(bool value)
	{
	}

	// Token: 0x06001840 RID: 6208 RVA: 0x0000A710 File Offset: 0x00008910
	[Token(Token = "0x600159D")]
	[Address(RVA = "0x1D6ECF0", Offset = "0x1D6EDF1", VA = "0x1D6ECF0")]
	private bool CheckBedSkipCommandID(int cmdId)
	{
		return default(bool);
	}

	// Token: 0x06001841 RID: 6209 RVA: 0x0000A728 File Offset: 0x00008928
	[Token(Token = "0x600159E")]
	[Address(RVA = "0x1D6FAD0", Offset = "0x1D6FBD1", VA = "0x1D6FAD0")]
	public bool CanBedSkip()
	{
		return default(bool);
	}

	// Token: 0x06001842 RID: 6210 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600159F")]
	[Address(RVA = "0x1D6FC90", Offset = "0x1D6FD91", VA = "0x1D6FC90")]
	public void DoBedSkip()
	{
	}

	// Token: 0x06001843 RID: 6211 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015A0")]
	[Address(RVA = "0x1D6FDF0", Offset = "0x1D6FEF1", VA = "0x1D6FDF0")]
	public void BedSkipEnd(float fadeTime = 0.5f)
	{
	}

	// Token: 0x06001844 RID: 6212 RVA: 0x0000A740 File Offset: 0x00008940
	[Token(Token = "0x60015A1")]
	[Address(RVA = "0x1D6FFC0", Offset = "0x1D700C1", VA = "0x1D6FFC0")]
	private bool CheckMessageID(int cmdId)
	{
		return default(bool);
	}

	// Token: 0x06001845 RID: 6213 RVA: 0x0000A758 File Offset: 0x00008958
	[Token(Token = "0x60015A2")]
	[Address(RVA = "0x1D6FFE0", Offset = "0x1D700E1", VA = "0x1D6FFE0")]
	private AdvMain.WorkList ReadCommand_TextChecker(NpcController npc)
	{
		return AdvMain.WorkList.WORK_NONE;
	}

	// Token: 0x06001846 RID: 6214 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015A3")]
	[Address(RVA = "0x1D71250", Offset = "0x1D71351", VA = "0x1D71250")]
	public AdvMain()
	{
	}

	// Token: 0x06001847 RID: 6215 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015A4")]
	[Address(RVA = "0x1D71380", Offset = "0x1D71481", VA = "0x1D71380")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D770", Offset = "0x19D871")]
	private void <ReadCommand>b__84_4()
	{
	}

	// Token: 0x06001848 RID: 6216 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015A5")]
	[Address(RVA = "0x1D71390", Offset = "0x1D71491", VA = "0x1D71390")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D780", Offset = "0x19D881")]
	private void <ReadCommand>b__84_5()
	{
	}

	// Token: 0x06001849 RID: 6217 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015A6")]
	[Address(RVA = "0x1D713A0", Offset = "0x1D714A1", VA = "0x1D713A0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D790", Offset = "0x19D891")]
	private void <ReadCommand>b__84_3()
	{
	}

	// Token: 0x0600184A RID: 6218 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015A7")]
	[Address(RVA = "0x1D713B0", Offset = "0x1D714B1", VA = "0x1D713B0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D7A0", Offset = "0x19D8A1")]
	private void <DoBedSkip>b__109_0()
	{
	}

	// Token: 0x04005BF6 RID: 23542
	[Token(Token = "0x400587D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1628F0", Offset = "0x1629F1")]
	private static AdvMain <Instance>k__BackingField;

	// Token: 0x04005BF7 RID: 23543
	[Token(Token = "0x400587E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x162900", Offset = "0x162A01")]
	private AdvDialogControl <advDialogControl>k__BackingField;

	// Token: 0x04005BF8 RID: 23544
	[Token(Token = "0x400587F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private ScriptWork scriptwork;

	// Token: 0x04005BF9 RID: 23545
	[Token(Token = "0x4005880")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Action completeFunc;

	// Token: 0x04005BFA RID: 23546
	[Token(Token = "0x4005881")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public UnityAction _endAction;

	// Token: 0x04005BFB RID: 23547
	[Token(Token = "0x4005882")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private ItemData BeforeEquipedTool;

	// Token: 0x04005BFC RID: 23548
	[Token(Token = "0x4005883")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool IsPCBattleModeRelease;

	// Token: 0x04005BFD RID: 23549
	[Token(Token = "0x4005884")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private GameObject EventTimelineObj;

	// Token: 0x04005BFE RID: 23550
	[Token(Token = "0x4005885")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private GameObject TimeLineObject;

	// Token: 0x04005BFF RID: 23551
	[Token(Token = "0x4005886")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool IsTimelineStartCalled;

	// Token: 0x04005C00 RID: 23552
	[Token(Token = "0x4005887")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public int IsTimelineEndWait;

	// Token: 0x04005C01 RID: 23553
	[Token(Token = "0x4005888")]
	private const int ScriptParamMax = 9;

	// Token: 0x04005C02 RID: 23554
	[Token(Token = "0x4005889")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool IsForceText;

	// Token: 0x04005C03 RID: 23555
	[Token(Token = "0x400588A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
	private bool IsAdvCreatedByCmd;

	// Token: 0x04005C04 RID: 23556
	[Token(Token = "0x400588B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private int advCmdCnt;

	// Token: 0x04005C05 RID: 23557
	[Token(Token = "0x400588C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private AdvMain.WorkList nextWork;

	// Token: 0x04005C06 RID: 23558
	[Token(Token = "0x400588D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private int ChangeSceneCount;

	// Token: 0x04005C07 RID: 23559
	[Token(Token = "0x400588E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private VariationNo playerVariation;

	// Token: 0x04005C08 RID: 23560
	[Token(Token = "0x400588F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private AdvMain.WorkList work;

	// Token: 0x04005C09 RID: 23561
	[Token(Token = "0x4005890")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private stCommand_t cmd;

	// Token: 0x04005C0A RID: 23562
	[Token(Token = "0x4005891")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private stCommand_t rndcmd;

	// Token: 0x04005C0B RID: 23563
	[Token(Token = "0x4005892")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private List<stCommand_t> cmdList;

	// Token: 0x04005C0C RID: 23564
	[Token(Token = "0x4005893")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private bool isWait;

	// Token: 0x04005C0D RID: 23565
	[Token(Token = "0x4005894")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	private float waitSec;

	// Token: 0x04005C0E RID: 23566
	[Token(Token = "0x4005895")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private float waitStartTime;

	// Token: 0x04005C0F RID: 23567
	[Token(Token = "0x4005896")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private TextWindow textWindow;

	// Token: 0x04005C10 RID: 23568
	[Token(Token = "0x4005897")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private NameWindow nameWindow;

	// Token: 0x04005C11 RID: 23569
	[Token(Token = "0x4005898")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private int isSkip;

	// Token: 0x04005C12 RID: 23570
	[Token(Token = "0x4005899")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	private bool IsCmdWait;

	// Token: 0x04005C13 RID: 23571
	[Token(Token = "0x400589A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private int SelectMenuCount;

	// Token: 0x04005C14 RID: 23572
	[Token(Token = "0x400589B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	private int SelectMenuTotalCount;

	// Token: 0x04005C15 RID: 23573
	[Token(Token = "0x400589C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private string seName;

	// Token: 0x04005C16 RID: 23574
	[Token(Token = "0x400589D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private string voiceName;

	// Token: 0x04005C17 RID: 23575
	[Token(Token = "0x400589E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private string[] JumpReserveScript;

	// Token: 0x04005C18 RID: 23576
	[Token(Token = "0x400589F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private int autoModeWaitCountMax;

	// Token: 0x04005C19 RID: 23577
	[Token(Token = "0x40058A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	private int autoModeWaitCount;

	// Token: 0x04005C1A RID: 23578
	[Token(Token = "0x40058A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private Shake shake;

	// Token: 0x04005C1B RID: 23579
	[Token(Token = "0x40058A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public bool skipable;

	// Token: 0x04005C1C RID: 23580
	[Token(Token = "0x40058A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x109")]
	public bool advskip;

	// Token: 0x04005C1D RID: 23581
	[Token(Token = "0x40058A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
	private int checkNpcId;

	// Token: 0x04005C1E RID: 23582
	[Token(Token = "0x40058A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private int ChangeNpcId;

	// Token: 0x04005C1F RID: 23583
	[Token(Token = "0x40058A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
	private int ChangeVariationNo;

	// Token: 0x04005C20 RID: 23584
	[Token(Token = "0x40058A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private bool IsChangeVariation;

	// Token: 0x04005C21 RID: 23585
	[Token(Token = "0x40058A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
	private readonly int VARIATION_ORIGIN;

	// Token: 0x04005C22 RID: 23586
	[Token(Token = "0x40058A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private int MoveCharaCount;

	// Token: 0x04005C23 RID: 23587
	[Token(Token = "0x40058AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
	private bool IsSystemFadeIn;

	// Token: 0x04005C24 RID: 23588
	[Token(Token = "0x40058AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private int loaderId;

	// Token: 0x04005C25 RID: 23589
	[Token(Token = "0x40058AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private List<int> listPreloadRes;

	// Token: 0x04005C26 RID: 23590
	[Token(Token = "0x40058AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private List<string> hintNames;

	// Token: 0x04005C27 RID: 23591
	[Token(Token = "0x40058AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private List<string> hintMsgs;

	// Token: 0x04005C28 RID: 23592
	[Token(Token = "0x40058AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private List<TimelineMsg> TimelineMsgList;

	// Token: 0x04005C29 RID: 23593
	[Token(Token = "0x40058B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private bool isSeriousScripts;

	// Token: 0x04005C2A RID: 23594
	[Token(Token = "0x40058B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private SeriousEventScripts seriousEventScripts;

	// Token: 0x04005C2B RID: 23595
	[Token(Token = "0x40058B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	public int loadcount;

	// Token: 0x04005C2C RID: 23596
	[Token(Token = "0x40058B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
	private bool IsBedSkip;

	// Token: 0x02000410 RID: 1040
	[Token(Token = "0x200106C")]
	private enum WorkList
	{
		// Token: 0x04005C2E RID: 23598
		[Token(Token = "0x4018FED")]
		WORK_NONE,
		// Token: 0x04005C2F RID: 23599
		[Token(Token = "0x4018FEE")]
		WORK_READ_TEXT,
		// Token: 0x04005C30 RID: 23600
		[Token(Token = "0x4018FEF")]
		WORK_MESSAGE_WAIT,
		// Token: 0x04005C31 RID: 23601
		[Token(Token = "0x4018FF0")]
		WORK_BU_WAIT,
		// Token: 0x04005C32 RID: 23602
		[Token(Token = "0x4018FF1")]
		WORK_BG_WAIT,
		// Token: 0x04005C33 RID: 23603
		[Token(Token = "0x4018FF2")]
		WORK_BGM_WAIT,
		// Token: 0x04005C34 RID: 23604
		[Token(Token = "0x4018FF3")]
		WORK_BGM_STOP_WAIT,
		// Token: 0x04005C35 RID: 23605
		[Token(Token = "0x4018FF4")]
		WORK_FADE_WAIT,
		// Token: 0x04005C36 RID: 23606
		[Token(Token = "0x4018FF5")]
		WORK_WAIT,
		// Token: 0x04005C37 RID: 23607
		[Token(Token = "0x4018FF6")]
		WORK_SELECT_WAIT,
		// Token: 0x04005C38 RID: 23608
		[Token(Token = "0x4018FF7")]
		WORK_TIMELINE_WAIT,
		// Token: 0x04005C39 RID: 23609
		[Token(Token = "0x4018FF8")]
		WORK_TIMELINE_END_WAIT,
		// Token: 0x04005C3A RID: 23610
		[Token(Token = "0x4018FF9")]
		WORK_MOVIE_WAIT,
		// Token: 0x04005C3B RID: 23611
		[Token(Token = "0x4018FFA")]
		WORK_CHECK_EXIST_NPC,
		// Token: 0x04005C3C RID: 23612
		[Token(Token = "0x4018FFB")]
		WORK_SKIP,
		// Token: 0x04005C3D RID: 23613
		[Token(Token = "0x4018FFC")]
		WORK_PAUSE,
		// Token: 0x04005C3E RID: 23614
		[Token(Token = "0x4018FFD")]
		WORK_PRELOAD_WAIT,
		// Token: 0x04005C3F RID: 23615
		[Token(Token = "0x4018FFE")]
		WORK_PRELOAD_WAIT_FADE,
		// Token: 0x04005C40 RID: 23616
		[Token(Token = "0x4018FFF")]
		WORK_CHANGEMODEL,
		// Token: 0x04005C41 RID: 23617
		[Token(Token = "0x4019000")]
		WORK_NPC_STANDBY_CHECK
	}

	// Token: 0x02000411 RID: 1041
	[Token(Token = "0x200106D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1575D0", Offset = "0x1576D1")]
	private sealed class <>c__DisplayClass63_0
	{
		// Token: 0x0600184B RID: 6219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D8E")]
		[Address(RVA = "0x2431340", Offset = "0x2431441", VA = "0x2431340")]
		public <>c__DisplayClass63_0()
		{
		}

		// Token: 0x0600184C RID: 6220 RVA: 0x0000A770 File Offset: 0x00008970
		[Token(Token = "0x6006D8F")]
		[Address(RVA = "0x2431350", Offset = "0x2431451", VA = "0x2431350")]
		internal bool <ShowTimelineMsg>b__0(TimelineMsg tmsg)
		{
			return default(bool);
		}

		// Token: 0x0600184D RID: 6221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D90")]
		[Address(RVA = "0x2431380", Offset = "0x2431481", VA = "0x2431380")]
		internal void <ShowTimelineMsg>b__1(AssetHandle<TimelineMsgData> handle)
		{
		}

		// Token: 0x04005C42 RID: 23618
		[Token(Token = "0x4019001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public TimelineMsgID msgId;

		// Token: 0x04005C43 RID: 23619
		[Token(Token = "0x4019002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AdvMain <>4__this;
	}

	// Token: 0x02000412 RID: 1042
	[Token(Token = "0x200106E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1575E0", Offset = "0x1576E1")]
	private sealed class <>c__DisplayClass68_0
	{
		// Token: 0x0600184E RID: 6222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D91")]
		[Address(RVA = "0x24315E0", Offset = "0x24316E1", VA = "0x24315E0")]
		public <>c__DisplayClass68_0()
		{
		}

		// Token: 0x0600184F RID: 6223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D92")]
		[Address(RVA = "0x24315F0", Offset = "0x24316F1", VA = "0x24315F0")]
		internal void <AdvStart>b__0(AssetHandle<TextAsset> handle)
		{
		}

		// Token: 0x04005C44 RID: 23620
		[Token(Token = "0x4019003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AdvMain <>4__this;

		// Token: 0x04005C45 RID: 23621
		[Token(Token = "0x4019004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string filePath;

		// Token: 0x04005C46 RID: 23622
		[Token(Token = "0x4019005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool research;
	}

	// Token: 0x02000413 RID: 1043
	[Token(Token = "0x200106F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1575F0", Offset = "0x1576F1")]
	private sealed class <>c__DisplayClass68_1
	{
		// Token: 0x06001850 RID: 6224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D93")]
		[Address(RVA = "0x24316C0", Offset = "0x24317C1", VA = "0x24316C0")]
		public <>c__DisplayClass68_1()
		{
		}

		// Token: 0x06001851 RID: 6225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D94")]
		[Address(RVA = "0x24316D0", Offset = "0x24317D1", VA = "0x24316D0")]
		internal void <AdvStart>b__1()
		{
		}

		// Token: 0x04005C47 RID: 23623
		[Token(Token = "0x4019006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AssetHandle<TextAsset> handle;

		// Token: 0x04005C48 RID: 23624
		[Token(Token = "0x4019007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AdvMain.<>c__DisplayClass68_0 CS$<>8__locals1;
	}

	// Token: 0x02000414 RID: 1044
	[Token(Token = "0x2001070")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157600", Offset = "0x157701")]
	private sealed class <AdvStartWaitResult>d__69 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001852 RID: 6226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D95")]
		[Address(RVA = "0x2431C00", Offset = "0x2431D01", VA = "0x2431C00")]
		[DebuggerHidden]
		public <AdvStartWaitResult>d__69(int <>1__state)
		{
		}

		// Token: 0x06001853 RID: 6227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D96")]
		[Address(RVA = "0x2431C30", Offset = "0x2431D31", VA = "0x2431C30", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001854 RID: 6228 RVA: 0x0000A788 File Offset: 0x00008988
		[Token(Token = "0x6006D97")]
		[Address(RVA = "0x2431C40", Offset = "0x2431D41", VA = "0x2431C40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06001855 RID: 6229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C27")]
		private object Current
		{
			[Token(Token = "0x6006D98")]
			[Address(RVA = "0x2431E00", Offset = "0x2431F01", VA = "0x2431E00", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001856 RID: 6230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D99")]
		[Address(RVA = "0x2431E10", Offset = "0x2431F11", VA = "0x2431E10", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06001857 RID: 6231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C28")]
		private object Current
		{
			[Token(Token = "0x6006D9A")]
			[Address(RVA = "0x2431E70", Offset = "0x2431F71", VA = "0x2431E70", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04005C49 RID: 23625
		[Token(Token = "0x4019008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04005C4A RID: 23626
		[Token(Token = "0x4019009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04005C4B RID: 23627
		[Token(Token = "0x401900A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AdvMain <>4__this;

		// Token: 0x04005C4C RID: 23628
		[Token(Token = "0x401900B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string filePath;

		// Token: 0x04005C4D RID: 23629
		[Token(Token = "0x401900C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool research;

		// Token: 0x04005C4E RID: 23630
		[Token(Token = "0x401900D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TextAsset <result>5__2;
	}

	// Token: 0x02000415 RID: 1045
	[Token(Token = "0x2001071")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157610", Offset = "0x157711")]
	private sealed class <>c__DisplayClass84_0
	{
		// Token: 0x06001858 RID: 6232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D9B")]
		[Address(RVA = "0x2431760", Offset = "0x2431861", VA = "0x2431760")]
		public <>c__DisplayClass84_0()
		{
		}

		// Token: 0x06001859 RID: 6233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D9C")]
		[Address(RVA = "0x2431770", Offset = "0x2431871", VA = "0x2431770")]
		internal void <ReadCommand>b__0(BossBehaviorController boss)
		{
		}

		// Token: 0x04005C4F RID: 23631
		[Token(Token = "0x401900E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string enemyName;

		// Token: 0x04005C50 RID: 23632
		[Token(Token = "0x401900F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AdvMain <>4__this;
	}

	// Token: 0x02000416 RID: 1046
	[Token(Token = "0x2001072")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157620", Offset = "0x157721")]
	private sealed class <>c__DisplayClass84_1
	{
		// Token: 0x0600185A RID: 6234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D9D")]
		[Address(RVA = "0x2431860", Offset = "0x2431961", VA = "0x2431860")]
		public <>c__DisplayClass84_1()
		{
		}

		// Token: 0x0600185B RID: 6235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D9E")]
		[Address(RVA = "0x2431870", Offset = "0x2431971", VA = "0x2431870")]
		internal void <ReadCommand>b__6(string name)
		{
		}

		// Token: 0x04005C51 RID: 23633
		[Token(Token = "0x4019010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public UINamingWindow.NamingId namingId;

		// Token: 0x04005C52 RID: 23634
		[Token(Token = "0x4019011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AdvMain.<>c__DisplayClass84_0 CS$<>8__locals1;
	}

	// Token: 0x02000417 RID: 1047
	[Token(Token = "0x2001073")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157630", Offset = "0x157731")]
	private sealed class <>c__DisplayClass84_2
	{
		// Token: 0x0600185C RID: 6236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D9F")]
		[Address(RVA = "0x2431990", Offset = "0x2431A91", VA = "0x2431990")]
		public <>c__DisplayClass84_2()
		{
		}

		// Token: 0x0600185D RID: 6237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DA0")]
		[Address(RVA = "0x24319A0", Offset = "0x2431AA1", VA = "0x24319A0")]
		internal void <ReadCommand>b__7(string name)
		{
		}

		// Token: 0x04005C53 RID: 23635
		[Token(Token = "0x4019012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public UINamingWindow.NamingId namingId;
	}

	// Token: 0x02000418 RID: 1048
	[Token(Token = "0x2001074")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157640", Offset = "0x157741")]
	private sealed class <>c__DisplayClass84_3
	{
		// Token: 0x0600185E RID: 6238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DA1")]
		[Address(RVA = "0x2431B50", Offset = "0x2431C51", VA = "0x2431B50")]
		public <>c__DisplayClass84_3()
		{
		}

		// Token: 0x0600185F RID: 6239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DA2")]
		[Address(RVA = "0x2431B60", Offset = "0x2431C61", VA = "0x2431B60")]
		internal void <ReadCommand>b__8()
		{
		}

		// Token: 0x04005C54 RID: 23636
		[Token(Token = "0x4019013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public NpcShopType npcShopType;
	}

	// Token: 0x02000419 RID: 1049
	[Token(Token = "0x2001075")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157650", Offset = "0x157751")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06001861 RID: 6241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DA4")]
		[Address(RVA = "0x2431170", Offset = "0x2431271", VA = "0x2431170")]
		public <>c()
		{
		}

		// Token: 0x06001862 RID: 6242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DA5")]
		[Address(RVA = "0x2431180", Offset = "0x2431281", VA = "0x2431180")]
		internal void <ReadCommand>b__84_1()
		{
		}

		// Token: 0x06001863 RID: 6243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DA6")]
		[Address(RVA = "0x24311F0", Offset = "0x24312F1", VA = "0x24311F0")]
		internal void <ReadCommand>b__84_2()
		{
		}

		// Token: 0x06001864 RID: 6244 RVA: 0x0000A7A0 File Offset: 0x000089A0
		[Token(Token = "0x6006DA7")]
		[Address(RVA = "0x24312F0", Offset = "0x24313F1", VA = "0x24312F0")]
		internal bool <GetFesNpcId>b__101_0(PartyBase p)
		{
			return default(bool);
		}

		// Token: 0x06001865 RID: 6245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DA8")]
		[Address(RVA = "0x2431330", Offset = "0x2431431", VA = "0x2431330")]
		internal void <BedSkipEnd>b__110_0()
		{
		}

		// Token: 0x04005C55 RID: 23637
		[Token(Token = "0x4019014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly AdvMain.<>c <>9;

		// Token: 0x04005C56 RID: 23638
		[Token(Token = "0x4019015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static UnityAction <>9__84_1;

		// Token: 0x04005C57 RID: 23639
		[Token(Token = "0x4019016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static UnityAction <>9__84_2;

		// Token: 0x04005C58 RID: 23640
		[Token(Token = "0x4019017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Func<PartyBase, bool> <>9__101_0;

		// Token: 0x04005C59 RID: 23641
		[Token(Token = "0x4019018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Action <>9__110_0;
	}
}

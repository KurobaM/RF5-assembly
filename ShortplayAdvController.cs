using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Define;
using Il2CppDummyDll;
using Loader;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x0200047D RID: 1149
[Token(Token = "0x2000376")]
public class ShortplayAdvController
{
	// Token: 0x1700047C RID: 1148
	// (get) Token: 0x06001BDA RID: 7130 RVA: 0x0000C3A8 File Offset: 0x0000A5A8
	[Token(Token = "0x17000408")]
	public bool IsPreLoading
	{
		[Token(Token = "0x60018D9")]
		[Address(RVA = "0x1E39F50", Offset = "0x1E3A051", VA = "0x1E39F50")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700047D RID: 1149
	// (get) Token: 0x06001BDB RID: 7131 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000409")]
	private SpcController PlayerSpc
	{
		[Token(Token = "0x60018DA")]
		[Address(RVA = "0x1E39F80", Offset = "0x1E3A081", VA = "0x1E39F80")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700047E RID: 1150
	// (get) Token: 0x06001BDC RID: 7132 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700040A")]
	private Character ActiveCharacter
	{
		[Token(Token = "0x60018DB")]
		[Address(RVA = "0x1E3A050", Offset = "0x1E3A151", VA = "0x1E3A050")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001BDD RID: 7133 RVA: 0x0000C3C0 File Offset: 0x0000A5C0
	[Token(Token = "0x60018DC")]
	[Address(RVA = "0x1E3A0B0", Offset = "0x1E3A1B1", VA = "0x1E3A0B0")]
	public bool Update()
	{
		return default(bool);
	}

	// Token: 0x06001BDE RID: 7134 RVA: 0x0000C3D8 File Offset: 0x0000A5D8
	[Token(Token = "0x60018DD")]
	[Address(RVA = "0x1E3A3D0", Offset = "0x1E3A4D1", VA = "0x1E3A3D0")]
	private bool LoadingPlayerActor()
	{
		return default(bool);
	}

	// Token: 0x06001BDF RID: 7135 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018DE")]
	[Address(RVA = "0x1E3A830", Offset = "0x1E3A931", VA = "0x1E3A830")]
	public void LoadingNpcActor()
	{
	}

	// Token: 0x06001BE0 RID: 7136 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018DF")]
	[Address(RVA = "0x1E3BD40", Offset = "0x1E3BE41", VA = "0x1E3BD40")]
	private Actor CreateActor(int NpcId)
	{
		return null;
	}

	// Token: 0x06001BE1 RID: 7137 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018E0")]
	[Address(RVA = "0x1E3C700", Offset = "0x1E3C801", VA = "0x1E3C700")]
	public void VARIAChange()
	{
	}

	// Token: 0x06001BE2 RID: 7138 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018E1")]
	[Address(RVA = "0x1E3C8D0", Offset = "0x1E3C9D1", VA = "0x1E3C8D0")]
	public void SetPlayerSpcBaseActorLoading()
	{
	}

	// Token: 0x06001BE3 RID: 7139 RVA: 0x0000C3F0 File Offset: 0x0000A5F0
	[Token(Token = "0x60018E2")]
	[Address(RVA = "0x1E3C8E0", Offset = "0x1E3C9E1", VA = "0x1E3C8E0")]
	public bool ShortPlayPreLoadNpc(int npcId)
	{
		return default(bool);
	}

	// Token: 0x06001BE4 RID: 7140 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018E3")]
	[Address(RVA = "0x1E3C9E0", Offset = "0x1E3CAE1", VA = "0x1E3C9E0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19DA00", Offset = "0x19DB01")]
	public IEnumerator ShortPlayStartId(int npcId, float wait, FieldPlaceId FieldPlaceId)
	{
		return null;
	}

	// Token: 0x06001BE5 RID: 7141 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018E4")]
	[Address(RVA = "0x1E3C010", Offset = "0x1E3C111", VA = "0x1E3C010")]
	public void ShortPlayNpcLoaded(SpcController spc)
	{
	}

	// Token: 0x06001BE6 RID: 7142 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018E5")]
	[Address(RVA = "0x1E3CA70", Offset = "0x1E3CB71", VA = "0x1E3CA70")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19DA70", Offset = "0x19DB71")]
	public IEnumerator ShortPlayStartName(string name, float wait, string sceneName)
	{
		return null;
	}

	// Token: 0x06001BE7 RID: 7143 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018E6")]
	[Address(RVA = "0x1E3A2A0", Offset = "0x1E3A3A1", VA = "0x1E3A2A0")]
	public void ShortPlayStartNameCheckEnabled()
	{
	}

	// Token: 0x06001BE8 RID: 7144 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018E7")]
	[Address(RVA = "0x1E3AC90", Offset = "0x1E3AD91", VA = "0x1E3AC90")]
	public void SpcToPlayerReset()
	{
	}

	// Token: 0x06001BE9 RID: 7145 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018E8")]
	[Address(RVA = "0x1E3CB10", Offset = "0x1E3CC11", VA = "0x1E3CB10")]
	public void CheckSpcToNpc()
	{
	}

	// Token: 0x06001BEA RID: 7146 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018E9")]
	[Address(RVA = "0x1E3AEE0", Offset = "0x1E3AFE1", VA = "0x1E3AEE0")]
	public void SpcToNpcReset()
	{
	}

	// Token: 0x06001BEB RID: 7147 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018EA")]
	[Address(RVA = "0x1E3D0E0", Offset = "0x1E3D1E1", VA = "0x1E3D0E0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19DAE0", Offset = "0x19DBE1")]
	public IEnumerator ShortPlayEndId(int npcId, float wait)
	{
		return null;
	}

	// Token: 0x06001BEC RID: 7148 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018EB")]
	[Address(RVA = "0x1E3D180", Offset = "0x1E3D281", VA = "0x1E3D180")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19DB50", Offset = "0x19DC51")]
	public IEnumerator ShortPlayEndName(string name, float wait)
	{
		return null;
	}

	// Token: 0x06001BED RID: 7149 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018EC")]
	[Address(RVA = "0x1E3D230", Offset = "0x1E3D331", VA = "0x1E3D230")]
	public void DoPartner(int NpcId, bool isDate)
	{
	}

	// Token: 0x06001BEE RID: 7150 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018ED")]
	[Address(RVA = "0x1E3D070", Offset = "0x1E3D171", VA = "0x1E3D070")]
	public void ClearPartner()
	{
	}

	// Token: 0x06001BEF RID: 7151 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018EE")]
	[Address(RVA = "0x1E3D310", Offset = "0x1E3D411", VA = "0x1E3D310")]
	public void ClearPartner(int NpcId)
	{
	}

	// Token: 0x06001BF0 RID: 7152 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018EF")]
	[Address(RVA = "0x1E3D390", Offset = "0x1E3D491", VA = "0x1E3D390")]
	public void AppearOnGroundReward(int orderId, int rewardId, int rewardNum, float posx, float posy, float posz)
	{
	}

	// Token: 0x06001BF1 RID: 7153 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018F0")]
	[Address(RVA = "0x1E3D660", Offset = "0x1E3D761", VA = "0x1E3D660")]
	public void AppearOnGroundReward(int orderId, int rewardId, int rewardNum, bool attachHand)
	{
	}

	// Token: 0x06001BF2 RID: 7154 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018F1")]
	[Address(RVA = "0x1E3DFA0", Offset = "0x1E3E0A1", VA = "0x1E3DFA0")]
	public void AppearOnGroundRewardForwardPlayer(int orderId, int rewardId, int rewardNum, bool attachHand)
	{
	}

	// Token: 0x06001BF3 RID: 7155 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018F2")]
	[Address(RVA = "0x1E3D700", Offset = "0x1E3D801", VA = "0x1E3D700")]
	public void AppearOnGroundReward(int orderId, int rewardId, int rewardNum, int rewardLevel, int npcId, bool attachHand)
	{
	}

	// Token: 0x1700047F RID: 1151
	// (get) Token: 0x06001BF4 RID: 7156 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700040B")]
	private Transform GetPlayerTransform
	{
		[Token(Token = "0x60018F3")]
		[Address(RVA = "0x1E3DFB0", Offset = "0x1E3E0B1", VA = "0x1E3DFB0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001BF5 RID: 7157 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018F4")]
	[Address(RVA = "0x1E3E080", Offset = "0x1E3E181", VA = "0x1E3E080")]
	public void CreateNpcPresent(int npcid, NpcPresentType type)
	{
	}

	// Token: 0x06001BF6 RID: 7158 RVA: 0x0000C408 File Offset: 0x0000A608
	[Token(Token = "0x60018F5")]
	[Address(RVA = "0x1E3E530", Offset = "0x1E3E631", VA = "0x1E3E530")]
	private ItemID GetItemIDAtEveryDayPresentAfterMarrage(NpcData data, int idx = -1)
	{
		return ItemID.ITEM_EMPTY;
	}

	// Token: 0x06001BF7 RID: 7159 RVA: 0x0000C420 File Offset: 0x0000A620
	[Token(Token = "0x60018F6")]
	[Address(RVA = "0x1E3E5C0", Offset = "0x1E3E6C1", VA = "0x1E3E5C0")]
	public bool CanHaveItemNpc(NpcController npc, int positionType)
	{
		return default(bool);
	}

	// Token: 0x06001BF8 RID: 7160 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018F7")]
	[Address(RVA = "0x1E3E760", Offset = "0x1E3E861", VA = "0x1E3E760")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19DBC0", Offset = "0x19DCC1")]
	public IEnumerator CreateObject(string itemId, string itemName, float scale, int positionType, float posX, float posY, float posZ, float rotX, float rotY, float rotZ, [Optional] NpcController npc)
	{
		return null;
	}

	// Token: 0x06001BF9 RID: 7161 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018F8")]
	[Address(RVA = "0x1E3E890", Offset = "0x1E3E991", VA = "0x1E3E890")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19DC30", Offset = "0x19DD31")]
	public IEnumerator CreateShortplayObject(string itemId, string itemName, float scale, int positionType, float posX, float posY, float posZ, float rotX, float rotY, float rotZ, [Optional] NpcController npc)
	{
		return null;
	}

	// Token: 0x06001BFA RID: 7162 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018F9")]
	[Address(RVA = "0x1E3E9C0", Offset = "0x1E3EAC1", VA = "0x1E3E9C0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19DCA0", Offset = "0x19DDA1")]
	public IEnumerator CreateShortplayOnlyItem(string itemId, string itemName, float scale, int positionType, float posX, float posY, float posZ, float rotX, float rotY, float rotZ, [Optional] NpcController npc)
	{
		return null;
	}

	// Token: 0x06001BFB RID: 7163 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018FA")]
	[Address(RVA = "0x1E3EAF0", Offset = "0x1E3EBF1", VA = "0x1E3EAF0")]
	public void CallbackCreateShortplayObject(OnGroundItem onGroundItem)
	{
	}

	// Token: 0x06001BFC RID: 7164 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018FB")]
	[Address(RVA = "0x1E3EB40", Offset = "0x1E3EC41", VA = "0x1E3EB40")]
	public void CallbackCreateShortplayObject(GameObject onGroundItemObj)
	{
	}

	// Token: 0x06001BFD RID: 7165 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018FC")]
	[Address(RVA = "0x1E3EB60", Offset = "0x1E3EC61", VA = "0x1E3EB60")]
	public void AfterCreateShortplayObject(GameObject itemObj, string itemId, string itemName, float scale, int positionType, float posX, float posY, float posZ, float rotX, float rotY, float rotZ)
	{
	}

	// Token: 0x06001BFE RID: 7166 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018FD")]
	[Address(RVA = "0x1E40740", Offset = "0x1E40841", VA = "0x1E40740")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19DD10", Offset = "0x19DE11")]
	public IEnumerator MoveObject(string itemName, float wait, int positionType, float posX, float posY, float posZ, float rotX, float rotY, float rotZ)
	{
		return null;
	}

	// Token: 0x06001BFF RID: 7167 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018FE")]
	[Address(RVA = "0x1E407A0", Offset = "0x1E408A1", VA = "0x1E407A0")]
	public void DeleteObject(string itemName, float wait)
	{
	}

	// Token: 0x06001C00 RID: 7168 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018FF")]
	[Address(RVA = "0x1E41080", Offset = "0x1E41181", VA = "0x1E41080")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19DD80", Offset = "0x19DE81")]
	public IEnumerator PlayEffect(string effectFileName, string effectName, float wait, int positionType, float posX, float posY, float posZ, float rotX, float rotY, float rotZ)
	{
		return null;
	}

	// Token: 0x06001C01 RID: 7169 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001900")]
	[Address(RVA = "0x1E410E0", Offset = "0x1E411E1", VA = "0x1E410E0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19DDF0", Offset = "0x19DEF1")]
	public IEnumerator MoveEffect(string effectName, float wait, int positionType, float posX, float posY, float posZ, float rotX, float rotY, float rotZ)
	{
		return null;
	}

	// Token: 0x06001C02 RID: 7170 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001901")]
	[Address(RVA = "0x1E41140", Offset = "0x1E41241", VA = "0x1E41140")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19DE60", Offset = "0x19DF61")]
	public IEnumerator StopEffect(string effectName, float wait)
	{
		return null;
	}

	// Token: 0x06001C03 RID: 7171 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001902")]
	[Address(RVA = "0x1E411A0", Offset = "0x1E412A1", VA = "0x1E411A0")]
	public void ChangeScene(string sceneName)
	{
	}

	// Token: 0x06001C04 RID: 7172 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001903")]
	[Address(RVA = "0x1E41220", Offset = "0x1E41321", VA = "0x1E41220")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19DED0", Offset = "0x19DFD1")]
	public IEnumerator ChangeSceneCoroutine(string sceneName)
	{
		return null;
	}

	// Token: 0x06001C05 RID: 7173 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001904")]
	[Address(RVA = "0x1E412A0", Offset = "0x1E413A1", VA = "0x1E412A0")]
	public void SetBehavierTree(string name)
	{
	}

	// Token: 0x06001C06 RID: 7174 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001905")]
	[Address(RVA = "0x1E413E0", Offset = "0x1E414E1", VA = "0x1E413E0")]
	public void SetNavMeshAgentDestination(string toName, float PatrolSpeed)
	{
	}

	// Token: 0x06001C07 RID: 7175 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001906")]
	[Address(RVA = "0x1E413F0", Offset = "0x1E414F1", VA = "0x1E413F0")]
	public void SetNavMeshAgentDestinationOther(string fromName, string toName, float moveSpeed)
	{
	}

	// Token: 0x06001C08 RID: 7176 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001907")]
	[Address(RVA = "0x1E41400", Offset = "0x1E41501", VA = "0x1E41400")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19DF40", Offset = "0x19E041")]
	public IEnumerator SetCameraMotion(string motionId, float wait, float posX, float posY, float posZ, float rotX, float rotY, float rotZ)
	{
		return null;
	}

	// Token: 0x06001C09 RID: 7177 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001908")]
	[Address(RVA = "0x1E414E0", Offset = "0x1E415E1", VA = "0x1E414E0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19DFB0", Offset = "0x19E0B1")]
	public IEnumerator CameraShake(float wait, float amplitudeGain = 1f, float frequencyGain = 1f, float attackTime = 1f, float sutainTime = 0.2f, float decayTime = 0.7f)
	{
		return null;
	}

	// Token: 0x06001C0A RID: 7178 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001909")]
	[Address(RVA = "0x1E41590", Offset = "0x1E41691", VA = "0x1E41590")]
	public void UsePlayerCamera(int resetType)
	{
	}

	// Token: 0x06001C0B RID: 7179 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600190A")]
	[Address(RVA = "0x1E41650", Offset = "0x1E41751", VA = "0x1E41650")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19E020", Offset = "0x19E121")]
	public IEnumerator UseShortPlayCamera(float wait)
	{
		return null;
	}

	// Token: 0x06001C0C RID: 7180 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600190B")]
	[Address(RVA = "0x1E416D0", Offset = "0x1E417D1", VA = "0x1E416D0")]
	public void ShortPlayCameraSetPosition(float wait, float posX, float posY, float posZ, float rotX, float rotY, float rotZ)
	{
	}

	// Token: 0x06001C0D RID: 7181 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600190C")]
	[Address(RVA = "0x1E417E0", Offset = "0x1E418E1", VA = "0x1E417E0")]
	public void ShortPlayCameraSetTargetPosition(float wait, float posX, float posY, float posZ, float rotX, float rotY, float rotZ, float moveSpeed)
	{
	}

	// Token: 0x06001C0E RID: 7182 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600190D")]
	[Address(RVA = "0x1E418F0", Offset = "0x1E419F1", VA = "0x1E418F0")]
	public void SetPoseId(int npcId, int poseId)
	{
	}

	// Token: 0x06001C0F RID: 7183 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600190E")]
	[Address(RVA = "0x1E41AF0", Offset = "0x1E41BF1", VA = "0x1E41AF0")]
	public void SetPoseName(string name, int poseId)
	{
	}

	// Token: 0x06001C10 RID: 7184 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600190F")]
	[Address(RVA = "0x1E41CD0", Offset = "0x1E41DD1", VA = "0x1E41CD0")]
	public void NpcMotionId(int npcId, int motionId, float wait, bool IsShortPlayCalled = true)
	{
	}

	// Token: 0x06001C11 RID: 7185 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001910")]
	[Address(RVA = "0x1E41F90", Offset = "0x1E42091", VA = "0x1E41F90")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19E090", Offset = "0x19E191")]
	public IEnumerator NpcMotionName(string name, int motionId, float wait)
	{
		return null;
	}

	// Token: 0x06001C12 RID: 7186 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001911")]
	[Address(RVA = "0x1E3D5C0", Offset = "0x1E3D6C1", VA = "0x1E3D5C0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19E100", Offset = "0x19E201")]
	public IEnumerator AppearEmotionId(int npcId, int _emotionId, float wait, float dispTime, bool IsShortPlay)
	{
		return null;
	}

	// Token: 0x06001C13 RID: 7187 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001912")]
	[Address(RVA = "0x1E42030", Offset = "0x1E42131", VA = "0x1E42030")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19E170", Offset = "0x19E271")]
	public IEnumerator AppearEmotionName(string name, int emotionId, float wait, float loop, bool IsShortPlay)
	{
		return null;
	}

	// Token: 0x06001C14 RID: 7188 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001913")]
	[Address(RVA = "0x1E42100", Offset = "0x1E42201", VA = "0x1E42100")]
	public void AppearEmotion(CharacterBase target, int emotionId, float dispTime, bool IsShortPlay)
	{
	}

	// Token: 0x06001C15 RID: 7189 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001914")]
	[Address(RVA = "0x1E42110", Offset = "0x1E42211", VA = "0x1E42110")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19E1E0", Offset = "0x19E2E1")]
	public IEnumerator SetEnabledObjectId(int npcId, bool enabled, float wait)
	{
		return null;
	}

	// Token: 0x06001C16 RID: 7190 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001915")]
	[Address(RVA = "0x1E421C0", Offset = "0x1E422C1", VA = "0x1E421C0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19E250", Offset = "0x19E351")]
	public IEnumerator SetEnabledObjectName(string name, bool enabled, float wait)
	{
		return null;
	}

	// Token: 0x06001C17 RID: 7191 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001916")]
	[Address(RVA = "0x1E42260", Offset = "0x1E42361", VA = "0x1E42260")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19E2C0", Offset = "0x19E3C1")]
	public IEnumerator ScreenFade(int fadeType, float wait, float fadetime, int colorType)
	{
		return null;
	}

	// Token: 0x06001C18 RID: 7192 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001917")]
	[Address(RVA = "0x1E42310", Offset = "0x1E42411", VA = "0x1E42310")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19E330", Offset = "0x19E431")]
	public IEnumerator UIAllShow(float wait)
	{
		return null;
	}

	// Token: 0x06001C19 RID: 7193 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001918")]
	[Address(RVA = "0x1E42390", Offset = "0x1E42491", VA = "0x1E42390")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19E3A0", Offset = "0x19E4A1")]
	public IEnumerator UIAllHide(float wait)
	{
		return null;
	}

	// Token: 0x06001C1A RID: 7194 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001919")]
	[Address(RVA = "0x1E42410", Offset = "0x1E42511", VA = "0x1E42410")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19E410", Offset = "0x19E511")]
	public IEnumerator SetPositionId(int npcId, float wait, float posX, float posY, float posZ, float rotX, float rotY, float rotZ, bool relative = false)
	{
		return null;
	}

	// Token: 0x06001C1B RID: 7195 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600191A")]
	[Address(RVA = "0x1E42500", Offset = "0x1E42601", VA = "0x1E42500")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19E480", Offset = "0x19E581")]
	public IEnumerator SetPositionName(string name, float wait, float posX, float posY, float posZ, float rotX, float rotY, float rotZ, bool relative = false)
	{
		return null;
	}

	// Token: 0x06001C1C RID: 7196 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600191B")]
	[Address(RVA = "0x1E425F0", Offset = "0x1E426F1", VA = "0x1E425F0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19E4F0", Offset = "0x19E5F1")]
	public IEnumerator MovePositionId(int npcId, float wait, float posX, float posY, float posZ, float rotX, float rotY, float rotZ, float moveSpeed, float locomotion, bool relative = false)
	{
		return null;
	}

	// Token: 0x06001C1D RID: 7197 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600191C")]
	[Address(RVA = "0x1E426D0", Offset = "0x1E427D1", VA = "0x1E426D0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19E560", Offset = "0x19E661")]
	public IEnumerator MovePositionName(string name, float wait, float posX, float posY, float posZ, float rotX, float rotY, float rotZ, float moveSpeed, float locomotion, bool relative = false)
	{
		return null;
	}

	// Token: 0x06001C1E RID: 7198 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600191D")]
	[Address(RVA = "0x1E427B0", Offset = "0x1E428B1", VA = "0x1E427B0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19E5D0", Offset = "0x19E6D1")]
	public IEnumerator StartBgm(string name, bool restart, float wait)
	{
		return null;
	}

	// Token: 0x06001C1F RID: 7199 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600191E")]
	[Address(RVA = "0x1E42840", Offset = "0x1E42941", VA = "0x1E42840")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19E640", Offset = "0x19E741")]
	public IEnumerator StopBgm(float wait)
	{
		return null;
	}

	// Token: 0x06001C20 RID: 7200 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600191F")]
	[Address(RVA = "0x1E428C0", Offset = "0x1E429C1", VA = "0x1E428C0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19E6B0", Offset = "0x19E7B1")]
	public IEnumerator StartSe(string name, bool loop, float wait)
	{
		return null;
	}

	// Token: 0x06001C21 RID: 7201 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001920")]
	[Address(RVA = "0x1E42950", Offset = "0x1E42A51", VA = "0x1E42950")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19E720", Offset = "0x19E821")]
	public IEnumerator StopSe(string name, float wait)
	{
		return null;
	}

	// Token: 0x06001C22 RID: 7202 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001921")]
	[Address(RVA = "0x1E429E0", Offset = "0x1E42AE1", VA = "0x1E429E0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19E790", Offset = "0x19E891")]
	public IEnumerator StartVoice(string name, bool loop, float wait)
	{
		return null;
	}

	// Token: 0x06001C23 RID: 7203 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001922")]
	[Address(RVA = "0x1E42A70", Offset = "0x1E42B71", VA = "0x1E42A70")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19E800", Offset = "0x19E901")]
	public IEnumerator StopVoice(string name, float wait)
	{
		return null;
	}

	// Token: 0x06001C24 RID: 7204 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001923")]
	[Address(RVA = "0x1E42B00", Offset = "0x1E42C01", VA = "0x1E42B00")]
	public void TimeLineEnd()
	{
	}

	// Token: 0x06001C25 RID: 7205 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001924")]
	[Address(RVA = "0x1E42CA0", Offset = "0x1E42DA1", VA = "0x1E42CA0")]
	public void StartTimelineMsg(TimelineMsgID msgId)
	{
	}

	// Token: 0x06001C26 RID: 7206 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001925")]
	[Address(RVA = "0x1E42D60", Offset = "0x1E42E61", VA = "0x1E42D60")]
	public void EndTimelineMsg()
	{
	}

	// Token: 0x06001C27 RID: 7207 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001926")]
	[Address(RVA = "0x1E42E40", Offset = "0x1E42F41", VA = "0x1E42E40")]
	public void ShakeStart(string cameraName)
	{
	}

	// Token: 0x06001C28 RID: 7208 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001927")]
	[Address(RVA = "0x1E42F60", Offset = "0x1E43061", VA = "0x1E42F60")]
	public void ShakeStop(string cameraName)
	{
	}

	// Token: 0x06001C29 RID: 7209 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001928")]
	[Address(RVA = "0x1E42F90", Offset = "0x1E43091", VA = "0x1E42F90")]
	public void FadeInBlack(float fadeTime)
	{
	}

	// Token: 0x06001C2A RID: 7210 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001929")]
	[Address(RVA = "0x1E43030", Offset = "0x1E43131", VA = "0x1E43030")]
	public void FadeOutBlack(float fadeTime)
	{
	}

	// Token: 0x06001C2B RID: 7211 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600192A")]
	[Address(RVA = "0x1E430D0", Offset = "0x1E431D1", VA = "0x1E430D0")]
	public void FadeInWhite(float fadeTime)
	{
	}

	// Token: 0x06001C2C RID: 7212 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600192B")]
	[Address(RVA = "0x1E43170", Offset = "0x1E43271", VA = "0x1E43170")]
	public void FadeOutWhite(float fadeTime)
	{
	}

	// Token: 0x06001C2D RID: 7213 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600192C")]
	[Address(RVA = "0x1E43210", Offset = "0x1E43311", VA = "0x1E43210")]
	public void ChageFaceIdle(int npcId)
	{
	}

	// Token: 0x06001C2E RID: 7214 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600192D")]
	[Address(RVA = "0x1E432F0", Offset = "0x1E433F1", VA = "0x1E432F0")]
	public void ChageFaceSmile(int npcId)
	{
	}

	// Token: 0x06001C2F RID: 7215 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600192E")]
	[Address(RVA = "0x1E433D0", Offset = "0x1E434D1", VA = "0x1E433D0")]
	public void ChageFaceDamage(int npcId)
	{
	}

	// Token: 0x06001C30 RID: 7216 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600192F")]
	[Address(RVA = "0x1E434B0", Offset = "0x1E435B1", VA = "0x1E434B0")]
	public void ChageFaceDie(int npcId)
	{
	}

	// Token: 0x06001C31 RID: 7217 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001930")]
	[Address(RVA = "0x1E43590", Offset = "0x1E43691", VA = "0x1E43590")]
	public void ChageFaceSurprise(int npcId)
	{
	}

	// Token: 0x06001C32 RID: 7218 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001931")]
	[Address(RVA = "0x1E43670", Offset = "0x1E43771", VA = "0x1E43670")]
	public void ChageFaceSerious(int npcId)
	{
	}

	// Token: 0x06001C33 RID: 7219 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001932")]
	[Address(RVA = "0x1E43750", Offset = "0x1E43851", VA = "0x1E43750")]
	public void ChageFaceShy(int npcId)
	{
	}

	// Token: 0x06001C34 RID: 7220 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001933")]
	[Address(RVA = "0x1E43830", Offset = "0x1E43931", VA = "0x1E43830")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19E870", Offset = "0x19E971")]
	public IEnumerator FaceParttern(int npcId, int faceId, float wait)
	{
		return null;
	}

	// Token: 0x06001C35 RID: 7221 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001934")]
	[Address(RVA = "0x1E438E0", Offset = "0x1E439E1", VA = "0x1E438E0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19E8E0", Offset = "0x19E9E1")]
	public IEnumerator LookAtTarget(int npcId, int targetNpcId, float wait, float posX, float posY, float posZ, float speed)
	{
		return null;
	}

	// Token: 0x06001C36 RID: 7222 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001935")]
	[Address(RVA = "0x1E439B0", Offset = "0x1E43AB1", VA = "0x1E439B0")]
	public void StartMovie(string movieName)
	{
	}

	// Token: 0x06001C37 RID: 7223 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001936")]
	[Address(RVA = "0x1E43BA0", Offset = "0x1E43CA1", VA = "0x1E43BA0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19E950", Offset = "0x19EA51")]
	public IEnumerator AllNpcDisable(bool forceDisabled, float wait)
	{
		return null;
	}

	// Token: 0x06001C38 RID: 7224 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001937")]
	[Address(RVA = "0x1E43C30", Offset = "0x1E43D31", VA = "0x1E43C30")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19E9C0", Offset = "0x19EAC1")]
	public IEnumerator SummonMonster(MonsterDataID id, string name, float wait, float posX, float posY, float posZ, float rotX, float rotY, float rotZ, int IsShortPlayMonster)
	{
		return null;
	}

	// Token: 0x06001C39 RID: 7225 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001938")]
	[Address(RVA = "0x1E405F0", Offset = "0x1E406F1", VA = "0x1E405F0")]
	private Character GetCharacter(int npcId)
	{
		return null;
	}

	// Token: 0x06001C3A RID: 7226 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001939")]
	[Address(RVA = "0x1E43D20", Offset = "0x1E43E21", VA = "0x1E43D20")]
	private NpcData GetNpcData(int npcId)
	{
		return null;
	}

	// Token: 0x06001C3B RID: 7227 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600193A")]
	[Address(RVA = "0x1E43DB0", Offset = "0x1E43EB1", VA = "0x1E43DB0")]
	public ShortplayAdvController()
	{
	}

	// Token: 0x06001C3C RID: 7228 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600193B")]
	[Address(RVA = "0x1E43F20", Offset = "0x1E44021", VA = "0x1E43F20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19EA30", Offset = "0x19EB31")]
	private void <ShortPlayStartId>b__43_0(HumanController human)
	{
	}

	// Token: 0x04006198 RID: 24984
	[Token(Token = "0x4005D92")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool IsLoadingWait;

	// Token: 0x04006199 RID: 24985
	[Token(Token = "0x4005D93")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	public bool IsLoadingActor000;

	// Token: 0x0400619A RID: 24986
	[Token(Token = "0x4005D94")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int IsLoadingNpcId;

	// Token: 0x0400619B RID: 24987
	[Token(Token = "0x4005D95")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<int> doPartnerId;

	// Token: 0x0400619C RID: 24988
	[Token(Token = "0x4005D96")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<int> doDatePartnerId;

	// Token: 0x0400619D RID: 24989
	[Token(Token = "0x4005D97")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private string SummonMonsterName;

	// Token: 0x0400619E RID: 24990
	[Token(Token = "0x4005D98")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool IsPreLoad;

	// Token: 0x0400619F RID: 24991
	[Token(Token = "0x4005D99")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private GameObject ShortplayOnGroundItem;

	// Token: 0x040061A0 RID: 24992
	[Token(Token = "0x4005D9A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private string CreateObject_itemId;

	// Token: 0x040061A1 RID: 24993
	[Token(Token = "0x4005D9B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private string CreateObject_itemName;

	// Token: 0x040061A2 RID: 24994
	[Token(Token = "0x4005D9C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float CreateObject_scale;

	// Token: 0x040061A3 RID: 24995
	[Token(Token = "0x4005D9D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private int CreateObject_positionType;

	// Token: 0x040061A4 RID: 24996
	[Token(Token = "0x4005D9E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float CreateObject_posX;

	// Token: 0x040061A5 RID: 24997
	[Token(Token = "0x4005D9F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private float CreateObject_posY;

	// Token: 0x040061A6 RID: 24998
	[Token(Token = "0x4005DA0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float CreateObject_posZ;

	// Token: 0x040061A7 RID: 24999
	[Token(Token = "0x4005DA1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private float CreateObject_rotX;

	// Token: 0x040061A8 RID: 25000
	[Token(Token = "0x4005DA2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private float CreateObject_rotY;

	// Token: 0x040061A9 RID: 25001
	[Token(Token = "0x4005DA3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private float CreateObject_rotZ;

	// Token: 0x040061AA RID: 25002
	[Token(Token = "0x4005DA4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private NpcController ShortplayAdvTargetNpc;

	// Token: 0x040061AB RID: 25003
	[Token(Token = "0x4005DA5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private bool IsOnGroundItem;

	// Token: 0x040061AC RID: 25004
	[Token(Token = "0x4005DA6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Color[] ColorList;

	// Token: 0x040061AD RID: 25005
	[Token(Token = "0x4005DA7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public GameObject shakeCameraObj;

	// Token: 0x040061AE RID: 25006
	[Token(Token = "0x4005DA8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private bool timelineShake;

	// Token: 0x040061AF RID: 25007
	[Token(Token = "0x4005DA9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private float magnitude;

	// Token: 0x040061B0 RID: 25008
	[Token(Token = "0x4005DAA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private Vector3 cameraPos;

	// Token: 0x040061B1 RID: 25009
	[Token(Token = "0x4005DAB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public ShortplayAdvController.StateShortPlayExitPlayer StateExitPlayer;

	// Token: 0x040061B2 RID: 25010
	[Token(Token = "0x4005DAC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public bool IsShortPlayExitNpc;

	// Token: 0x040061B3 RID: 25011
	[Token(Token = "0x4005DAD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA9")]
	public bool IsCheckShortPlayExitNpc;

	// Token: 0x040061B4 RID: 25012
	[Token(Token = "0x4005DAE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAA")]
	private bool IsChangePlayableCamera;

	// Token: 0x0200047E RID: 1150
	[Token(Token = "0x2001090")]
	public enum StateShortPlayExitPlayer
	{
		// Token: 0x040061B6 RID: 25014
		[Token(Token = "0x401907A")]
		NONE,
		// Token: 0x040061B7 RID: 25015
		[Token(Token = "0x401907B")]
		SHORTPLAY_END,
		// Token: 0x040061B8 RID: 25016
		[Token(Token = "0x401907C")]
		ON_ADV_COMPLETE
	}

	// Token: 0x0200047F RID: 1151
	[Token(Token = "0x2001091")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1577A0", Offset = "0x1578A1")]
	private sealed class <ShortPlayStartId>d__43 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001C3D RID: 7229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DEC")]
		[Address(RVA = "0x1DE1880", Offset = "0x1DE1981", VA = "0x1DE1880")]
		[DebuggerHidden]
		public <ShortPlayStartId>d__43(int <>1__state)
		{
		}

		// Token: 0x06001C3E RID: 7230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DED")]
		[Address(RVA = "0x1DE18B0", Offset = "0x1DE19B1", VA = "0x1DE18B0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001C3F RID: 7231 RVA: 0x0000C438 File Offset: 0x0000A638
		[Token(Token = "0x6006DEE")]
		[Address(RVA = "0x1DE18C0", Offset = "0x1DE19C1", VA = "0x1DE18C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06001C40 RID: 7232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C31")]
		private object Current
		{
			[Token(Token = "0x6006DEF")]
			[Address(RVA = "0x1DE1BF0", Offset = "0x1DE1CF1", VA = "0x1DE1BF0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001C41 RID: 7233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DF0")]
		[Address(RVA = "0x1DE1C00", Offset = "0x1DE1D01", VA = "0x1DE1C00", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06001C42 RID: 7234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C32")]
		private object Current
		{
			[Token(Token = "0x6006DF1")]
			[Address(RVA = "0x1DE1C60", Offset = "0x1DE1D61", VA = "0x1DE1C60", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040061B9 RID: 25017
		[Token(Token = "0x401907D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040061BA RID: 25018
		[Token(Token = "0x401907E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040061BB RID: 25019
		[Token(Token = "0x401907F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ShortplayAdvController <>4__this;

		// Token: 0x040061BC RID: 25020
		[Token(Token = "0x4019080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int npcId;

		// Token: 0x040061BD RID: 25021
		[Token(Token = "0x4019081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public FieldPlaceId FieldPlaceId;
	}

	// Token: 0x02000480 RID: 1152
	[Token(Token = "0x2001092")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1577B0", Offset = "0x1578B1")]
	private sealed class <ShortPlayStartName>d__45 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001C43 RID: 7235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DF2")]
		[Address(RVA = "0x1DE1C70", Offset = "0x1DE1D71", VA = "0x1DE1C70")]
		[DebuggerHidden]
		public <ShortPlayStartName>d__45(int <>1__state)
		{
		}

		// Token: 0x06001C44 RID: 7236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DF3")]
		[Address(RVA = "0x1DE1CA0", Offset = "0x1DE1DA1", VA = "0x1DE1CA0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001C45 RID: 7237 RVA: 0x0000C450 File Offset: 0x0000A650
		[Token(Token = "0x6006DF4")]
		[Address(RVA = "0x1DE1CB0", Offset = "0x1DE1DB1", VA = "0x1DE1CB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06001C46 RID: 7238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C33")]
		private object Current
		{
			[Token(Token = "0x6006DF5")]
			[Address(RVA = "0x1DE1D60", Offset = "0x1DE1E61", VA = "0x1DE1D60", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001C47 RID: 7239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DF6")]
		[Address(RVA = "0x1DE1D70", Offset = "0x1DE1E71", VA = "0x1DE1D70", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06001C48 RID: 7240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C34")]
		private object Current
		{
			[Token(Token = "0x6006DF7")]
			[Address(RVA = "0x1DE1DD0", Offset = "0x1DE1ED1", VA = "0x1DE1DD0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040061BE RID: 25022
		[Token(Token = "0x4019082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040061BF RID: 25023
		[Token(Token = "0x4019083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040061C0 RID: 25024
		[Token(Token = "0x4019084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ShortplayAdvController <>4__this;

		// Token: 0x040061C1 RID: 25025
		[Token(Token = "0x4019085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string name;
	}

	// Token: 0x02000481 RID: 1153
	[Token(Token = "0x2001093")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1577C0", Offset = "0x1578C1")]
	private sealed class <ShortPlayEndId>d__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001C49 RID: 7241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DF8")]
		[Address(RVA = "0x1DE0CA0", Offset = "0x1DE0DA1", VA = "0x1DE0CA0")]
		[DebuggerHidden]
		public <ShortPlayEndId>d__50(int <>1__state)
		{
		}

		// Token: 0x06001C4A RID: 7242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DF9")]
		[Address(RVA = "0x1DE0CD0", Offset = "0x1DE0DD1", VA = "0x1DE0CD0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001C4B RID: 7243 RVA: 0x0000C468 File Offset: 0x0000A668
		[Token(Token = "0x6006DFA")]
		[Address(RVA = "0x1DE0CE0", Offset = "0x1DE0DE1", VA = "0x1DE0CE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06001C4C RID: 7244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C35")]
		private object Current
		{
			[Token(Token = "0x6006DFB")]
			[Address(RVA = "0x1DE1490", Offset = "0x1DE1591", VA = "0x1DE1490", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001C4D RID: 7245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DFC")]
		[Address(RVA = "0x1DE14A0", Offset = "0x1DE15A1", VA = "0x1DE14A0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06001C4E RID: 7246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C36")]
		private object Current
		{
			[Token(Token = "0x6006DFD")]
			[Address(RVA = "0x1DE1500", Offset = "0x1DE1601", VA = "0x1DE1500", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040061C2 RID: 25026
		[Token(Token = "0x4019086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040061C3 RID: 25027
		[Token(Token = "0x4019087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040061C4 RID: 25028
		[Token(Token = "0x4019088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float wait;

		// Token: 0x040061C5 RID: 25029
		[Token(Token = "0x4019089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int npcId;

		// Token: 0x040061C6 RID: 25030
		[Token(Token = "0x401908A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ShortplayAdvController <>4__this;

		// Token: 0x040061C7 RID: 25031
		[Token(Token = "0x401908B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private NpcData <npcData>5__2;

		// Token: 0x040061C8 RID: 25032
		[Token(Token = "0x401908C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private SpcController <spc>5__3;
	}

	// Token: 0x02000482 RID: 1154
	[Token(Token = "0x2001094")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1577D0", Offset = "0x1578D1")]
	private sealed class <ShortPlayEndName>d__51 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001C4F RID: 7247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DFE")]
		[Address(RVA = "0x1DE1510", Offset = "0x1DE1611", VA = "0x1DE1510")]
		[DebuggerHidden]
		public <ShortPlayEndName>d__51(int <>1__state)
		{
		}

		// Token: 0x06001C50 RID: 7248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DFF")]
		[Address(RVA = "0x1DE1540", Offset = "0x1DE1641", VA = "0x1DE1540", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001C51 RID: 7249 RVA: 0x0000C480 File Offset: 0x0000A680
		[Token(Token = "0x6006E00")]
		[Address(RVA = "0x1DE1550", Offset = "0x1DE1651", VA = "0x1DE1550", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06001C52 RID: 7250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C37")]
		private object Current
		{
			[Token(Token = "0x6006E01")]
			[Address(RVA = "0x1DE1800", Offset = "0x1DE1901", VA = "0x1DE1800", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001C53 RID: 7251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E02")]
		[Address(RVA = "0x1DE1810", Offset = "0x1DE1911", VA = "0x1DE1810", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06001C54 RID: 7252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C38")]
		private object Current
		{
			[Token(Token = "0x6006E03")]
			[Address(RVA = "0x1DE1870", Offset = "0x1DE1971", VA = "0x1DE1870", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040061C9 RID: 25033
		[Token(Token = "0x401908D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040061CA RID: 25034
		[Token(Token = "0x401908E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040061CB RID: 25035
		[Token(Token = "0x401908F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float wait;

		// Token: 0x040061CC RID: 25036
		[Token(Token = "0x4019090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string name;

		// Token: 0x040061CD RID: 25037
		[Token(Token = "0x4019091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ShortplayAdvController <>4__this;
	}

	// Token: 0x02000483 RID: 1155
	[Token(Token = "0x2001095")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1577E0", Offset = "0x1578E1")]
	private sealed class <CreateObject>d__64 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001C55 RID: 7253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E04")]
		[Address(RVA = "0x1DDC430", Offset = "0x1DDC531", VA = "0x1DDC430")]
		[DebuggerHidden]
		public <CreateObject>d__64(int <>1__state)
		{
		}

		// Token: 0x06001C56 RID: 7254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E05")]
		[Address(RVA = "0x1DDC460", Offset = "0x1DDC561", VA = "0x1DDC460", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001C57 RID: 7255 RVA: 0x0000C498 File Offset: 0x0000A698
		[Token(Token = "0x6006E06")]
		[Address(RVA = "0x1DDC470", Offset = "0x1DDC571", VA = "0x1DDC470", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06001C58 RID: 7256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C39")]
		private object Current
		{
			[Token(Token = "0x6006E07")]
			[Address(RVA = "0x1DDC730", Offset = "0x1DDC831", VA = "0x1DDC730", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001C59 RID: 7257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E08")]
		[Address(RVA = "0x1DDC740", Offset = "0x1DDC841", VA = "0x1DDC740", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06001C5A RID: 7258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C3A")]
		private object Current
		{
			[Token(Token = "0x6006E09")]
			[Address(RVA = "0x1DDC7A0", Offset = "0x1DDC8A1", VA = "0x1DDC7A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040061CE RID: 25038
		[Token(Token = "0x4019092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040061CF RID: 25039
		[Token(Token = "0x4019093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040061D0 RID: 25040
		[Token(Token = "0x4019094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ShortplayAdvController <>4__this;

		// Token: 0x040061D1 RID: 25041
		[Token(Token = "0x4019095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public NpcController npc;

		// Token: 0x040061D2 RID: 25042
		[Token(Token = "0x4019096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int positionType;

		// Token: 0x040061D3 RID: 25043
		[Token(Token = "0x4019097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float scale;

		// Token: 0x040061D4 RID: 25044
		[Token(Token = "0x4019098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string itemId;

		// Token: 0x040061D5 RID: 25045
		[Token(Token = "0x4019099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string itemName;

		// Token: 0x040061D6 RID: 25046
		[Token(Token = "0x401909A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float posX;

		// Token: 0x040061D7 RID: 25047
		[Token(Token = "0x401909B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float posY;

		// Token: 0x040061D8 RID: 25048
		[Token(Token = "0x401909C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float posZ;

		// Token: 0x040061D9 RID: 25049
		[Token(Token = "0x401909D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float rotX;

		// Token: 0x040061DA RID: 25050
		[Token(Token = "0x401909E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float rotY;

		// Token: 0x040061DB RID: 25051
		[Token(Token = "0x401909F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float rotZ;
	}

	// Token: 0x02000484 RID: 1156
	[Token(Token = "0x2001096")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1577F0", Offset = "0x1578F1")]
	private sealed class <CreateShortplayObject>d__65 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001C5B RID: 7259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E0A")]
		[Address(RVA = "0x1DDC7B0", Offset = "0x1DDC8B1", VA = "0x1DDC7B0")]
		[DebuggerHidden]
		public <CreateShortplayObject>d__65(int <>1__state)
		{
		}

		// Token: 0x06001C5C RID: 7260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E0B")]
		[Address(RVA = "0x1DDC7E0", Offset = "0x1DDC8E1", VA = "0x1DDC7E0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001C5D RID: 7261 RVA: 0x0000C4B0 File Offset: 0x0000A6B0
		[Token(Token = "0x6006E0C")]
		[Address(RVA = "0x1DDC7F0", Offset = "0x1DDC8F1", VA = "0x1DDC7F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06001C5E RID: 7262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C3B")]
		private object Current
		{
			[Token(Token = "0x6006E0D")]
			[Address(RVA = "0x1DDCAA0", Offset = "0x1DDCBA1", VA = "0x1DDCAA0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001C5F RID: 7263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E0E")]
		[Address(RVA = "0x1DDCAB0", Offset = "0x1DDCBB1", VA = "0x1DDCAB0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06001C60 RID: 7264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C3C")]
		private object Current
		{
			[Token(Token = "0x6006E0F")]
			[Address(RVA = "0x1DDCB10", Offset = "0x1DDCC11", VA = "0x1DDCB10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040061DC RID: 25052
		[Token(Token = "0x40190A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040061DD RID: 25053
		[Token(Token = "0x40190A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040061DE RID: 25054
		[Token(Token = "0x40190A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ShortplayAdvController <>4__this;

		// Token: 0x040061DF RID: 25055
		[Token(Token = "0x40190A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public NpcController npc;

		// Token: 0x040061E0 RID: 25056
		[Token(Token = "0x40190A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int positionType;

		// Token: 0x040061E1 RID: 25057
		[Token(Token = "0x40190A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float scale;

		// Token: 0x040061E2 RID: 25058
		[Token(Token = "0x40190A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string itemId;

		// Token: 0x040061E3 RID: 25059
		[Token(Token = "0x40190A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string itemName;

		// Token: 0x040061E4 RID: 25060
		[Token(Token = "0x40190A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float posX;

		// Token: 0x040061E5 RID: 25061
		[Token(Token = "0x40190A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float posY;

		// Token: 0x040061E6 RID: 25062
		[Token(Token = "0x40190AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float posZ;

		// Token: 0x040061E7 RID: 25063
		[Token(Token = "0x40190AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float rotX;

		// Token: 0x040061E8 RID: 25064
		[Token(Token = "0x40190AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float rotY;

		// Token: 0x040061E9 RID: 25065
		[Token(Token = "0x40190AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float rotZ;
	}

	// Token: 0x02000485 RID: 1157
	[Token(Token = "0x2001097")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157800", Offset = "0x157901")]
	private sealed class <>c__DisplayClass66_0
	{
		// Token: 0x06001C61 RID: 7265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E10")]
		[Address(RVA = "0x1DDB430", Offset = "0x1DDB531", VA = "0x1DDB430")]
		public <>c__DisplayClass66_0()
		{
		}

		// Token: 0x06001C62 RID: 7266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E11")]
		[Address(RVA = "0x1DDB440", Offset = "0x1DDB541", VA = "0x1DDB440")]
		internal void <CreateShortplayOnlyItem>b__0(AssetHandle<GameObject> handle)
		{
		}

		// Token: 0x040061EA RID: 25066
		[Token(Token = "0x40190AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ShortplayAdvController <>4__this;

		// Token: 0x040061EB RID: 25067
		[Token(Token = "0x40190AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string itemId;

		// Token: 0x040061EC RID: 25068
		[Token(Token = "0x40190B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string itemName;

		// Token: 0x040061ED RID: 25069
		[Token(Token = "0x40190B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float scale;

		// Token: 0x040061EE RID: 25070
		[Token(Token = "0x40190B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int positionType;

		// Token: 0x040061EF RID: 25071
		[Token(Token = "0x40190B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float posX;

		// Token: 0x040061F0 RID: 25072
		[Token(Token = "0x40190B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float posY;

		// Token: 0x040061F1 RID: 25073
		[Token(Token = "0x40190B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float posZ;

		// Token: 0x040061F2 RID: 25074
		[Token(Token = "0x40190B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float rotX;

		// Token: 0x040061F3 RID: 25075
		[Token(Token = "0x40190B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float rotY;

		// Token: 0x040061F4 RID: 25076
		[Token(Token = "0x40190B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float rotZ;

		// Token: 0x040061F5 RID: 25077
		[Token(Token = "0x40190B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public NpcController npc;
	}

	// Token: 0x02000486 RID: 1158
	[Token(Token = "0x2001098")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157810", Offset = "0x157911")]
	private sealed class <CreateShortplayOnlyItem>d__66 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001C63 RID: 7267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E12")]
		[Address(RVA = "0x1DDCB20", Offset = "0x1DDCC21", VA = "0x1DDCB20")]
		[DebuggerHidden]
		public <CreateShortplayOnlyItem>d__66(int <>1__state)
		{
		}

		// Token: 0x06001C64 RID: 7268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E13")]
		[Address(RVA = "0x1DDCB50", Offset = "0x1DDCC51", VA = "0x1DDCB50", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001C65 RID: 7269 RVA: 0x0000C4C8 File Offset: 0x0000A6C8
		[Token(Token = "0x6006E14")]
		[Address(RVA = "0x1DDCB60", Offset = "0x1DDCC61", VA = "0x1DDCB60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06001C66 RID: 7270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C3D")]
		private object Current
		{
			[Token(Token = "0x6006E15")]
			[Address(RVA = "0x1DDCE20", Offset = "0x1DDCF21", VA = "0x1DDCE20", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001C67 RID: 7271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E16")]
		[Address(RVA = "0x1DDCE30", Offset = "0x1DDCF31", VA = "0x1DDCE30", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06001C68 RID: 7272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C3E")]
		private object Current
		{
			[Token(Token = "0x6006E17")]
			[Address(RVA = "0x1DDCE90", Offset = "0x1DDCF91", VA = "0x1DDCE90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040061F6 RID: 25078
		[Token(Token = "0x40190BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040061F7 RID: 25079
		[Token(Token = "0x40190BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040061F8 RID: 25080
		[Token(Token = "0x40190BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ShortplayAdvController <>4__this;

		// Token: 0x040061F9 RID: 25081
		[Token(Token = "0x40190BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string itemId;

		// Token: 0x040061FA RID: 25082
		[Token(Token = "0x40190BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string itemName;

		// Token: 0x040061FB RID: 25083
		[Token(Token = "0x40190BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float scale;

		// Token: 0x040061FC RID: 25084
		[Token(Token = "0x40190C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int positionType;

		// Token: 0x040061FD RID: 25085
		[Token(Token = "0x40190C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float posX;

		// Token: 0x040061FE RID: 25086
		[Token(Token = "0x40190C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float posY;

		// Token: 0x040061FF RID: 25087
		[Token(Token = "0x40190C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float posZ;

		// Token: 0x04006200 RID: 25088
		[Token(Token = "0x40190C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float rotX;

		// Token: 0x04006201 RID: 25089
		[Token(Token = "0x40190C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float rotY;

		// Token: 0x04006202 RID: 25090
		[Token(Token = "0x40190C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float rotZ;

		// Token: 0x04006203 RID: 25091
		[Token(Token = "0x40190C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public NpcController npc;
	}

	// Token: 0x02000487 RID: 1159
	[Token(Token = "0x2001099")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157820", Offset = "0x157921")]
	private sealed class <MoveObject>d__70 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001C69 RID: 7273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E18")]
		[Address(RVA = "0x1DDDBD0", Offset = "0x1DDDCD1", VA = "0x1DDDBD0")]
		[DebuggerHidden]
		public <MoveObject>d__70(int <>1__state)
		{
		}

		// Token: 0x06001C6A RID: 7274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E19")]
		[Address(RVA = "0x1DDDC00", Offset = "0x1DDDD01", VA = "0x1DDDC00", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001C6B RID: 7275 RVA: 0x0000C4E0 File Offset: 0x0000A6E0
		[Token(Token = "0x6006E1A")]
		[Address(RVA = "0x1DDDC10", Offset = "0x1DDDD11", VA = "0x1DDDC10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06001C6C RID: 7276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C3F")]
		private object Current
		{
			[Token(Token = "0x6006E1B")]
			[Address(RVA = "0x1DDDC70", Offset = "0x1DDDD71", VA = "0x1DDDC70", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001C6D RID: 7277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E1C")]
		[Address(RVA = "0x1DDDC80", Offset = "0x1DDDD81", VA = "0x1DDDC80", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06001C6E RID: 7278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C40")]
		private object Current
		{
			[Token(Token = "0x6006E1D")]
			[Address(RVA = "0x1DDDCE0", Offset = "0x1DDDDE1", VA = "0x1DDDCE0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04006204 RID: 25092
		[Token(Token = "0x40190C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04006205 RID: 25093
		[Token(Token = "0x40190C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;
	}

	// Token: 0x02000488 RID: 1160
	[Token(Token = "0x200109A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157830", Offset = "0x157931")]
	private sealed class <PlayEffect>d__72 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001C6F RID: 7279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E1E")]
		[Address(RVA = "0x1DDEA20", Offset = "0x1DDEB21", VA = "0x1DDEA20")]
		[DebuggerHidden]
		public <PlayEffect>d__72(int <>1__state)
		{
		}

		// Token: 0x06001C70 RID: 7280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E1F")]
		[Address(RVA = "0x1DDEA50", Offset = "0x1DDEB51", VA = "0x1DDEA50", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001C71 RID: 7281 RVA: 0x0000C4F8 File Offset: 0x0000A6F8
		[Token(Token = "0x6006E20")]
		[Address(RVA = "0x1DDEA60", Offset = "0x1DDEB61", VA = "0x1DDEA60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06001C72 RID: 7282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C41")]
		private object Current
		{
			[Token(Token = "0x6006E21")]
			[Address(RVA = "0x1DDEAC0", Offset = "0x1DDEBC1", VA = "0x1DDEAC0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001C73 RID: 7283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E22")]
		[Address(RVA = "0x1DDEAD0", Offset = "0x1DDEBD1", VA = "0x1DDEAD0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06001C74 RID: 7284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C42")]
		private object Current
		{
			[Token(Token = "0x6006E23")]
			[Address(RVA = "0x1DDEB30", Offset = "0x1DDEC31", VA = "0x1DDEB30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04006206 RID: 25094
		[Token(Token = "0x40190CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04006207 RID: 25095
		[Token(Token = "0x40190CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;
	}

	// Token: 0x02000489 RID: 1161
	[Token(Token = "0x200109B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157840", Offset = "0x157941")]
	private sealed class <MoveEffect>d__73 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001C75 RID: 7285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E24")]
		[Address(RVA = "0x1DDDAB0", Offset = "0x1DDDBB1", VA = "0x1DDDAB0")]
		[DebuggerHidden]
		public <MoveEffect>d__73(int <>1__state)
		{
		}

		// Token: 0x06001C76 RID: 7286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E25")]
		[Address(RVA = "0x1DDDAE0", Offset = "0x1DDDBE1", VA = "0x1DDDAE0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001C77 RID: 7287 RVA: 0x0000C510 File Offset: 0x0000A710
		[Token(Token = "0x6006E26")]
		[Address(RVA = "0x1DDDAF0", Offset = "0x1DDDBF1", VA = "0x1DDDAF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06001C78 RID: 7288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C43")]
		private object Current
		{
			[Token(Token = "0x6006E27")]
			[Address(RVA = "0x1DDDB50", Offset = "0x1DDDC51", VA = "0x1DDDB50", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001C79 RID: 7289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E28")]
		[Address(RVA = "0x1DDDB60", Offset = "0x1DDDC61", VA = "0x1DDDB60", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06001C7A RID: 7290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C44")]
		private object Current
		{
			[Token(Token = "0x6006E29")]
			[Address(RVA = "0x1DDDBC0", Offset = "0x1DDDCC1", VA = "0x1DDDBC0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04006208 RID: 25096
		[Token(Token = "0x40190CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04006209 RID: 25097
		[Token(Token = "0x40190CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;
	}

	// Token: 0x0200048A RID: 1162
	[Token(Token = "0x200109C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157850", Offset = "0x157951")]
	private sealed class <StopEffect>d__74 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001C7B RID: 7291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E2A")]
		[Address(RVA = "0x1DE24E0", Offset = "0x1DE25E1", VA = "0x1DE24E0")]
		[DebuggerHidden]
		public <StopEffect>d__74(int <>1__state)
		{
		}

		// Token: 0x06001C7C RID: 7292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E2B")]
		[Address(RVA = "0x1DE2510", Offset = "0x1DE2611", VA = "0x1DE2510", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001C7D RID: 7293 RVA: 0x0000C528 File Offset: 0x0000A728
		[Token(Token = "0x6006E2C")]
		[Address(RVA = "0x1DE2520", Offset = "0x1DE2621", VA = "0x1DE2520", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06001C7E RID: 7294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C45")]
		private object Current
		{
			[Token(Token = "0x6006E2D")]
			[Address(RVA = "0x1DE2580", Offset = "0x1DE2681", VA = "0x1DE2580", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001C7F RID: 7295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E2E")]
		[Address(RVA = "0x1DE2590", Offset = "0x1DE2691", VA = "0x1DE2590", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06001C80 RID: 7296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C46")]
		private object Current
		{
			[Token(Token = "0x6006E2F")]
			[Address(RVA = "0x1DE25F0", Offset = "0x1DE26F1", VA = "0x1DE25F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400620A RID: 25098
		[Token(Token = "0x40190CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400620B RID: 25099
		[Token(Token = "0x40190CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;
	}

	// Token: 0x0200048B RID: 1163
	[Token(Token = "0x200109D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157860", Offset = "0x157961")]
	private sealed class <ChangeSceneCoroutine>d__76 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001C81 RID: 7297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E30")]
		[Address(RVA = "0x1DDC200", Offset = "0x1DDC301", VA = "0x1DDC200")]
		[DebuggerHidden]
		public <ChangeSceneCoroutine>d__76(int <>1__state)
		{
		}

		// Token: 0x06001C82 RID: 7298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E31")]
		[Address(RVA = "0x1DDC230", Offset = "0x1DDC331", VA = "0x1DDC230", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001C83 RID: 7299 RVA: 0x0000C540 File Offset: 0x0000A740
		[Token(Token = "0x6006E32")]
		[Address(RVA = "0x1DDC240", Offset = "0x1DDC341", VA = "0x1DDC240", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06001C84 RID: 7300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C47")]
		private object Current
		{
			[Token(Token = "0x6006E33")]
			[Address(RVA = "0x1DDC3B0", Offset = "0x1DDC4B1", VA = "0x1DDC3B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001C85 RID: 7301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E34")]
		[Address(RVA = "0x1DDC3C0", Offset = "0x1DDC4C1", VA = "0x1DDC3C0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06001C86 RID: 7302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C48")]
		private object Current
		{
			[Token(Token = "0x6006E35")]
			[Address(RVA = "0x1DDC420", Offset = "0x1DDC521", VA = "0x1DDC420", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400620C RID: 25100
		[Token(Token = "0x40190D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400620D RID: 25101
		[Token(Token = "0x40190D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400620E RID: 25102
		[Token(Token = "0x40190D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string sceneName;
	}

	// Token: 0x0200048C RID: 1164
	[Token(Token = "0x200109E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157870", Offset = "0x157971")]
	private sealed class <SetCameraMotion>d__80 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001C87 RID: 7303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E36")]
		[Address(RVA = "0x1DDEEF0", Offset = "0x1DDEFF1", VA = "0x1DDEEF0")]
		[DebuggerHidden]
		public <SetCameraMotion>d__80(int <>1__state)
		{
		}

		// Token: 0x06001C88 RID: 7304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E37")]
		[Address(RVA = "0x1DDEF20", Offset = "0x1DDF021", VA = "0x1DDEF20", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001C89 RID: 7305 RVA: 0x0000C558 File Offset: 0x0000A758
		[Token(Token = "0x6006E38")]
		[Address(RVA = "0x1DDEF30", Offset = "0x1DDF031", VA = "0x1DDEF30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06001C8A RID: 7306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C49")]
		private object Current
		{
			[Token(Token = "0x6006E39")]
			[Address(RVA = "0x1DDF080", Offset = "0x1DDF181", VA = "0x1DDF080", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001C8B RID: 7307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E3A")]
		[Address(RVA = "0x1DDF090", Offset = "0x1DDF191", VA = "0x1DDF090", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06001C8C RID: 7308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C4A")]
		private object Current
		{
			[Token(Token = "0x6006E3B")]
			[Address(RVA = "0x1DDF0F0", Offset = "0x1DDF1F1", VA = "0x1DDF0F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400620F RID: 25103
		[Token(Token = "0x40190D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04006210 RID: 25104
		[Token(Token = "0x40190D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04006211 RID: 25105
		[Token(Token = "0x40190D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float wait;

		// Token: 0x04006212 RID: 25106
		[Token(Token = "0x40190D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string motionId;

		// Token: 0x04006213 RID: 25107
		[Token(Token = "0x40190D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float posX;

		// Token: 0x04006214 RID: 25108
		[Token(Token = "0x40190D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float posY;

		// Token: 0x04006215 RID: 25109
		[Token(Token = "0x40190D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float posZ;

		// Token: 0x04006216 RID: 25110
		[Token(Token = "0x40190DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float rotX;

		// Token: 0x04006217 RID: 25111
		[Token(Token = "0x40190DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float rotY;

		// Token: 0x04006218 RID: 25112
		[Token(Token = "0x40190DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float rotZ;
	}

	// Token: 0x0200048D RID: 1165
	[Token(Token = "0x200109F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157880", Offset = "0x157981")]
	private sealed class <CameraShake>d__81 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001C8D RID: 7309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E3C")]
		[Address(RVA = "0x1DDC040", Offset = "0x1DDC141", VA = "0x1DDC040")]
		[DebuggerHidden]
		public <CameraShake>d__81(int <>1__state)
		{
		}

		// Token: 0x06001C8E RID: 7310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E3D")]
		[Address(RVA = "0x1DDC070", Offset = "0x1DDC171", VA = "0x1DDC070", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001C8F RID: 7311 RVA: 0x0000C570 File Offset: 0x0000A770
		[Token(Token = "0x6006E3E")]
		[Address(RVA = "0x1DDC080", Offset = "0x1DDC181", VA = "0x1DDC080", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06001C90 RID: 7312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C4B")]
		private object Current
		{
			[Token(Token = "0x6006E3F")]
			[Address(RVA = "0x1DDC180", Offset = "0x1DDC281", VA = "0x1DDC180", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001C91 RID: 7313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E40")]
		[Address(RVA = "0x1DDC190", Offset = "0x1DDC291", VA = "0x1DDC190", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06001C92 RID: 7314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C4C")]
		private object Current
		{
			[Token(Token = "0x6006E41")]
			[Address(RVA = "0x1DDC1F0", Offset = "0x1DDC2F1", VA = "0x1DDC1F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04006219 RID: 25113
		[Token(Token = "0x40190DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400621A RID: 25114
		[Token(Token = "0x40190DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400621B RID: 25115
		[Token(Token = "0x40190DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float wait;

		// Token: 0x0400621C RID: 25116
		[Token(Token = "0x40190E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float amplitudeGain;

		// Token: 0x0400621D RID: 25117
		[Token(Token = "0x40190E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float frequencyGain;

		// Token: 0x0400621E RID: 25118
		[Token(Token = "0x40190E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float attackTime;

		// Token: 0x0400621F RID: 25119
		[Token(Token = "0x40190E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float sutainTime;

		// Token: 0x04006220 RID: 25120
		[Token(Token = "0x40190E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float decayTime;
	}

	// Token: 0x0200048E RID: 1166
	[Token(Token = "0x20010A0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157890", Offset = "0x157991")]
	private sealed class <UseShortPlayCamera>d__83 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001C93 RID: 7315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E42")]
		[Address(RVA = "0x1DE36C0", Offset = "0x1DE37C1", VA = "0x1DE36C0")]
		[DebuggerHidden]
		public <UseShortPlayCamera>d__83(int <>1__state)
		{
		}

		// Token: 0x06001C94 RID: 7316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E43")]
		[Address(RVA = "0x1DE36F0", Offset = "0x1DE37F1", VA = "0x1DE36F0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001C95 RID: 7317 RVA: 0x0000C588 File Offset: 0x0000A788
		[Token(Token = "0x6006E44")]
		[Address(RVA = "0x1DE3700", Offset = "0x1DE3801", VA = "0x1DE3700", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06001C96 RID: 7318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C4D")]
		private object Current
		{
			[Token(Token = "0x6006E45")]
			[Address(RVA = "0x1DE3840", Offset = "0x1DE3941", VA = "0x1DE3840", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001C97 RID: 7319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E46")]
		[Address(RVA = "0x1DE3850", Offset = "0x1DE3951", VA = "0x1DE3850", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06001C98 RID: 7320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C4E")]
		private object Current
		{
			[Token(Token = "0x6006E47")]
			[Address(RVA = "0x1DE38B0", Offset = "0x1DE39B1", VA = "0x1DE38B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04006221 RID: 25121
		[Token(Token = "0x40190E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04006222 RID: 25122
		[Token(Token = "0x40190E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04006223 RID: 25123
		[Token(Token = "0x40190E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float wait;
	}

	// Token: 0x0200048F RID: 1167
	[Token(Token = "0x20010A1")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1578A0", Offset = "0x1579A1")]
	private sealed class <>c__DisplayClass89_0
	{
		// Token: 0x06001C99 RID: 7321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E48")]
		[Address(RVA = "0x1DDB670", Offset = "0x1DDB771", VA = "0x1DDB670")]
		public <>c__DisplayClass89_0()
		{
		}

		// Token: 0x06001C9A RID: 7322 RVA: 0x0000C5A0 File Offset: 0x0000A7A0
		[Token(Token = "0x6006E49")]
		[Address(RVA = "0x1DDB680", Offset = "0x1DDB781", VA = "0x1DDB680")]
		internal bool <NpcMotionName>b__0(Animator a)
		{
			return default(bool);
		}

		// Token: 0x04006224 RID: 25124
		[Token(Token = "0x40190E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x04006225 RID: 25125
		[Token(Token = "0x40190E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Predicate<Animator> <>9__0;
	}

	// Token: 0x02000490 RID: 1168
	[Token(Token = "0x20010A2")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1578B0", Offset = "0x1579B1")]
	private sealed class <NpcMotionName>d__89 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001C9B RID: 7323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E4A")]
		[Address(RVA = "0x1DDE510", Offset = "0x1DDE611", VA = "0x1DDE510")]
		[DebuggerHidden]
		public <NpcMotionName>d__89(int <>1__state)
		{
		}

		// Token: 0x06001C9C RID: 7324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E4B")]
		[Address(RVA = "0x1DDE540", Offset = "0x1DDE641", VA = "0x1DDE540", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001C9D RID: 7325 RVA: 0x0000C5B8 File Offset: 0x0000A7B8
		[Token(Token = "0x6006E4C")]
		[Address(RVA = "0x1DDE550", Offset = "0x1DDE651", VA = "0x1DDE550", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06001C9E RID: 7326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C4F")]
		private object Current
		{
			[Token(Token = "0x6006E4D")]
			[Address(RVA = "0x1DDE9A0", Offset = "0x1DDEAA1", VA = "0x1DDE9A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001C9F RID: 7327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E4E")]
		[Address(RVA = "0x1DDE9B0", Offset = "0x1DDEAB1", VA = "0x1DDE9B0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06001CA0 RID: 7328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C50")]
		private object Current
		{
			[Token(Token = "0x6006E4F")]
			[Address(RVA = "0x1DDEA10", Offset = "0x1DDEB11", VA = "0x1DDEA10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04006226 RID: 25126
		[Token(Token = "0x40190EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04006227 RID: 25127
		[Token(Token = "0x40190EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04006228 RID: 25128
		[Token(Token = "0x40190EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string name;

		// Token: 0x04006229 RID: 25129
		[Token(Token = "0x40190ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float wait;

		// Token: 0x0400622A RID: 25130
		[Token(Token = "0x40190EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ShortplayAdvController.<>c__DisplayClass89_0 <>8__1;

		// Token: 0x0400622B RID: 25131
		[Token(Token = "0x40190EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int motionId;
	}

	// Token: 0x02000491 RID: 1169
	[Token(Token = "0x20010A3")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1578C0", Offset = "0x1579C1")]
	private sealed class <AppearEmotionId>d__90 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001CA1 RID: 7329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E50")]
		[Address(RVA = "0x1DDBAA0", Offset = "0x1DDBBA1", VA = "0x1DDBAA0")]
		[DebuggerHidden]
		public <AppearEmotionId>d__90(int <>1__state)
		{
		}

		// Token: 0x06001CA2 RID: 7330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E51")]
		[Address(RVA = "0x1DDBAD0", Offset = "0x1DDBBD1", VA = "0x1DDBAD0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001CA3 RID: 7331 RVA: 0x0000C5D0 File Offset: 0x0000A7D0
		[Token(Token = "0x6006E52")]
		[Address(RVA = "0x1DDBAE0", Offset = "0x1DDBBE1", VA = "0x1DDBAE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06001CA4 RID: 7332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C51")]
		private object Current
		{
			[Token(Token = "0x6006E53")]
			[Address(RVA = "0x1DDBD50", Offset = "0x1DDBE51", VA = "0x1DDBD50", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001CA5 RID: 7333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E54")]
		[Address(RVA = "0x1DDBD60", Offset = "0x1DDBE61", VA = "0x1DDBD60", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06001CA6 RID: 7334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C52")]
		private object Current
		{
			[Token(Token = "0x6006E55")]
			[Address(RVA = "0x1DDBDC0", Offset = "0x1DDBEC1", VA = "0x1DDBDC0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400622C RID: 25132
		[Token(Token = "0x40190F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400622D RID: 25133
		[Token(Token = "0x40190F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400622E RID: 25134
		[Token(Token = "0x40190F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int _emotionId;

		// Token: 0x0400622F RID: 25135
		[Token(Token = "0x40190F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float wait;

		// Token: 0x04006230 RID: 25136
		[Token(Token = "0x40190F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int npcId;

		// Token: 0x04006231 RID: 25137
		[Token(Token = "0x40190F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float dispTime;

		// Token: 0x04006232 RID: 25138
		[Token(Token = "0x40190F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private EmotionType <emotionId>5__2;
	}

	// Token: 0x02000492 RID: 1170
	[Token(Token = "0x20010A4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1578D0", Offset = "0x1579D1")]
	private sealed class <AppearEmotionName>d__91 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001CA7 RID: 7335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E56")]
		[Address(RVA = "0x1DDBDD0", Offset = "0x1DDBED1", VA = "0x1DDBDD0")]
		[DebuggerHidden]
		public <AppearEmotionName>d__91(int <>1__state)
		{
		}

		// Token: 0x06001CA8 RID: 7336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E57")]
		[Address(RVA = "0x1DDBE00", Offset = "0x1DDBF01", VA = "0x1DDBE00", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001CA9 RID: 7337 RVA: 0x0000C5E8 File Offset: 0x0000A7E8
		[Token(Token = "0x6006E58")]
		[Address(RVA = "0x1DDBE10", Offset = "0x1DDBF11", VA = "0x1DDBE10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06001CAA RID: 7338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C53")]
		private object Current
		{
			[Token(Token = "0x6006E59")]
			[Address(RVA = "0x1DDBFC0", Offset = "0x1DDC0C1", VA = "0x1DDBFC0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001CAB RID: 7339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E5A")]
		[Address(RVA = "0x1DDBFD0", Offset = "0x1DDC0D1", VA = "0x1DDBFD0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06001CAC RID: 7340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C54")]
		private object Current
		{
			[Token(Token = "0x6006E5B")]
			[Address(RVA = "0x1DDC030", Offset = "0x1DDC131", VA = "0x1DDC030", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04006233 RID: 25139
		[Token(Token = "0x40190F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04006234 RID: 25140
		[Token(Token = "0x40190F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04006235 RID: 25141
		[Token(Token = "0x40190F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float wait;

		// Token: 0x04006236 RID: 25142
		[Token(Token = "0x40190FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string name;

		// Token: 0x04006237 RID: 25143
		[Token(Token = "0x40190FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ShortplayAdvController <>4__this;

		// Token: 0x04006238 RID: 25144
		[Token(Token = "0x40190FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int emotionId;

		// Token: 0x04006239 RID: 25145
		[Token(Token = "0x40190FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float loop;

		// Token: 0x0400623A RID: 25146
		[Token(Token = "0x40190FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool IsShortPlay;
	}

	// Token: 0x02000493 RID: 1171
	[Token(Token = "0x20010A5")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1578E0", Offset = "0x1579E1")]
	private sealed class <SetEnabledObjectId>d__93 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001CAD RID: 7341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E5C")]
		[Address(RVA = "0x1DDF100", Offset = "0x1DDF201", VA = "0x1DDF100")]
		[DebuggerHidden]
		public <SetEnabledObjectId>d__93(int <>1__state)
		{
		}

		// Token: 0x06001CAE RID: 7342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E5D")]
		[Address(RVA = "0x1DDF130", Offset = "0x1DDF231", VA = "0x1DDF130", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001CAF RID: 7343 RVA: 0x0000C600 File Offset: 0x0000A800
		[Token(Token = "0x6006E5E")]
		[Address(RVA = "0x1DDF140", Offset = "0x1DDF241", VA = "0x1DDF140", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06001CB0 RID: 7344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C55")]
		private object Current
		{
			[Token(Token = "0x6006E5F")]
			[Address(RVA = "0x1DDF2C0", Offset = "0x1DDF3C1", VA = "0x1DDF2C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001CB1 RID: 7345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E60")]
		[Address(RVA = "0x1DDF2D0", Offset = "0x1DDF3D1", VA = "0x1DDF2D0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06001CB2 RID: 7346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C56")]
		private object Current
		{
			[Token(Token = "0x6006E61")]
			[Address(RVA = "0x1DDF330", Offset = "0x1DDF431", VA = "0x1DDF330", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400623B RID: 25147
		[Token(Token = "0x40190FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400623C RID: 25148
		[Token(Token = "0x4019100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400623D RID: 25149
		[Token(Token = "0x4019101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float wait;

		// Token: 0x0400623E RID: 25150
		[Token(Token = "0x4019102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int npcId;

		// Token: 0x0400623F RID: 25151
		[Token(Token = "0x4019103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ShortplayAdvController <>4__this;

		// Token: 0x04006240 RID: 25152
		[Token(Token = "0x4019104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool enabled;
	}

	// Token: 0x02000494 RID: 1172
	[Token(Token = "0x20010A6")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1578F0", Offset = "0x1579F1")]
	private sealed class <SetEnabledObjectName>d__94 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001CB3 RID: 7347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E62")]
		[Address(RVA = "0x1DDF340", Offset = "0x1DDF441", VA = "0x1DDF340")]
		[DebuggerHidden]
		public <SetEnabledObjectName>d__94(int <>1__state)
		{
		}

		// Token: 0x06001CB4 RID: 7348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E63")]
		[Address(RVA = "0x1DDF370", Offset = "0x1DDF471", VA = "0x1DDF370", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001CB5 RID: 7349 RVA: 0x0000C618 File Offset: 0x0000A818
		[Token(Token = "0x6006E64")]
		[Address(RVA = "0x1DDF380", Offset = "0x1DDF481", VA = "0x1DDF380", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06001CB6 RID: 7350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C57")]
		private object Current
		{
			[Token(Token = "0x6006E65")]
			[Address(RVA = "0x1DDF6E0", Offset = "0x1DDF7E1", VA = "0x1DDF6E0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001CB7 RID: 7351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E66")]
		[Address(RVA = "0x1DDF6F0", Offset = "0x1DDF7F1", VA = "0x1DDF6F0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06001CB8 RID: 7352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C58")]
		private object Current
		{
			[Token(Token = "0x6006E67")]
			[Address(RVA = "0x1DDF750", Offset = "0x1DDF851", VA = "0x1DDF750", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04006241 RID: 25153
		[Token(Token = "0x4019105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04006242 RID: 25154
		[Token(Token = "0x4019106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04006243 RID: 25155
		[Token(Token = "0x4019107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float wait;

		// Token: 0x04006244 RID: 25156
		[Token(Token = "0x4019108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string name;

		// Token: 0x04006245 RID: 25157
		[Token(Token = "0x4019109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool enabled;
	}

	// Token: 0x02000495 RID: 1173
	[Token(Token = "0x20010A7")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157900", Offset = "0x157A01")]
	private sealed class <ScreenFade>d__95 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001CB9 RID: 7353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E68")]
		[Address(RVA = "0x1DDEB40", Offset = "0x1DDEC41", VA = "0x1DDEB40")]
		[DebuggerHidden]
		public <ScreenFade>d__95(int <>1__state)
		{
		}

		// Token: 0x06001CBA RID: 7354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E69")]
		[Address(RVA = "0x1DDEB70", Offset = "0x1DDEC71", VA = "0x1DDEB70", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001CBB RID: 7355 RVA: 0x0000C630 File Offset: 0x0000A830
		[Token(Token = "0x6006E6A")]
		[Address(RVA = "0x1DDEB80", Offset = "0x1DDEC81", VA = "0x1DDEB80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06001CBC RID: 7356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C59")]
		private object Current
		{
			[Token(Token = "0x6006E6B")]
			[Address(RVA = "0x1DDEE70", Offset = "0x1DDEF71", VA = "0x1DDEE70", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001CBD RID: 7357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E6C")]
		[Address(RVA = "0x1DDEE80", Offset = "0x1DDEF81", VA = "0x1DDEE80", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06001CBE RID: 7358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C5A")]
		private object Current
		{
			[Token(Token = "0x6006E6D")]
			[Address(RVA = "0x1DDEEE0", Offset = "0x1DDEFE1", VA = "0x1DDEEE0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04006246 RID: 25158
		[Token(Token = "0x401910A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04006247 RID: 25159
		[Token(Token = "0x401910B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04006248 RID: 25160
		[Token(Token = "0x401910C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float wait;

		// Token: 0x04006249 RID: 25161
		[Token(Token = "0x401910D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int fadeType;

		// Token: 0x0400624A RID: 25162
		[Token(Token = "0x401910E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fadetime;

		// Token: 0x0400624B RID: 25163
		[Token(Token = "0x401910F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ShortplayAdvController <>4__this;

		// Token: 0x0400624C RID: 25164
		[Token(Token = "0x4019110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int colorType;
	}

	// Token: 0x02000496 RID: 1174
	[Token(Token = "0x20010A8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157910", Offset = "0x157A11")]
	private sealed class <UIAllShow>d__96 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001CBF RID: 7359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E6E")]
		[Address(RVA = "0x1DE3470", Offset = "0x1DE3571", VA = "0x1DE3470")]
		[DebuggerHidden]
		public <UIAllShow>d__96(int <>1__state)
		{
		}

		// Token: 0x06001CC0 RID: 7360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E6F")]
		[Address(RVA = "0x1DE34A0", Offset = "0x1DE35A1", VA = "0x1DE34A0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001CC1 RID: 7361 RVA: 0x0000C648 File Offset: 0x0000A848
		[Token(Token = "0x6006E70")]
		[Address(RVA = "0x1DE34B0", Offset = "0x1DE35B1", VA = "0x1DE34B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06001CC2 RID: 7362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C5B")]
		private object Current
		{
			[Token(Token = "0x6006E71")]
			[Address(RVA = "0x1DE3640", Offset = "0x1DE3741", VA = "0x1DE3640", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001CC3 RID: 7363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E72")]
		[Address(RVA = "0x1DE3650", Offset = "0x1DE3751", VA = "0x1DE3650", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06001CC4 RID: 7364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C5C")]
		private object Current
		{
			[Token(Token = "0x6006E73")]
			[Address(RVA = "0x1DE36B0", Offset = "0x1DE37B1", VA = "0x1DE36B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400624D RID: 25165
		[Token(Token = "0x4019111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400624E RID: 25166
		[Token(Token = "0x4019112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400624F RID: 25167
		[Token(Token = "0x4019113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float wait;
	}

	// Token: 0x02000497 RID: 1175
	[Token(Token = "0x20010A9")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157920", Offset = "0x157A21")]
	private sealed class <UIAllHide>d__97 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001CC5 RID: 7365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E74")]
		[Address(RVA = "0x1DE3210", Offset = "0x1DE3311", VA = "0x1DE3210")]
		[DebuggerHidden]
		public <UIAllHide>d__97(int <>1__state)
		{
		}

		// Token: 0x06001CC6 RID: 7366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E75")]
		[Address(RVA = "0x1DE3240", Offset = "0x1DE3341", VA = "0x1DE3240", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001CC7 RID: 7367 RVA: 0x0000C660 File Offset: 0x0000A860
		[Token(Token = "0x6006E76")]
		[Address(RVA = "0x1DE3250", Offset = "0x1DE3351", VA = "0x1DE3250", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06001CC8 RID: 7368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C5D")]
		private object Current
		{
			[Token(Token = "0x6006E77")]
			[Address(RVA = "0x1DE33F0", Offset = "0x1DE34F1", VA = "0x1DE33F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001CC9 RID: 7369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E78")]
		[Address(RVA = "0x1DE3400", Offset = "0x1DE3501", VA = "0x1DE3400", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06001CCA RID: 7370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C5E")]
		private object Current
		{
			[Token(Token = "0x6006E79")]
			[Address(RVA = "0x1DE3460", Offset = "0x1DE3561", VA = "0x1DE3460", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04006250 RID: 25168
		[Token(Token = "0x4019114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04006251 RID: 25169
		[Token(Token = "0x4019115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04006252 RID: 25170
		[Token(Token = "0x4019116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float wait;
	}

	// Token: 0x02000498 RID: 1176
	[Token(Token = "0x20010AA")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157930", Offset = "0x157A31")]
	private sealed class <SetPositionId>d__98 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001CCB RID: 7371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E7A")]
		[Address(RVA = "0x1DDF760", Offset = "0x1DDF861", VA = "0x1DDF760")]
		[DebuggerHidden]
		public <SetPositionId>d__98(int <>1__state)
		{
		}

		// Token: 0x06001CCC RID: 7372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E7B")]
		[Address(RVA = "0x1DDF790", Offset = "0x1DDF891", VA = "0x1DDF790", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001CCD RID: 7373 RVA: 0x0000C678 File Offset: 0x0000A878
		[Token(Token = "0x6006E7C")]
		[Address(RVA = "0x1DDF7A0", Offset = "0x1DDF8A1", VA = "0x1DDF7A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06001CCE RID: 7374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C5F")]
		private object Current
		{
			[Token(Token = "0x6006E7D")]
			[Address(RVA = "0x1DE0820", Offset = "0x1DE0921", VA = "0x1DE0820", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001CCF RID: 7375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E7E")]
		[Address(RVA = "0x1DE0830", Offset = "0x1DE0931", VA = "0x1DE0830", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06001CD0 RID: 7376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C60")]
		private object Current
		{
			[Token(Token = "0x6006E7F")]
			[Address(RVA = "0x1DE0890", Offset = "0x1DE0991", VA = "0x1DE0890", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04006253 RID: 25171
		[Token(Token = "0x4019117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04006254 RID: 25172
		[Token(Token = "0x4019118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04006255 RID: 25173
		[Token(Token = "0x4019119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float wait;

		// Token: 0x04006256 RID: 25174
		[Token(Token = "0x401911A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int npcId;

		// Token: 0x04006257 RID: 25175
		[Token(Token = "0x401911B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ShortplayAdvController <>4__this;

		// Token: 0x04006258 RID: 25176
		[Token(Token = "0x401911C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool relative;

		// Token: 0x04006259 RID: 25177
		[Token(Token = "0x401911D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float posX;

		// Token: 0x0400625A RID: 25178
		[Token(Token = "0x401911E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float posY;

		// Token: 0x0400625B RID: 25179
		[Token(Token = "0x401911F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float posZ;

		// Token: 0x0400625C RID: 25180
		[Token(Token = "0x4019120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float rotX;

		// Token: 0x0400625D RID: 25181
		[Token(Token = "0x4019121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float rotY;

		// Token: 0x0400625E RID: 25182
		[Token(Token = "0x4019122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float rotZ;
	}

	// Token: 0x02000499 RID: 1177
	[Token(Token = "0x20010AB")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157940", Offset = "0x157A41")]
	private sealed class <SetPositionName>d__99 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001CD1 RID: 7377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E80")]
		[Address(RVA = "0x1DE08A0", Offset = "0x1DE09A1", VA = "0x1DE08A0")]
		[DebuggerHidden]
		public <SetPositionName>d__99(int <>1__state)
		{
		}

		// Token: 0x06001CD2 RID: 7378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E81")]
		[Address(RVA = "0x1DE08D0", Offset = "0x1DE09D1", VA = "0x1DE08D0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001CD3 RID: 7379 RVA: 0x0000C690 File Offset: 0x0000A890
		[Token(Token = "0x6006E82")]
		[Address(RVA = "0x1DE08E0", Offset = "0x1DE09E1", VA = "0x1DE08E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06001CD4 RID: 7380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C61")]
		private object Current
		{
			[Token(Token = "0x6006E83")]
			[Address(RVA = "0x1DE0C20", Offset = "0x1DE0D21", VA = "0x1DE0C20", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001CD5 RID: 7381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E84")]
		[Address(RVA = "0x1DE0C30", Offset = "0x1DE0D31", VA = "0x1DE0C30", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06001CD6 RID: 7382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C62")]
		private object Current
		{
			[Token(Token = "0x6006E85")]
			[Address(RVA = "0x1DE0C90", Offset = "0x1DE0D91", VA = "0x1DE0C90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400625F RID: 25183
		[Token(Token = "0x4019123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04006260 RID: 25184
		[Token(Token = "0x4019124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04006261 RID: 25185
		[Token(Token = "0x4019125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float wait;

		// Token: 0x04006262 RID: 25186
		[Token(Token = "0x4019126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string name;

		// Token: 0x04006263 RID: 25187
		[Token(Token = "0x4019127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool relative;

		// Token: 0x04006264 RID: 25188
		[Token(Token = "0x4019128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float posX;

		// Token: 0x04006265 RID: 25189
		[Token(Token = "0x4019129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float posY;

		// Token: 0x04006266 RID: 25190
		[Token(Token = "0x401912A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float posZ;

		// Token: 0x04006267 RID: 25191
		[Token(Token = "0x401912B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float rotX;

		// Token: 0x04006268 RID: 25192
		[Token(Token = "0x401912C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float rotY;

		// Token: 0x04006269 RID: 25193
		[Token(Token = "0x401912D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float rotZ;
	}

	// Token: 0x0200049A RID: 1178
	[Token(Token = "0x20010AC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157950", Offset = "0x157A51")]
	private sealed class <MovePositionId>d__100 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001CD7 RID: 7383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E86")]
		[Address(RVA = "0x1DDDCF0", Offset = "0x1DDDDF1", VA = "0x1DDDCF0")]
		[DebuggerHidden]
		public <MovePositionId>d__100(int <>1__state)
		{
		}

		// Token: 0x06001CD8 RID: 7384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E87")]
		[Address(RVA = "0x1DDDD20", Offset = "0x1DDDE21", VA = "0x1DDDD20", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001CD9 RID: 7385 RVA: 0x0000C6A8 File Offset: 0x0000A8A8
		[Token(Token = "0x6006E88")]
		[Address(RVA = "0x1DDDD30", Offset = "0x1DDDE31", VA = "0x1DDDD30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06001CDA RID: 7386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C63")]
		private object Current
		{
			[Token(Token = "0x6006E89")]
			[Address(RVA = "0x1DDE1A0", Offset = "0x1DDE2A1", VA = "0x1DDE1A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001CDB RID: 7387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E8A")]
		[Address(RVA = "0x1DDE1B0", Offset = "0x1DDE2B1", VA = "0x1DDE1B0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06001CDC RID: 7388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C64")]
		private object Current
		{
			[Token(Token = "0x6006E8B")]
			[Address(RVA = "0x1DDE210", Offset = "0x1DDE311", VA = "0x1DDE210", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400626A RID: 25194
		[Token(Token = "0x401912E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400626B RID: 25195
		[Token(Token = "0x401912F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400626C RID: 25196
		[Token(Token = "0x4019130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float wait;

		// Token: 0x0400626D RID: 25197
		[Token(Token = "0x4019131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int npcId;

		// Token: 0x0400626E RID: 25198
		[Token(Token = "0x4019132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool relative;

		// Token: 0x0400626F RID: 25199
		[Token(Token = "0x4019133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float posX;

		// Token: 0x04006270 RID: 25200
		[Token(Token = "0x4019134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float posY;

		// Token: 0x04006271 RID: 25201
		[Token(Token = "0x4019135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float posZ;

		// Token: 0x04006272 RID: 25202
		[Token(Token = "0x4019136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public ShortplayAdvController <>4__this;

		// Token: 0x04006273 RID: 25203
		[Token(Token = "0x4019137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float moveSpeed;

		// Token: 0x04006274 RID: 25204
		[Token(Token = "0x4019138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float locomotion;
	}

	// Token: 0x0200049B RID: 1179
	[Token(Token = "0x20010AD")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157960", Offset = "0x157A61")]
	private sealed class <MovePositionName>d__101 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001CDD RID: 7389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E8C")]
		[Address(RVA = "0x1DDE220", Offset = "0x1DDE321", VA = "0x1DDE220")]
		[DebuggerHidden]
		public <MovePositionName>d__101(int <>1__state)
		{
		}

		// Token: 0x06001CDE RID: 7390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E8D")]
		[Address(RVA = "0x1DDE250", Offset = "0x1DDE351", VA = "0x1DDE250", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001CDF RID: 7391 RVA: 0x0000C6C0 File Offset: 0x0000A8C0
		[Token(Token = "0x6006E8E")]
		[Address(RVA = "0x1DDE260", Offset = "0x1DDE361", VA = "0x1DDE260", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06001CE0 RID: 7392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C65")]
		private object Current
		{
			[Token(Token = "0x6006E8F")]
			[Address(RVA = "0x1DDE490", Offset = "0x1DDE591", VA = "0x1DDE490", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001CE1 RID: 7393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E90")]
		[Address(RVA = "0x1DDE4A0", Offset = "0x1DDE5A1", VA = "0x1DDE4A0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06001CE2 RID: 7394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C66")]
		private object Current
		{
			[Token(Token = "0x6006E91")]
			[Address(RVA = "0x1DDE500", Offset = "0x1DDE601", VA = "0x1DDE500", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04006275 RID: 25205
		[Token(Token = "0x4019139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04006276 RID: 25206
		[Token(Token = "0x401913A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04006277 RID: 25207
		[Token(Token = "0x401913B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float wait;

		// Token: 0x04006278 RID: 25208
		[Token(Token = "0x401913C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string name;

		// Token: 0x04006279 RID: 25209
		[Token(Token = "0x401913D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool relative;

		// Token: 0x0400627A RID: 25210
		[Token(Token = "0x401913E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float posX;

		// Token: 0x0400627B RID: 25211
		[Token(Token = "0x401913F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float posY;

		// Token: 0x0400627C RID: 25212
		[Token(Token = "0x4019140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float posZ;

		// Token: 0x0400627D RID: 25213
		[Token(Token = "0x4019141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float moveSpeed;

		// Token: 0x0400627E RID: 25214
		[Token(Token = "0x4019142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float locomotion;
	}

	// Token: 0x0200049C RID: 1180
	[Token(Token = "0x20010AE")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157970", Offset = "0x157A71")]
	private sealed class <StartBgm>d__102 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001CE3 RID: 7395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E92")]
		[Address(RVA = "0x1DE1DE0", Offset = "0x1DE1EE1", VA = "0x1DE1DE0")]
		[DebuggerHidden]
		public <StartBgm>d__102(int <>1__state)
		{
		}

		// Token: 0x06001CE4 RID: 7396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E93")]
		[Address(RVA = "0x1DE1E10", Offset = "0x1DE1F11", VA = "0x1DE1E10", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001CE5 RID: 7397 RVA: 0x0000C6D8 File Offset: 0x0000A8D8
		[Token(Token = "0x6006E94")]
		[Address(RVA = "0x1DE1E20", Offset = "0x1DE1F21", VA = "0x1DE1E20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06001CE6 RID: 7398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C67")]
		private object Current
		{
			[Token(Token = "0x6006E95")]
			[Address(RVA = "0x1DE1F20", Offset = "0x1DE2021", VA = "0x1DE1F20", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001CE7 RID: 7399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E96")]
		[Address(RVA = "0x1DE1F30", Offset = "0x1DE2031", VA = "0x1DE1F30", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06001CE8 RID: 7400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C68")]
		private object Current
		{
			[Token(Token = "0x6006E97")]
			[Address(RVA = "0x1DE1F90", Offset = "0x1DE2091", VA = "0x1DE1F90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400627F RID: 25215
		[Token(Token = "0x4019143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04006280 RID: 25216
		[Token(Token = "0x4019144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04006281 RID: 25217
		[Token(Token = "0x4019145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float wait;

		// Token: 0x04006282 RID: 25218
		[Token(Token = "0x4019146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string name;
	}

	// Token: 0x0200049D RID: 1181
	[Token(Token = "0x20010AF")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157980", Offset = "0x157A81")]
	private sealed class <StopBgm>d__103 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001CE9 RID: 7401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E98")]
		[Address(RVA = "0x1DE2320", Offset = "0x1DE2421", VA = "0x1DE2320")]
		[DebuggerHidden]
		public <StopBgm>d__103(int <>1__state)
		{
		}

		// Token: 0x06001CEA RID: 7402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E99")]
		[Address(RVA = "0x1DE2350", Offset = "0x1DE2451", VA = "0x1DE2350", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001CEB RID: 7403 RVA: 0x0000C6F0 File Offset: 0x0000A8F0
		[Token(Token = "0x6006E9A")]
		[Address(RVA = "0x1DE2360", Offset = "0x1DE2461", VA = "0x1DE2360", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06001CEC RID: 7404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C69")]
		private object Current
		{
			[Token(Token = "0x6006E9B")]
			[Address(RVA = "0x1DE2460", Offset = "0x1DE2561", VA = "0x1DE2460", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001CED RID: 7405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E9C")]
		[Address(RVA = "0x1DE2470", Offset = "0x1DE2571", VA = "0x1DE2470", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06001CEE RID: 7406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C6A")]
		private object Current
		{
			[Token(Token = "0x6006E9D")]
			[Address(RVA = "0x1DE24D0", Offset = "0x1DE25D1", VA = "0x1DE24D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04006283 RID: 25219
		[Token(Token = "0x4019147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04006284 RID: 25220
		[Token(Token = "0x4019148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04006285 RID: 25221
		[Token(Token = "0x4019149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float wait;
	}

	// Token: 0x0200049E RID: 1182
	[Token(Token = "0x20010B0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157990", Offset = "0x157A91")]
	private sealed class <StartSe>d__104 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001CEF RID: 7407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E9E")]
		[Address(RVA = "0x1DE1FA0", Offset = "0x1DE20A1", VA = "0x1DE1FA0")]
		[DebuggerHidden]
		public <StartSe>d__104(int <>1__state)
		{
		}

		// Token: 0x06001CF0 RID: 7408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E9F")]
		[Address(RVA = "0x1DE1FD0", Offset = "0x1DE20D1", VA = "0x1DE1FD0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001CF1 RID: 7409 RVA: 0x0000C708 File Offset: 0x0000A908
		[Token(Token = "0x6006EA0")]
		[Address(RVA = "0x1DE1FE0", Offset = "0x1DE20E1", VA = "0x1DE1FE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06001CF2 RID: 7410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C6B")]
		private object Current
		{
			[Token(Token = "0x6006EA1")]
			[Address(RVA = "0x1DE20E0", Offset = "0x1DE21E1", VA = "0x1DE20E0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001CF3 RID: 7411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EA2")]
		[Address(RVA = "0x1DE20F0", Offset = "0x1DE21F1", VA = "0x1DE20F0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x06001CF4 RID: 7412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C6C")]
		private object Current
		{
			[Token(Token = "0x6006EA3")]
			[Address(RVA = "0x1DE2150", Offset = "0x1DE2251", VA = "0x1DE2150", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04006286 RID: 25222
		[Token(Token = "0x401914A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04006287 RID: 25223
		[Token(Token = "0x401914B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04006288 RID: 25224
		[Token(Token = "0x401914C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float wait;

		// Token: 0x04006289 RID: 25225
		[Token(Token = "0x401914D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string name;
	}

	// Token: 0x0200049F RID: 1183
	[Token(Token = "0x20010B1")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1579A0", Offset = "0x157AA1")]
	private sealed class <StopSe>d__105 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001CF5 RID: 7413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EA4")]
		[Address(RVA = "0x1DE2600", Offset = "0x1DE2701", VA = "0x1DE2600")]
		[DebuggerHidden]
		public <StopSe>d__105(int <>1__state)
		{
		}

		// Token: 0x06001CF6 RID: 7414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EA5")]
		[Address(RVA = "0x1DE2630", Offset = "0x1DE2731", VA = "0x1DE2630", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001CF7 RID: 7415 RVA: 0x0000C720 File Offset: 0x0000A920
		[Token(Token = "0x6006EA6")]
		[Address(RVA = "0x1DE2640", Offset = "0x1DE2741", VA = "0x1DE2640", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06001CF8 RID: 7416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C6D")]
		private object Current
		{
			[Token(Token = "0x6006EA7")]
			[Address(RVA = "0x1DE2740", Offset = "0x1DE2841", VA = "0x1DE2740", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001CF9 RID: 7417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EA8")]
		[Address(RVA = "0x1DE2750", Offset = "0x1DE2851", VA = "0x1DE2750", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06001CFA RID: 7418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C6E")]
		private object Current
		{
			[Token(Token = "0x6006EA9")]
			[Address(RVA = "0x1DE27B0", Offset = "0x1DE28B1", VA = "0x1DE27B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400628A RID: 25226
		[Token(Token = "0x401914E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400628B RID: 25227
		[Token(Token = "0x401914F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400628C RID: 25228
		[Token(Token = "0x4019150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float wait;

		// Token: 0x0400628D RID: 25229
		[Token(Token = "0x4019151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string name;
	}

	// Token: 0x020004A0 RID: 1184
	[Token(Token = "0x20010B2")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1579B0", Offset = "0x157AB1")]
	private sealed class <StartVoice>d__106 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001CFB RID: 7419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EAA")]
		[Address(RVA = "0x1DE2160", Offset = "0x1DE2261", VA = "0x1DE2160")]
		[DebuggerHidden]
		public <StartVoice>d__106(int <>1__state)
		{
		}

		// Token: 0x06001CFC RID: 7420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EAB")]
		[Address(RVA = "0x1DE2190", Offset = "0x1DE2291", VA = "0x1DE2190", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001CFD RID: 7421 RVA: 0x0000C738 File Offset: 0x0000A938
		[Token(Token = "0x6006EAC")]
		[Address(RVA = "0x1DE21A0", Offset = "0x1DE22A1", VA = "0x1DE21A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06001CFE RID: 7422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C6F")]
		private object Current
		{
			[Token(Token = "0x6006EAD")]
			[Address(RVA = "0x1DE22A0", Offset = "0x1DE23A1", VA = "0x1DE22A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001CFF RID: 7423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EAE")]
		[Address(RVA = "0x1DE22B0", Offset = "0x1DE23B1", VA = "0x1DE22B0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06001D00 RID: 7424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C70")]
		private object Current
		{
			[Token(Token = "0x6006EAF")]
			[Address(RVA = "0x1DE2310", Offset = "0x1DE2411", VA = "0x1DE2310", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400628E RID: 25230
		[Token(Token = "0x4019152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400628F RID: 25231
		[Token(Token = "0x4019153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04006290 RID: 25232
		[Token(Token = "0x4019154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float wait;

		// Token: 0x04006291 RID: 25233
		[Token(Token = "0x4019155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string name;
	}

	// Token: 0x020004A1 RID: 1185
	[Token(Token = "0x20010B3")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1579C0", Offset = "0x157AC1")]
	private sealed class <StopVoice>d__107 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001D01 RID: 7425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EB0")]
		[Address(RVA = "0x1DE27C0", Offset = "0x1DE28C1", VA = "0x1DE27C0")]
		[DebuggerHidden]
		public <StopVoice>d__107(int <>1__state)
		{
		}

		// Token: 0x06001D02 RID: 7426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EB1")]
		[Address(RVA = "0x1DE27F0", Offset = "0x1DE28F1", VA = "0x1DE27F0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001D03 RID: 7427 RVA: 0x0000C750 File Offset: 0x0000A950
		[Token(Token = "0x6006EB2")]
		[Address(RVA = "0x1DE2800", Offset = "0x1DE2901", VA = "0x1DE2800", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06001D04 RID: 7428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C71")]
		private object Current
		{
			[Token(Token = "0x6006EB3")]
			[Address(RVA = "0x1DE2900", Offset = "0x1DE2A01", VA = "0x1DE2900", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001D05 RID: 7429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EB4")]
		[Address(RVA = "0x1DE2910", Offset = "0x1DE2A11", VA = "0x1DE2910", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06001D06 RID: 7430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C72")]
		private object Current
		{
			[Token(Token = "0x6006EB5")]
			[Address(RVA = "0x1DE2970", Offset = "0x1DE2A71", VA = "0x1DE2970", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04006292 RID: 25234
		[Token(Token = "0x4019156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04006293 RID: 25235
		[Token(Token = "0x4019157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04006294 RID: 25236
		[Token(Token = "0x4019158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float wait;

		// Token: 0x04006295 RID: 25237
		[Token(Token = "0x4019159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string name;
	}

	// Token: 0x020004A2 RID: 1186
	[Token(Token = "0x20010B4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1579D0", Offset = "0x157AD1")]
	private sealed class <FaceParttern>d__124 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001D07 RID: 7431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EB6")]
		[Address(RVA = "0x1DDCEA0", Offset = "0x1DDCFA1", VA = "0x1DDCEA0")]
		[DebuggerHidden]
		public <FaceParttern>d__124(int <>1__state)
		{
		}

		// Token: 0x06001D08 RID: 7432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EB7")]
		[Address(RVA = "0x1DDCED0", Offset = "0x1DDCFD1", VA = "0x1DDCED0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001D09 RID: 7433 RVA: 0x0000C768 File Offset: 0x0000A968
		[Token(Token = "0x6006EB8")]
		[Address(RVA = "0x1DDCEE0", Offset = "0x1DDCFE1", VA = "0x1DDCEE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06001D0A RID: 7434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C73")]
		private object Current
		{
			[Token(Token = "0x6006EB9")]
			[Address(RVA = "0x1DDD1B0", Offset = "0x1DDD2B1", VA = "0x1DDD1B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001D0B RID: 7435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EBA")]
		[Address(RVA = "0x1DDD1C0", Offset = "0x1DDD2C1", VA = "0x1DDD1C0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06001D0C RID: 7436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C74")]
		private object Current
		{
			[Token(Token = "0x6006EBB")]
			[Address(RVA = "0x1DDD220", Offset = "0x1DDD321", VA = "0x1DDD220", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04006296 RID: 25238
		[Token(Token = "0x401915A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04006297 RID: 25239
		[Token(Token = "0x401915B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04006298 RID: 25240
		[Token(Token = "0x401915C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float wait;

		// Token: 0x04006299 RID: 25241
		[Token(Token = "0x401915D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int npcId;

		// Token: 0x0400629A RID: 25242
		[Token(Token = "0x401915E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ShortplayAdvController <>4__this;

		// Token: 0x0400629B RID: 25243
		[Token(Token = "0x401915F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int faceId;
	}

	// Token: 0x020004A3 RID: 1187
	[Token(Token = "0x20010B5")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1579E0", Offset = "0x157AE1")]
	private sealed class <LookAtTarget>d__125 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001D0D RID: 7437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EBC")]
		[Address(RVA = "0x1DDD230", Offset = "0x1DDD331", VA = "0x1DDD230")]
		[DebuggerHidden]
		public <LookAtTarget>d__125(int <>1__state)
		{
		}

		// Token: 0x06001D0E RID: 7438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EBD")]
		[Address(RVA = "0x1DDD260", Offset = "0x1DDD361", VA = "0x1DDD260", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001D0F RID: 7439 RVA: 0x0000C780 File Offset: 0x0000A980
		[Token(Token = "0x6006EBE")]
		[Address(RVA = "0x1DDD270", Offset = "0x1DDD371", VA = "0x1DDD270", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06001D10 RID: 7440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C75")]
		private object Current
		{
			[Token(Token = "0x6006EBF")]
			[Address(RVA = "0x1DDDA30", Offset = "0x1DDDB31", VA = "0x1DDDA30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001D11 RID: 7441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EC0")]
		[Address(RVA = "0x1DDDA40", Offset = "0x1DDDB41", VA = "0x1DDDA40", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06001D12 RID: 7442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C76")]
		private object Current
		{
			[Token(Token = "0x6006EC1")]
			[Address(RVA = "0x1DDDAA0", Offset = "0x1DDDBA1", VA = "0x1DDDAA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400629C RID: 25244
		[Token(Token = "0x4019160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400629D RID: 25245
		[Token(Token = "0x4019161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400629E RID: 25246
		[Token(Token = "0x4019162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float wait;

		// Token: 0x0400629F RID: 25247
		[Token(Token = "0x4019163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float speed;

		// Token: 0x040062A0 RID: 25248
		[Token(Token = "0x4019164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int npcId;

		// Token: 0x040062A1 RID: 25249
		[Token(Token = "0x4019165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int targetNpcId;

		// Token: 0x040062A2 RID: 25250
		[Token(Token = "0x4019166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float posX;

		// Token: 0x040062A3 RID: 25251
		[Token(Token = "0x4019167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float posY;

		// Token: 0x040062A4 RID: 25252
		[Token(Token = "0x4019168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float posZ;

		// Token: 0x040062A5 RID: 25253
		[Token(Token = "0x4019169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ShortplayAdvController <>4__this;
	}

	// Token: 0x020004A4 RID: 1188
	[Token(Token = "0x20010B6")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1579F0", Offset = "0x157AF1")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06001D14 RID: 7444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EC3")]
		[Address(RVA = "0x1E44020", Offset = "0x1E44121", VA = "0x1E44020")]
		public <>c()
		{
		}

		// Token: 0x06001D15 RID: 7445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EC4")]
		[Address(RVA = "0x1E44030", Offset = "0x1E44131", VA = "0x1E44030")]
		internal void <StartMovie>b__126_0()
		{
		}

		// Token: 0x040062A6 RID: 25254
		[Token(Token = "0x401916A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly ShortplayAdvController.<>c <>9;

		// Token: 0x040062A7 RID: 25255
		[Token(Token = "0x401916B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static UnityAction <>9__126_0;
	}

	// Token: 0x020004A5 RID: 1189
	[Token(Token = "0x20010B7")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157A00", Offset = "0x157B01")]
	private sealed class <AllNpcDisable>d__127 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001D16 RID: 7446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EC5")]
		[Address(RVA = "0x1DDB6C0", Offset = "0x1DDB7C1", VA = "0x1DDB6C0")]
		[DebuggerHidden]
		public <AllNpcDisable>d__127(int <>1__state)
		{
		}

		// Token: 0x06001D17 RID: 7447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EC6")]
		[Address(RVA = "0x1DDB6F0", Offset = "0x1DDB7F1", VA = "0x1DDB6F0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001D18 RID: 7448 RVA: 0x0000C798 File Offset: 0x0000A998
		[Token(Token = "0x6006EC7")]
		[Address(RVA = "0x1DDB700", Offset = "0x1DDB801", VA = "0x1DDB700", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06001D19 RID: 7449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C77")]
		private object Current
		{
			[Token(Token = "0x6006EC8")]
			[Address(RVA = "0x1DDBA20", Offset = "0x1DDBB21", VA = "0x1DDBA20", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001D1A RID: 7450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EC9")]
		[Address(RVA = "0x1DDBA30", Offset = "0x1DDBB31", VA = "0x1DDBA30", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x06001D1B RID: 7451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C78")]
		private object Current
		{
			[Token(Token = "0x6006ECA")]
			[Address(RVA = "0x1DDBA90", Offset = "0x1DDBB91", VA = "0x1DDBA90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040062A8 RID: 25256
		[Token(Token = "0x401916C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040062A9 RID: 25257
		[Token(Token = "0x401916D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040062AA RID: 25258
		[Token(Token = "0x401916E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float wait;

		// Token: 0x040062AB RID: 25259
		[Token(Token = "0x401916F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool forceDisabled;
	}

	// Token: 0x020004A6 RID: 1190
	[Token(Token = "0x20010B8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157A10", Offset = "0x157B11")]
	private sealed class <>c__DisplayClass128_0
	{
		// Token: 0x06001D1C RID: 7452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006ECB")]
		[Address(RVA = "0x1E44140", Offset = "0x1E44241", VA = "0x1E44140")]
		public <>c__DisplayClass128_0()
		{
		}

		// Token: 0x06001D1D RID: 7453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006ECC")]
		[Address(RVA = "0x1E44150", Offset = "0x1E44251", VA = "0x1E44150")]
		internal void <SummonMonster>b__2(BossBehaviorController behaviorController)
		{
		}

		// Token: 0x06001D1E RID: 7454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006ECD")]
		[Address(RVA = "0x1E44230", Offset = "0x1E44331", VA = "0x1E44230")]
		internal void <SummonMonster>b__4(EnemyBehaviorController behaviorcontroller)
		{
		}

		// Token: 0x040062AC RID: 25260
		[Token(Token = "0x4019170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float posX;

		// Token: 0x040062AD RID: 25261
		[Token(Token = "0x4019171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float posY;

		// Token: 0x040062AE RID: 25262
		[Token(Token = "0x4019172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float posZ;

		// Token: 0x040062AF RID: 25263
		[Token(Token = "0x4019173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float rotX;

		// Token: 0x040062B0 RID: 25264
		[Token(Token = "0x4019174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float rotY;

		// Token: 0x040062B1 RID: 25265
		[Token(Token = "0x4019175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float rotZ;

		// Token: 0x040062B2 RID: 25266
		[Token(Token = "0x4019176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string name;
	}

	// Token: 0x020004A7 RID: 1191
	[Token(Token = "0x20010B9")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157A20", Offset = "0x157B21")]
	private sealed class <>c__DisplayClass128_1
	{
		// Token: 0x06001D1F RID: 7455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006ECE")]
		[Address(RVA = "0x1E44310", Offset = "0x1E44411", VA = "0x1E44310")]
		public <>c__DisplayClass128_1()
		{
		}

		// Token: 0x06001D20 RID: 7456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006ECF")]
		[Address(RVA = "0x1E44320", Offset = "0x1E44421", VA = "0x1E44320")]
		internal void <SummonMonster>b__0(SpcMonsterController smc)
		{
		}

		// Token: 0x040062B3 RID: 25267
		[Token(Token = "0x4019177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SpcMonsterController spcMonsterController;

		// Token: 0x040062B4 RID: 25268
		[Token(Token = "0x4019178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ShortplayAdvController.<>c__DisplayClass128_0 CS$<>8__locals1;
	}

	// Token: 0x020004A8 RID: 1192
	[Token(Token = "0x20010BA")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157A30", Offset = "0x157B31")]
	private sealed class <>c__DisplayClass128_2
	{
		// Token: 0x06001D21 RID: 7457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006ED0")]
		[Address(RVA = "0x1DDB280", Offset = "0x1DDB381", VA = "0x1DDB280")]
		public <>c__DisplayClass128_2()
		{
		}

		// Token: 0x06001D22 RID: 7458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006ED1")]
		[Address(RVA = "0x1DDB290", Offset = "0x1DDB391", VA = "0x1DDB290")]
		internal void <SummonMonster>b__1(MonsterControllerBase enemyBossMonsterInstance)
		{
		}

		// Token: 0x040062B5 RID: 25269
		[Token(Token = "0x4019179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MonsterControllerBase enemyBossMonster;
	}

	// Token: 0x020004A9 RID: 1193
	[Token(Token = "0x20010BB")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157A40", Offset = "0x157B41")]
	private sealed class <>c__DisplayClass128_3
	{
		// Token: 0x06001D23 RID: 7459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006ED2")]
		[Address(RVA = "0x1DDB360", Offset = "0x1DDB461", VA = "0x1DDB360")]
		public <>c__DisplayClass128_3()
		{
		}

		// Token: 0x06001D24 RID: 7460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006ED3")]
		[Address(RVA = "0x1DDB370", Offset = "0x1DDB471", VA = "0x1DDB370")]
		internal void <SummonMonster>b__3(MonsterControllerBase enemyParameter)
		{
		}

		// Token: 0x040062B6 RID: 25270
		[Token(Token = "0x401917A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MonsterControllerBase monsterController;
	}

	// Token: 0x020004AA RID: 1194
	[Token(Token = "0x20010BC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157A50", Offset = "0x157B51")]
	private sealed class <SummonMonster>d__128 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001D25 RID: 7461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006ED4")]
		[Address(RVA = "0x1DE2980", Offset = "0x1DE2A81", VA = "0x1DE2980")]
		[DebuggerHidden]
		public <SummonMonster>d__128(int <>1__state)
		{
		}

		// Token: 0x06001D26 RID: 7462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006ED5")]
		[Address(RVA = "0x1DE29B0", Offset = "0x1DE2AB1", VA = "0x1DE29B0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001D27 RID: 7463 RVA: 0x0000C7B0 File Offset: 0x0000A9B0
		[Token(Token = "0x6006ED6")]
		[Address(RVA = "0x1DE29C0", Offset = "0x1DE2AC1", VA = "0x1DE29C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06001D28 RID: 7464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C79")]
		private object Current
		{
			[Token(Token = "0x6006ED7")]
			[Address(RVA = "0x1DE3190", Offset = "0x1DE3291", VA = "0x1DE3190", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001D29 RID: 7465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006ED8")]
		[Address(RVA = "0x1DE31A0", Offset = "0x1DE32A1", VA = "0x1DE31A0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06001D2A RID: 7466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C7A")]
		private object Current
		{
			[Token(Token = "0x6006ED9")]
			[Address(RVA = "0x1DE3200", Offset = "0x1DE3301", VA = "0x1DE3200", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040062B7 RID: 25271
		[Token(Token = "0x401917B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040062B8 RID: 25272
		[Token(Token = "0x401917C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040062B9 RID: 25273
		[Token(Token = "0x401917D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float posX;

		// Token: 0x040062BA RID: 25274
		[Token(Token = "0x401917E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float posY;

		// Token: 0x040062BB RID: 25275
		[Token(Token = "0x401917F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float posZ;

		// Token: 0x040062BC RID: 25276
		[Token(Token = "0x4019180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float rotX;

		// Token: 0x040062BD RID: 25277
		[Token(Token = "0x4019181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float rotY;

		// Token: 0x040062BE RID: 25278
		[Token(Token = "0x4019182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float rotZ;

		// Token: 0x040062BF RID: 25279
		[Token(Token = "0x4019183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string name;

		// Token: 0x040062C0 RID: 25280
		[Token(Token = "0x4019184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float wait;

		// Token: 0x040062C1 RID: 25281
		[Token(Token = "0x4019185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public int IsShortPlayMonster;

		// Token: 0x040062C2 RID: 25282
		[Token(Token = "0x4019186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private ShortplayAdvController.<>c__DisplayClass128_0 <>8__1;

		// Token: 0x040062C3 RID: 25283
		[Token(Token = "0x4019187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public MonsterDataID id;

		// Token: 0x040062C4 RID: 25284
		[Token(Token = "0x4019188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private ShortplayAdvController.<>c__DisplayClass128_2 <>8__2;

		// Token: 0x040062C5 RID: 25285
		[Token(Token = "0x4019189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ShortplayAdvController.<>c__DisplayClass128_3 <>8__3;
	}
}

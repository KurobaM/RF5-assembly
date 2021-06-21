using System;
using System.Collections.Generic;
using Field;
using Il2CppDummyDll;

// Token: 0x0200064E RID: 1614
[Token(Token = "0x2000486")]
public class OnGroundItemManager : SingletonMonoBehaviour<OnGroundItemManager>
{
	// Token: 0x17000662 RID: 1634
	// (get) Token: 0x06002820 RID: 10272 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700051C")]
	public LinkedList<FieldOnGroundItemInfo> InfoList
	{
		[Token(Token = "0x60021F2")]
		[Address(RVA = "0x20C3D20", Offset = "0x20C3E21", VA = "0x20C3D20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1EA0", Offset = "0x1A1FA1")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000663 RID: 1635
	// (get) Token: 0x06002821 RID: 10273 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700051D")]
	public Dictionary<OnGroundItem, LinkedListNode<FieldOnGroundItemInfo>> OnGroundItems
	{
		[Token(Token = "0x60021F3")]
		[Address(RVA = "0x20C3D30", Offset = "0x20C3E31", VA = "0x20C3D30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1EB0", Offset = "0x1A1FB1")]
		get
		{
			return null;
		}
	}

	// Token: 0x06002822 RID: 10274 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60021F4")]
	[Address(RVA = "0x20C3D40", Offset = "0x20C3E41", VA = "0x20C3D40")]
	public void Regist(OnGroundItem onGroundItem)
	{
	}

	// Token: 0x06002823 RID: 10275 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60021F5")]
	[Address(RVA = "0x20C4010", Offset = "0x20C4111", VA = "0x20C4010")]
	public void Remove(OnGroundItem onGroundItem)
	{
	}

	// Token: 0x06002824 RID: 10276 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60021F6")]
	[Address(RVA = "0x20C4180", Offset = "0x20C4281", VA = "0x20C4180")]
	public void OnDestroyOnGroundItem(OnGroundItem onGroundItem)
	{
	}

	// Token: 0x06002825 RID: 10277 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60021F7")]
	[Address(RVA = "0x20C4290", Offset = "0x20C4391", VA = "0x20C4290")]
	public void OnSceneChanged(FieldSceneId nextScene)
	{
	}

	// Token: 0x06002826 RID: 10278 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60021F8")]
	[Address(RVA = "0x20C44C0", Offset = "0x20C45C1", VA = "0x20C44C0")]
	public void UpdateMeshShadow(Func<float, bool> checkEnableShadowFunc)
	{
	}

	// Token: 0x06002827 RID: 10279 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60021F9")]
	[Address(RVA = "0x20C47F0", Offset = "0x20C48F1", VA = "0x20C47F0")]
	public void ResetMeshShadow()
	{
	}

	// Token: 0x17000664 RID: 1636
	// (get) Token: 0x06002828 RID: 10280 RVA: 0x0000FEB8 File Offset: 0x0000E0B8
	[Token(Token = "0x1700051E")]
	public static bool IsHideByCamera
	{
		[Token(Token = "0x60021FA")]
		[Address(RVA = "0x20C49C0", Offset = "0x20C4AC1", VA = "0x20C49C0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06002829 RID: 10281 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60021FB")]
	[Address(RVA = "0x20C4A80", Offset = "0x20C4B81", VA = "0x20C4A80")]
	private void Update()
	{
	}

	// Token: 0x0600282A RID: 10282 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60021FC")]
	[Address(RVA = "0x20C4D50", Offset = "0x20C4E51", VA = "0x20C4D50")]
	private void Start()
	{
	}

	// Token: 0x0600282B RID: 10283 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60021FD")]
	[Address(RVA = "0x20C4EA0", Offset = "0x20C4FA1", VA = "0x20C4EA0")]
	public void PrevSave()
	{
	}

	// Token: 0x0600282C RID: 10284 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60021FE")]
	[Address(RVA = "0x20C50B0", Offset = "0x20C51B1", VA = "0x20C50B0")]
	private void OnChangeScene()
	{
	}

	// Token: 0x0600282D RID: 10285 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60021FF")]
	[Address(RVA = "0x20C5110", Offset = "0x20C5211", VA = "0x20C5110")]
	public OnGroundItemManager()
	{
	}

	// Token: 0x04006F98 RID: 28568
	[Token(Token = "0x4006826")]
	public const int FieldMax = 15;

	// Token: 0x04006F99 RID: 28569
	[Token(Token = "0x4006827")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x168590", Offset = "0x168691")]
	private readonly LinkedList<FieldOnGroundItemInfo> <InfoList>k__BackingField;

	// Token: 0x04006F9A RID: 28570
	[Token(Token = "0x4006828")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1685A0", Offset = "0x1686A1")]
	private readonly Dictionary<OnGroundItem, LinkedListNode<FieldOnGroundItemInfo>> <OnGroundItems>k__BackingField;

	// Token: 0x04006F9B RID: 28571
	[Token(Token = "0x4006829")]
	[FieldOffset(Offset = "0x28")]
	private bool prevFrame_IsHideByCamera;
}

using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000A02 RID: 2562
[Token(Token = "0x20006B6")]
public class CampMenuMain : MonoBehaviour
{
	// Token: 0x1700092E RID: 2350
	// (get) Token: 0x06004322 RID: 17186 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700075A")]
	private Camera MyCamera
	{
		[Token(Token = "0x6003823")]
		[Address(RVA = "0x1E7AA50", Offset = "0x1E7AB51", VA = "0x1E7AA50")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700092F RID: 2351
	// (get) Token: 0x06004323 RID: 17187 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700075B")]
	private UIModelLoader UIEquipModel
	{
		[Token(Token = "0x6003824")]
		[Address(RVA = "0x1E7AAB0", Offset = "0x1E7ABB1", VA = "0x1E7AAB0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06004324 RID: 17188 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003825")]
	[Address(RVA = "0x1E7AB10", Offset = "0x1E7AC11", VA = "0x1E7AB10")]
	public void OpenModelView(ActorID actor_id)
	{
	}

	// Token: 0x06004325 RID: 17189 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003826")]
	[Address(RVA = "0x1E7AC10", Offset = "0x1E7AD11", VA = "0x1E7AC10")]
	public void OpenModelView(MonsterDataID monsterDataID)
	{
	}

	// Token: 0x06004326 RID: 17190 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003827")]
	[Address(RVA = "0x1E7AD10", Offset = "0x1E7AE11", VA = "0x1E7AD10")]
	public void ResetModelEquip()
	{
	}

	// Token: 0x06004327 RID: 17191 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003828")]
	[Address(RVA = "0x1E7ADF0", Offset = "0x1E7AEF1", VA = "0x1E7ADF0")]
	public void CloseModelView()
	{
	}

	// Token: 0x06004328 RID: 17192 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003829")]
	[Address(RVA = "0x1E7AFC0", Offset = "0x1E7B0C1", VA = "0x1E7AFC0")]
	private void Start()
	{
	}

	// Token: 0x06004329 RID: 17193 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600382A")]
	[Address(RVA = "0x1E7B040", Offset = "0x1E7B141", VA = "0x1E7B040")]
	private void Update()
	{
	}

	// Token: 0x0600432A RID: 17194 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600382B")]
	[Address(RVA = "0x1E7B340", Offset = "0x1E7B441", VA = "0x1E7B340")]
	private void StartCamp()
	{
	}

	// Token: 0x0600432B RID: 17195 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600382C")]
	[Address(RVA = "0x1E7B9C0", Offset = "0x1E7BAC1", VA = "0x1E7B9C0")]
	public void StartCampOnSave()
	{
	}

	// Token: 0x0600432C RID: 17196 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600382D")]
	[Address(RVA = "0x1E7B5F0", Offset = "0x1E7B6F1", VA = "0x1E7B5F0")]
	public void CloseCamp()
	{
	}

	// Token: 0x0600432D RID: 17197 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600382E")]
	[Address(RVA = "0x1E7BA70", Offset = "0x1E7BB71", VA = "0x1E7BA70")]
	public CampMenuMain()
	{
	}

	// Token: 0x0400A1C1 RID: 41409
	[Token(Token = "0x4007A23")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private CursorLinkConnector CenterMenuObj;

	// Token: 0x0400A1C2 RID: 41410
	[Token(Token = "0x4007A24")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private CampPage firstPage;

	// Token: 0x0400A1C3 RID: 41411
	[Token(Token = "0x4007A25")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private CampPageSwitcher campPageSwitcher;

	// Token: 0x0400A1C4 RID: 41412
	[Token(Token = "0x4007A26")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private CursorController MyCursor;

	// Token: 0x0400A1C5 RID: 41413
	[Token(Token = "0x4007A27")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Color CampModelAmbientColor;

	// Token: 0x0400A1C6 RID: 41414
	[Token(Token = "0x4007A28")]
	[FieldOffset(Offset = "0x48")]
	public GameObject SubMenuObj;

	// Token: 0x0400A1C7 RID: 41415
	[Token(Token = "0x4007A29")]
	[FieldOffset(Offset = "0x50")]
	private bool MenuOpened;

	// Token: 0x0400A1C8 RID: 41416
	[Token(Token = "0x4007A2A")]
	[FieldOffset(Offset = "0x51")]
	public bool isOpendModelView;

	// Token: 0x0400A1C9 RID: 41417
	[Token(Token = "0x4007A2B")]
	[FieldOffset(Offset = "0x52")]
	public bool cursorUsedOpenModelView;

	// Token: 0x0400A1CA RID: 41418
	[Token(Token = "0x4007A2C")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private GameObject ModelViewerMenu;

	// Token: 0x0400A1CB RID: 41419
	[Token(Token = "0x4007A2D")]
	[FieldOffset(Offset = "0x60")]
	public Transform SubMenuParent;

	// Token: 0x0400A1CC RID: 41420
	[Token(Token = "0x4007A2E")]
	[FieldOffset(Offset = "0x68")]
	private ButtonGuideId idOnOpenModelView;

	// Token: 0x0400A1CD RID: 41421
	[Token(Token = "0x4007A2F")]
	[FieldOffset(Offset = "0x6C")]
	public bool CanSaveState;

	// Token: 0x0400A1CE RID: 41422
	[Token(Token = "0x4007A30")]
	[FieldOffset(Offset = "0x70")]
	public Color tempAmbientLight;

	// Token: 0x02000A03 RID: 2563
	[Token(Token = "0x20012CE")]
	public enum TempItemSlot
	{
		// Token: 0x0400A1D0 RID: 41424
		[Token(Token = "0x401B402")]
		Hand,
		// Token: 0x0400A1D1 RID: 41425
		[Token(Token = "0x401B403")]
		PlayerEquipTool,
		// Token: 0x0400A1D2 RID: 41426
		[Token(Token = "0x401B404")]
		PlayerEquipHead,
		// Token: 0x0400A1D3 RID: 41427
		[Token(Token = "0x401B405")]
		PlayerEquipShield,
		// Token: 0x0400A1D4 RID: 41428
		[Token(Token = "0x401B406")]
		PlayerEquipBody,
		// Token: 0x0400A1D5 RID: 41429
		[Token(Token = "0x401B407")]
		PlayerEquipShoes,
		// Token: 0x0400A1D6 RID: 41430
		[Token(Token = "0x401B408")]
		PlayerEquipAccessory,
		// Token: 0x0400A1D7 RID: 41431
		[Token(Token = "0x401B409")]
		Max
	}
}

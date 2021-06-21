using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Define;
using Il2CppDummyDll;
using Loader;
using Loader.ID;
using UnityEngine;

// Token: 0x02000577 RID: 1399
[Token(Token = "0x20003EF")]
public class SeasonManager : SingletonMonoBehaviour<SeasonManager>
{
	// Token: 0x17000575 RID: 1397
	// (get) Token: 0x060021DA RID: 8666 RVA: 0x0000DEC0 File Offset: 0x0000C0C0
	// (set) Token: 0x060021DB RID: 8667 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000465")]
	public Season Season
	{
		[Token(Token = "0x6001C9A")]
		[Address(RVA = "0x21E56B0", Offset = "0x21E57B1", VA = "0x21E56B0")]
		get
		{
			return Season.None;
		}
		[Token(Token = "0x6001C9B")]
		[Address(RVA = "0x21E56C0", Offset = "0x21E57C1", VA = "0x21E56C0")]
		set
		{
		}
	}

	// Token: 0x17000576 RID: 1398
	// (get) Token: 0x060021DC RID: 8668 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000466")]
	public SeasonMaterialDataTableArray SeasonMaterialDataTableArray
	{
		[Token(Token = "0x6001C9C")]
		[Address(RVA = "0x21E56D0", Offset = "0x21E57D1", VA = "0x21E56D0")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000577 RID: 1399
	// (get) Token: 0x060021DD RID: 8669 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000467")]
	public SeasonTextureDataTableArray SeasonTextureDataTableArray
	{
		[Token(Token = "0x6001C9D")]
		[Address(RVA = "0x21E56E0", Offset = "0x21E57E1", VA = "0x21E56E0")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000578 RID: 1400
	// (get) Token: 0x060021DE RID: 8670 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000468")]
	public SeasonTextureDataTableArray SeasonTerrainTextureDataTableArray
	{
		[Token(Token = "0x6001C9E")]
		[Address(RVA = "0x21E56F0", Offset = "0x21E57F1", VA = "0x21E56F0")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000579 RID: 1401
	// (get) Token: 0x060021DF RID: 8671 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060021E0 RID: 8672 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000469")]
	public HashSet<SeasonChangeObject> ChangeMaterialObjectHashSet
	{
		[Token(Token = "0x6001C9F")]
		[Address(RVA = "0x21E5700", Offset = "0x21E5801", VA = "0x21E5700")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A08F0", Offset = "0x1A09F1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001CA0")]
		[Address(RVA = "0x21E5710", Offset = "0x21E5811", VA = "0x21E5710")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A0900", Offset = "0x1A0A01")]
		set
		{
		}
	}

	// Token: 0x1700057A RID: 1402
	// (get) Token: 0x060021E1 RID: 8673 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060021E2 RID: 8674 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700046A")]
	public HashSet<SeasonChangeObject> ChangeTextureObjectHashSet
	{
		[Token(Token = "0x6001CA1")]
		[Address(RVA = "0x21E5720", Offset = "0x21E5821", VA = "0x21E5720")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A0910", Offset = "0x1A0A11")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001CA2")]
		[Address(RVA = "0x21E5730", Offset = "0x21E5831", VA = "0x21E5730")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A0920", Offset = "0x1A0A21")]
		set
		{
		}
	}

	// Token: 0x1700057B RID: 1403
	// (get) Token: 0x060021E3 RID: 8675 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060021E4 RID: 8676 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700046B")]
	public HashSet<SeasonChangeObject> ChangeTerrainObjectHashSet
	{
		[Token(Token = "0x6001CA3")]
		[Address(RVA = "0x21E5740", Offset = "0x21E5841", VA = "0x21E5740")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A0930", Offset = "0x1A0A31")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001CA4")]
		[Address(RVA = "0x21E5750", Offset = "0x21E5851", VA = "0x21E5750")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A0940", Offset = "0x1A0A41")]
		set
		{
		}
	}

	// Token: 0x1700057C RID: 1404
	// (get) Token: 0x060021E5 RID: 8677 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060021E6 RID: 8678 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700046C")]
	public HashSet<SeasonChangeEachLoadObject> ChangeTerrainFbxObjectHashSet
	{
		[Token(Token = "0x6001CA5")]
		[Address(RVA = "0x21E5760", Offset = "0x21E5861", VA = "0x21E5760")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A0950", Offset = "0x1A0A51")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001CA6")]
		[Address(RVA = "0x21E5770", Offset = "0x21E5871", VA = "0x21E5770")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A0960", Offset = "0x1A0A61")]
		set
		{
		}
	}

	// Token: 0x1700057D RID: 1405
	// (get) Token: 0x060021E7 RID: 8679 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060021E8 RID: 8680 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700046D")]
	public HashSet<SeasonVisibleObject>[] ChangeVisibleObjectHashSet
	{
		[Token(Token = "0x6001CA7")]
		[Address(RVA = "0x21E5780", Offset = "0x21E5881", VA = "0x21E5780")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A0970", Offset = "0x1A0A71")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001CA8")]
		[Address(RVA = "0x21E5790", Offset = "0x21E5891", VA = "0x21E5790")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A0980", Offset = "0x1A0A81")]
		set
		{
		}
	}

	// Token: 0x1700057E RID: 1406
	// (get) Token: 0x060021E9 RID: 8681 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060021EA RID: 8682 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700046E")]
	private Dictionary<int, TextureChangeMaterialParam> TextureChangeMaterialDictinary
	{
		[Token(Token = "0x6001CA9")]
		[Address(RVA = "0x21E57A0", Offset = "0x21E58A1", VA = "0x21E57A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A0990", Offset = "0x1A0A91")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001CAA")]
		[Address(RVA = "0x21E57B0", Offset = "0x21E58B1", VA = "0x21E57B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A09A0", Offset = "0x1A0AA1")]
		set
		{
		}
	}

	// Token: 0x1700057F RID: 1407
	// (get) Token: 0x060021EB RID: 8683 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060021EC RID: 8684 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700046F")]
	private HashSet<Renderer> ApplyTextureChangeMaterialHashSet
	{
		[Token(Token = "0x6001CAB")]
		[Address(RVA = "0x21E57C0", Offset = "0x21E58C1", VA = "0x21E57C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A09B0", Offset = "0x1A0AB1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001CAC")]
		[Address(RVA = "0x21E57D0", Offset = "0x21E58D1", VA = "0x21E57D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A09C0", Offset = "0x1A0AC1")]
		set
		{
		}
	}

	// Token: 0x17000580 RID: 1408
	// (get) Token: 0x060021ED RID: 8685 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000470")]
	public Dictionary<Loader.ID.Texture, UnityEngine.Texture> LoadTextureDictinary
	{
		[Token(Token = "0x6001CAD")]
		[Address(RVA = "0x21E57E0", Offset = "0x21E58E1", VA = "0x21E57E0")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000581 RID: 1409
	// (get) Token: 0x060021EE RID: 8686 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000471")]
	public Dictionary<string, Material> LoadMaterialDictinary
	{
		[Token(Token = "0x6001CAE")]
		[Address(RVA = "0x21E57F0", Offset = "0x21E58F1", VA = "0x21E57F0")]
		get
		{
			return null;
		}
	}

	// Token: 0x060021EF RID: 8687 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001CAF")]
	[Address(RVA = "0x21E51D0", Offset = "0x21E52D1", VA = "0x21E51D0")]
	public void AddChangeObject(SeasonChangeObject obj)
	{
	}

	// Token: 0x060021F0 RID: 8688 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001CB0")]
	[Address(RVA = "0x21E5480", Offset = "0x21E5581", VA = "0x21E5480")]
	public void RemoveChangeObject(SeasonChangeObject obj)
	{
	}

	// Token: 0x060021F1 RID: 8689 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001CB1")]
	[Address(RVA = "0x21E4D00", Offset = "0x21E4E01", VA = "0x21E4D00")]
	public void AddChangeObject(SeasonChangeEachLoadObject obj)
	{
	}

	// Token: 0x060021F2 RID: 8690 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001CB2")]
	[Address(RVA = "0x21E5000", Offset = "0x21E5101", VA = "0x21E5000")]
	public void RemoveChangeObject(SeasonChangeEachLoadObject obj)
	{
	}

	// Token: 0x060021F3 RID: 8691 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001CB3")]
	[Address(RVA = "0x21E5800", Offset = "0x21E5901", VA = "0x21E5800")]
	public void AddChangeObject(SeasonVisibleObject obj)
	{
	}

	// Token: 0x060021F4 RID: 8692 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001CB4")]
	[Address(RVA = "0x21E58A0", Offset = "0x21E59A1", VA = "0x21E58A0")]
	public void RemoveChangeObject(SeasonVisibleObject obj)
	{
	}

	// Token: 0x060021F5 RID: 8693 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001CB5")]
	[Address(RVA = "0x21E5940", Offset = "0x21E5A41", VA = "0x21E5940")]
	private void OnDestroy()
	{
	}

	// Token: 0x060021F6 RID: 8694 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001CB6")]
	[Address(RVA = "0x21E5950", Offset = "0x21E5A51", VA = "0x21E5950", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x060021F7 RID: 8695 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001CB7")]
	[Address(RVA = "0x21E5BA0", Offset = "0x21E5CA1", VA = "0x21E5BA0")]
	private void Start()
	{
	}

	// Token: 0x060021F8 RID: 8696 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CB8")]
	[Address(RVA = "0x21E6260", Offset = "0x21E6361", VA = "0x21E6260")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A09D0", Offset = "0x1A0AD1")]
	public IEnumerator OnSceneChangeSeason()
	{
		return null;
	}

	// Token: 0x060021F9 RID: 8697 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001CB9")]
	[Address(RVA = "0x21E62E0", Offset = "0x21E63E1", VA = "0x21E62E0")]
	private void OnSeasonChange(int elapsedSeason)
	{
	}

	// Token: 0x060021FA RID: 8698 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CBA")]
	[Address(RVA = "0x21E64E0", Offset = "0x21E65E1", VA = "0x21E64E0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A0A40", Offset = "0x1A0B41")]
	public IEnumerator SeasonChangeLoad(Season season)
	{
		return null;
	}

	// Token: 0x060021FB RID: 8699 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CBB")]
	[Address(RVA = "0x21E6570", Offset = "0x21E6671", VA = "0x21E6570")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A0AB0", Offset = "0x1A0BB1")]
	public IEnumerator SeasonChangeFade(Season season)
	{
		return null;
	}

	// Token: 0x060021FC RID: 8700 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CBC")]
	[Address(RVA = "0x21E5E50", Offset = "0x21E5F51", VA = "0x21E5E50")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A0B20", Offset = "0x1A0C21")]
	public IEnumerator LoadTexture(Season loadSeason)
	{
		return null;
	}

	// Token: 0x060021FD RID: 8701 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CBD")]
	[Address(RVA = "0x21E61D0", Offset = "0x21E62D1", VA = "0x21E61D0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A0B90", Offset = "0x1A0C91")]
	public IEnumerator LoadTerrainTexture(Season loadSeason)
	{
		return null;
	}

	// Token: 0x060021FE RID: 8702 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CBE")]
	[Address(RVA = "0x21E6600", Offset = "0x21E6701", VA = "0x21E6600")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A0C00", Offset = "0x1A0D01")]
	public IEnumerator LoadTexture(Season loadSeason, Dictionary<string, SeasonTextureAssetIdData> seasonTextureTable, Dictionary<Loader.ID.Texture, UnityEngine.Texture> loadTextureDict)
	{
		return null;
	}

	// Token: 0x060021FF RID: 8703 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001CBF")]
	[Address(RVA = "0x21E66A0", Offset = "0x21E67A1", VA = "0x21E66A0")]
	public void UnloadTexture(Season useSeason)
	{
	}

	// Token: 0x06002200 RID: 8704 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001CC0")]
	[Address(RVA = "0x21E6AC0", Offset = "0x21E6BC1", VA = "0x21E6AC0")]
	public void UnloadTerrainTexture(Season useSeason)
	{
	}

	// Token: 0x06002201 RID: 8705 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001CC1")]
	[Address(RVA = "0x21E6720", Offset = "0x21E6821", VA = "0x21E6720")]
	public void UnloadTexture(Season useSeason, Dictionary<string, SeasonTextureAssetIdData> seasonTextureTable, Dictionary<Loader.ID.Texture, UnityEngine.Texture> loadTextureDict)
	{
	}

	// Token: 0x06002202 RID: 8706 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001CC2")]
	[Address(RVA = "0x21E5EE0", Offset = "0x21E5FE1", VA = "0x21E5EE0")]
	public void LoadMaterial(Season loadSeason)
	{
	}

	// Token: 0x06002203 RID: 8707 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001CC3")]
	[Address(RVA = "0x21E6AE0", Offset = "0x21E6BE1", VA = "0x21E6AE0")]
	public void UnloadMaterial(Season useSeason)
	{
	}

	// Token: 0x06002204 RID: 8708 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001CC4")]
	[Address(RVA = "0x21E6E90", Offset = "0x21E6F91", VA = "0x21E6E90")]
	public void ChangeMaterialTexture(Season setSeason)
	{
	}

	// Token: 0x06002205 RID: 8709 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001CC5")]
	[Address(RVA = "0x21E6FB0", Offset = "0x21E70B1", VA = "0x21E6FB0")]
	public void ChangeMaterialTexture(Season setSeason, SeasonChangeObject changeObject)
	{
	}

	// Token: 0x06002206 RID: 8710 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001CC6")]
	[Address(RVA = "0x21E73B0", Offset = "0x21E74B1", VA = "0x21E73B0")]
	public void ChangeMaterialTexture(Season setSeason, SeasonChangeEachLoadObject changeObject, UnityEngine.Texture texture)
	{
	}

	// Token: 0x06002207 RID: 8711 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001CC7")]
	[Address(RVA = "0x21E74C0", Offset = "0x21E75C1", VA = "0x21E74C0")]
	public void ChangeRendererMaterial(Season setSeason)
	{
	}

	// Token: 0x06002208 RID: 8712 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001CC8")]
	[Address(RVA = "0x21E75E0", Offset = "0x21E76E1", VA = "0x21E75E0")]
	public void ChangeRendererMaterial(Season setSeason, SeasonChangeObject changeObject)
	{
	}

	// Token: 0x06002209 RID: 8713 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001CC9")]
	[Address(RVA = "0x21E78A0", Offset = "0x21E79A1", VA = "0x21E78A0")]
	public void ChangeTerrainTexture(Season setSeason)
	{
	}

	// Token: 0x0600220A RID: 8714 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001CCA")]
	[Address(RVA = "0x21E79C0", Offset = "0x21E7AC1", VA = "0x21E79C0")]
	public void ChangeTerrainTexture(Season setSeason, SeasonChangeObject changeObject)
	{
	}

	// Token: 0x0600220B RID: 8715 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001CCB")]
	[Address(RVA = "0x21E7C70", Offset = "0x21E7D71", VA = "0x21E7C70")]
	public void ChangeEachLoadObject(Season setSeason)
	{
	}

	// Token: 0x0600220C RID: 8716 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001CCC")]
	[Address(RVA = "0x21E52E0", Offset = "0x21E53E1", VA = "0x21E52E0")]
	public void ChangeSeasonObject(SeasonChangeObject changeObject)
	{
	}

	// Token: 0x0600220D RID: 8717 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001CCD")]
	[Address(RVA = "0x21E4D70", Offset = "0x21E4E71", VA = "0x21E4D70")]
	public void ChangeSeasonObject(SeasonChangeEachLoadObject changeObject)
	{
	}

	// Token: 0x0600220E RID: 8718 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001CCE")]
	[Address(RVA = "0x21E7E10", Offset = "0x21E7F11", VA = "0x21E7E10")]
	public void ChangeVisibleObject(Season setSeason)
	{
	}

	// Token: 0x0600220F RID: 8719 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001CCF")]
	[Address(RVA = "0x21E7FB0", Offset = "0x21E80B1", VA = "0x21E7FB0")]
	public void ChangeSeasonObject(SeasonVisibleObject changeObject)
	{
	}

	// Token: 0x06002210 RID: 8720 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001CD0")]
	[Address(RVA = "0x21E80A0", Offset = "0x21E81A1", VA = "0x21E80A0")]
	public void ChangeVisibleObject(Season setSeason, SeasonVisibleObject changeObject)
	{
	}

	// Token: 0x06002211 RID: 8721 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001CD1")]
	[Address(RVA = "0x21D91B0", Offset = "0x21D92B1", VA = "0x21D91B0")]
	public void AfterLoadGameData()
	{
	}

	// Token: 0x06002212 RID: 8722 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001CD2")]
	[Address(RVA = "0x21E8130", Offset = "0x21E8231", VA = "0x21E8130")]
	public SeasonManager()
	{
	}

	// Token: 0x04006A56 RID: 27222
	[Token(Token = "0x4006406")]
	[FieldOffset(Offset = "0x18")]
	private readonly string SeasonTerrainTextureSearchString;

	// Token: 0x04006A57 RID: 27223
	[Token(Token = "0x4006407")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Season _Season;

	// Token: 0x04006A58 RID: 27224
	[Token(Token = "0x4006408")]
	[FieldOffset(Offset = "0x24")]
	public Season RequestSeason;

	// Token: 0x04006A59 RID: 27225
	[Token(Token = "0x4006409")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private SeasonMaterialDataTableArray _SeasonMaterialDataTableArray;

	// Token: 0x04006A5A RID: 27226
	[Token(Token = "0x400640A")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private SeasonTextureDataTableArray _SeasonTextureDataTableArray;

	// Token: 0x04006A5B RID: 27227
	[Token(Token = "0x400640B")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private SeasonTextureDataTableArray _SeasonTerrainTextureDataTableArray;

	// Token: 0x04006A5C RID: 27228
	[Token(Token = "0x400640C")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1665E0", Offset = "0x1666E1")]
	private HashSet<SeasonChangeObject> <ChangeMaterialObjectHashSet>k__BackingField;

	// Token: 0x04006A5D RID: 27229
	[Token(Token = "0x400640D")]
	[FieldOffset(Offset = "0x48")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1665F0", Offset = "0x1666F1")]
	private HashSet<SeasonChangeObject> <ChangeTextureObjectHashSet>k__BackingField;

	// Token: 0x04006A5E RID: 27230
	[Token(Token = "0x400640E")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x166600", Offset = "0x166701")]
	private HashSet<SeasonChangeObject> <ChangeTerrainObjectHashSet>k__BackingField;

	// Token: 0x04006A5F RID: 27231
	[Token(Token = "0x400640F")]
	[FieldOffset(Offset = "0x58")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x166610", Offset = "0x166711")]
	private HashSet<SeasonChangeEachLoadObject> <ChangeTerrainFbxObjectHashSet>k__BackingField;

	// Token: 0x04006A60 RID: 27232
	[Token(Token = "0x4006410")]
	[FieldOffset(Offset = "0x60")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x166620", Offset = "0x166721")]
	private HashSet<SeasonVisibleObject>[] <ChangeVisibleObjectHashSet>k__BackingField;

	// Token: 0x04006A61 RID: 27233
	[Token(Token = "0x4006411")]
	[FieldOffset(Offset = "0x68")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x166630", Offset = "0x166731")]
	private Dictionary<int, TextureChangeMaterialParam> <TextureChangeMaterialDictinary>k__BackingField;

	// Token: 0x04006A62 RID: 27234
	[Token(Token = "0x4006412")]
	[FieldOffset(Offset = "0x70")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x166640", Offset = "0x166741")]
	private HashSet<Renderer> <ApplyTextureChangeMaterialHashSet>k__BackingField;

	// Token: 0x04006A63 RID: 27235
	[Token(Token = "0x4006413")]
	[FieldOffset(Offset = "0x78")]
	private Dictionary<Loader.ID.Texture, UnityEngine.Texture> _LoadTextureDictinary;

	// Token: 0x04006A64 RID: 27236
	[Token(Token = "0x4006414")]
	[FieldOffset(Offset = "0x80")]
	private Dictionary<string, Material> _LoadMaterialDictinary;

	// Token: 0x04006A65 RID: 27237
	[Token(Token = "0x4006415")]
	[FieldOffset(Offset = "0x88")]
	private bool[] _LoadedSeason;

	// Token: 0x04006A66 RID: 27238
	[Token(Token = "0x4006416")]
	[FieldOffset(Offset = "0x90")]
	private bool[] _LoadedSeasonMaterial;

	// Token: 0x04006A67 RID: 27239
	[Token(Token = "0x4006417")]
	[FieldOffset(Offset = "0x98")]
	private bool IsLoadEnd;

	// Token: 0x04006A68 RID: 27240
	[Token(Token = "0x4006418")]
	[FieldOffset(Offset = "0x99")]
	private bool PrevFade;

	// Token: 0x04006A69 RID: 27241
	[Token(Token = "0x4006419")]
	[FieldOffset(Offset = "0x9A")]
	private bool PrevPause;

	// Token: 0x02000578 RID: 1400
	[Token(Token = "0x2001111")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157ED0", Offset = "0x157FD1")]
	private sealed class <OnSceneChangeSeason>d__63 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06002213 RID: 8723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600702B")]
		[Address(RVA = "0x1E2E610", Offset = "0x1E2E711", VA = "0x1E2E610")]
		[DebuggerHidden]
		public <OnSceneChangeSeason>d__63(int <>1__state)
		{
		}

		// Token: 0x06002214 RID: 8724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600702C")]
		[Address(RVA = "0x1E2E640", Offset = "0x1E2E741", VA = "0x1E2E640", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06002215 RID: 8725 RVA: 0x0000DED8 File Offset: 0x0000C0D8
		[Token(Token = "0x600702D")]
		[Address(RVA = "0x1E2E650", Offset = "0x1E2E751", VA = "0x1E2E650", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x06002216 RID: 8726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CCD")]
		private object Current
		{
			[Token(Token = "0x600702E")]
			[Address(RVA = "0x1E2E750", Offset = "0x1E2E851", VA = "0x1E2E750", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06002217 RID: 8727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600702F")]
		[Address(RVA = "0x1E2E760", Offset = "0x1E2E861", VA = "0x1E2E760", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x06002218 RID: 8728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CCE")]
		private object Current
		{
			[Token(Token = "0x6007030")]
			[Address(RVA = "0x1E2E7C0", Offset = "0x1E2E8C1", VA = "0x1E2E7C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04006A6A RID: 27242
		[Token(Token = "0x40192C3")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04006A6B RID: 27243
		[Token(Token = "0x40192C4")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04006A6C RID: 27244
		[Token(Token = "0x40192C5")]
		[FieldOffset(Offset = "0x20")]
		public SeasonManager <>4__this;
	}

	// Token: 0x02000579 RID: 1401
	[Token(Token = "0x2001112")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157EE0", Offset = "0x157FE1")]
	private sealed class <SeasonChangeLoad>d__65 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06002219 RID: 8729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007031")]
		[Address(RVA = "0x1E2ECC0", Offset = "0x1E2EDC1", VA = "0x1E2ECC0")]
		[DebuggerHidden]
		public <SeasonChangeLoad>d__65(int <>1__state)
		{
		}

		// Token: 0x0600221A RID: 8730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007032")]
		[Address(RVA = "0x1E2ECF0", Offset = "0x1E2EDF1", VA = "0x1E2ECF0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600221B RID: 8731 RVA: 0x0000DEF0 File Offset: 0x0000C0F0
		[Token(Token = "0x6007033")]
		[Address(RVA = "0x1E2ED00", Offset = "0x1E2EE01", VA = "0x1E2ED00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x0600221C RID: 8732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CCF")]
		private object Current
		{
			[Token(Token = "0x6007034")]
			[Address(RVA = "0x1E2EE30", Offset = "0x1E2EF31", VA = "0x1E2EE30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600221D RID: 8733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007035")]
		[Address(RVA = "0x1E2EE40", Offset = "0x1E2EF41", VA = "0x1E2EE40", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x0600221E RID: 8734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CD0")]
		private object Current
		{
			[Token(Token = "0x6007036")]
			[Address(RVA = "0x1E2EEA0", Offset = "0x1E2EFA1", VA = "0x1E2EEA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04006A6D RID: 27245
		[Token(Token = "0x40192C6")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04006A6E RID: 27246
		[Token(Token = "0x40192C7")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04006A6F RID: 27247
		[Token(Token = "0x40192C8")]
		[FieldOffset(Offset = "0x20")]
		public SeasonManager <>4__this;

		// Token: 0x04006A70 RID: 27248
		[Token(Token = "0x40192C9")]
		[FieldOffset(Offset = "0x28")]
		public Season season;
	}

	// Token: 0x0200057A RID: 1402
	[Token(Token = "0x2001113")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157EF0", Offset = "0x157FF1")]
	private sealed class <SeasonChangeFade>d__66 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600221F RID: 8735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007037")]
		[Address(RVA = "0x1E2E7D0", Offset = "0x1E2E8D1", VA = "0x1E2E7D0")]
		[DebuggerHidden]
		public <SeasonChangeFade>d__66(int <>1__state)
		{
		}

		// Token: 0x06002220 RID: 8736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007038")]
		[Address(RVA = "0x1E2E800", Offset = "0x1E2E901", VA = "0x1E2E800", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06002221 RID: 8737 RVA: 0x0000DF08 File Offset: 0x0000C108
		[Token(Token = "0x6007039")]
		[Address(RVA = "0x1E2E810", Offset = "0x1E2E911", VA = "0x1E2E810", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x06002222 RID: 8738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CD1")]
		private object Current
		{
			[Token(Token = "0x600703A")]
			[Address(RVA = "0x1E2EC40", Offset = "0x1E2ED41", VA = "0x1E2EC40", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06002223 RID: 8739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600703B")]
		[Address(RVA = "0x1E2EC50", Offset = "0x1E2ED51", VA = "0x1E2EC50", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x06002224 RID: 8740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CD2")]
		private object Current
		{
			[Token(Token = "0x600703C")]
			[Address(RVA = "0x1E2ECB0", Offset = "0x1E2EDB1", VA = "0x1E2ECB0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04006A71 RID: 27249
		[Token(Token = "0x40192CA")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04006A72 RID: 27250
		[Token(Token = "0x40192CB")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04006A73 RID: 27251
		[Token(Token = "0x40192CC")]
		[FieldOffset(Offset = "0x20")]
		public SeasonManager <>4__this;

		// Token: 0x04006A74 RID: 27252
		[Token(Token = "0x40192CD")]
		[FieldOffset(Offset = "0x28")]
		public Season season;
	}

	// Token: 0x0200057B RID: 1403
	[Token(Token = "0x2001114")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157F00", Offset = "0x158001")]
	private sealed class <LoadTexture>d__67 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06002225 RID: 8741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600703D")]
		[Address(RVA = "0x1E2E020", Offset = "0x1E2E121", VA = "0x1E2E020")]
		[DebuggerHidden]
		public <LoadTexture>d__67(int <>1__state)
		{
		}

		// Token: 0x06002226 RID: 8742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600703E")]
		[Address(RVA = "0x1E2E050", Offset = "0x1E2E151", VA = "0x1E2E050", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06002227 RID: 8743 RVA: 0x0000DF20 File Offset: 0x0000C120
		[Token(Token = "0x600703F")]
		[Address(RVA = "0x1E2E060", Offset = "0x1E2E161", VA = "0x1E2E060", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x06002228 RID: 8744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CD3")]
		private object Current
		{
			[Token(Token = "0x6007040")]
			[Address(RVA = "0x1E2E110", Offset = "0x1E2E211", VA = "0x1E2E110", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06002229 RID: 8745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007041")]
		[Address(RVA = "0x1E2E120", Offset = "0x1E2E221", VA = "0x1E2E120", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x0600222A RID: 8746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CD4")]
		private object Current
		{
			[Token(Token = "0x6007042")]
			[Address(RVA = "0x1E2E180", Offset = "0x1E2E281", VA = "0x1E2E180", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04006A75 RID: 27253
		[Token(Token = "0x40192CE")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04006A76 RID: 27254
		[Token(Token = "0x40192CF")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04006A77 RID: 27255
		[Token(Token = "0x40192D0")]
		[FieldOffset(Offset = "0x20")]
		public SeasonManager <>4__this;

		// Token: 0x04006A78 RID: 27256
		[Token(Token = "0x40192D1")]
		[FieldOffset(Offset = "0x28")]
		public Season loadSeason;
	}

	// Token: 0x0200057C RID: 1404
	[Token(Token = "0x2001115")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157F10", Offset = "0x158011")]
	private sealed class <LoadTerrainTexture>d__68 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600222B RID: 8747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007043")]
		[Address(RVA = "0x1E2DEE0", Offset = "0x1E2DFE1", VA = "0x1E2DEE0")]
		[DebuggerHidden]
		public <LoadTerrainTexture>d__68(int <>1__state)
		{
		}

		// Token: 0x0600222C RID: 8748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007044")]
		[Address(RVA = "0x1E2DF10", Offset = "0x1E2E011", VA = "0x1E2DF10", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600222D RID: 8749 RVA: 0x0000DF38 File Offset: 0x0000C138
		[Token(Token = "0x6007045")]
		[Address(RVA = "0x1E2DF20", Offset = "0x1E2E021", VA = "0x1E2DF20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x0600222E RID: 8750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CD5")]
		private object Current
		{
			[Token(Token = "0x6007046")]
			[Address(RVA = "0x1E2DFA0", Offset = "0x1E2E0A1", VA = "0x1E2DFA0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600222F RID: 8751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007047")]
		[Address(RVA = "0x1E2DFB0", Offset = "0x1E2E0B1", VA = "0x1E2DFB0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x06002230 RID: 8752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CD6")]
		private object Current
		{
			[Token(Token = "0x6007048")]
			[Address(RVA = "0x1E2E010", Offset = "0x1E2E111", VA = "0x1E2E010", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04006A79 RID: 27257
		[Token(Token = "0x40192D2")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04006A7A RID: 27258
		[Token(Token = "0x40192D3")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04006A7B RID: 27259
		[Token(Token = "0x40192D4")]
		[FieldOffset(Offset = "0x20")]
		public SeasonManager <>4__this;

		// Token: 0x04006A7C RID: 27260
		[Token(Token = "0x40192D5")]
		[FieldOffset(Offset = "0x28")]
		public Season loadSeason;
	}

	// Token: 0x0200057D RID: 1405
	[Token(Token = "0x2001116")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157F20", Offset = "0x158021")]
	private sealed class <>c__DisplayClass69_0
	{
		// Token: 0x06002231 RID: 8753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007049")]
		[Address(RVA = "0x1E2DE10", Offset = "0x1E2DF11", VA = "0x1E2DE10")]
		public <>c__DisplayClass69_0()
		{
		}

		// Token: 0x04006A7D RID: 27261
		[Token(Token = "0x40192D6")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<Loader.ID.Texture, UnityEngine.Texture> loadTextureDict;

		// Token: 0x04006A7E RID: 27262
		[Token(Token = "0x40192D7")]
		[FieldOffset(Offset = "0x18")]
		public int count;
	}

	// Token: 0x0200057E RID: 1406
	[Token(Token = "0x2001117")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157F30", Offset = "0x158031")]
	private sealed class <>c__DisplayClass69_1
	{
		// Token: 0x06002232 RID: 8754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600704A")]
		[Address(RVA = "0x1E2DE20", Offset = "0x1E2DF21", VA = "0x1E2DE20")]
		public <>c__DisplayClass69_1()
		{
		}

		// Token: 0x06002233 RID: 8755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600704B")]
		[Address(RVA = "0x1E2DE30", Offset = "0x1E2DF31", VA = "0x1E2DE30")]
		internal void <LoadTexture>b__0(AssetHandle<UnityEngine.Texture> handle)
		{
		}

		// Token: 0x04006A7F RID: 27263
		[Token(Token = "0x40192D8")]
		[FieldOffset(Offset = "0x10")]
		public Loader.ID.Texture loadSeasonData;

		// Token: 0x04006A80 RID: 27264
		[Token(Token = "0x40192D9")]
		[FieldOffset(Offset = "0x18")]
		public SeasonManager.<>c__DisplayClass69_0 CS$<>8__locals1;
	}

	// Token: 0x0200057F RID: 1407
	[Token(Token = "0x2001118")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157F40", Offset = "0x158041")]
	private sealed class <LoadTexture>d__69 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06002234 RID: 8756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600704C")]
		[Address(RVA = "0x1E2E190", Offset = "0x1E2E291", VA = "0x1E2E190")]
		[DebuggerHidden]
		public <LoadTexture>d__69(int <>1__state)
		{
		}

		// Token: 0x06002235 RID: 8757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600704D")]
		[Address(RVA = "0x1E2E1C0", Offset = "0x1E2E2C1", VA = "0x1E2E1C0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06002236 RID: 8758 RVA: 0x0000DF50 File Offset: 0x0000C150
		[Token(Token = "0x600704E")]
		[Address(RVA = "0x1E2E1D0", Offset = "0x1E2E2D1", VA = "0x1E2E1D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x06002237 RID: 8759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CD7")]
		private object Current
		{
			[Token(Token = "0x600704F")]
			[Address(RVA = "0x1E2E590", Offset = "0x1E2E691", VA = "0x1E2E590", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06002238 RID: 8760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007050")]
		[Address(RVA = "0x1E2E5A0", Offset = "0x1E2E6A1", VA = "0x1E2E5A0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x06002239 RID: 8761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CD8")]
		private object Current
		{
			[Token(Token = "0x6007051")]
			[Address(RVA = "0x1E2E600", Offset = "0x1E2E701", VA = "0x1E2E600", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04006A81 RID: 27265
		[Token(Token = "0x40192DA")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04006A82 RID: 27266
		[Token(Token = "0x40192DB")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04006A83 RID: 27267
		[Token(Token = "0x40192DC")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<Loader.ID.Texture, UnityEngine.Texture> loadTextureDict;

		// Token: 0x04006A84 RID: 27268
		[Token(Token = "0x40192DD")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, SeasonTextureAssetIdData> seasonTextureTable;

		// Token: 0x04006A85 RID: 27269
		[Token(Token = "0x40192DE")]
		[FieldOffset(Offset = "0x30")]
		public Season loadSeason;

		// Token: 0x04006A86 RID: 27270
		[Token(Token = "0x40192DF")]
		[FieldOffset(Offset = "0x38")]
		private SeasonManager.<>c__DisplayClass69_0 <>8__1;
	}
}

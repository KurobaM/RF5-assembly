using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x02000E00 RID: 3584
	[Token(Token = "0x2000928")]
	[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x148CF0", Offset = "0x148DF1")]
	public class SkyProfile : ScriptableObject
	{
		// Token: 0x17000BC9 RID: 3017
		// (get) Token: 0x06005C19 RID: 23577 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005C1A RID: 23578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700092D")]
		public Material skyboxMaterial
		{
			[Token(Token = "0x6004C34")]
			[Address(RVA = "0x23E04C0", Offset = "0x23E05C1", VA = "0x23E04C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004C35")]
			[Address(RVA = "0x23E04D0", Offset = "0x23E05D1", VA = "0x23E04D0")]
			set
			{
			}
		}

		// Token: 0x17000BCA RID: 3018
		// (get) Token: 0x06005C1B RID: 23579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700092E")]
		public string shaderName
		{
			[Token(Token = "0x6004C36")]
			[Address(RVA = "0x23E0700", Offset = "0x23E0801", VA = "0x23E0700")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BCB RID: 3019
		// (get) Token: 0x06005C1C RID: 23580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700092F")]
		public ProfileGroupSection[] groupDefinitions
		{
			[Token(Token = "0x6004C37")]
			[Address(RVA = "0x23E0710", Offset = "0x23E0811", VA = "0x23E0710")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BCC RID: 3020
		// (get) Token: 0x06005C1D RID: 23581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000930")]
		public ProfileFeatureSection[] featureDefinitions
		{
			[Token(Token = "0x6004C38")]
			[Address(RVA = "0x23E07D0", Offset = "0x23E08D1", VA = "0x23E07D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005C1E RID: 23582 RVA: 0x0001E3D8 File Offset: 0x0001C5D8
		[Token(Token = "0x6004C39")]
		[Address(RVA = "0x23E0890", Offset = "0x23E0991", VA = "0x23E0890")]
		public float GetNumberPropertyValue(string propertyKey)
		{
			return 0f;
		}

		// Token: 0x06005C1F RID: 23583 RVA: 0x0001E3F0 File Offset: 0x0001C5F0
		[Token(Token = "0x6004C3A")]
		[Address(RVA = "0x23D8020", Offset = "0x23D8121", VA = "0x23D8020")]
		public float GetNumberPropertyValue(string propertyKey, float timeOfDay)
		{
			return 0f;
		}

		// Token: 0x06005C20 RID: 23584 RVA: 0x0001E408 File Offset: 0x0001C608
		[Token(Token = "0x6004C3B")]
		[Address(RVA = "0x23E08A0", Offset = "0x23E09A1", VA = "0x23E08A0")]
		public Color GetColorPropertyValue(string propertyKey)
		{
			return default(Color);
		}

		// Token: 0x06005C21 RID: 23585 RVA: 0x0001E420 File Offset: 0x0001C620
		[Token(Token = "0x6004C3C")]
		[Address(RVA = "0x23D8100", Offset = "0x23D8201", VA = "0x23D8100")]
		public Color GetColorPropertyValue(string propertyKey, float timeOfDay)
		{
			return default(Color);
		}

		// Token: 0x06005C22 RID: 23586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C3D")]
		[Address(RVA = "0x23E08B0", Offset = "0x23E09B1", VA = "0x23E08B0")]
		public Texture GetTexturePropertyValue(string propertyKey)
		{
			return null;
		}

		// Token: 0x06005C23 RID: 23587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C3E")]
		[Address(RVA = "0x23DB5C0", Offset = "0x23DB6C1", VA = "0x23DB5C0")]
		public Texture GetTexturePropertyValue(string propertyKey, float timeOfDay)
		{
			return null;
		}

		// Token: 0x06005C24 RID: 23588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C3F")]
		[Address(RVA = "0x23E08C0", Offset = "0x23E09C1", VA = "0x23E08C0")]
		public SpherePoint GetSpherePointPropertyValue(string propertyKey)
		{
			return null;
		}

		// Token: 0x06005C25 RID: 23589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C40")]
		[Address(RVA = "0x23E08D0", Offset = "0x23E09D1", VA = "0x23E08D0")]
		public SpherePoint GetSpherePointPropertyValue(string propertyKey, float timeOfDay)
		{
			return null;
		}

		// Token: 0x06005C26 RID: 23590 RVA: 0x0001E438 File Offset: 0x0001C638
		[Token(Token = "0x6004C41")]
		[Address(RVA = "0x23E0C70", Offset = "0x23E0D71", VA = "0x23E0C70")]
		public bool GetBoolPropertyValue(string propertyKey)
		{
			return default(bool);
		}

		// Token: 0x06005C27 RID: 23591 RVA: 0x0001E450 File Offset: 0x0001C650
		[Token(Token = "0x6004C42")]
		[Address(RVA = "0x23E0C80", Offset = "0x23E0D81", VA = "0x23E0C80")]
		public bool GetBoolPropertyValue(string propertyKey, float timeOfDay)
		{
			return default(bool);
		}

		// Token: 0x06005C28 RID: 23592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C43")]
		[Address(RVA = "0x23E0D60", Offset = "0x23E0E61", VA = "0x23E0D60")]
		public SkyProfile()
		{
		}

		// Token: 0x06005C29 RID: 23593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C44")]
		[Address(RVA = "0x23E0F30", Offset = "0x23E1031", VA = "0x23E0F30")]
		private void OnEnable()
		{
		}

		// Token: 0x06005C2A RID: 23594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C45")]
		[Address(RVA = "0x23E0EA0", Offset = "0x23E0FA1", VA = "0x23E0EA0")]
		private void ReloadFullProfile()
		{
		}

		// Token: 0x06005C2B RID: 23595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C46")]
		[Address(RVA = "0x23E0690", Offset = "0x23E0791", VA = "0x23E0690")]
		private void ReloadDefinitions()
		{
		}

		// Token: 0x06005C2C RID: 23596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C47")]
		[Address(RVA = "0x23E15A0", Offset = "0x23E16A1", VA = "0x23E15A0")]
		private IProfileDefinition GetShaderInfoForMaterial(string shaderName)
		{
			return null;
		}

		// Token: 0x06005C2D RID: 23597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C48")]
		[Address(RVA = "0x23E0F40", Offset = "0x23E1041", VA = "0x23E0F40")]
		public void MergeProfileWithDefinitions()
		{
		}

		// Token: 0x06005C2E RID: 23598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C49")]
		[Address(RVA = "0x23E1600", Offset = "0x23E1701", VA = "0x23E1600")]
		public void MergeGroupsWithDefinitions()
		{
		}

		// Token: 0x06005C2F RID: 23599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C4A")]
		[Address(RVA = "0x23E2570", Offset = "0x23E2671", VA = "0x23E2570")]
		public Dictionary<string, ProfileGroupDefinition> GroupDefinitionDictionary()
		{
			return null;
		}

		// Token: 0x06005C30 RID: 23600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C4B")]
		[Address(RVA = "0x23E2750", Offset = "0x23E2851", VA = "0x23E2750")]
		public ProfileGroupSection[] ProfileDefinitionTable()
		{
			return null;
		}

		// Token: 0x06005C31 RID: 23601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C4C")]
		[Address(RVA = "0x23E20C0", Offset = "0x23E21C1", VA = "0x23E20C0")]
		private void AddNumericGroup(string propKey, string groupName, float min, float max, float value)
		{
		}

		// Token: 0x06005C32 RID: 23602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C4D")]
		[Address(RVA = "0x23E1F50", Offset = "0x23E2051", VA = "0x23E1F50")]
		private void AddColorGroup(string propKey, string groupName, Color color)
		{
		}

		// Token: 0x06005C33 RID: 23603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C4E")]
		[Address(RVA = "0x23E2210", Offset = "0x23E2311", VA = "0x23E2210")]
		private void AddTextureGroup(string propKey, string groupName, Texture2D texture)
		{
		}

		// Token: 0x06005C34 RID: 23604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C4F")]
		[Address(RVA = "0x23E2300", Offset = "0x23E2401", VA = "0x23E2300")]
		private void AddSpherePointGroup(string propKey, string groupName, SpherePoint point)
		{
		}

		// Token: 0x06005C35 RID: 23605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C50")]
		[Address(RVA = "0x23E2430", Offset = "0x23E2531", VA = "0x23E2430")]
		private void AddBooleanGroup(string propKey, string groupName, bool value)
		{
		}

		// Token: 0x06005C36 RID: 23606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C51")]
		public T GetGroup<T>(string propertyKey) where T : class
		{
			return null;
		}

		// Token: 0x06005C37 RID: 23607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C52")]
		[Address(RVA = "0x23E2960", Offset = "0x23E2A61", VA = "0x23E2960")]
		public IKeyframeGroup GetGroup(string propertyKey)
		{
			return null;
		}

		// Token: 0x06005C38 RID: 23608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C53")]
		[Address(RVA = "0x23E29D0", Offset = "0x23E2AD1", VA = "0x23E29D0")]
		public IKeyframeGroup GetGroupWithId(string groupId)
		{
			return null;
		}

		// Token: 0x06005C39 RID: 23609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C54")]
		[Address(RVA = "0x23E2D80", Offset = "0x23E2E81", VA = "0x23E2D80")]
		public ProfileGroupSection[] GetProfileDefinitions()
		{
			return null;
		}

		// Token: 0x06005C3A RID: 23610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C55")]
		[Address(RVA = "0x23E2E40", Offset = "0x23E2F41", VA = "0x23E2E40")]
		public ProfileGroupSection GetSectionInfo(string sectionKey)
		{
			return null;
		}

		// Token: 0x06005C3B RID: 23611 RVA: 0x0001E468 File Offset: 0x0001C668
		[Token(Token = "0x6004C56")]
		[Address(RVA = "0x23E2F80", Offset = "0x23E3081", VA = "0x23E2F80")]
		public bool IsManagedByTimeline(string propertyKey)
		{
			return default(bool);
		}

		// Token: 0x06005C3C RID: 23612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C57")]
		[Address(RVA = "0x23E1140", Offset = "0x23E1241", VA = "0x23E1140")]
		public void ValidateTimelineGroupKeys()
		{
		}

		// Token: 0x06005C3D RID: 23613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C58")]
		[Address(RVA = "0x23E2FF0", Offset = "0x23E30F1", VA = "0x23E2FF0")]
		public List<ProfileGroupDefinition> GetGroupDefinitionsManagedByTimeline()
		{
			return null;
		}

		// Token: 0x06005C3E RID: 23614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C59")]
		[Address(RVA = "0x23E32B0", Offset = "0x23E33B1", VA = "0x23E32B0")]
		public List<ProfileGroupDefinition> GetGroupDefinitionsNotManagedByTimeline()
		{
			return null;
		}

		// Token: 0x06005C3F RID: 23615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C5A")]
		[Address(RVA = "0x23E3230", Offset = "0x23E3331", VA = "0x23E3230")]
		public ProfileGroupDefinition GetGroupDefinitionForKey(string propertyKey)
		{
			return null;
		}

		// Token: 0x06005C40 RID: 23616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C5B")]
		[Address(RVA = "0x23E0F70", Offset = "0x23E1071", VA = "0x23E0F70")]
		public void RebuildKeyToGroupInfoMapping()
		{
		}

		// Token: 0x06005C41 RID: 23617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C5C")]
		[Address(RVA = "0x23E3630", Offset = "0x23E3731", VA = "0x23E3630")]
		public void TrimGroupToSingleKeyframe(string propertyKey)
		{
		}

		// Token: 0x06005C42 RID: 23618 RVA: 0x0001E480 File Offset: 0x0001C680
		[Token(Token = "0x6004C5D")]
		[Address(RVA = "0x23E3560", Offset = "0x23E3661", VA = "0x23E3560")]
		public bool CanGroupBeOnTimeline(ProfileGroupDefinition definition)
		{
			return default(bool);
		}

		// Token: 0x06005C43 RID: 23619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C5E")]
		[Address(RVA = "0x23E1D00", Offset = "0x23E1E01", VA = "0x23E1D00")]
		protected void MergeShaderKeywordsWithDefinitions()
		{
		}

		// Token: 0x06005C44 RID: 23620 RVA: 0x0001E498 File Offset: 0x0001C698
		[Token(Token = "0x6004C5F")]
		[Address(RVA = "0x23D6F10", Offset = "0x23D7011", VA = "0x23D6F10")]
		public bool IsFeatureEnabled(string featureKey, bool recursive = true)
		{
			return default(bool);
		}

		// Token: 0x06005C45 RID: 23621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C60")]
		[Address(RVA = "0x23E3750", Offset = "0x23E3851", VA = "0x23E3750")]
		public void SetFeatureEnabled(string featureKey, bool value)
		{
		}

		// Token: 0x0400BC78 RID: 48248
		[Token(Token = "0x4008CE5")]
		public const string DefaultShaderName = "Funly/Sky Studio/Skybox/3D Standard";

		// Token: 0x0400BC79 RID: 48249
		[Token(Token = "0x4008CE6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Material m_SkyboxMaterial;

		// Token: 0x0400BC7A RID: 48250
		[Token(Token = "0x4008CE7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string m_ShaderName;

		// Token: 0x0400BC7B RID: 48251
		[Token(Token = "0x4008CE8")]
		[FieldOffset(Offset = "0x28")]
		public IProfileDefinition profileDefinition;

		// Token: 0x0400BC7C RID: 48252
		[Token(Token = "0x4008CE9")]
		[FieldOffset(Offset = "0x30")]
		public List<string> timelineManagedKeys;

		// Token: 0x0400BC7D RID: 48253
		[Token(Token = "0x4008CEA")]
		[FieldOffset(Offset = "0x38")]
		public KeyframeGroupDictionary keyframeGroups;

		// Token: 0x0400BC7E RID: 48254
		[Token(Token = "0x4008CEB")]
		[FieldOffset(Offset = "0x40")]
		public BoolDictionary featureStatus;

		// Token: 0x0400BC7F RID: 48255
		[Token(Token = "0x4008CEC")]
		[FieldOffset(Offset = "0x48")]
		public LightningArtSet lightningArtSet;

		// Token: 0x0400BC80 RID: 48256
		[Token(Token = "0x4008CED")]
		[FieldOffset(Offset = "0x50")]
		public RainSplashArtSet rainSplashArtSet;

		// Token: 0x0400BC81 RID: 48257
		[Token(Token = "0x4008CEE")]
		[FieldOffset(Offset = "0x58")]
		public Texture2D starLayer1DataTexture;

		// Token: 0x0400BC82 RID: 48258
		[Token(Token = "0x4008CEF")]
		[FieldOffset(Offset = "0x60")]
		public Texture2D starLayer2DataTexture;

		// Token: 0x0400BC83 RID: 48259
		[Token(Token = "0x4008CF0")]
		[FieldOffset(Offset = "0x68")]
		public Texture2D starLayer3DataTexture;

		// Token: 0x0400BC84 RID: 48260
		[Token(Token = "0x4008CF1")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private int m_ProfileVersion;

		// Token: 0x0400BC85 RID: 48261
		[Token(Token = "0x4008CF2")]
		[FieldOffset(Offset = "0x78")]
		private Dictionary<string, ProfileGroupDefinition> m_KeyToGroupInfo;
	}
}

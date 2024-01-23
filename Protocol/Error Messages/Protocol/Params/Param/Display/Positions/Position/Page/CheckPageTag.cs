// <auto-generated>This is auto-generated code by Validator Management Tool. Do not modify.</auto-generated>
namespace Skyline.DataMiner.CICD.Validators.Protocol.Tests.Protocol.Params.Param.Display.Positions.Position.Page.CheckPageTag
{
    using System;
    using System.Collections.Generic;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;
    using Skyline.DataMiner.CICD.Validators.Protocol.Common;
    using Skyline.DataMiner.CICD.Validators.Protocol.Interfaces;

    internal static class Error
    {
        public static IValidationResult MissingTag(IValidate test, IReadable referenceNode, IReadable positionNode, string pid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckPageTag,
                ErrorId = ErrorIds.MissingTag,
                FullId = "2.22.2",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Missing tag '{0}' in {1} '{2}'.", "Position/Page", "Param", pid),
                HowToFix = "",
                ExampleCode = "",
                Details = "A Position tag should always contain a Page tag." + Environment.NewLine + "Note that, exept for title end parameters, the same parameter should not be displayed more than once on the same page.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult EmptyTag(IValidate test, IReadable referenceNode, IReadable positionNode, string pid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckPageTag,
                ErrorId = ErrorIds.EmptyTag,
                FullId = "2.22.3",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Empty tag '{0}' in {1} '{2}'.", "Position/Page", "Param", pid),
                HowToFix = "",
                ExampleCode = "",
                Details = "A Position tag should always contain a Page tag." + Environment.NewLine + "Note that, exept for title end parameters, the same parameter should not be displayed more than once on the same page.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult UntrimmedTag(IValidate test, IReadable referenceNode, IReadable positionNode, string pid, string untrimmedValue)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckPageTag,
                ErrorId = ErrorIds.UntrimmedTag,
                FullId = "2.22.4",
                Category = Category.Param,
                Severity = Severity.Warning,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Untrimmed tag '{0}' in {1} '{2}'. Current value '{3}'.", "Position/Page", "Param", pid, untrimmedValue),
                HowToFix = "",
                ExampleCode = "",
                Details = "A Position tag should always contain a Page tag." + Environment.NewLine + "Note that, exept for title end parameters, the same parameter should not be displayed more than once on the same page.",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult DuplicatedValue(IValidate test, IReadable referenceNode, IReadable positionNode, string duplicateValue, string paramId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckPageTag,
                ErrorId = ErrorIds.DuplicatedValue,
                FullId = "2.22.5",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Duplicated {0} {1} '{2}'. {0} IDs '{3}'.", "Param", "Position/Page", duplicateValue, paramId),
                HowToFix = "",
                ExampleCode = "",
                Details = "A Position tag should always contain a Page tag." + Environment.NewLine + "Note that, exept for title end parameters, the same parameter should not be displayed more than once on the same page.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult WrongCasing_Sub(IValidate test, IReadable referenceNode, IReadable positionNode, string currentValue, string expectedValue, string pid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckPageTag,
                ErrorId = ErrorIds.WrongCasing_Sub,
                FullId = "2.22.6",
                Category = Category.Param,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Current value '{0}'. Expected value '{1}'. {2} {3} '{4}'.", currentValue, expectedValue, "Param", "ID", pid),
                HowToFix = "",
                ExampleCode = "",
                Details = "Position/Page values should follow following title case rules:" + Environment.NewLine + "- Should start with a capital" + Environment.NewLine + "    - First and last word" + Environment.NewLine + "    - Important words (verbs, nouns, adjective, adverb, etc)" + Environment.NewLine + "- Should not start with a capital" + Environment.NewLine + "    - Articles (a, an, the)" + Environment.NewLine + "    - Coordinating conjuctions (and, but, for, nor, or, so, yet)" + Environment.NewLine + "    - Preposition with <4 chars (at, by, to...)",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult WrongCasing(IValidate test, IReadable referenceNode, IReadable positionNode)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckPageTag,
                ErrorId = ErrorIds.WrongCasing,
                FullId = "2.22.7",
                Category = Category.Param,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("'{0}' values do not follow {1} rules.", "Position/Page", "title casing"),
                HowToFix = "",
                ExampleCode = "",
                Details = "Position/Page values should follow following title case rules:" + Environment.NewLine + "- Should start with a capital" + Environment.NewLine + "    - First and last word" + Environment.NewLine + "    - Important words (verbs, nouns, adjective, adverb, etc)" + Environment.NewLine + "- Should not start with a capital" + Environment.NewLine + "    - Articles (a, an, the)" + Environment.NewLine + "    - Coordinating conjuctions (and, but, for, nor, or, so, yet)" + Environment.NewLine + "    - Preposition with <4 chars (at, by, to...)",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    internal static class ErrorCompare
    {
        public static IValidationResult RemovedFromPage(IReadable referenceNode, IReadable positionNode, string paramPid, string pageName)
        {
            return new ValidationResult
            {
                Test = null,
                CheckId = CheckId.CheckPageTag,
                ErrorId = ErrorIds.RemovedFromPage,
                FullId = "2.22.1",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.MajorChangeChecker,
                FixImpact = FixImpact.Breaking,
                GroupDescription = "",
                Description = String.Format("Param '{0}' was removed from page '{1}'.", paramPid, pageName),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    internal static class ErrorIds
    {
        public const uint RemovedFromPage = 1;
        public const uint MissingTag = 2;
        public const uint EmptyTag = 3;
        public const uint UntrimmedTag = 4;
        public const uint DuplicatedValue = 5;
        public const uint WrongCasing_Sub = 6;
        public const uint WrongCasing = 7;
    }

    /// <summary>
    /// Contains the identifiers of the checks.
    /// </summary>
    public static class CheckId
    {
        /// <summary>
        /// The check identifier.
        /// </summary>
        public const uint CheckPageTag = 22;
    }
}
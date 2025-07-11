﻿using System;
using System.Collections.Generic;

namespace VersOne.Epub.Schema
{
    /// <summary>
    /// <para>A metadata link. Links are used to associate resources with the EPUB book, such as metadata records.</para>
    /// <para>See <see href="https://www.w3.org/TR/epub-33/#sec-link-elem" /> for more information.</para>
    /// </summary>
    public class EpubMetadataLink
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EpubMetadataLink" /> class.
        /// </summary>
        /// <param name="href">The location of the linked resource.</param>
        /// <param name="id">The unique ID of this link or <c>null</c> if the link doesn't have an ID.</param>
        /// <param name="mediaType">The media type of the linked resource or <c>null</c> if the link doesn't specify the media type.</param>
        /// <param name="properties">
        /// A list of the link properties used to establish the type of record a referenced resource represents or <c>null</c> if the link doesn't specify properties.
        /// </param>
        /// <param name="refines">A relative IRI that identifies the resource augmented by the link or <c>null</c> if the link doesn't specify any augmentation.</param>
        /// <param name="relationships">A list of properties that establish the relationship the resource has with the EPUB book.</param>
        /// <param name="hrefLanguage">The language of the linked resource or <c>null</c> if the link doesn't specify the language of the linked resource.</param>
        /// <exception cref="ArgumentNullException">The <paramref name="href" /> parameter is <c>null</c>.</exception>
        public EpubMetadataLink(string href, string? id = null, string? mediaType = null, List<EpubMetadataLinkProperty>? properties = null, string? refines = null,
            List<EpubMetadataLinkRelationship>? relationships = null, string? hrefLanguage = null)
        {
            Href = href ?? throw new ArgumentNullException(nameof(href));
            Id = id;
            MediaType = mediaType;
            Properties = properties;
            Refines = refines;
            Relationships = relationships ?? new List<EpubMetadataLinkRelationship>();
            HrefLanguage = hrefLanguage;
        }

        /// <summary>
        /// <para>Gets the location of the linked resource.</para>
        /// <para>
        /// See <see href="https://www.w3.org/TR/epub-33/#sec-link-elem" />
        /// and <see href="https://www.w3.org/TR/epub-33/#attrdef-href" /> for more information.
        /// </para>
        /// </summary>
        public string Href { get; }

        /// <summary>
        /// <para>Gets the unique ID of this link or <c>null</c> if the link doesn't have an ID.</para>
        /// <para>See <see href="https://www.w3.org/TR/epub-33/#attrdef-id" /> for more information.</para>
        /// </summary>
        public string? Id { get; }

        /// <summary>
        /// <para>Gets the media type of the linked resource or <c>null</c> if the link doesn't specify the media type.</para>
        /// <para>
        /// See <see href="https://www.w3.org/TR/epub-33/#attrdef-link-media-type" /> for more information.
        /// </para>
        /// </summary>
        public string? MediaType { get; }

        /// <summary>
        /// <para>Gets a list of the link properties used to establish the type of record a referenced resource represents or <c>null</c> if the link doesn't specify properties.</para>
        /// <para>
        /// See <see href="https://www.w3.org/TR/epub-33/#attrdef-properties" />
        /// and <see href="https://www.w3.org/TR/epub-33/#sec-link-properties" /> for more information.
        /// </para>
        /// </summary>
        public List<EpubMetadataLinkProperty>? Properties { get; }

        /// <summary>
        /// <para>Gets a relative IRI that identifies the resource augmented by the link or <c>null</c> if the link doesn't specify any augmentation.</para>
        /// <para>
        /// See <see href="https://www.w3.org/TR/epub-33/#attrdef-refines" /> for more information.
        /// </para>
        /// </summary>
        public string? Refines { get; }

        /// <summary>
        /// <para>Gets a list of properties that establish the relationship the resource has with the EPUB book.</para>
        /// <para>
        /// See <see href="https://www.w3.org/TR/epub-33/#attrdef-link-rel" />
        /// and <see href="https://www.w3.org/TR/epub-33/#sec-link-rel" /> for more information.
        /// </para>
        /// </summary>
        public List<EpubMetadataLinkRelationship> Relationships { get; }

        /// <summary>
        /// <para>Gets the language of the linked resource or <c>null</c> if the link doesn't specify the language of the linked resource.</para>
        /// <para>
        /// See <see href="https://www.w3.org/TR/epub-33/#attrdef-hreflang" />
        /// and <see href="https://www.rfc-editor.org/info/bcp47" /> for more information.
        /// </para>
        /// </summary>
        public string? HrefLanguage { get; }
    }
}

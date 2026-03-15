# SMIS.UI - Syncfusion Blazor Implementation

## Overview
SMIS.UI is a clean implementation of the SMIS mobile application using Syncfusion Blazor components. All Bootstrap dependencies have been removed and replaced with Syncfusion's comprehensive UI component library.

## Syncfusion Components Used

### Layout & Navigation
- **SfSidebar** - Collapsible sidebar navigation
- **SfMenu** - Vertical navigation menu with icons
- **SfButton** - Action buttons throughout the app

### Data Display
- **SfGrid** - Data grid with paging, sorting, and filtering
- **SfCard** - Card containers for content organization

### Form Controls
- **SfTextBox** - Text input fields
- **SfNumericTextBox** - Numeric input with formatting
- **SfDropDownList** - Dropdown selection
- **SfCheckBox** - Checkbox input

### Feedback & Progress
- **SfSpinner** - Loading indicators
- **SfProgressBar** - Progress visualization
- **SfMessage** - Success/error messages
- **SfChip** - Chip/badge display

## Pages Implemented

### 1. Home (`/`)
- Welcome page with feature cards
- Navigation buttons to other sections
- Demonstrates: SfCard, SfButton

### 2. Counter (`/counter`)
- Interactive counter with increment/decrement
- Progress bar visualization
- Demonstrates: SfButton, SfChip, SfProgressBar

### 3. Weather (`/weather`)
- Weather forecast data grid
- Loading spinner
- Demonstrates: SfGrid, SfSpinner, pagination

### 4. Products (`/products`)
- Product listing with grid
- Action buttons for CRUD operations
- Demonstrates: SfGrid, SfCard, SfButton, filtering, sorting

### 5. Product Form (`/product-form`)
- Complete form with various input types
- Form validation ready
- Demonstrates: SfTextBox, SfNumericTextBox, SfDropDownList, SfCheckBox, SfMessage

## Configuration

### MauiProgram.cs
```csharp
builder.Services.AddSyncfusionBlazor();
```

### index.html
- Syncfusion CSS: `https://cdn.syncfusion.com/blazor/27.1.48/styles/bootstrap5.css`
- Syncfusion JS: `https://cdn.syncfusion.com/blazor/27.1.48/syncfusion-blazor.min.js`

### Packages
All Syncfusion packages are centrally managed in `Directory.Packages.props` at version 27.1.48:
- Syncfusion.Blazor.Themes
- Syncfusion.Blazor.Buttons
- Syncfusion.Blazor.Cards
- Syncfusion.Blazor.Grid
- Syncfusion.Blazor.Inputs
- Syncfusion.Blazor.Navigations
- Syncfusion.Blazor.Notifications
- Syncfusion.Blazor.Spinner
- Syncfusion.Blazor.ProgressBar
- Syncfusion.Blazor.DropDowns

## Removed Dependencies
- Bootstrap CSS and JS
- Custom Bootstrap-based layouts
- All `.razor.css` scoped styles for layout components

## Styling Approach
- Minimal custom CSS in component `<style>` blocks
- Relies on Syncfusion's Bootstrap5 theme
- Clean, modern UI with consistent spacing and colors

## Running the Application

### Windows
```bash
cd SMIS.UI
dotnet build -t:Run -f net9.0-windows
```

### Android
```bash
cd SMIS.UI
dotnet build -t:Run -f net9.0-android
```

### iOS (macOS only)
```bash
cd SMIS.UI
dotnet build -t:Run -f net9.0-ios
```

### macOS
```bash
cd SMIS.UI
dotnet build -t:Run -f net9.0-maccatalyst
```

## Next Steps

### Recommended Enhancements
1. **API Integration** - Connect to SMIS.Api backend
2. **Authentication** - Add login/logout with JWT
3. **Offline Support** - Implement local data caching
4. **Real Product Management** - CRUD operations with API
5. **Advanced Grid Features** - Export, grouping, custom filters
6. **Form Validation** - FluentValidation integration
7. **Theming** - Custom Syncfusion theme or theme switcher
8. **Localization** - Multi-language support using SMIS translation system

### Additional Syncfusion Components to Consider
- **SfDialog** - Modal dialogs
- **SfToast** - Toast notifications
- **SfDatePicker** - Date selection
- **SfUploader** - File upload
- **SfChart** - Data visualization
- **SfSchedule** - Calendar/scheduling
- **SfTreeView** - Hierarchical data
- **SfTab** - Tabbed interface

## Documentation
- [Syncfusion Blazor Documentation](https://blazor.syncfusion.com/documentation/introduction)
- [Syncfusion Blazor Demos](https://blazor.syncfusion.com/demos/)
- [.NET MAUI Blazor Documentation](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/blazorwebview)

## License
Syncfusion requires a license for production use. Community licenses are available for qualifying developers.

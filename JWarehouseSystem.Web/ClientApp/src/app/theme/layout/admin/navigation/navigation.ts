import {Injectable} from '@angular/core';

export interface NavigationItem {
  id: string;
  title: string;
  type: 'item' | 'collapse' | 'group';
  translate?: string;
  icon?: string;
  hidden?: boolean;
  url?: string;
  classes?: string;
  exactMatch?: boolean;
  external?: boolean;
  target?: boolean;
  breadcrumbs?: boolean;
  function?: any;
  badge?: {
    title?: string;
    type?: string;
  };
  children?: Navigation[];
}

export interface Navigation extends NavigationItem {
  children?: NavigationItem[];
}

const NavigationItems = [
  {
    id: 'navigation',
    title: 'Dashboard Panel',
    type: 'group',
    icon: 'feather icon-monitor',
    children: [
      {
        id: 'dashboard',
        title: 'Dashboard',
        type: 'collapse',
        icon: 'feather icon-monitor',
        children: [
          {
            id: 'default',
            title: 'Order & Purchases',
            type: 'item',
            url: '/dashboard/default'
          },
          {
            id: 'inventory',
            title: 'Inventory Management',
            type: 'item',
            url: '/dashboard/inventory'
          },
          {
            id: 'warehouse',
            title: 'Warehouse Management',
            type: 'item',
            url: '/dashboard/warehouse'
          },
          {
            id: 'movement',
            title: 'Product Movement',
            type: 'item',
            url: '/dashboard/movement'
          }
        ]
      }
      //{
      //  id: 'users',
      //  title: 'Entity Profiles',
      //  type: 'collapse',
      //  icon: 'feather icon-users',
      //  children: [
          
      //    {
      //      id: 'cards',
      //      title: 'Orders',
      //      type: 'item',
      //      url: '/users/card'
      //    },
      //    {
      //      id: 'list',
      //      title: 'Purchases',
      //      type: 'item',
      //      url: '/users/list'
      //    }
      //  ]
      //}
    ]
  },
  {
    id: 'transactions',
    title: 'Transaction Panel',
    type: 'group',
    icon: 'feather icon-briefcase',
    children: [
      {
        id: 'tOrders',
        title: 'Orders',
        type: 'item',
        icon: 'feather icon-shopping-cart',
        url: '/transaction/orders'
      },
      {
        id: 'tPurchases',
        title: 'Purchases',
        type: 'item',
        icon: 'feather icon-credit-card',
        url: '/transaction/purchases'
      },
      {
        id: 'tDeliveries',
        title: 'Deliveries',
        type: 'item',
        icon: 'feather icon-package',
        url: '/transaction/deliveries'
      },
      {
        id: 'tReceipts',
        title: 'Receipts',
        type: 'item',
        icon: 'feather icon-navigation',
        url: '/transaction/receipts'
      },
      {
        id: 'tInventory',
        title: 'Inventory',
        type: 'item',
        icon: 'feather icon-layers',
        url: '/transaction/inventories'
      }
    
    ]
  },
  {
    id: 'ui-element',
    title: 'Operations Panel',
    type: 'group',
    icon: 'feather icon-layers',
    children: [
      
      {
        id: 'oStockMovement',
        title: 'Stock Movement',
        type: 'item',
        icon: 'feather icon-activity',
        url: '/operation/stockmovement'
      },
      {
        id: 'oPacking',
        title: 'Packing',
        type: 'item',
        icon: 'feather icon-slack',
        url: '/operation/packing'
      },
      {
        id: 'oPicking',
        title: 'Picking',
        type: 'item',
        icon: 'feather icon-sidebar',
        url: '/operation/picking'
      },
     
      {
        id: 'oShipping',
        title: 'Shipping',
        type: 'item',
        icon: 'feather icon-globe',
        url: '/operation/shipping'
      }
     
    ]
  },
  {
    id: 'configurations',
    title: 'Configuration Panel',
    type: 'group',
    icon: 'feather icon-layout',
    children: [
      {
        id: 'config-people',
        title: 'People',
        type: 'collapse',
        icon: 'feather icon-user',
        children: [
          {
            id: 'config-users',
            title: 'Users',
            type: 'item',
            url: '/setup/currencies'
          },
          {
            id: 'config-employees',
            title: 'Employees',
            type: 'item',
            url: '/setup/currencies'
          },
          {
            id: 'config-drivers',
            title: 'Drivers',
            type: 'item',
            url: '/setup/currencies'
          },
          {
            id: 'config-customers',
            title: 'Customers',
            type: 'item',
            url: '/setup/currencies'
          },
          {
            id: 'config-suppliers',
            title: 'Suppliers',
            type: 'item',
            url: '/setup/currencies'
          }
        ]
      },
      {
        id: 'config-product',
        title: 'Product',
        type: 'collapse',
        icon: 'feather icon-briefcase',
        children: [
          {
            id: 'config-products',
            title: 'Products',
            type: 'item',
            url: '/forms/basic'
          },
          {
            id: 'config-productgroup',
            title: 'Product Categories',
            type: 'item',
            url: '/forms/advance'
          }
          
        ]
      },
      {
        id: 'config-warehouse',
        title: 'Dock & Warehouse',
        type: 'collapse',
        icon: 'feather icon-home',
        children: [
          {
            id: 'config-Docks',
            title: 'Docks',
            type: 'item',
            url: '/setup/docks'
          },
         /*  {
            id: 'config-packingareas',
            title: 'Packing Areas',
            type: 'item',
            url: '/setup/packingareas'
          },
          {
            id: 'config-pickingareas',
            title: 'Picking Areas',
            type: 'item',
            url: '/setup/pickingareas'
          }, */
          {
            id: 'config-ships',
            title: 'Ships',
            type: 'item',
            url: '/setup/ships'
          },
          {
            id: 'config-warehouses',
            title: 'Warehouses',
            type: 'item',
            url: '/setup/warehouses'
          },
         
        ]
      },
      {
        id: 'config-place',
        title: 'Currency & Location',
        type: 'collapse',
        icon: 'feather icon-map-pin',
        children: [
          {
            id: 'config-currency',
            title: 'Currencies',
            type: 'item',
            url: '/setup/currencies'
          },
          {
            id: 'config-region',
            title: 'Regions',
            type: 'item',
            url: '/setup/regions'
          },
          {
            id: 'config-country',
            title: 'Countries',
            type: 'item',
            url: '/setup/countries'
          },
          {
            id: 'config-location',
            title: 'Locations',
            type: 'item',
            url: '/setup/locations'
          }
        
        ]
      },
      {
        id: 'config-status',
        title: 'Statuses',
        type: 'collapse',
        icon: 'feather icon-flag',
        children: [
         
          {
            id: 'config-orderstatus',
            title: 'Order Status',
            type: 'item',
            url: '/forms/validation'
          },
          {
            id: 'config-purchasestatus',
            title: 'Purchase Status',
            type: 'item',
            url: '/forms/masking'
          },
          {
            id: 'config-dockstatus',
            title: 'Dock Status',
            type: 'item',
            url: '/forms/basic'
          }
         
        ]
      }
    ]
  },
  {
    id: 'report',
    title: 'Reporting Panel',
    type: 'group',
    icon: 'feather icon-layout',
    children: [
      {
        id: 'static-reports',
        title: 'Static Reports',
        type: 'collapse',
        icon: 'feather icon-bar-chart'
        //children: [
        //  {
        //    id: 'form-elements',
        //    title: 'Form Elements',
        //    type: 'item',
        //    url: '/forms/basic'
        //  },
        //  {
        //    id: 'form-elements',
        //    title: 'Form Advance',
        //    type: 'item',
        //    url: '/forms/advance'
        //  },
        //  {
        //    id: 'form-validation',
        //    title: 'Form Validation',
        //    type: 'item',
        //    url: '/forms/validation'
        //  },
        //  {
        //    id: 'form-masking',
        //    title: 'Form Masking',
        //    type: 'item',
        //    url: '/forms/masking'
        //  },
        //  {
        //    id: 'form-wizard',
        //    title: 'Form Wizard',
        //    type: 'item',
        //    url: '/forms/wizard'
        //  },
        //  {
        //    id: 'form-picker',
        //    title: 'Form Picker',
        //    type: 'item',
        //    url: '/forms/picker'
        //  },
        //  {
        //    id: 'form-select',
        //    title: 'Form Select',
        //    type: 'item',
        //    url: '/forms/select'
        //  }
        //]
      },
      {
        id: 'raw-data',
        title: 'Raw Data',
        type: 'collapse',
        icon: 'feather icon-file-text'
        //children: [
        //  {
        //    id: 'form-elements',
        //    title: 'Form Elements',
        //    type: 'item',
        //    url: '/forms/basic'
        //  },
        //  {
        //    id: 'form-elements',
        //    title: 'Form Advance',
        //    type: 'item',
        //    url: '/forms/advance'
        //  },
        //  {
        //    id: 'form-validation',
        //    title: 'Form Validation',
        //    type: 'item',
        //    url: '/forms/validation'
        //  },
        //  {
        //    id: 'form-masking',
        //    title: 'Form Masking',
        //    type: 'item',
        //    url: '/forms/masking'
        //  },
        //  {
        //    id: 'form-wizard',
        //    title: 'Form Wizard',
        //    type: 'item',
        //    url: '/forms/wizard'
        //  },
        //  {
        //    id: 'form-picker',
        //    title: 'Form Picker',
        //    type: 'item',
        //    url: '/forms/picker'
        //  },
        //  {
        //    id: 'form-select',
        //    title: 'Form Select',
        //    type: 'item',
        //    url: '/forms/select'
        //  }
        //]
      }
    ]
  }

];

@Injectable()
export class NavigationItem {
  public get() {
    return NavigationItems;
  }
}

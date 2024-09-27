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
    title: 'DASHBOARDS',
    type: 'group',
    icon: 'feather icon-monitor',
    children: [
      {
        id: 'dashboard',
        title: 'Dashboard',
        type: 'collapse',
        icon: 'feather icon-home',
        children: [
          {
            id: 'default',
            title: 'Order & Purchases',
            type: 'item',
            url: '/dashboard/default'
          },
          {
            id: 'sale',
            title: 'Inventory Management',
            type: 'item',
            url: '/dashboard/sale'
          },
          {
            id: 'crm',
            title: 'Warehouse Management',
            type: 'item',
            url: '/dashboard/crm'
          },
          {
            id: 'analytics',
            title: 'Product Movement',
            type: 'item',
            url: '/dashboard/analytics'
          }
        ]
      },
      {
        id: 'users',
        title: 'Entity Profiles',
        type: 'collapse',
        icon: 'feather icon-users',
        children: [
          
          {
            id: 'cards',
            title: 'Orders',
            type: 'item',
            url: '/users/card'
          },
          {
            id: 'list',
            title: 'Purchases',
            type: 'item',
            url: '/users/list'
          }
        ]
      }
    ]
  },
  {
    id: 'transactions',
    title: 'TRANSACTIONS',
    type: 'group',
    icon: 'feather icon-briefcase',
    children: [
      {
        id: 'tOrders',
        title: 'Orders',
        type: 'item',
        icon: 'feather icon-shopping-cart',
        url: '../../../basic/button'
      },
      {
        id: 'tPurchases',
        title: 'Purchases',
        type: 'item',
        icon: 'feather icon-credit-card',
        url: '/basic/button'
      },
      {
        id: 'tDeliveries',
        title: 'Deliveries',
        type: 'item',
        icon: 'feather icon-package',
        url: '/basic/button'
      },
      {
        id: 'tReceipts',
        title: 'Receipts',
        type: 'item',
        icon: 'feather icon-box',
        url: '/basic/button'
      },
      {
        id: 'tInventory',
        title: 'Inventory',
        type: 'item',
        icon: 'feather icon-layers',
        url: '/basic/button'
      }
    
    ]
  },
  {
    id: 'ui-element',
    title: 'OPERATIONS',
    type: 'group',
    icon: 'feather icon-layers',
    children: [
      {
        id: 'oStockRequest',
        title: 'Stock Request',
        type: 'item',
        icon:'feather icon-box',
        url:'/basic/button'
      },
      {
        id: 'oStockSend',
        title: 'Stock Send',
        type: 'item',
        icon: 'feather icon-box',
        url: '/basic/button'
      },
      {
        id: 'oStockMovement',
        title: 'Stock Movement',
        type: 'item',
        icon: 'feather icon-box',
        url: '/basic/button'
      },
      {
        id: 'oPicking',
        title: 'Picking',
        type: 'item',
        icon: 'feather icon-box',
        url: '/basic/button'
      },
      {
        id: 'oPacking',
        title: 'Packing',
        type: 'item',
        icon: 'feather icon-box',
        url: '/basic/button'
      },
      {
        id: 'oShipping',
        title: 'Shipping',
        type: 'item',
        icon: 'feather icon-box',
        url: '/basic/button'
      }
     
    ]
  },
  {
    id: 'configurations',
    title: 'CONFIGURATIONS',
    type: 'group',
    icon: 'feather icon-layout',
    children: [
      {
        id: 'config-entity',
        title: 'Entity',
        type: 'collapse',
        icon: 'feather icon-users',
        children: [
          {
            id: 'config-users',
            title: 'Users',
            type: 'item',
            url: '/forms/basic'
          },
          {
            id: 'config-employees',
            title: 'Employees',
            type: 'item',
            url: '/forms/advance'
          },
          {
            id: 'config-drivers',
            title: 'Drivers',
            type: 'item',
            url: '/forms/validation'
          },
          {
            id: 'config-customers',
            title: 'Customers',
            type: 'item',
            url: '/forms/masking'
          },
          {
            id: 'config-suppliers',
            title: 'Suppliers',
            type: 'item',
            url: '/forms/wizard'
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
        title: 'Warehouse',
        type: 'collapse',
        icon: 'feather icon-users',
        children: [
          {
            id: 'config-users',
            title: 'Users',
            type: 'item',
            url: '/forms/basic'
          },
          {
            id: 'config-employees',
            title: 'Employees',
            type: 'item',
            url: '/forms/advance'
          },
          {
            id: 'config-drivers',
            title: 'Drivers',
            type: 'item',
            url: '/forms/validation'
          },
          {
            id: 'config-customers',
            title: 'Customers',
            type: 'item',
            url: '/forms/masking'
          },
          {
            id: 'config-suppliers',
            title: 'Suppliers',
            type: 'item',
            url: '/forms/wizard'
          }
        ]
      },
      {
        id: 'config-place',
        title: 'Currency & Location',
        type: 'collapse',
        icon: 'feather icon-users',
        children: [
          {
            id: 'config-currency',
            title: 'Currencies',
            type: 'item',
            url: '/forms/basic'
          },
          {
            id: 'config-region',
            title: 'Regions',
            type: 'item',
            url: '/forms/advance'
          },
          {
            id: 'config-country',
            title: 'Countries',
            type: 'item',
            url: '/countries'
          },
          {
            id: 'config-location',
            title: 'Locations',
            type: 'item',
            url: '/forms/masking'
          },
          {
            id: 'config-suppliers',
            title: 'Suppliers',
            type: 'item',
            url: '/forms/wizard'
          }
        ]
      },
      {
        id: 'config-status',
        title: 'Statuses',
        type: 'collapse',
        icon: 'feather icon-users',
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
    title: 'REPORTING',
    type: 'group',
    icon: 'feather icon-layout',
    children: [
      {
        id: 'static-reports',
        title: 'Static Reports',
        type: 'collapse',
        icon: 'feather icon-file-text',
        children: [
          {
            id: 'form-elements',
            title: 'Form Elements',
            type: 'item',
            url: '/forms/basic'
          },
          {
            id: 'form-elements',
            title: 'Form Advance',
            type: 'item',
            url: '/forms/advance'
          },
          {
            id: 'form-validation',
            title: 'Form Validation',
            type: 'item',
            url: '/forms/validation'
          },
          {
            id: 'form-masking',
            title: 'Form Masking',
            type: 'item',
            url: '/forms/masking'
          },
          {
            id: 'form-wizard',
            title: 'Form Wizard',
            type: 'item',
            url: '/forms/wizard'
          },
          {
            id: 'form-picker',
            title: 'Form Picker',
            type: 'item',
            url: '/forms/picker'
          },
          {
            id: 'form-select',
            title: 'Form Select',
            type: 'item',
            url: '/forms/select'
          }
        ]
      },
      {
        id: 'raw-data',
        title: 'Raw Data',
        type: 'collapse',
        icon: 'feather icon-file-text',
        children: [
          {
            id: 'form-elements',
            title: 'Form Elements',
            type: 'item',
            url: '/forms/basic'
          },
          {
            id: 'form-elements',
            title: 'Form Advance',
            type: 'item',
            url: '/forms/advance'
          },
          {
            id: 'form-validation',
            title: 'Form Validation',
            type: 'item',
            url: '/forms/validation'
          },
          {
            id: 'form-masking',
            title: 'Form Masking',
            type: 'item',
            url: '/forms/masking'
          },
          {
            id: 'form-wizard',
            title: 'Form Wizard',
            type: 'item',
            url: '/forms/wizard'
          },
          {
            id: 'form-picker',
            title: 'Form Picker',
            type: 'item',
            url: '/forms/picker'
          },
          {
            id: 'form-select',
            title: 'Form Select',
            type: 'item',
            url: '/forms/select'
          }
        ]
      }
    ]
  },

  {
    id: 'other',
    title: 'OTHER',
    type: 'group',
    icon: 'feather icon-align-left',
    children: [
      {
        id: 'menu-level',
        title: 'Menu Levels',
        type: 'collapse',
        icon: 'feather icon-menu',
        children: [
          {
            id: 'menu-level-2.1',
            title: 'Menu Level 2.1',
            type: 'item',
            url: 'javascript:',
            external: true
          },
          {
            id: 'menu-level-2.2',
            title: 'Menu Level 2.2',
            type: 'collapse',
            children: [
              {
                id: 'menu-level-2.2.1',
                title: 'Menu Level 2.2.1',
                type: 'item',
                url: 'javascript:',
                external: true
              },
              {
                id: 'menu-level-2.2.2',
                title: 'Menu Level 2.2.2',
                type: 'item',
                url: 'javascript:',
                external: true
              }
            ]
          }
        ]
      },
      {
        id: 'disabled-menu',
        title: 'Disabled Menu',
        type: 'item',
        url: 'javascript:',
        classes: 'nav-item disabled',
        icon: 'feather icon-power',
        external: true
      },
      {
        id: 'sample-page',
        title: 'Sample Page',
        type: 'item',
        url: '/sample-page',
        classes: 'nav-item',
        icon: 'feather icon-sidebar'
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
